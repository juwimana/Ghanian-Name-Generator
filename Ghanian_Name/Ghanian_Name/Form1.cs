using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghanian_Name
{
    public partial class Form1 : Form
    {
        string[] male_name = { "Kojo", "Kwabena", "Kwaku", "Yaw", "Kofi", "Kwame", "Kwesi" };
        string[] female_name = { "Adjoa", "Abena", "Akua", "Yaa", "Afua", "Ama", "Akosua" };
        string day = "";
        string gender = "";
        public Form1()
        {
            InitializeComponent();
            //Change title of form
            this.Text = "My Ghanian Name";
            
            // Changes the border to Fixed3D.
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
         public enum FlatStyle
        {
            Popup,
        }
        private void comboBox_day_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           day = comboBox_day.SelectedItem.ToString();
        }

        private void comboBox_gender_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            gender = comboBox_gender.SelectedItem.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (gender == "Female")
            {
                if (day == "Monday")
                {
                    label_name.Text = female_name[0];
                }
                else if (day == "Tuesday")
                {
                    label_name.Text = female_name[1];
                }
                else if (day == "Wednesday")
                {
                    label_name.Text = female_name[2];
                }
                else if (day == "Thursday")
                {
                    label_name.Text = female_name[3];
                }
                else if (day == "Friday")
                {
                    label_name.Text = female_name[4];
                }
                else if (day == "Saturday")
                {
                    label_name.Text = female_name[5];
                }
                else if (day == "Sunday")
                {
                    label_name.Text = female_name[6];
                }
            }
            else if (gender == "Male")
            {
                if (day == "Monday")
                {
                    label_name.Text = male_name[0];
                }
                else if (day == "Tuesday")
                {
                    label_name.Text = male_name[1];
                }
                else if (day == "Wednesday")
                {
                    label_name.Text = male_name[2];
                }
                else if (day == "Thursday")
                {
                    label_name.Text = male_name[3];
                }
                else if (day == "Friday")
                {
                    label_name.Text = male_name[4];
                }
                else if (day == "Saturday")
                {
                    label_name.Text = male_name[5];
                }
                else if (day == "Sunday")
                {
                    label_name.Text = male_name[6];
                }
            }
            else
                label_name.Text = "Error";
                
        }

        
    }
}
