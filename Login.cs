using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiVeBo
{
    public partial class Login : Form
    {
        DBconnection conexionBD;
        MySqlCommand comando;
        MySqlDataReader reader;
        String query;
        public Login()
        {
            InitializeComponent();
            IniciarConexion();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            string user = tbPass.Text, pass = tbUser.Text;
            if ( user == "admin" &&  pass == "admin")
            {
                MessageBox.Show("Login Exitoso");
                Menu menuVentana = new Menu();//Instancia del form 'Menu'
                this.Hide();
                menuVentana.ShowDialog(this);//Cambia al form 'Menu'
                this.Show();
                //this.WindowState = FormWindowState.Maximized; //Muestra en pantalla completa.
            }
            else
                MessageBox.Show("Usuario y/o contraseña incorrectos");*/
            

            if ((tbUser.Text != "") &&
                     (tbPass.Text != ""))
            {
                string usuario = tbUser.Text;
                string contraseña = tbPass.Text;
                query = "SELECT * FROM Usuario WHERE usuario = '" + usuario + "'";
                comando = new MySqlCommand(query, conexionBD.Connection);

                try
                {
                    reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader.GetString("contrasena").Equals(contraseña))
                        {
                            Usuario user = new Usuario();
                            user.nombreUsusario = usuario;
                            user.contraseña = reader.GetString("contrasena");
                            user.permisos = reader.GetInt32("permisos");
                            MessageBox.Show("Has accesado al sistema", "Bienvenido(a)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Menu ventana = new Menu(conexionBD,user);
                            tbUser.Clear();
                            tbPass.Clear();
                            this.Hide();
                            reader.Close();
                            ventana.ShowDialog(this);
                            this.Show();
                            this.Focus();
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Contraseña incorrecta");
                        }
                    }
                }
                catch (Exception exception)
                {
                    reader.Close();
                    MessageBox.Show(exception.Message);
                    Close();
                }
            }
            else
                MessageBox.Show("Ingresar nombre y contraseña", "Error de autentificación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void IniciarConexion()
        {
            conexionBD = DBconnection.Instance();
            conexionBD.DatabaseName = "bdcine";
            comando = new MySqlCommand();

            if (conexionBD.IsConnected())
            {
                MessageBox.Show("Conexion lograda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Conexion fallida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

    }
}
