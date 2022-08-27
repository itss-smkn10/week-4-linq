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
    public partial class FormTransaction : Form
    {
        private int currentRow = -1;

        public FormTransaction()
        {
            InitializeComponent();
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void loadDgv()
        {
            DataClassesDataContext db = new DataClassesDataContext();
            foreach (Merchandise merchandise in db.Merchandises)
            {
                dgvMerchandise.Rows.Add(merchandise.Id, merchandise.Name, merchandise.Model.Name, merchandise.Specification, merchandise.Price);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > -1)
            {
                currentRow = e.RowIndex;

                txtName.Text = dgvMerchandise.Rows[currentRow].Cells[1].Value.ToString();
                txtPrice.Text = dgvMerchandise.Rows[currentRow].Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Add")
            {
                var dgvMerchandiseRows = dgvMerchandise.Rows[currentRow];

                for (int i = 0; i < dgvOrder.RowCount; i++)
                {
                    if (dgvOrder.Rows[i].Cells[0].Value == dgvMerchandiseRows.Cells[0].Value)
                    {
                        int qty = Convert.ToInt32(dgvOrder.Rows[i].Cells[3].Value);

                        dgvOrder.Rows[i].Cells[3].Value = qty + Convert.ToInt32(txtQty.Text);
                        dgvOrder.Rows[i].Cells[5].Value = Convert.ToInt32(dgvOrder.Rows[i].Cells[3].Value) * Convert.ToInt32(txtPrice.Text);
                        // generateTotal();
                        return;
                    }
                }

                dgvOrder.Rows.Add(
                    dgvMerchandiseRows.Cells[0].Value.ToString(),
                    dgvMerchandiseRows.Cells[1].Value.ToString(),
                    dgvMerchandiseRows.Cells[2].Value.ToString(),
                    txtQty.Text,
                    dgvMerchandiseRows.Cells[4].Value.ToString(),
                    Convert.ToInt32(dgvMerchandiseRows.Cells[4].Value.ToString()) * Convert.ToInt32(txtQty.Text)
               );
            }
            else
            {

            }


        }
    }
}
