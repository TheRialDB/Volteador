using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volteador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string palabra;
        string resultado;
        //Char[] modo2; // nuevo array

        private void btnVoltear_Click(object sender, EventArgs e)
        {
            resultado = "";

            palabra = txtPalabra.Text;

            //modo2 = palabra.ToCharArray(); 

            for (int i = palabra.Length-1; i >= 0; i--)
            {
                resultado = resultado + palabra.ElementAt(i).ToString();
                //resultado = resultado + modo2[i];

            }

            if (resultado == "?")
            {
                resultado = "¿";
            }
            
            lblResultado.Text = resultado;
        }
    }
}
