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

        //declaramos las variables
        string operacion;
        double num1, num2, resultado;

        bool reiniciar = false;


        private void DefinirOperacion()
        {
            AsignarDatos();

            if (num2 > 0)
            {
                lblnum1.Text = txtpantalla.Text;
                lbloperacion.Text = operacion;
                txtpantalla.Text = "0";
            }

        }

        private void AsignarDatos()
        {
            num1 = Convert.ToDouble(lblnum1.Text);
            num2 = Convert.ToDouble(txtpantalla.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            Dibujartecladonumerico();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = btndivision.Text;
            DefinirOperacion();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            AsignarDatos();
            
            if (lbloperacion.Text == btndivision.Text)
            {
                Dividir();
            }

            if (lbloperacion.Text == btnmultiplicacion.Text)
            {
                Multiplicar();
            }

            if (lbloperacion.Text == btnresta.Text)
            {
                Resta();
            }

            if (lbloperacion.Text == btnsuma.Text)
            {
                Sumar();
            }

            if (lbloperacion.Text == btnporcentaje.Text)
            {
                Porcentaje(); 
            }
        }

        private void Porcentaje()
        {
            resultado = num1 * num2 / 100;
            txtpantalla.Text = resultado.ToString();
            Limpiar();

        }

        private void Sumar()
        {
            resultado = num1 + num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }

        private void Resta()
        {
            resultado = num1 - num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();

        }

        private void Multiplicar()
        {
            resultado = num1 * num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }


        private void Limpiar()
        {
            reiniciar = true;

            lbloperacion.Text = "0";
            lblnum1.Text = "0";

        }

        private void Dividir()
        {
            resultado = num1 / num2;
            txtpantalla.Text = resultado.ToString();

            Limpiar();
            

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

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = btnmultiplicacion.Text;
            DefinirOperacion();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = btnresta.Text;
            DefinirOperacion();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = btnsuma.Text;
            DefinirOperacion();
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            operacion = btnporcentaje.Text;
            DefinirOperacion();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

        }

        private void Borrar()
        {
            txtpantalla.Text = "0";
            lbloperacion.Text = "0";
            lblnum1.Text = "0";
        }

        private void ReiniciarProcesos()
        {
            if (reiniciar == true)
            {
                txtpantalla.Text = "0";
                reiniciar = false;
            }

        }

        //metodo para los botones
        private void Btnnumero_Click(object sender, EventArgs e)
        {
            ReiniciarProcesos();

            string numerostring = ((Button)sender).Text;            

            if (txtpantalla.Text == "0")
            {
                txtpantalla.Clear();
            }

            txtpantalla.Text += numerostring;
        }
    }
}
