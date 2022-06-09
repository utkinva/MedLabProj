using MedLabProj.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedLabProj
{
    public partial class PriceListForm : Form
    {
        public PriceListForm()
        {
            InitializeComponent();
        }

        private void priceListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PriceListForm_Load(object sender, EventArgs e)
        {
            priceListBindingSource.DataSource = Program.db.PriceList.ToList();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            PriceList priceList = (PriceList)priceListBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Удалить выбранный вид анализов?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Program.db.PriceList.Remove(priceList);
                    Program.db.SaveChanges();
                    MessageBox.Show($"Данные удалены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    priceListBindingSource.DataSource = Program.db.PriceList.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            else
            {
                return;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
