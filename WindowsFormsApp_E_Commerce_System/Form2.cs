using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_E_Commerce_System
{
    public partial class Form2 : Form 
    {
        Form1 frm1;
        public Form2(Form1 frm1)
        {
            this.frm1 = frm1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        //Button DONE
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (StringException(textBoxUserName.Text) == false)
                return;
            if (StringException(textBoxPassword.Text) == false)
                return;
            if (StringException(textBoxStreet.Text) == false)
                return;
            if (IntException(textBoxBuildingNumber.Text) == false)
                return;
            int building_number = int.Parse(textBoxBuildingNumber.Text);
            if (StringException(textBoxCity.Text) == false)
                return;
            if (StringException(textBoxState.Text) == false)
                return;

            string user_name = textBoxUserName.Text;
            string password= textBoxPassword.Text;
            string street= textBoxStreet.Text;
            string city= textBoxCity.Text;
            string state = textBoxState.Text;

            if (frm1.AddBuyer(user_name, password, street, building_number, city, state) == false)
            {
                textBoxUserName.Clear();
            }

            else
                this.Close();
        }
        
        
        //EXCEPTIONS
        public static bool StringException(string input)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new Exception("Input cannot be null or whitespace only");
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        // IntException
        public static bool IntException(string input)
        {
           
            try
            {
                int.Parse(input);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }



    }
       

    }

