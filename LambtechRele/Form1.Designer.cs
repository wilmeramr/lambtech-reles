
namespace LambtechRele
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDesconectar = new MetroFramework.Controls.MetroButton();
            this.btnConectar = new MetroFramework.Controls.MetroButton();
            this.cmbPorts = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnCircuito4 = new MetroFramework.Controls.MetroButton();
            this.btnCircuito3 = new MetroFramework.Controls.MetroButton();
            this.btnCircuito2 = new MetroFramework.Controls.MetroButton();
            this.lblCircuitos = new MetroFramework.Controls.MetroLabel();
            this.btnCircuito1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Highlight = true;
            this.btnDesconectar.Location = new System.Drawing.Point(282, 24);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(87, 32);
            this.btnDesconectar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDesconectar.TabIndex = 8;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Highlight = true;
            this.btnConectar.Location = new System.Drawing.Point(194, 24);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(84, 32);
            this.btnConectar.Style = MetroFramework.MetroColorStyle.Black;
            this.btnConectar.TabIndex = 7;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.ItemHeight = 23;
            this.cmbPorts.Location = new System.Drawing.Point(80, 27);
            this.cmbPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(104, 29);
            this.cmbPorts.TabIndex = 6;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnCircuito4);
            this.metroPanel1.Controls.Add(this.btnCircuito3);
            this.metroPanel1.Controls.Add(this.btnCircuito2);
            this.metroPanel1.Controls.Add(this.lblCircuitos);
            this.metroPanel1.Controls.Add(this.btnCircuito1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(49, 85);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(370, 81);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // btnCircuito4
            // 
            this.btnCircuito4.Highlight = true;
            this.btnCircuito4.Location = new System.Drawing.Point(284, 40);
            this.btnCircuito4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCircuito4.Name = "btnCircuito4";
            this.btnCircuito4.Size = new System.Drawing.Size(61, 28);
            this.btnCircuito4.Style = MetroFramework.MetroColorStyle.Black;
            this.btnCircuito4.TabIndex = 10;
            this.btnCircuito4.Text = "4";
            this.btnCircuito4.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCircuito3
            // 
            this.btnCircuito3.Highlight = true;
            this.btnCircuito3.Location = new System.Drawing.Point(196, 40);
            this.btnCircuito3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCircuito3.Name = "btnCircuito3";
            this.btnCircuito3.Size = new System.Drawing.Size(61, 28);
            this.btnCircuito3.Style = MetroFramework.MetroColorStyle.Black;
            this.btnCircuito3.TabIndex = 9;
            this.btnCircuito3.Text = "3";
            this.btnCircuito3.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCircuito2
            // 
            this.btnCircuito2.Highlight = true;
            this.btnCircuito2.Location = new System.Drawing.Point(112, 38);
            this.btnCircuito2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCircuito2.Name = "btnCircuito2";
            this.btnCircuito2.Size = new System.Drawing.Size(61, 29);
            this.btnCircuito2.Style = MetroFramework.MetroColorStyle.Black;
            this.btnCircuito2.TabIndex = 8;
            this.btnCircuito2.Text = "2";
            this.btnCircuito2.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lblCircuitos
            // 
            this.lblCircuitos.AutoSize = true;
            this.lblCircuitos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCircuitos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCircuitos.Location = new System.Drawing.Point(157, 6);
            this.lblCircuitos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCircuitos.Name = "lblCircuitos";
            this.lblCircuitos.Size = new System.Drawing.Size(63, 25);
            this.lblCircuitos.TabIndex = 7;
            this.lblCircuitos.Text = "RELES";
            // 
            // btnCircuito1
            // 
            this.btnCircuito1.Highlight = true;
            this.btnCircuito1.Location = new System.Drawing.Point(25, 38);
            this.btnCircuito1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCircuito1.Name = "btnCircuito1";
            this.btnCircuito1.Size = new System.Drawing.Size(61, 28);
            this.btnCircuito1.Style = MetroFramework.MetroColorStyle.Black;
            this.btnCircuito1.TabIndex = 2;
            this.btnCircuito1.Text = "1";
            this.btnCircuito1.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LambtechRele.Properties.Resources.WhatsApp_Image_2022_10_02_at_12_59_49;
            this.pictureBox1.Location = new System.Drawing.Point(113, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(444, 245);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cmbPorts);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDesconectar;
        private MetroFramework.Controls.MetroButton btnConectar;
        private MetroFramework.Controls.MetroComboBox cmbPorts;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnCircuito4;
        private MetroFramework.Controls.MetroButton btnCircuito3;
        private MetroFramework.Controls.MetroButton btnCircuito2;
        private MetroFramework.Controls.MetroLabel lblCircuitos;
        private MetroFramework.Controls.MetroButton btnCircuito1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

