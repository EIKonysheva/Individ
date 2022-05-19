
namespace Individ
{
    partial class StudentsList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Students = new System.Windows.Forms.DataGridView();
            this.Students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Students);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_Students
            // 
            this.dataGridView_Students.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView_Students.ColumnHeadersHeight = 29;
            this.dataGridView_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Students,
            this.Surname,
            this.Patronymic,
            this.Dates});
            this.dataGridView_Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Students.GridColor = System.Drawing.Color.MintCream;
            this.dataGridView_Students.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Students.Name = "dataGridView_Students";
            this.dataGridView_Students.ReadOnly = true;
            this.dataGridView_Students.RowHeadersWidth = 51;
            this.dataGridView_Students.RowTemplate.Height = 24;
            this.dataGridView_Students.Size = new System.Drawing.Size(800, 450);
            this.dataGridView_Students.TabIndex = 0;
            // 
            // Students
            // 
            this.Students.DataPropertyName = "Students";
            this.Students.HeaderText = "Имя";
            this.Students.MinimumWidth = 6;
            this.Students.Name = "Students";
            this.Students.ReadOnly = true;
            this.Students.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 125;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.MinimumWidth = 6;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Width = 125;
            // 
            // Dates
            // 
            this.Dates.HeaderText = "День рождения";
            this.Dates.MinimumWidth = 6;
            this.Dates.Name = "Dates";
            this.Dates.ReadOnly = true;
            this.Dates.Width = 125;
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            //this.Name= "StudentsList";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Students;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Students;
    }
}