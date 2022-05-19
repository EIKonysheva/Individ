
namespace Individ
{
    partial class Individual_task
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("09-121");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("09-122");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Individual_task));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView_groups = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl_Logirovanie = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox_Logi = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox_LogiError = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Download = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_ChangePic = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_Students = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl_Logirovanie.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl_Logirovanie);
            this.splitContainer1.Size = new System.Drawing.Size(800, 419);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView_groups);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 261);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView_groups
            // 
            this.treeView_groups.BackColor = System.Drawing.Color.MintCream;
            this.treeView_groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_groups.Location = new System.Drawing.Point(0, 0);
            this.treeView_groups.Name = "treeView_groups";
            treeNode3.Name = "group1";
            treeNode3.Text = "09-121";
            treeNode4.Name = "group2";
            treeNode4.Text = "09-122";
            this.treeView_groups.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.treeView_groups.Size = new System.Drawing.Size(266, 261);
            this.treeView_groups.TabIndex = 0;
            this.treeView_groups.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_groups_NodeMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl_Logirovanie
            // 
            this.tabControl_Logirovanie.Controls.Add(this.tabPage1);
            this.tabControl_Logirovanie.Controls.Add(this.tabPage2);
            this.tabControl_Logirovanie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Logirovanie.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Logirovanie.Name = "tabControl_Logirovanie";
            this.tabControl_Logirovanie.SelectedIndex = 0;
            this.tabControl_Logirovanie.Size = new System.Drawing.Size(800, 154);
            this.tabControl_Logirovanie.TabIndex = 1;
            this.tabControl_Logirovanie.Tag = " ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox_Logi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Логи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Logi
            // 
            this.richTextBox_Logi.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox_Logi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Logi.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_Logi.Name = "richTextBox_Logi";
            this.richTextBox_Logi.Size = new System.Drawing.Size(786, 121);
            this.richTextBox_Logi.TabIndex = 0;
            this.richTextBox_Logi.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox_LogiError);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 125);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Логи ошибок";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox_LogiError
            // 
            this.richTextBox_LogiError.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox_LogiError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_LogiError.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_LogiError.Name = "richTextBox_LogiError";
            this.richTextBox_LogiError.Size = new System.Drawing.Size(786, 119);
            this.richTextBox_LogiError.TabIndex = 0;
            this.richTextBox_LogiError.Text = " ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Download,
            this.toolStripLabel_ChangePic,
            this.toolStripLabel_Students});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_Download
            // 
            this.toolStripLabel_Download.Name = "toolStripLabel_Download";
            this.toolStripLabel_Download.Size = new System.Drawing.Size(149, 28);
            this.toolStripLabel_Download.Text = "Загрузить студентов";
            this.toolStripLabel_Download.Click += new System.EventHandler(this.toolStripLabel_Download_Click);
            // 
            // toolStripLabel_ChangePic
            // 
            this.toolStripLabel_ChangePic.Name = "toolStripLabel_ChangePic";
            this.toolStripLabel_ChangePic.Size = new System.Drawing.Size(144, 28);
            this.toolStripLabel_ChangePic.Text = "Изменить картинку";
            this.toolStripLabel_ChangePic.Click += new System.EventHandler(this.toolStripLabel_ChangePic_Click);
            // 
            // toolStripLabel_Students
            // 
            this.toolStripLabel_Students.Name = "toolStripLabel_Students";
            this.toolStripLabel_Students.Size = new System.Drawing.Size(73, 28);
            this.toolStripLabel_Students.Text = "Студенты";
            this.toolStripLabel_Students.Click += new System.EventHandler(this.toolStripLabel_Students_Click);
            // 
            // Individual_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Individual_task";
            this.Text = "Individual task";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl_Logirovanie.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView_groups;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Download;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_ChangePic;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Students;
        private System.Windows.Forms.TabControl tabControl_Logirovanie;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox_Logi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox_LogiError;
    }
}

