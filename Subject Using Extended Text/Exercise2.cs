using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subject_Using_Extended_Text
{
    public partial class Exercise2 : Form
    {
        ImageList list = new ImageList();
        public Exercise2()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Type");
            listView1.Columns.Add("Date");
            radioButtonTiles.Checked = true;
            list.Images.Add(new Bitmap("C:\\Users\\vtsyu\\Downloads\\465070_article_blog_content_news_note_icon.png"));
            listView1.LargeImageList = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folder.SelectedPath;
                string[] files = Directory.GetFiles(folder.SelectedPath);

                foreach (string file in files)
                {
                    FileInfo file1= new FileInfo(file);

                    ListViewItem item = new ListViewItem(new string[] {
                        file1.Name,
                        file1.Extension,
                        file1.CreationTime.ToString(),
                        "0"
                    },0);
                    listView1.Items.Add(item);
                }


            }
        }

        private void radioButtonTiles_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonTiles.Checked)
            {
                listView1.View = View.Details;
            }
        }

        private void radioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonList.Checked)
            {
                listView1.View = View.List;
            }
        }

        private void radioButtonIcons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIcons.Checked)
            {
                listView1.View = View.LargeIcon;
            }
        }
    }
}
