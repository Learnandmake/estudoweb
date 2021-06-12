using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session2.form
{
    public partial class orcamento : Form
    {
        public orcamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
                int opcaopro = 0;
                int opcaohd = 0;
                int opcaoram = 0;
                int opcaopv = 0;

                if (pp1.Checked == true)
                { opcaopro = 1; }
                if (pp2.Checked == true)
                { opcaopro = 2; }
                if (pp3.Checked == true)
                { opcaopro = 3; }

                if (pp1.Checked == true)
                { opcaopro = 1; }
                if (pp2.Checked == true)
                { opcaopro = 2; }
                if (pp3.Checked == true)
                { opcaopro = 3; }

                if (pv1.Checked == true)
                { opcaopv = 1; }
                if (pv2.Checked == true)
                { opcaopv = 2; }
                if (pv3.Checked == true)
                { opcaopv = 3; }

                if (ph1.Checked == true)
                {
                    opcaohd = 1;
                }
                if (ph2.Checked == true)
                {
                    opcaohd = 2;
                }
                if (ph3.Checked == true)
                {
                    opcaohd = 3;
                }


                function.sessiontwo two = new function.sessiontwo();
                double total = two.totalorcamento(opcaopro, opcaohd, opcaoram, opcaopv);

                double parcela = Convert.ToDouble(cbo.SelectedItem);
                 if(parcela != 0)
                {
                    double ptotal = total / parcela;

                    lblorc.Text = "Orcamento";
                    lblorc.Visible = true;
                    lblp.Visible = true;
                    lblreais.Visible = true;
                    lblreal.Visible = true;
                    lblt.Visible = true;
                    lblvl1.Text = Convert.ToString(total);
                    lblvl1.Visible = true;
                    lblvl2.Text = Convert.ToString(ptotal);
                    lblvl2.Visible = true;
                }
               else
               {
                    lblorc.Text = "selecione uma parcela";
                    lblorc.Visible = true;
                }
              
            }
            catch(Exception)
            {
                lblorc.Text = "erro";
                   lblorc.Visible = true;
            }    
                                           
            }
        }
    }

