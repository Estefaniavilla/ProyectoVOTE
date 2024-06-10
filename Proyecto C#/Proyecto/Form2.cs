using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic;

namespace Proyecto
{
    public partial class Form2 : Form
    {
        Votante votante;
        public Form2()
        {
            InitializeComponent();
            votante = new Votante();
        }
        string[] information = new string[8];
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
            votante = new Votante(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxPhoneNumber.Text, txtBoxCity.Text, txtBoxResidenceEntity.Text, txtBoxAge.Text, cbGender.Text, txtBoxElectorKey.Text, int.Parse(txtSection.Text), DateOnly.Parse(txtEmission.Text), DateOnly.Parse(txtValidity.Text));
            SaveWord();
        }



        private void SaveWord()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Documentos de Word (*.docx)|*.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;

                try
                {
                    using (WordprocessingDocument wordDoc = WordprocessingDocument.Create("documento.docx", WordprocessingDocumentType.Document))
                    {
                        // Agregar un nuevo cuerpo al documento
                        MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                        mainPart.Document = new Document();
                        Body body = mainPart.Document.AppendChild(new Body());

                        // Agregar los elementos del arreglo al documento
                        Paragraph paragraph = body.AppendChild(new Paragraph());
                        paragraph.Append(new Run(new Text(votante.toString())));
                    }
                    File.Copy("documento.docx", filepath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


        }

    }




}

