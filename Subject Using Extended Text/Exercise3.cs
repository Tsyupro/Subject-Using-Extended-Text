using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subject_Using_Extended_Text
{
    public partial class Exercise3 : Form
    {
        public Exercise3()
        {
            InitializeComponent();
            richTextBox1.AllowDrop = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files(*.txt)|*.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                richTextBox1.Text = reader.ReadToEnd();
            }
        }

        private void Exercise3_DragDrop(object sender, DragEventArgs e)
        {
            string[] path = (string[])e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show($" Path: {path[0]}");
            try
            {
                StreamReader reader = new StreamReader(path[0]);
                richTextBox1.Text = reader.ReadToEnd();

            }
            catch
            {
                MessageBox.Show("=(");
            }
        }

        private void Exercise3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }

        }
     
        private void Exercise3_DragLeave(object sender, EventArgs e)
        {
        }
    }
}
