using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediacalculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // CALCULAR
        {
            float soma, media, valor;
            soma = 0;

            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)control).Text);
                    soma += valor;

                }

                media = soma / 4;
                this.Controls["label7"].Text = media.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) //   LIMPAR
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";

                }
                this.Controls["label7"].Text = "...";
                
            }
        }
    }
    }

