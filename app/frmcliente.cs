using entities.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static business.controladores.controladorcliente;
namespace app
{
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }

      

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (lleno())
            {
                MessageBox.Show("ya no hay mas campos disponibles ");
                return;
            }
            
            char checkeado;
            DateTime nacimiento;
            DateTime ingreso;
            if (txtide.Text.Length == 0)
            {
                MessageBox.Show("debe digitar un id");
                return;
            }

           


            if (Existecliente(txtide.Text))
            {
                MessageBox.Show("el id ya existe");
                return;
            }


            if (txtnombre.Text.Length == 0)
            {
                MessageBox.Show("debe digitar un nombre");
                return;
            }

            if (txtprimerapellido.Text.Length == 0)
            {
                MessageBox.Show("debe digitar una direccion");
                return;
            }

            if (txtsegundoapellido.Text.Length == 0)
            {
                MessageBox.Show("debe digitar una direccion");
                return;
            }

            if (!rbtmasculino.Checked && !rbtfemenino.Checked)
            {
                MessageBox.Show("debe digitar el genero");
                return;
            }



            if (rbtmasculino.Checked)
            {
                checkeado = 'M';
            }
            else
            {
                checkeado = 'F';
            }

            nacimiento = dtpnacimiento.Value;
            ingreso = dtpingreso.Value;



            cliente nuevo = new cliente()
            {
                Id = txtide.Text,
                nombre = txtnombre.Text,
                primer_apellido = txtprimerapellido.Text,
                segundo_apellido = txtsegundoapellido.Text,
                fecha_nacimiento = nacimiento,
                genero = checkeado,
                fecha_ingreso = ingreso

            };

            agregar(nuevo);
            MessageBox.Show("cliente ingresado");

            txtide.Text = "";
            txtnombre.Text = "";
            txtprimerapellido.Text = "";
            txtsegundoapellido.Text = "";
            rbtfemenino.Checked = false;
            rbtmasculino.Checked = false;
        }

      

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {

        }
    }
}
