using database;
using database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        private StorageLogic logic = new StorageLogic();
        public Form1()
        {
            InitializeComponent();
            comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        private void LoadData()
        {
            try
            {
                var listCat = logic.ReadCategoty();
                var listProd = logic.ReadProduct();
                var listCatProd = logic.ReadCategotyProducts();
                if (listCatProd != null)
                {
                    dataGridView1.DataSource = listCatProd;
                    dataGridView1.Columns[0].Visible=false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = false;
                }
                if(listCat != null)
                {
                    comboBoxCategory.DisplayMember = "Id";
                    comboBoxCategory.ValueMember = "Id";
                    comboBoxCategory.DataSource = listCat;
                    comboBoxCategory.SelectedItem = null;
                }
                if (listProd != null)
                {
                    comboBoxProduct.DisplayMember = "Id";
                    comboBoxProduct.ValueMember = "Id";
                    comboBoxProduct.DataSource = listProd;
                    comboBoxProduct.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            if(textBoxCategory.Text == "")
            {
                throw new Exception("Заполните название категории");
            }
            logic.InsertCategory(new Category() { Name = textBoxCategory.Text });
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxCategory.SelectedIndex < 0 || comboBoxProduct.SelectedIndex < 0)
            {
                throw new Exception("Заполните внешние ключи");
            }
            logic.InsertProductCategory(new CategoryProduct()
            {
                ProductId = (int)comboBoxProduct.SelectedValue,
                CategoryId = (int)comboBoxCategory.SelectedValue
            });
            LoadData();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            if (textBoxProduct.Text == "")
            {
                throw new Exception("Заполните название категории");
            }
            logic.InsertProduct(new Product() { Name = textBoxProduct.Text });
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
