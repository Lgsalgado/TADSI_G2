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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea regresar al Menú Principal?", "Salir ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int cantidad = 0;
            

            try
            {
                numero = Convert.ToInt32(idFacturaTextBox.Text);
                cantidad = Convert.ToInt32(telClienteTextBox.Text);
                this.facturaTableAdapter.AgregaFactura(nomClienteTextBox.Text, cedClienteTextBox.Text, dirClienteTextBox.Text,cantidad, totalFacturaTextBox.Text,numero);
                this.facturaTableAdapter.Fill(this.tecProDataSet.factura);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Número ID correcto o el campo se encuentra vacio");
                ex.GetType();

            }
        }

        private void FacturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tecProDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tecProDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.tecProDataSet.clientes);
            // TODO: esta línea de código carga datos en la tabla 'tecProDataSet.factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.tecProDataSet.factura);

        }

        private void LblCliente_Click(object sender, EventArgs e)
        {

        }

        private void LblDirec_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                int numero = Convert.ToInt32(idFacturaTextBox.Text);
                int cantidad = Convert.ToInt32(telClienteTextBox.Text);
                this.facturaTableAdapter.ModificaFactura(nomClienteTextBox.Text, cedClienteTextBox.Text, dirClienteTextBox.Text, cantidad, totalFacturaTextBox.Text, numero, numero);
                this.facturaTableAdapter.Fill(this.tecProDataSet.factura);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Número tamaño correcto o el campo se encuentra vacio");
                ex.GetType();

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(idFacturaTextBox.Text);
                int cantidad = Convert.ToInt32(telClienteTextBox.Text);
                this.facturaTableAdapter.EliminaFactura(numero);
                this.facturaTableAdapter.Fill(this.tecProDataSet.factura);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese ID correcto o el campo se encuentra vacio");
                ex.GetType();

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            try
            {
                int numero = Convert.ToInt32(idFacturaTextBox.Text);
                int cantidad = Convert.ToInt32(telClienteTextBox.Text);
                this.facturaTableAdapter.BuscaFactura(tecProDataSet.factura, numero);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Número ID correcto o el campo se encuentra vacio");
                ex.GetType();

            }
        }
    }
}
