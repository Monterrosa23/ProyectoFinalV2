using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoFinal.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPrestamo : MaterialForm
    {
        public frmPrestamo()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMultas form = new frmMultas();
            form.ShowDialog();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard form = new frmDashboard();
            form.ShowDialog();
        }
    }
}
