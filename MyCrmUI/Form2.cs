using Autofac;
using MyCrm.Model;
using MyCrm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCrmUI
{
    public partial class Form2 : Form
    {
        private readonly ICustomerService customerService;
        public Form2(ICustomerService customerService)
        {
            InitializeComponent();
            this.customerService = customerService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Phone = textBox3.Text,
                Email = textBox4.Text
            };

            customerService.Insert(customer);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
