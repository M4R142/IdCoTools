using IdCoTools.Models.Database;
using IdCoTools.Models.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdCoTools
{
    public partial class IdCoToolConsole : Form
    {
        static Database database;
        public IdCoToolConsole()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Comenzar con el proceso al pulsar el botón.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonFinish.Enabled = false;
            ProgressBar.Value = 0;
            string log = "INICIANDO PROCESO DE GENERACION DE UNA BASE DE DATOS A PARTIR DE DATOS SELECCIONADOS";
            Log_Update(log);
            StartProcess();
            ProgressBar_Update(5);
            buttonFinish.Enabled = true;
            buttonStart.Enabled = true;
        }
        /// <summary>
        /// Cerrar la aplicación cuando se pulse el botón de finalizar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Proceso de creación y exportación de la bd.
        /// </summary>
        private void StartProcess()
        {
            if (GetSourceFile())
            {
                CreateDatabase();
                int totalFiles = OpenFileDialog.FileNames.Length;
                Log_Update($"        - PASO 3: Iniciando procesado de datos (total {totalFiles})");
                int n = 1;
                ProgressBar_Update(5);
                int diff = 65 / totalFiles;
                foreach (String file in OpenFileDialog.FileNames)
                {
                    string fileName = Path.GetFileName(file);
                    Log_Update($"               - Dato {n}/{totalFiles}: Archivo \"{fileName}\"");
                    if (CheckFileName(fileName))
                    {
                        CreatePersonInDB(file);
                        ProgressBar_Update(diff);
                    }
                    n += 1;
                }
                ShowFinishProcessInfo();
            }
        }
        /// <summary>
        /// Mostrar por consola la información de finalización.
        /// </summary>
        private void ShowFinishProcessInfo()
        {
            Log_Update("PROCESO FINALIZADO CON ÉXITO");
            LabelStatus.Visible = true;
            LabelStatus.Text = "Proceso de exportación a Base de Datos finalizado con éxito. Pulsa Iniciar o Finalizar para continuar....";
            ProgressBar.Value = 100;
        }
        /// <summary>
        /// Selecionar las imagenes que se van ha utilizar mediante un cuadro de dialogo.
        /// </summary>
        /// <returns></returns>
        private bool GetSourceFile()
        {
            string log = "";
            bool flag = false;
            Log_Update("        - PASO 1: Selecionar las imagenes.");
            ProgressBar_Update(5);
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                log = "                - Imágenes seleccionadas correctamente - Estado: OK. ";
                ProgressBar_Update(10);
                flag = true;
            }
            else
            {
                log = "Error 1 - No se han seleccionado las imagenes. - Estado: Fail.";
            }
            Log_Update(log);
            return flag;
        }
        /// <summary>
        /// Crear la base de datos y la tabla.
        /// </summary>
        private void CreateDatabase()
        {
            string log = "        - PASO 2: Creando Base de Datos.";
            Log_Update(log);
            ProgressBar_Update(5);
            string nameDB = "database_" + DateTime.Now.ToString("dd-MM-yyyy_HH.mm") + ".db3";
            database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads", nameDB));
            database.CreateTable();
            ProgressBar_Update(5);
        }
        /// <summary>
        /// Comprobar si el fichero de la imagen cumple con los requisitos de nomenclatura.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool CheckFileName(string fileName)
        {
            string regexExpression = "^([a-zA-Z])*[_ -]{1}([a-zA-Z])*[.]((jpg)|(png))";
            Regex regex = new Regex(regexExpression);
            string log = "";
            if (!regex.IsMatch(fileName))
            {
                log = $"                       -  Fail - Nombre de archivo incorrecto. {fileName} ha sido descartado.";
                Log_Update(log);
                return false;  
            }
            return true;
        }
        /// <summary>
        /// Añadir una nueva persona a la base de datos.
        /// </summary>
        /// <param name="file"></param>
        private void CreatePersonInDB(string file)
        {
            string[] subs = file.Split(' ', '_', '.', '\\');
            string name = subs[subs.Length - 3];
            string lastname = subs[subs.Length - 2];
            string tipo = subs[subs.Length - 1];
            byte[] image = File.ReadAllBytes(file);
            string log = $"                       -  Nombre: {name}, Apellido: {lastname}, Tipo: {tipo}";
            Log_Update(log);
            Person person = new Person
            {
                Name = name,
                LastName = lastname,
                Photo = image
            };
            log = "                       -  Añadiendo datos a la Base de Datos...";
            Log_Update(log);
            database.SavePerson(person);
        }
        /// <summary>
        /// Actualizar el log.
        /// </summary>
        /// <param name="log"></param>
        private void Log_Update(string log)
        {
            ShowLogTxtBox.Text += System.Environment.NewLine + log;
        }
        /// <summary>
        /// Actualizar el valor de la barra de progreso.
        /// </summary>
        /// <param name="n"></param>
        private void ProgressBar_Update(int n)
        {
            if(ProgressBar.Value + n < 100)
            {
                ProgressBar.Value += n;
                return;
            }
            ProgressBar.Value = 100;
        }
    }
}
