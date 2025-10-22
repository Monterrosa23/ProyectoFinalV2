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
using WindowsFormsApp1;

namespace ProyectoFinal
{
    public partial class frmLibros : MaterialForm
    {
        public frmLibros()
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

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard form = new frmDashboard();
            form.ShowDialog();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditorial form = new frmEditorial();
            form.ShowDialog();

        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAutores form = new frmAutores();
            form.ShowDialog();
        }
    }
}
