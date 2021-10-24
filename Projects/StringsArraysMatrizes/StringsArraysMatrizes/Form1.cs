using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace StringsArraysMatrizes
{
    public partial class Form1 : Form
    {
        public int[] numbers = new int[10];
        public int verify = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                numbers[i] = int.Parse(Interaction.InputBox(String.Format("Digite o Valor {0} => ", i)));
           
            foreach(int number in numbers)
                lstNumbers.Items.Add(number);
           
            verify = int.Parse(Interaction.InputBox("Digite o valor a procurar => "));

            if (Array.IndexOf(numbers, verify) >= 0)
            {
                MessageBox.Show(String.Format("O Number Esta no Vetor Na Position => {0} ", Array.IndexOf(numbers, verify)));
                lstNumbers.Items.Clear();
            }
            else
                MessageBox.Show("O Number Nao Esta no Vetor");
        }
    }
}
