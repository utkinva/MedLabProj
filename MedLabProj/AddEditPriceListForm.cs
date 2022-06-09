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
    public partial class AddEditPriceListForm : Form
    {
        PriceList priceList;
        public AddEditPriceListForm()
        {
            InitializeComponent();

        }
        private void AddEditPriceListForm_Load(object sender, EventArgs e)
        {
            priceList = new PriceList();
            priceListBindingSource.Add(priceList);
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            if (titleTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните поле \"Наименование\"");
                return;
            }
            if (costMaskedTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните поле \"Стоимость\"");
                return;
            }

            if (priceList.ID == 0)
            {
                foreach (var item in Program.db.PriceList.ToList())
                {
                    if (item.Title == titleTextBox.Text)
                    {
                        MessageBox.Show("Такой вид анализов уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Program.db.PriceList.Add(priceList);
            }



            try
            {

                Program.db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


    }
}
