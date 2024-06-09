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
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    public string Vote { get; set; }

    public string NewVote { get; set; }

    private void button1_Click(object sender, EventArgs e)
    {
      Form3 form3 = new Form3();
      form3.Vote = "NewVote";
      form3.Show();

    }

    private void button2_Click(object sender, EventArgs e)
    {
      Form3 form3 = new Form3();
      form3.Vote = "NewVote";
      form3.Show();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {

    }
  }
}

