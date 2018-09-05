using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FormShooter
{
    public partial class Form1 : Form
    {
        Square square = new Square();
        
        public Form1()
        {
            InitializeComponent();

            // pos of square
            square.X = 320;
            square.Y = 200;
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush shipColor = Brushes.Blue;

            // draw the square
            canvas.FillRectangle(shipColor, new Rectangle(square.X, square.Y, 20, 20));
        }
    }
}
