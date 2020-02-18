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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void MaterialesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tecProDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tecProDataSet.materiales' Puede moverla o quitarla según sea necesario.
            this.materialesTableAdapter.Fill(this.tecProDataSet.materiales);

        }

        private void IdMaterialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int cantidad = 0;

            try
            {
                numero = Convert.ToInt32(idMaterialTextBox.Text);
                cantidad = Convert.ToInt32(cantMaterialTextBox.Text);
                this.materialesTableAdapter.AgregarMaterial(numero,nomMaterialTextBox.Text,tamMaterialTextBox.Text , tipoMaterialTextBox.Text,cantidad,descMaterialTextBox.Text);
                this.materialesTableAdapter.Fill(this.tecProDataSet.materiales);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Número ID correcto o el campo se encuentra vacio");
                ex.GetType();

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                int numero = Convert.ToInt32(idMaterialTextBox.Text);
                int cantidad = Convert.ToInt32(cantMaterialTextBox.Text);
                this.materialesTableAdapter.ModificaMaterial(numero, nomMaterialTextBox.Text, tamMaterialTextBox.Text, tipoMaterialTextBox.Text, cantidad, descMaterialTextBox.Text,numero);
                this.materialesTableAdapter.Fill(this.tecProDataSet.materiales);

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
                int numero = Convert.ToInt32(idMaterialTextBox.Text);
                int cantidad = Convert.ToInt32(cantMaterialTextBox.Text);
                this.materialesTableAdapter.EliminaMaterial(numero);
                this.materialesTableAdapter.Fill(this.tecProDataSet.materiales);

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
                int numero = Convert.ToInt32(idMaterialTextBox.Text);
                int cantidad = Convert.ToInt32(cantMaterialTextBox.Text);
                this.materialesTableAdapter.BuscarMaterial(tecProDataSet.materiales,numero);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Número ID correcto o el campo se encuentra vacio");
                ex.GetType();

            }
        }

        private void TamMaterialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.SoloNumeros(e);
        }

        private void CantMaterialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantMaterialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.SoloNumeros(e);
        }
    }
}
