using SQLite;
using System.Threading.Tasks;

namespace IdCoTools.Models.Database
{
    public class Database : IDatabase
    {
        SQLiteAsyncConnection database;
        /// <summary>
        /// Inicializar la conexión de la base de datos.
        /// </summary>
        /// <param name="name">Nombre del path + base de datos</param>
        public Database(string name)
        {
            database = new SQLiteAsyncConnection(name);
        }
        public int Count()
        {
            Task<int> count = database.Table<Person.Person>().CountAsync();
            return count.Result;
        }
        /// <summary>
        /// Crear la tabla Person en la base de datos.
        /// </summary>
        public void CreateTable()
        {
            database.CreateTableAsync<Person.Person>().Wait();
        }
        /// <summary>
        /// Eliminar la tabla Person en la base de datos.
        /// </summary>
        public void DropTable()
        {
            database.DropTableAsync<Person.Person>().Wait();
        }
        /// <summary>
        /// Eliminar un objeto Person de la base de datos.
        /// </summary>
        /// <param name="person">Person a eliminar de la BD</param>
        /// <returns>Numero de filas de la BD eliminadas</returns>
        public int RemovePerson(Person.Person person)
        {
            Task<int> num = database.DeleteAsync(person);
            return num.Result;
        }
        /// <summary>
        /// Guardar un objeto Person en la base de datos.
        /// </summary>
        /// <param name="person">Guardar un objeto Person en la BD</param>
        /// <returns>numero de filas añadidas en la BD</returns>
        public int SavePerson(Person.Person person)
        {
            person.Name = person.Name.ToUpper();
            person.LastName = person.LastName.ToUpper();
            Task<int> num = database.InsertAsync(person);
            return num.Result;
        }
    }
}
