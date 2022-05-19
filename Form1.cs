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
    public partial class Individual_task : Form
    {
        
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static Logger log;
        public string group; 
        List<Bitmap> pics = new List<Bitmap>();
        int i = 0;
        public Individual_task()
        {
            InitializeComponent();
            pics.Add(Properties.Resources.picture1);
            pics.Add(Properties.Resources.picture2);
            pics.Add(Properties.Resources.picture3);
            pics.Add(Properties.Resources.picture4);
            pics.Add(Properties.Resources.picture5);
            NLog.LogManager.Setup().LoadConfiguration(builder => {
                builder.ForLogger().FilterMinLevel(LogLevel.Info).WriteToConsole();
                builder.ForLogger().FilterMinLevel(LogLevel.Debug).WriteToFile(fileName: "file.txt");
            });
            NLog.LogManager.Setup().LoadConfiguration(builder => {
                //builder.ForLogger().FilterMinLevel(LogLevel.Error).WriteTo();
                builder.ForLogger().FilterMinLevel(LogLevel.Error).WriteToFile(fileName: "fileError.txt");
            });
            logger.Trace("log {0}", this.Text);

        }

        private void toolStripLabel_ChangePic_Click(object sender, EventArgs e)
        {

            logger.Trace("log {0}", this.Text);
            try
            {
                if (i == pics.Count)
                { i = 0; }
                pictureBox1.Image = pics[i];
                i++;
        }
            catch (Exception msg)
            {
                logger.Debug(msg.ToString());
            }
}

        private void toolStripLabel_Download_Click(object sender, EventArgs e)
        {
            treeView_groups.Nodes[0].Nodes.Clear();
            treeView_groups.Nodes[1].Nodes.Clear();
            using (StreamReader reader = new StreamReader("09-121.txt"))
            {
                while (true)
                {
                    string temp = reader.ReadLine();
                    if (temp == null) break;
                    treeView_groups.Nodes[0].Nodes.Add(temp);
                }
            }
            using (StreamReader reader = new StreamReader("09-122.txt"))
            {
                while (true)
                {
                    string temp = reader.ReadLine();

                    if (temp == null) break;

                    treeView_groups.Nodes[1].Nodes.Add(temp);
                }
            }
            logger.Debug("log {0}", this.Text);
        }

        private void toolStripLabel_Students_Click(object sender, EventArgs e)
        {
            StudentsList formSt = new StudentsList();
            formSt.Group = group;
            formSt.Show();
            logger.Debug("log {0}", this.Text);

        }

        private void treeView_groups_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            group = e.Node.Text;
            logger.Debug("log {0}", this.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader("file.txt"))
                {
                    while (true)
                    {
                        string temp = reader.ReadLine();
                        if (temp == null) break;
                        richTextBox_Logi.Text += temp+"\n";
                    }
                }
                using (StreamReader reader = new StreamReader("fileError.txt"))
                {
                    while (true)
                    {
                        string temp = reader.ReadLine();
                        if (temp == null) break;
                        richTextBox_LogiError.Text += temp +"\n";
                    }
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex, "Whoops!");
            }
        }
    }
}
