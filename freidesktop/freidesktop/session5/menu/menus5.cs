using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session5.menu
{
    public partial class menus5 : Form
    {
        public menus5()
        {
            InitializeComponent();
        }
        public static void ThreadProc()
        {
            Application.Run(new form.login());
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            form.login m = new form.login();
            m.Show();

            this.Hide();
        
            }


    }
    }

