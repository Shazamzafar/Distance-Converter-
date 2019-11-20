// Name:        Shazam Zafar
// Class:       C#
//Project:      Distance Converter
//Date:         01/22/2019 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceConverterZafar
{
    public partial class Form1 : Form
    {

        public object Messagebox { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Addiing Item to the listBoxes
            FromListBox.Items.Add("Inch");
            FromListBox.Items.Add("Feet");
            FromListBox.Items.Add("Yard");

            // Addiing Item to the listBoxes
            ToDistanceListBox.Items.Add("Inch");
            ToDistanceListBox.Items.Add("Feet");
            ToDistanceListBox.Items.Add("Yard");

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            try
            {

                
                double distance; // Variable for distance
                double final = 0; //variable to store user input    
                string option, option2; //variables to store items from each listbox    


                if (double.TryParse(NumberTextBox.Text, out distance) && distance >= 0) //to prevent exemption    

                {


                    if (FromListBox.SelectedIndex != -1 &&
                    ToDistanceListBox.SelectedIndex != -1)//to prevent exemption for listboxes  
                    {
                        // Conversion
                        option = FromListBox.SelectedItem.ToString();
                        option2 = ToDistanceListBox.SelectedItem.ToString();

                        // if statements for all the calculations 

                        if (option == "Yard" && option2 == "Feet")
                        {
                            final = distance * 3;
                        }
                        else if (option == "Yard" && option2 == "Inch")
                        {
                            final = distance * 36;

                        }
                        else if (option == "Feet" && option2 == "Yard")
                        {
                            final = distance / 3;
                        }
                        else if (option == "Feet" && option2 == "Inch")
                        {
                            final = distance * 12;
                        }
                        else if (option == "Inch" && option2 == "Feet")

                        { final = distance / 12; }

                        else if (option == "Inch" && option2 == "Yard")
                        {
                            final = distance / 36;

                        }
                        else if (option == option2)
                        {
                            final = distance;
                        }
                        //if (final >= 0)
                        //{
                            // Displaying
                            AnswerLabel.Text = final.ToString("");
                       // }
                    }

                    
                    else
                    {
                        MessageBox.Show("Please select an item from the list"); // Asking user to select  listbox
                    }
                }
                

                  
                else
                {
                    MessageBox.Show("Please enter a number greater than 0!"); // Asking user to enter a number
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear textbox  label and list box
            NumberTextBox.Clear();
            AnswerLabel.Text = "";
            FromListBox.SelectedIndex = -1;
            ToDistanceListBox.SelectedIndex = -1;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // close program
            Close();
        }

        
    }
}