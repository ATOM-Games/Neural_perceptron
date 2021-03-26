using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Persik
{
    public partial class Pattern : UserControl
    {
        public double[] PatValues; public double Answers;
        public Pattern(double[] d, string ns, double And) { 
            InitializeComponent(d, ns);
            PatValues = new double[d.Length];
            for (int i = 0; i < PatValues.Length; PatValues[i]=d[i], i++ ) ;
            Answers = And;
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {

        }

        public string ToString() {
            return (Answers==0)? "Я этого не знаю" : "Это похоже на [ "+Nazvanie.Text+" ]";
        }
    }
}
