using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_4___LINQ
{
    public partial class Form1 : Form
    {
        private int currentSelectedRow = -1;
        private bool isUpdate = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadCbRole();
            enable(false);
        }

        private void enable(bool enabled)
        {
            enableField(enabled);
            enableButton(enabled);
        }

        private void enableField(bool enabled)
        {
            txtName.Enabled = enabled;
            txtEmal.Enabled = enabled;
            txtPhoneNumber.Enabled = enabled;
        }

        private void enableButton(bool enabled)
        {
            btnInsert.Enabled = !enabled;
            btnUpdate.Enabled = !enabled;
            btnDelete.Enabled = !enabled;
            btnSave.Enabled = enabled;
            btnCancel.Enabled = enabled;
        }

        private void loadCbRole()
        {
            cbRole.Items.Clear();

            DataClassesDataContext dataClassesDataContext = new DataClassesDataContext();
            cbRole.DataSource = dataClassesDataContext.Roles;
            cbRole.ValueMember = "Id";
            cbRole.DisplayMember = "Name";
        }

        private void loadDgv()
        {
            dgv.Rows.Clear();

            DataClassesDataContext dataClassesDataContext = new DataClassesDataContext();
            IQueryable<Customer> customers = dataClassesDataContext.Customers.Where(x => x.Name.Contains(textBox1.Text) || x.Email.Contains(textBox1.Text));

            foreach (Customer customer in customers)
            {
                dgv.Rows.Add(customer.Id, customer.Name, customer.Email, customer.PhoneNumber);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFieldData();
            enable(true);
            isUpdate = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentSelectedRow == -1)
            {
                MessageBox.Show("You must select datagridview cell");
            }
            else
            {
                enable(true);
                isUpdate = true;
            }
        }

        private bool checkAll()
        {
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentSelectedRow == -1)
            {
                MessageBox.Show("You must select datagridview cell");
            }
            else
            {
                DataClassesDataContext dataClassesDataContext = new DataClassesDataContext();

                Customer customer = dataClassesDataContext.Customers.Where(x => x.Id.Equals(txtID.Text)).FirstOrDefault();
                dataClassesDataContext.Customers.DeleteOnSubmit(customer);

                dataClassesDataContext.SubmitChanges();

                loadDgv();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enable(false);
            clearFieldData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dataClassesDataContext = new DataClassesDataContext();
            if (isUpdate)
            {
                Customer customer = dataClassesDataContext.Customers.Where(x => x.Id.Equals(txtID.Text)).FirstOrDefault();
                customer.Id = txtID.Text;
                customer.Name = txtName.Text;
                customer.Email = txtEmal.Text;
                customer.PhoneNumber = txtPhoneNumber.Text;

                dataClassesDataContext.SubmitChanges();
            }
            else
            {
                Customer customer = new Customer();
                customer.Id = txtID.Text;
                customer.Name = txtName.Text;
                customer.Email = txtEmal.Text;
                customer.PhoneNumber = txtPhoneNumber.Text;

                bool emailExist = dataClassesDataContext.Administrators.Any(x => x.Email.Equals(txtEmal.Text));
                if (emailExist)
                {
                    MessageBox.Show("Nggak boleh sama, email ");
                }
                else if (checkAll())
                {
                    dataClassesDataContext.Customers.InsertOnSubmit(customer);
                    dataClassesDataContext.SubmitChanges();
                }
            }
            loadDgv();
            enable(false);
            clearFieldData();
        }

        private void clearFieldData()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmal.Text = "";
            txtPhoneNumber.Text = "";
            textBox1.Text = "";
            currentSelectedRow = -1;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentSelectedRow = e.RowIndex;

                txtID.Text = dgv.Rows[currentSelectedRow].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[currentSelectedRow].Cells[1].Value.ToString();
                txtEmal.Text = dgv.Rows[currentSelectedRow].Cells[2].Value.ToString();
                txtPhoneNumber.Text = dgv.Rows[currentSelectedRow].Cells[3].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadDgv();
        }
    }
}
