using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session3.form
{
    public partial class facebook : Form
    {
        public facebook()
        {
            InitializeComponent();
        }

        private void cboidioma_TextChanged(object sender, EventArgs e)
        {
            string idioma = Convert.ToString(cboidioma.SelectedItem);

            if (idioma == "Brasil")
            { 
                picfbbr.Visible = true;
                picfbesp.Visible = false;
                picfbeua.Visible = false;
                picfb.Visible = false;    
             }
            if (idioma == "Espanha")
            {
                picfbbr.Visible = false;
                picfbesp.Visible = true;
                picfbeua.Visible = false;
                picfb.Visible = false;
            }
            if (idioma == "Estados Unidos")
            {
                picfbbr.Visible = false;
                picfbesp.Visible = false;
                picfbeua.Visible = true;
                picfb.Visible = false;
            }

        }
    }
}
