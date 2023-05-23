using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Los_Dos_Chinos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ENTRAR_Click(object sender, EventArgs e)
        {   

            String user, pass;
            
            user = txtUsuario.Text;
            pass = txtContraseña.Text;



            if (user == "Admin" && pass == "123456")
            {

                MessageBox.Show("Acceso Otorgado");

                Menu opcion1 = new Menu();
                opcion1.Show();
                this.Hide();


            }
            else if (user == "Operador" && pass == "123456")
            {
                MessageBox.Show("Acceso Otorgado");

                MenuOperador opcion8 = new MenuOperador();
                opcion8.Show();
                this.Hide();



            }
            else
            {

                MessageBox.Show("Error! Verifique su Usuario y Contraseña");
                txtUsuario.Text = "";
                txtContraseña.Text = "";

            }





        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
