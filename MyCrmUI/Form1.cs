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
    public partial class Form1 : Form
    {
        private readonly ICustomerService customerService;
        public Form1(ILifetimeScope scope)
        {
            InitializeComponent();
            customerService = scope.Resolve<ICustomerService>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Müşteri Sayısı = " + customerService.GetAll().Count().ToString();
            dataGridView1.DataSource = customerService.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(customerService);
            f2.FormClosed += F2_FormClosed;
            f2.Show();
        }
        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = customerService.GetAll();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var a = ((List<Customer>)dataGridView1.DataSource)[(dataGridView1.SelectedRows[0].Index)];
            FormGuncelleme gun = new FormGuncelleme(customerService,a);
            gun.Show();
        }
    }
}
