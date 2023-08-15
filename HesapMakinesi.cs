using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDesktopApp
{
    public partial class HesapMakinesi : Form
    {
        decimal number = 0; //Hafızadaki Değer
        string operations = "";
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void btnOne_Click_1(object sender, EventArgs e)
        {
            txtProgress.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "9";
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            txtProgress.Text += "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProgress.Text = "";
            lblResult.Text = "Sonuç:";
            lbOperations.Text = "İşlemler:";
            number = 0;
            operations = "";

        }

        private void txtProgress_TextChanged(object sender, EventArgs e)
        {
            //if (txtProgress.Text == "") txtProgress.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(txtProgress.Text != "")
            {
                if (operations == "")
                {
                    operations = txtProgress.Text; //Eğer operations boş ise txtProgress değerimi buraya yaz 5
                }
                else
                {
                    operations = number + "+" + txtProgress.Text; //Toplama işlemi yaparken burada bir değer varsa 5+10+5; 15+5 değer ekle diyoruz
                }
                lbOperations.Text = "İşlemler:" + operations;

            }

            decimal txtNumber = txtProgress.Text == "" ? 0 : Convert.ToDecimal(txtProgress.Text);
            number += txtNumber;  // Hafızaki number değeri += burdaki txtNumber değeri
            lblResult.Text = "Sonuç:" + number;
            txtProgress.Text = "";
        }

        private void btnMines_Click(object sender, EventArgs e)
        {
            if (txtProgress.Text != "")
            {
                if (operations == "")
                {
                    operations = txtProgress.Text; 
                }
                else
                {
                    operations = number + "-" + txtProgress.Text; 
                }
                lbOperations.Text = "İşlemler:" + operations;
            }
            decimal txtNumber = txtProgress.Text == "" ? 0 : Convert.ToDecimal(txtProgress.Text);
            number -= txtNumber;  
            lblResult.Text = "Sonuç:" + number;
            txtProgress.Text = "";
        }
            private void btnMultiplication_Click(object sender, EventArgs e)
        {

                if (txtProgress.Text != "")
                {
                    if (operations == "")
                    {
                        operations = txtProgress.Text; 
                    }
                    else
                    {
                        operations = number + "*" + txtProgress.Text;
                    }
                lbOperations.Text = "İşlemler:" + operations;
                     }
                decimal txtNumber = txtProgress.Text == "" ? 1 : Convert.ToDecimal(txtProgress.Text);
                    number *= txtNumber;  
                    lblResult.Text = "Sonuç:" + number;
                    txtProgress.Text = "";
                }
                private void btnDivision_Click(object sender, EventArgs e)
        {

                    if (txtProgress.Text != "")
                    {
                        if (operations == "")
                        {
                            operations = txtProgress.Text; 
                        }
                        else
                        {
                            operations = number + "/" + txtProgress.Text; 
                        }
                        lbOperations.Text = "İşlemler:" + operations;

                    }
            decimal txtNumber = txtProgress.Text == "" ? 1 : Convert.ToDecimal(txtProgress.Text);
            number /= txtNumber; 
            lblResult.Text = "Sonuç:" + number;
            txtProgress.Text = "";
        }
        private void txtProgress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch))  //Yazdığım değer digit degilse 
             {
                e.Handled = true; //Yazdığım son karekteri hafızada saklama, uçur.
            }

                if (ch == '+' ) 
            {
                e.Handled = true;//10+ gibi bir string deger almaması için bu kodu yazıyoruz.Yazılan + text değeri olarak almaz.
                btnPlus_Click(sender, e);
            }
            else if (ch == '-')
             {
                e.Handled = true;
                btnMines_Click(sender, e);
            }
            else if (ch == '*')
            {
                e.Handled = true;
                btnMultiplication_Click(sender, e);
            }
            else if (ch== '/')
            {
                e.Handled = true;
                btnDivision_Click(sender, e);
            }

        }
    }
}
