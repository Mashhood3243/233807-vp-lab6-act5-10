using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _233807VP_DB_WINFORMS
{
    public partial class Form2 : Form
    {

        public string CustomerName { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Hobbies { get; set; }
        public string Status { get; set; }

        public Form2(string customer,string country,string gender,string hobbies,string status)
        {

            InitializeComponent();
        CustomerName = customer;
            Country = country;
            Gender = gender;
            Hobbies = hobbies;
            Status = status;
        }

        public void DisplayData()
        {
            label6.Text = CustomerName;
            label7.Text = Country;
            label8.Text = Gender;
            label9.Text = Hobbies;
            label10.Text = Status;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }
    }
}
