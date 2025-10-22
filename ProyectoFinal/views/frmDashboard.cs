using MaterialSkin;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProyectoFinal.views
{
    public partial class frmDashboard : MaterialForm
    {
        public frmDashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Brown600, Primary.Brown500,
                Primary.Brown100, Accent.Cyan700,
                TextShade.WHITE
                );
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrestamo form = new frmPrestamo();
            form.ShowDialog();

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLibros form = new frmLibros();
            form.ShowDialog();

        }
    }
}
