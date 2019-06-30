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
    public partial class FormGuncelleme : Form
    {
        private readonly ICustomerService customerService;
        private readonly Customer customer;
        public FormGuncelleme(ICustomerService customerService, Customer customer)
        {
            InitializeComponent();
            this.customerService = customerService;
            this.customer = customer;
            label1.Text = "ID : " + customer.Id;
            textBox1.Text = customer.FirstName;
            textBox2.Text = customer.LastName;
            textBox3.Text = customer.Phone;
            textBox4.Text = customer.Email;
        }

        private void FormGuncelleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer.FirstName = textBox1.Text;
            customer.LastName = textBox2.Text;
            customer.Phone = textBox3.Text;
            customer.Email = textBox4.Text;
            customerService.Update(customer);
        }
    }
}
