using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using ContactosStarWars.Aplicacion;

namespace ContactosStarWars
{
    public partial class FPrincipal : Form
    {
        private ContactosStarWarsServicio servicioContactos;

        public FPrincipal()
        {
            InitializeComponent();
            servicioContactos = new ContactosStarWarsServicio();
        }

        private void FMain_Load(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            IList<Contacto> contactos = servicioContactos.ObtenerContactos();
            lstResultado.DataSource = contactos;
        }

    }
}
