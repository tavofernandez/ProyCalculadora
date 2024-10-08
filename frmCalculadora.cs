using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        //declaramos las varibles
        string operacion;
        double num1, num2, resultado;

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            Dibujartecladonumerico();
        }

        private void Dibujartecladonumerico()
        {
            char[] numeros;
            numeros = "7894563210.".ToCharArray();

            //limpiamos el panel
            panelnumerico.Controls.Clear();

            foreach (char numero in numeros)
            {
                Button btnnumero = new Button();
                btnnumero.Text = numero.ToString();
                btnnumero.Size = new Size(55, 55);
                btnnumero.FlatStyle = FlatStyle.Flat;
                btnnumero.ForeColor = Color.White;
                btnnumero.BackColor = Color.Transparent;
                btnnumero.BackgroundImage = Properties.Resources.circuloazul;
                btnnumero.BackgroundImageLayout = ImageLayout.Stretch;
                btnnumero.FlatAppearance.BorderSize = 0;
                //Al pasar el mouse
                btnnumero.FlatAppearance.MouseDownBackColor = Color.Transparent;
                //al hacer click
                btnnumero.FlatAppearance.MouseOverBackColor = Color.Transparent;

                //agregamos los controles
                panelnumerico.Controls.Add(btnnumero);

                //damos funcionalidad a los botones que hemos generado por codigo
                btnnumero.Click += Btnnumero_Click;

            }           

        }

        //metodo para los botones
        private void Btnnumero_Click(object sender, EventArgs e)
        {
            string numerostring = ((Button)sender).Text;            

            if (txtpantalla.Text == "0")
            {
                txtpantalla.Clear();
            }

            txtpantalla.Text += numerostring;
        }
    }
}
