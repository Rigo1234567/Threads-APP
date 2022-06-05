using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using entities.modelos;
using static business.controladores.controladorcliente;

namespace app.forms
{
    public partial class frmmostrarcliente : Form
    {
        List<cliente> clientes = new List<cliente>();
        Semaphore se = new Semaphore(3, 3);
        static readonly object locke = new object();



        public frmmostrarcliente()
        {

            InitializeComponent();
            dgvclientes.MultiSelect = false;
           //Control.CheckForIllegalCrossThreadCalls = false;



        }



        private void moveRowTo(DataGridView table, int oldIndex, int newIndex)
        {
            if (newIndex < oldIndex)
            {
                oldIndex += 1;
            }
            else if (newIndex == oldIndex)
            {
                return;
            }
            table.Rows.Insert(newIndex, 1);
            DataGridViewRow row = table.Rows[newIndex];
            DataGridViewCell cell0 = table.Rows[oldIndex].Cells[0];
            DataGridViewCell cell1 = table.Rows[oldIndex].Cells[1];
            row.Cells[0].Value = cell0.Value;
            row.Cells[1].Value = cell1.Value;
            table.Rows[oldIndex].Visible = false;
            table.Rows.RemoveAt(oldIndex);
            table.Rows[oldIndex].Selected = false;
            table.Rows[newIndex].Selected = true;
        }

        private void mas()
        {
            Invoke(new MethodInvoker(() => cargarmasculinos()));
        }
       


        private void fem()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => cargarfemeninos()));
            }
        }

        private void cargarfemeninos()
        {
            //se genera con la estructura lock para sincronizar
            lock (locke)
            {
                Invoke(new MethodInvoker(() =>
               dgvfemeninos.Rows.Clear()));

           
                foreach (var item in listarclientes().Where(x => x != null && x.genero.Equals('F')))
            {

                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(() => dgvfemeninos.Rows.Add(
               item.Id, item.nombrecompleto, item.fecha_nacimiento, item.genero, item.fecha_ingreso) ));
                       
                    }
                   

                    
                    
                    foreach (DataGridViewRow item2 in dgvclientes.Rows)
                    {
                        string valor = Convert.ToString(item2.Cells["Column6"].Value);
                        if (valor == item.Id)
                        {
                            Invoke(new MethodInvoker(() =>
                           dgvclientes.Rows.Remove(item2)));
                        }
                    }
                   
                    Thread.Sleep(100);
                }
              

            }
            
        }

       
        private void cargarmasculinos()
        {
            lock (locke)
            {
                Invoke(new MethodInvoker(() =>

               dgvmasculinos.Rows.Clear()));
           

                foreach (var item in listarclientes().Where(x => x != null && x.genero.Equals('M')))
            {
                    //se genera con la estructura lock para sincronizar
                    Invoke(new MethodInvoker(() =>

                       dgvmasculinos.Rows.Add(item.Id, item.nombrecompleto, item.fecha_nacimiento, item.genero, item.fecha_ingreso)));
                    

                    foreach (DataGridViewRow item2 in dgvclientes.Rows)
                    {
                        string valor = Convert.ToString(item2.Cells["Column6"].Value);
                        if(valor == item.Id)
                        {
                            Invoke(new MethodInvoker(() =>
                           dgvclientes.Rows.Remove(item2)));
                        }
                    }
             
                    Thread.Sleep(100);


                }
              



            }
        }


        private   void cargar()
        {
            try
            {
                dgvclientes.Rows.Clear();

                foreach (var item in listarclientes().Where(x => x != null))
                {
                    dgvclientes.Rows.Add(item.Id, item.nombrecompleto, item.fecha_nacimiento, item.genero, item.fecha_ingreso);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("el indice esta fuera de rango");
            }
            


        }
        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmmostrarcliente_Load(object sender, EventArgs e)
        {
          
            cargar();

           
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (vacio() == true)
            {
                MessageBox.Show("el arreglo esta vacio");
                return;
            }

          
            Thread hilo1 = new Thread(new System.Threading.ThreadStart(cargarfemeninos));
            Thread hilo2 = new Thread(new System.Threading.ThreadStart(cargarmasculinos));
            
            hilo1.Start();        
            hilo2.Start();
          






            txtfemeninos.Text = listarclientes().Count(x => x != null && x.genero.Equals('F')).ToString();
            txtmasculinos.Text = listarclientes().Count(x => x != null && x.genero.Equals('M')).ToString();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvclientes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                moveRowTo(dgvclientes, 0, 1);
            }));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
