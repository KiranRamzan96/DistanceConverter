using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            
            double distance = 0;
           
            if (double.TryParse(txt_Enterdistance.Text, out distance))
            { 
                string from = lst_From.SelectedItem.ToString();
                string to = Lst_To.SelectedItem.ToString();
               
                if (from == to)
                {
                 
                    txt_condistance.Text = txt_Enterdistance.Text;                 
                }
                else
                {
                    if (from == "Inches" && to == "Feet" )
                    {
                        //if Feet is selected for conversion
                        //make conversion and display it in the textbox
                        txt_condistance.Text = (distance / 12).ToString("0.00");
                    }
                    else if (from == "Inches" && to == "Yards" )
                    {
                        //if Yards is selected for conversion
                        //make conversion and display it in the textbox
                        txt_condistance.Text = (distance / 36).ToString("0.00");
                    }
                    else if (from == "Feet" && to == "Inches" )
                    {
                        //if inches is selected for conversion
                        //make conversion and display it in the textbox
                        txt_condistance.Text = (distance * 12).ToString("0.00");
                    }
                    else if (from == "Feet" && to == "Yards")
                    {
                        //if Yards is selected for conversion
                        //make conversion and display it in the textbox
                        txt_condistance.Text = (distance / 3).ToString("0.00");
                    }

                    else if (from == "Yards" && to == "Inches")
                    {
                        //if inches is selected for conversion
                        //make conversion and display it in the textbox
                        txt_condistance.Text = (distance * 36).ToString("0.00");
                    }
                    else if (from == "Yards" && to == "Feet")
                    {
                        //if Feet is selected for conversion
                        //make conversion and display it in the textbox
                        txt_condistance.Text = (distance * 3).ToString("0.00");
                    }
                }

            }
            else
            {
                //display MessageBox
                MessageBox.Show("Enter valid distance in number.");
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
