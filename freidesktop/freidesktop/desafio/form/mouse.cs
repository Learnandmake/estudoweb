using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.desafio.form
{
    public partial class mouse : Form
    {
        public mouse()
        {
            InitializeComponent();
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pic_MouseLeave_1(object sender, EventArgs e)
        {

            Point posicao = pic.PointToScreen(Point.Empty);

            posicao.X += pic.Width / 2;
            posicao.Y += pic.Height / 2;

            Cursor.Position = posicao;
            Cursor.Current = Cursors.No;

            lblaviso2.Visible = true;
            lblaviso1.Visible = false;
        }
    }
}
