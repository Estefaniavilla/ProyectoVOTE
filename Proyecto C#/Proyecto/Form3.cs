using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        public string Vote { get; internal set; }

        private void btnVote1_Click(object sender, EventArgs e)
        {
            pbPri.Image = Image.FromFile(@"C:\\Users\\jovan\\source\\repos\\Proyecto\\Proyecto\\Resources\\PRI_Votado.png");
            pb1Pan.Image = Image.FromFile(@"C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\descarga.png");
            pbMorena.Image = Image.FromFile(@"C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\1024px-Morena_partido_logo.png");
        }

        private void btnVote2_Click(object sender, EventArgs e)
        {
            pbPri.Image = Image.FromFile(@"C:\\Users\\jovan\\source\\repos\\Proyecto\\Proyecto\\Resources\\PRI_(partido_revolucionario_institucional)_logo_(Mexico).png");
            pb1Pan.Image = Image.FromFile(@"C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\PAN_Votado.png");
            pbMorena.Image = Image.FromFile(@"C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\1024px-Morena_partido_logo.png");

        }

        private void btnVote3_Click(object sender, EventArgs e)
        {
            pbPri.Image = Image.FromFile(@"C:\\Users\\jovan\\source\\repos\\Proyecto\\Proyecto\\Resources\\PRI_(partido_revolucionario_institucional)_logo_(Mexico).png");
            pb1Pan.Image = Image.FromFile(@"C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\descarga.png");
            pbMorena.Image = Image.FromFile(@"C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\Morena_votado.png");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Title = "Save Review File";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    File.WriteAllText(filePath, txtSuggetion.Text);
                    MessageBox.Show("Review saved seccessfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred while saving the review: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}