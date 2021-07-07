using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freientity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            database.entity.schooldbEntities a = new database.entity.schooldbEntities();
            dvg.DataSource = a.tbturmas.ToList();
        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
