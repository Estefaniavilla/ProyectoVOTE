using System.Security.Cryptography.X509Certificates;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public string NewVote { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Vote = "NewVote";
            form2.Show();

        }
    }
}




