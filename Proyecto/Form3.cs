using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            lblMensaje.Text = "Thank you for your vote!!";
        }

        private void btnVote2_Click(object sender, EventArgs e)
        {
            lblMensaje2.Text = "Thank you for your vote!!";
        }

        private void btnVote3_Click(object sender, EventArgs e)
        {
            lblMensaje3.Text = "Thank your for your vote!!";
        }


    }
}
