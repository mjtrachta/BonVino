using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinoApp.Endidades;
using VinoApp.Formularios.Bodegas;

namespace VinoApp.Boundary.Bodegas
{
    public partial class InterfazNotificacion : Form
    {

        public InterfazNotificacion()
        {
            InitializeComponent();

        }


        public void notificarNovedadVinoParaBodega()
        {
            ShowDialog();
        }
    }
}
