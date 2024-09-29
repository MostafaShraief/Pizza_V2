using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void calculate_total_price()
        {

            int Price = 0;

            // Calculate Size Price
            if (rb_size_small.Checked)
                Price += Convert.ToInt32(rb_size_small.Tag);
            else if (rb_size_medium.Checked)
                Price += Convert.ToInt32(rb_size_medium.Tag);
            else if (rb_size_large.Checked)
                Price += Convert.ToInt32(rb_size_large.Tag);

            // Calculate Crust Pizza
            if (rb_crust_thin.Checked)
                Price += Convert.ToInt32(rb_crust_thin.Tag);
            else if (rb_crust_thick.Checked)
                Price += Convert.ToInt32(rb_crust_thick.Tag);

            // Calculate Where To Eat Price
            if (rb_whrtoeat_eatin.Checked)
                Price += Convert.ToInt32(rb_whrtoeat_eatin.Tag);
            else if (rb_whrtoeat_outside.Checked)
                Price += Convert.ToInt32(rb_whrtoeat_outside.Tag);

            // Calculate Toppings Price
            if (chk_ext_cheese.Checked)
                Price += Convert.ToInt32(chk_ext_cheese.Tag);
            if (chk_onions.Checked)
                Price += Convert.ToInt32(chk_onions.Tag);
            if (chk_olives.Checked)
                Price += Convert.ToInt32(chk_olives.Tag);
            if (chk_mushrooms.Checked)
                Price += Convert.ToInt32(chk_mushrooms.Tag);
            if (chk_tomatoes.Checked)
                Price += Convert.ToInt32(chk_tomatoes.Tag);
            if (chk_green_peppers.Checked)
                Price += Convert.ToInt32(chk_green_peppers.Tag);

            lbl_price.Text = '$' + Price.ToString();

        }

        void update_lbl_toppings_text()
        {

            string ToppingsText = "";

            if (chk_ext_cheese.Checked)
                ToppingsText += "Extra Cheese, ";
            if (chk_onions.Checked)
                ToppingsText += "Onions, ";
            if (chk_olives.Checked)
                ToppingsText += "Olives, ";
            if (chk_mushrooms.Checked)
                ToppingsText += "Mushrooms, ";
            if (chk_tomatoes.Checked)
                ToppingsText += "Tomatoes, ";
            if (chk_green_peppers.Checked)
                ToppingsText += "Green Peppers, ";

            if (ToppingsText != "")
            {
                ToppingsText = ToppingsText.Remove(ToppingsText.Length - 2, 2);
                ToppingsText += '.';
            }
            else
                ToppingsText = lbl_toppings.Tag.ToString();

            lbl_toppings.Text = ToppingsText;

        }

        bool check_order()
        {

            return (rb_size_small.Checked || // check size
                   rb_size_medium.Checked || 
                   rb_size_large.Checked) &&
                   (rb_crust_thin.Checked || // check crust
                   rb_crust_thick.Checked) &&
                   (rb_whrtoeat_eatin.Checked || // check where to eat
                   rb_whrtoeat_outside.Checked) && 
                   (chk_ext_cheese.Checked || // check toppings
                   chk_onions.Checked ||
                   chk_onions.Checked ||
                   chk_mushrooms.Checked ||
                   chk_tomatoes.Checked ||
                   chk_green_peppers.Checked);
        }

        void order()
        {

            if (check_order())
            {

                // Disable All Group Buttons
                gb_size.Enabled = false;
                gb_crust.Enabled = false;
                gb_whrtoeat.Enabled = false;
                gb_toppings.Enabled = false;
                gb_summary.Enabled = false;
                btn_order.Enabled = false;

                // Show Successful Message
                MessageBox.Show("Ordered Successfully.", "Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Ordered Canceled,\nThere Is Empty Field/s.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        void reset_new_form()
        {

            // Size
            rb_size_small.Checked = false;
            rb_size_medium.Checked = false;
            rb_size_large.Checked = false;
            lbl_size.Text = lbl_size.Tag.ToString();

            // Crust
            rb_crust_thin.Checked = false;
            rb_crust_thick.Checked = false;
            lbl_crust.Text = lbl_crust.Tag.ToString();

            // Where To Eat
            rb_whrtoeat_outside.Checked = false;
            rb_whrtoeat_eatin.Checked = false;
            lbl_whrtoeat.Text = lbl_whrtoeat.Tag.ToString();

            // Toppings
            chk_ext_cheese.Checked = false;
            chk_onions.Checked = false;
            chk_olives.Checked = false;
            chk_mushrooms.Checked = false;
            chk_tomatoes.Checked = false;
            chk_green_peppers.Checked = false;
            lbl_toppings.Text = lbl_toppings.Tag.ToString();

            // Enable Group Buttons
            gb_size.Enabled = true;
            gb_crust.Enabled = true;
            gb_whrtoeat.Enabled = true;
            gb_toppings.Enabled = true;
            gb_summary.Enabled = true;
            btn_order.Enabled = true;

            // Recalculate Price
            calculate_total_price();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void thunderGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void dungeonHeaderLabel17_Click(object sender, EventArgs e)
        {

        }

        private void thunderGroupBox5_Click(object sender, EventArgs e)
        {

        }

        private void rb_size_small_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            lbl_size.Text = "Small";
        }

        private void gb_size_medium_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            lbl_size.Text = "Medium";
        }

        private void gb_size_large_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            lbl_size.Text = "Large";
        }

        private void rb_crust_thin_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            lbl_crust.Text = "Thin Crust";
        }

        private void rb_crust_thick_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            lbl_crust.Text = "Thick Crust";
        }

        private void rb_whrtoeat_outside_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            lbl_whrtoeat.Text = "Outside";
        }
        private void rb_whrtoeat_eatin_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            lbl_whrtoeat.Text = "Eat In";
        }

        private void chk_ext_cheese_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            update_lbl_toppings_text();
        }
        private void chk_onions_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            update_lbl_toppings_text();
        }

        private void chk_olives_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            update_lbl_toppings_text();
        }

        private void chk_mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            update_lbl_toppings_text();
        }

        private void chk_tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            update_lbl_toppings_text();
        }

        private void chk_green_peppers_CheckedChanged(object sender, EventArgs e)
        {
            calculate_total_price();
            update_lbl_toppings_text();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            order();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            reset_new_form();
        }
    }
}
