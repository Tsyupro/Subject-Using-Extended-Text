using System.Windows.Forms;

namespace Subject_Using_Extended_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercise1 exercise = new Exercise1();
            exercise.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercise2 exercise = new Exercise2();
            exercise.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exercise3 exercise = new Exercise3();
            exercise.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exercise4 exercise = new Exercise4();
            exercise.ShowDialog();
        }
    }
}