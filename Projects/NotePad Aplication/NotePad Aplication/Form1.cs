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

namespace NotePad_Aplication
{
    public partial class Form1 : Form
    {

        private OpenFileDialog abrirDialogo;
        private SaveFileDialog salvarDialogo;
        private FontDialog fonteDialogo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fonteDialogo = new FontDialog();
        }

        private void CriarNovo()
        {
            try 
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    this.Text = "Untiled";
                    this.richTextBox1.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("File is Empty.!");
                }
            }
            catch (Exception ex) 
            { 
            
            }
            finally 
            {
 
            }
        }

        private void AbrirArquivo()
        {
            try
            {
                abrirDialogo = new OpenFileDialog();

                if (abrirDialogo.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(abrirDialogo.FileName);
                    this.Text = abrirDialogo.FileName;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                abrirDialogo = null;
            }
        }

        private void SalvarArquivo()
        {
            try
            {
                salvarDialogo = new SaveFileDialog();

                salvarDialogo.Filter = "Aqruivo de Texto (*.txt) | *.txt";

                if(salvarDialogo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(salvarDialogo.FileName, this.richTextBox1.Text);
                    this.Text = salvarDialogo.FileName;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarNovo();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* if(string.IsNullOrEmpty(this.richTextBox1.Text)
            {
                MessageBox.Show("...");
            }*/
            this.Close();
        }

        private void formatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fonteDialogo.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Font = fonteDialogo.Font;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }

    }
}
