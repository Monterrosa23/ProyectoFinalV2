namespace ProyectoFinal.views
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnPrestamos = new MaterialSkin.Controls.MaterialButton();
            this.btnLibros = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(422, 122);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(158, 46);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario";
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrestamos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrestamos.Depth = 0;
            this.btnPrestamos.HighEmphasis = true;
            this.btnPrestamos.Icon = null;
            this.btnPrestamos.Location = new System.Drawing.Point(63, 285);
            this.btnPrestamos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrestamos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrestamos.Size = new System.Drawing.Size(138, 36);
            this.btnPrestamos.TabIndex = 2;
            this.btnPrestamos.Text = "Ir a prestamos";
            this.btnPrestamos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrestamos.UseAccentColor = false;
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLibros.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLibros.Depth = 0;
            this.btnLibros.HighEmphasis = true;
            this.btnLibros.Icon = null;
            this.btnLibros.Location = new System.Drawing.Point(63, 436);
            this.btnLibros.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLibros.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLibros.Size = new System.Drawing.Size(101, 36);
            this.btnLibros.TabIndex = 3;
            this.btnLibros.Text = "ir a libros";
            this.btnLibros.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLibros.UseAccentColor = false;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 604);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Name = "frmDashboard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private MaterialSkin.Controls.MaterialButton btnPrestamos;
        private MaterialSkin.Controls.MaterialButton btnLibros;
    }
}