using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_JC_Distribuidres_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea regresar al Menú Principal?", "Salir ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tecProDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.tecProDataSet.clientes);

        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void ClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tecProDataSet);

        }

        private void NomClienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void CedClienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void TelClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelClienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void CedClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DirClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DirClienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void NomClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int numero=0;
            
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);
                this.clientesTableAdapter.AgregarCliente(txtNombre.Text, txtCedula.Text, txtDireccion.Text, numero);
                this.clientesTableAdapter.Fill(this.tecProDataSet.clientes);
              
            }
            catch(Exception ex)
            {
               MessageBox.Show("Ingrese Número telefónico correcto o el campo se encuentra vacio");
                ex.GetType();

            }

            


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {

                int numero = Convert.ToInt32(txtNumero.Text);
                this.clientesTableAdapter.ModificarCliente(txtNombre.Text, txtCedula.Text, txtDireccion.Text, numero, txtCedula.Text);
                this.clientesTableAdapter.Fill(this.tecProDataSet.clientes);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Número telefónico correcto o el campo se encuentra vacio");
                ex.GetType();

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                this.clientesTableAdapter.EliminarCliente(txtCedula.Text);
                this.clientesTableAdapter.Fill(this.tecProDataSet.clientes);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Número telefónico correcto o el campo se encuentra vacio");
                ex.GetType();

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            this.clientesTableAdapter.BuscarCliente(tecProDataSet.clientes,txtCedula.Text);
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Número telefónico correcto o el campo se encuentra vacio");
                ex.GetType();

            }

        }

        private void CedClienteTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.SoloNumeros(e);
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.SoloNumeros(e);
        }
    }
}
