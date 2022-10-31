using System;
using BE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE
{
    public partial class Form1 : Form
    {
        private void txtMulti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        string opcionSeleccionada = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtMulti.Text = "";
            lblResultado.Text = "";
            opcionSeleccionada = BoxArea.Text;

            if (opcionSeleccionada == "Cuadrado")
            {
                txtMulti.Visible = true;
                txtAltura.Visible = false;

                lblMulti.Text = "Lado";
                lblAltura.Text = "";

            }
            else if (opcionSeleccionada == "Rectangulo" || opcionSeleccionada == "Triangulo")
            {
                txtMulti.Visible = true;
                txtAltura.Visible = true;
                lblMulti.Text = "Base";
                lblAltura.Text = "Altura";
            }
            else if (opcionSeleccionada == "Circulo")
            {
                txtMulti.Visible = true;
                txtAltura.Visible = false;
                lblMulti.Text = "Radio";
                lblAltura.Text = "";

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btmCalcular_Click(object sender, EventArgs e)
        {
           
            if (opcionSeleccionada == "Cuadrado")
            {
                if (txtMulti.Text == "")
                {
                    MessageBox.Show("Escriba un valor");
                }
                else
                {
                    decimal res = Area.calcularAreaCuadrado(Convert.ToDecimal(txtMulti.Text));
                    lblResultado.Text = res.ToString();
                    txtMulti.Text = "";

                }

            }
            else if (opcionSeleccionada == "Rectangulo")
            {
                if (txtMulti.Text == "" || txtAltura.Text == "")
                {
                    MessageBox.Show("Escriba un valor");
                }
                else
                {
                    decimal Base = Convert.ToDecimal(txtMulti.Text);
                    decimal altura = Convert.ToDecimal(txtAltura.Text);
                    decimal res = Area.calcularAreaRectangulo(Base, altura);
                    lblResultado.Text = res.ToString();
                    txtAltura.Text = "";
                    txtMulti.Text = "";
                }
            
            }
            else if (opcionSeleccionada == "Triangulo")
            {
                if (txtMulti.Text == "" || txtAltura.Text == "")
                {
                    MessageBox.Show("Escriba un valor");
                }
                else
                {
                    decimal Base = Convert.ToDecimal(txtMulti.Text);
                    decimal altura = Convert.ToDecimal(txtAltura.Text);
                    decimal res = Area.calcularAreaRectangulo(Base, altura);
                    lblResultado.Text = res.ToString();
                    txtAltura.Text = "";
                    txtMulti.Text = "";
                }
            }
            else if (opcionSeleccionada == "Circulo")
            {
                if (txtMulti.Text == "")
                {
                    MessageBox.Show("Escriba un valor");
                }
                else
                {
                    decimal res = Area.calcularAreaCuadrado(Convert.ToDecimal(txtMulti.Text));
                    lblResultado.Text = res.ToString();
                    txtMulti.Text = "";
                }
             
            }
            else
            {
                MessageBox.Show("Seleccione una opciòn");
            }
        }


    }
}
