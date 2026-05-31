using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystems
{
    public partial class SalaryFormUnit : Form
    {
        public SalaryFormUnit()
        {
            InitializeComponent();
        }

        public void CreateItem (int WorkerID)
        {
            try
            {
                // Создание новой строки в DataTable
                DataTable salarysTable = this.dBDataSet.salarys;
                DataRow newRow = salarysTable.NewRow();
                newRow["worker_id"] = WorkerID;
                newRow["salary_amount"] = 0;
                newRow["date_pay"] = DateTime.Now;

                // Добавление строки в таблицу
                salarysTable.Rows.Add(newRow);

                // Устанавливаем позицию на новую строку
                this.SalarysBindingSource.Position = this.SalarysBindingSource.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания записи: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadItem (int SalaryID)
        {
            try
            {
                this.salarysTableAdapter.FillById(this.dBDataSet.salarys, SalaryID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки записи: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalaryFormUnit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.salarys". При необходимости она может быть перемещена или удалена.
            //this.salarysTableAdapter.Fill(this.dBDataSet.salarys);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.SalarysBindingSource.EndEdit();
                this.salarysTableAdapter.Update(this.dBDataSet.salarys);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
