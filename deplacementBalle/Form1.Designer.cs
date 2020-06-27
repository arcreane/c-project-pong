namespace deplacementBalle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbRaquetteGauche = new System.Windows.Forms.PictureBox();
            this.pbRaquetteDroite = new System.Windows.Forms.PictureBox();
            this.pbBallle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaquetteGauche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaquetteDroite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBallle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbRaquetteGauche);
            this.groupBox1.Controls.Add(this.pbRaquetteDroite);
            this.groupBox1.Controls.Add(this.pbBallle);
            this.groupBox1.Location = new System.Drawing.Point(12, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 461);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pbRaquetteGauche
            // 
            this.pbRaquetteGauche.Image = ((System.Drawing.Image)(resources.GetObject("pbRaquetteGauche.Image")));
            this.pbRaquetteGauche.Location = new System.Drawing.Point(6, 117);
            this.pbRaquetteGauche.Name = "pbRaquetteGauche";
            this.pbRaquetteGauche.Size = new System.Drawing.Size(25, 157);
            this.pbRaquetteGauche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaquetteGauche.TabIndex = 1;
            this.pbRaquetteGauche.TabStop = false;
            // 
            // pbRaquetteDroite
            // 
            this.pbRaquetteDroite.Image = ((System.Drawing.Image)(resources.GetObject("pbRaquetteDroite.Image")));
            this.pbRaquetteDroite.Location = new System.Drawing.Point(1150, 117);
            this.pbRaquetteDroite.Name = "pbRaquetteDroite";
            this.pbRaquetteDroite.Size = new System.Drawing.Size(25, 157);
            this.pbRaquetteDroite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaquetteDroite.TabIndex = 1;
            this.pbRaquetteDroite.TabStop = false;
            // 
            // pbBallle
            // 
            this.pbBallle.Image = ((System.Drawing.Image)(resources.GetObject("pbBallle.Image")));
            this.pbBallle.Location = new System.Drawing.Point(193, 13);
            this.pbBallle.Name = "pbBallle";
            this.pbBallle.Size = new System.Drawing.Size(32, 31);
            this.pbBallle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBallle.TabIndex = 0;
            this.pbBallle.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 451);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaquetteGauche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaquetteDroite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBallle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbBallle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbRaquetteDroite;
        private System.Windows.Forms.PictureBox pbRaquetteGauche;
    }
}

