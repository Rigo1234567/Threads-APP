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
namespace app.forms
{
    public partial class frmmostrarclientes : Form
    {
        public frmmostrarclientes()
        {
            InitializeComponent();
            cargar();
        }


        private void cargar()
        {
            dgvclientes.DataSource = null;
            dgvclientes.DataSource = listarclientes();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
