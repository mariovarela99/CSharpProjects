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

namespace Exercicio_Aula_27_28
{
    public partial class Form1 : Form
    {
        static string path = @"C:\Users\mariovarela99\3D Objects\exercise\file.txt";
        StreamReader ReadFile;
        string[,] matriz = new string[4, 3];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            int k = 0;
            char virgula = ',';
            string[] Valores = new string[12];
            dgvValores.Rows.Add(3);
            ReadFile = new StreamReader(path);

            string Text = ReadFile.ReadLine();
            Valores = Text.Split(virgula);
            ReadFile.Close();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = Valores[k];
                    k++;
                }
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dgvValores[j, i].Value = matriz[i, j];
                }
            }

            MessageBox.Show("Dados impressos com sucesso.!");
        }
    }
}
