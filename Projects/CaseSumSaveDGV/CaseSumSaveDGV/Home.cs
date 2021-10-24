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

namespace CaseSumSaveDGV
{
    public partial class Home : Form
    {
        public static string FilePath = @"C:\Users\mariovarela99\Documents\Test\Testing.txt";
        string[] Lines;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            WriteOnDGV();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(number1.Text);
            int n2 = int.Parse(number2.Text);
            int soma = n1 + n2;

            File.AppendAllText(FilePath, String.Format("{0}-{1}-{2}\n", n1, n2, soma));
            CleanDGV();
            WriteOnDGV();

        }

        public void WriteOnDGV()
        {
            CleanDGV();

            Lines = File.ReadAllLines(FilePath);

            dgvDados.Rows.Add(Lines.Length);

            for (int i = 0; i <= Lines.Length - 1; i++)
            {
                string[] numbers = Lines[i].Split('-');
                dgvDados[0, i].Value = numbers[0];
                dgvDados[1, i].Value = numbers[1];
                dgvDados[2, i].Value = numbers[2];
            }
        }

        private void CleanDGV()
        {
            dgvDados.Rows.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            WriteOnDGV();
        }
    }
}
