using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIO_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            int n3 = int.Parse(txtN3.Text);
            int Pormedio = (n1 + n2 + n3) / 3;
            lblPromedio.Text = Pormedio.ToString ();
            
            if (Pormedio >= 0)
            {
                if (Pormedio <=5)
                {
                  
                    lblPromedio.ForeColor = Color.Red;

                }
                else if (Pormedio >= 6)
                {

                }
                if (Pormedio <= 10)
                {
                    lblPromedio.ForeColor = Color.Red;
                }
                else if (Pormedio >=11)
                {

                }
                if (Pormedio <=12)
                {
                    lblPromedio.ForeColor = Color.Red;
                }
                else if (Pormedio >=13)
                {

                }
                if (Pormedio <= 16)
                {
                    lblPromedio.ForeColor = Color.Blue;
                }
                else if (Pormedio >=17)
                {

                }
                if (Pormedio <= 20)
                {
                    lblPromedio.ForeColor = Color.Blue;
                }
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "mi formularios";

        }
    }
}


