using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinformsCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(tbFirstNumber.Text);
            var num2 = Convert.ToInt32(tbSecondNumber.Text);

            var sum = num1 + num2;

            lblAnswer.Text = sum.ToString();
            button5.Visible = false;
        }
    }
}
