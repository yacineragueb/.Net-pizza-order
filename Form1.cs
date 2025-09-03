using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if(rbSmallSize.Checked)
            {
                lSizeValue.Text = "Small";
                return;
            }
            if (rbMeduimSize.Checked)
            {
                lSizeValue.Text = "Meduim";
                return;
            }
            if (rbLargSize.Checked)
            {
                lSizeValue.Text = "Larg";
                return;
            }

        }

        private void UpdateToppings(string Separator = ", ")
        {
            UpdateTotalPrice();

            string AllToppings = "";

            if (chbExtraCheese.Checked) AllToppings += chbExtraCheese.Text + Separator;
            if (chbMashrooms.Checked) AllToppings += chbMashrooms.Text + Separator;
            if (chbTomatoes.Checked) AllToppings += chbTomatoes.Text + Separator;
            if (chbOnion.Checked) AllToppings += chbOnion.Text + Separator;
            if (chbOlives.Checked) AllToppings += chbOlives.Text + Separator;
            if (chbGreenPeppers.Checked) AllToppings += chbGreenPeppers.Text + Separator;

            if(AllToppings.EndsWith(Separator))
            {
                AllToppings = AllToppings.Substring(0, AllToppings.Length - Separator.Length);
            }

            if (AllToppings == "")
            {
                lToppingsValue.Text = "There is no Toppings";
            } else
            {
                lToppingsValue.Text = AllToppings;
            }
        }

        float GetSelectedSizePrice()
        {
            if (rbSmallSize.Checked)
                return Convert.ToSingle(rbSmallSize.Tag);
            else if (rbMeduimSize.Checked)
                return Convert.ToSingle(rbMeduimSize.Tag);
            else 
                return Convert.ToSingle(rbLargSize.Tag);
        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if(chbExtraCheese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbExtraCheese.Tag);
            }

            if (chbMashrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbMashrooms.Tag);
            }

            if (chbTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbTomatoes.Tag);
            }

            if (chbOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbOnion.Tag);
            }

            if (chbOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbOlives.Tag);
            }

            if (chbGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbGreenPeppers.Tag);
            }

            return ToppingsTotalPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);
            else 
                return Convert.ToSingle(rbThickCrust.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lTotalPriceValue.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lSizeValue.Text = "Thin Crust";
                return;
            }
            if (rbThickCrust.Checked)
            {
                lSizeValue.Text = "Thick Crust";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            if (rbTakeOut.Checked)
            {
                lSizeValue.Text = "Take out";
                return;
            }
            if (rbEatIn.Checked)
            {
                lSizeValue.Text = "Eat in";
                return;
            }
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        private void rbSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduimSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLargSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want order this pizza?", "Confirm your order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                gbFormPizza.Enabled = false;
                MessageBox.Show("You order successfuly", "Order pizza");
            }

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbFormPizza.Enabled = true;
            rbSmallSize.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true;
            if (chbExtraCheese.Checked) chbExtraCheese.Checked = false;
            if (chbMashrooms.Checked) chbMashrooms.Checked = false;
            if (chbTomatoes.Checked) chbTomatoes.Checked = false;
            if (chbOnion.Checked) chbOnion.Checked = false;
            if (chbOlives.Checked) chbOlives.Checked = false;
            if (chbGreenPeppers.Checked) chbGreenPeppers.Checked = false;
        }

        private void chbMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
    }
}
