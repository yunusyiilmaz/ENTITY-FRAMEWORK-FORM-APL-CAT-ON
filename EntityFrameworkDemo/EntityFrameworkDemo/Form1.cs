using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        productDal _productDal=new productDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void LoadProduct()
        {
        dataGridView1.DataSource = _productDal.GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = txbName.Text,
                UnityPrice = Convert.ToInt32(txbUnitPrice.Text),
                StockAmount = Convert.ToInt32(txbStockAmount.Text)
            });
            LoadProduct();
            MessageBox.Show("ADDED");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = txbNameUpdate.Text,
                UnityPrice=Convert.ToInt32(txbUnitPriceUpdate.Text),
                StockAmount=Convert.ToInt32(txbStockAmountUpdate.Text)
            }) ;
            LoadProduct();
            MessageBox.Show("UPDATED");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbNameUpdate.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txbUnitPriceUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txbStockAmountUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            });
            LoadProduct();
            MessageBox.Show("DELETED");
        }
    }
}
