using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = textBox1.Text,
                UnitPrice =Convert.ToDecimal(textBox2.Text),
                StockAmount =Convert.ToInt16(textBox3.Text)
            });
            dgwProducts.DataSource = _productDal.GetAll();
        }
    }
}
