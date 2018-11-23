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
    public partial class Menu : Form
    {
        DBconnection conexionBD;
        Usuario user;
        int fondo = 0;
        public Menu(DBconnection conexionBD, Usuario user)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }

        private void btnVentaBoletos_Click(object sender, EventArgs e)
        {
            Venta ventaVentana = new Venta();
            this.Hide();
            ventaVentana.ShowDialog(this);//Cambia al form 'Menu'
            this.Show();
            //ventaVentana.WindowState = FormWindowState.Maximized; //Muestra en pantalla completa.
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            ControlUsuarios CtrlUsrVentana = new ControlUsuarios(conexionBD);
            this.Hide();
            CtrlUsrVentana.ShowDialog(this);//Cambia al form 'Control Usuarios'
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporte ReporteVentana = new Reporte();
            this.Hide();
            ReporteVentana.ShowDialog(this);//Cambia al form 'Control Usuarios'
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(fondo == 0)
            {
                this.BackgroundImage = Properties.Resources.busBack;
                fondo = 1;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.logoFinal;
                fondo = 0;
            }
        }
    }
}
