using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deplacementBalle
{
    public partial class Form1 : Form
    {

        int sensX = 20;
        int sensY = 20;

        public Form1()
        {

            InitializeComponent();

            pbRaquetteDroite.Image = deplacementBalle.Properties.Resources.Palette;
            pbRaquetteGauche.Image = deplacementBalle.Properties.Resources.Palette;
            pbBallle.Image = deplacementBalle.Properties.Resources.ball_green;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pbBallle.Location.X; //Balle X
            int y = pbBallle.Location.Y; //Balle Y
            int xd = pbRaquetteDroite.Location.X;
            int yd = pbRaquetteDroite.Location.Y; 
            int xg = pbRaquetteGauche.Location.X; 
            int yg = pbRaquetteGauche.Location.Y; 


            if (y + pbBallle.Height >= groupBox1.Height)
            {
                sensY = -20;

            }
            else if (y - pbBallle.Height <= 0)
            {
                sensY = 20;
            }
            else if (x + pbBallle.Width >= groupBox1.Width)
            {
                sensX = -20;
            }
            else if (x - pbBallle.Width <= 0)
            {
                sensX = 20;

            }
            else if (pbBallle.Bounds.IntersectsWith(pbRaquetteDroite.Bounds)  )
            {
                sensX = -30;
                if (y + (pbBallle.Height / 2) < yd + (pbRaquetteDroite.Height / 2))
                {
                    sensY = -20;
                }
                else
                {
                    sensY = 20;
                }
            }
            else if (pbBallle.Bounds.IntersectsWith(pbRaquetteGauche.Bounds)  )
            {

                sensX = +20;

                if (y + (pbBallle.Height / 2) < yg + (pbRaquetteGauche.Height / 2))
                {
                    sensY = -20; 
                }
                else
                {
                    sensY = 20;
                }
            }

            pbBallle.Location = new Point(x + sensX, y + sensY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                pbRaquetteDroite.Location = new Point(pbRaquetteDroite.Location.X, pbRaquetteDroite.Location.Y - 10);
                    break;
                case Keys.Down:
                pbRaquetteDroite.Location = new Point(pbRaquetteDroite.Location.X, pbRaquetteDroite.Location.Y + 10);
                    break;      
                case Keys.Z:
                pbRaquetteGauche.Location = new Point(pbRaquetteGauche.Location.X, pbRaquetteGauche.Location.Y - 10);
                    break;
                case Keys.S:
                pbRaquetteGauche.Location = new Point(pbRaquetteGauche.Location.X, pbRaquetteGauche.Location.Y + 10);
                    break;
            }
        }
    }
}
