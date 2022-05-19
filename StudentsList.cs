using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NLog;
using NLog.Config;

namespace Individ
{
    public partial class StudentsList : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public string Group;
        public StudentsList()
        {
            InitializeComponent();
            logger.Debug("log {0}", this.Text);
        }

        private void Students_Load(object sender, EventArgs e)
        {
            try
            {
                Stream fs = new FileStream(String.Concat(Group, ".txt"), FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string[] s = new string[] { };
                while (sr.Peek() != -1)
                {
                    string text = sr.ReadLine();
                    s = text.Split(' ');
                    dataGridView_Students.Rows.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Logger logger = LogManager.GetLogger("fileLogger");
                logger.Error(ex, "Whoops!");
            }
        }
    }
}
