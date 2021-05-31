using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double widthFeet, lengthFeet;
            double areaFeet, areaYard;
            double priceFloor = 0;
            double totalCost = 0;
            string value;

            try
            {

                if (txtBxLfeet.Text == "" && txtBxLinches.Text != "")
                {
                    lengthFeet = double.Parse(txtBxLinches.Text) / 12;
                }
                else if (txtBxLfeet.Text != "" && txtBxLinches.Text == "")
                {
                    lengthFeet = double.Parse(txtBxLfeet.Text);
                }
                else
                {
                    lengthFeet = double.Parse(txtBxLfeet.Text) + double.Parse(txtBxLinches.Text) / 12;
                }

                if (txtBxWFeet.Text == "" && txtBxWInches.Text != "")
                {
                    widthFeet = double.Parse(txtBxWInches.Text) / 12;
                }
                else if (txtBxWFeet.Text != "" && txtBxWInches.Text == "") 
                {
                    widthFeet = double.Parse(txtBxWFeet.Text);
                }
                else
                {
                    widthFeet = double.Parse(txtBxWFeet.Text) + double.Parse(txtBxWInches.Text) / 12;
                }

                areaFeet = widthFeet * lengthFeet;
                areaYard = areaFeet / 9;


                if (rdBtnOak.Checked)
                {
                    value = rdBtnOak.Text;
                    priceFloor = double.Parse(value.Substring(value.Length - 21, 5));
                }
                else if (rdBtnCherry.Checked)
                {
                    value = rdBtnCherry.Text;
                    priceFloor = double.Parse(value.Substring(value.Length - 21, 5));
                }
                else if (rdBtnMaple.Checked)
                {
                    value = rdBtnMaple.Text;
                    priceFloor = double.Parse(value.Substring(value.Length - 21, 5));
                }
                else if (rdBtnWalnut.Checked)
                {
                    value = rdBtnWalnut.Text;
                    priceFloor = double.Parse(value.Substring(value.Length - 21, 5));
                }

                totalCost = priceFloor * areaYard;

                    
                txtBxTotalCost.Text = "The total cost to cover the room is " + totalCost.ToString("C2") + "."
                    + "\r\nThe room area is " + areaYard.ToString("F2") + " square yard.";


            }
            catch (FormatException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (DivideByZeroException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (ArgumentException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxLfeet.Clear();
            txtBxLinches.Clear();
            txtBxTotalCost.Clear();
            txtBxWFeet.Clear();
            txtBxWInches.Clear();
        }
    }
}
