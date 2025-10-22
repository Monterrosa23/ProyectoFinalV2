using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace WindowsFormsApp1
{
    public partial class frmMultas : MaterialForm
    {
        public frmMultas()
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

        private void multas_Load(object sender, EventArgs e)
        {

        }
    }
}
