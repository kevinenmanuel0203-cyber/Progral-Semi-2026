using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Fmprincipal : Form
    {
        public Fmprincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form objAlumnos = new Form();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }
        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias objMateria = new frmMaterias();
            objMateria.MdiParent = this;
            objMateria.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodos objPeriodo = new frmPeriodos();
            objPeriodo.MdiParent = this;
            objPeriodo.Show();
        }
    }
}
