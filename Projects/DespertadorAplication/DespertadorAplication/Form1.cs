using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DespertadorAplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hora = int.Parse(textBox1.Text);
            minuto = int.Parse(textBox2.Text);
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hora == DateTime.Now.Hour && minuto == DateTime.Now.Minute)
            {
                timer1.Enabled = false;
                if (checkBox1.Checked == true)
                {
                    Microsoft.VisualBasic.Interaction.Shell(@"C:\Windows\System32\shutdown.exe -f -s");
                }
                else
                {
                    //MessageBox.Show("Alarme Tocado Com Sucesso.!");
                    Microsoft.VisualBasic.Devices.Audio audio = new Microsoft.VisualBasic.Devices.Audio();
                    audio.Play(openFileDialog1.FileName);
                }
            }
        }

        private void Campanhia_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
