using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnum1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtnum2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum2.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(txtnum1.Text, out n1).ToString());
            if (!double.TryParse(txtnum1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show(double.TryParse(txtnum2.Text, out n2).ToString());
            if (!double.TryParse(txtnum2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtoutput.Text = (n1 + n2).ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnum1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtnum2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum2.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(txtnum1.Text, out n1).ToString());
            if (!double.TryParse(txtnum1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show(double.TryParse(txtnum2.Text, out n2).ToString());
            if (!double.TryParse(txtnum2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtoutput.Text = (n1 - n2).ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnum1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtnum2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum2.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(txtnum1.Text, out n1).ToString());
            if (!double.TryParse(txtnum1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show(double.TryParse(txtnum2.Text, out n2).ToString());
            if (!double.TryParse(txtnum2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtoutput.Text = (n1 * n2).ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnum1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtnum2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum2.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(txtnum1.Text, out n1).ToString());
            if (!double.TryParse(txtnum1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show(double.TryParse(txtnum2.Text, out n2).ToString());
            if (!double.TryParse(txtnum2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtoutput.Text = (n1 / n2).ToString();
        }

        private void rem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnum1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtnum2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum2.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(txtnum1.Text, out n1).ToString());
            if (!double.TryParse(txtnum1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show(double.TryParse(txtnum2.Text, out n2).ToString());
            if (!double.TryParse(txtnum2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtoutput.Text = (n1 % n2).ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();    
            txtnum2.Clear();
            txtoutput.Clear();
            txtnum1.Focus();

        }
    }
}
