using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace Proyecto_JC_Distribuidres_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =GABO-PC;Initial Catalog=tecPro;User ID=gabo;Password=gabo");


        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            logear(this.txtUser.Text, this.txtPassword.Text);

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USER")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USER";
                txtUser.ForeColor = Color.DimGray;
            }
        }


        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {

        }
        public void logear(string usuario, string contrasena)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select idUser, passUser from usuarios Where idUser = @usuario AND passUser = @password", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("password", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][0].ToString() == txtUser.Text)
                    {
                        new FormEscritorio().Show();
                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o Clave incorrectos, ingrese correctamente sus credenciales ");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }

        }

        private void LinkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Salir ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class1.SoloNumeros(e);
        }
    }
}
