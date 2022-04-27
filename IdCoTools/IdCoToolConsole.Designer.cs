
namespace IdCoTools
{
    partial class IdCoToolConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ShowLogTxtBox = new System.Windows.Forms.RichTextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.Controls.Add(this.ShowLogTxtBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.ProgressBar, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.LabelStatus, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonStart, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonFinish, 2, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // ShowLogTxtBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.ShowLogTxtBox, 3);
            this.ShowLogTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowLogTxtBox.Location = new System.Drawing.Point(3, 3);
            this.ShowLogTxtBox.Name = "ShowLogTxtBox";
            this.ShowLogTxtBox.ReadOnly = true;
            this.ShowLogTxtBox.Size = new System.Drawing.Size(794, 376);
            this.ShowLogTxtBox.TabIndex = 0;
            this.ShowLogTxtBox.Text = "";
            // 
            // ProgressBar
            // 
            this.tableLayoutPanel.SetColumnSpan(this.ProgressBar, 3);
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBar.Location = new System.Drawing.Point(3, 385);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(794, 16);
            this.ProgressBar.TabIndex = 1;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelStatus.Location = new System.Drawing.Point(3, 404);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(554, 46);
            this.LabelStatus.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.Location = new System.Drawing.Point(563, 407);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(114, 40);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Iniciar";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFinish.Location = new System.Drawing.Point(683, 407);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(114, 40);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.Text = "Finalizar";
            this.buttonFinish.UseVisualStyleBackColor = true;
            // 
            // IdCoToolConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "IdCoToolConsole";
            this.Text = "IdCoToolConsole";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.RichTextBox ShowLogTxtBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFinish;
    }
}