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
    enum State
    {
        Create = 1,
        Update = 2
    }

    public partial class formSalary : Form
    {
        
        static State state;
        public formSalary()
        {
            InitializeComponent();
        }

        private void formSalary_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dBDataSet.workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.salarys". При необходимости она может быть перемещена или удалена.
            this.salarysTableAdapter.Fill(this.dBDataSet.salarys);

            // Проверка есть ли рабочий в БД
            if (this.dBDataSet.workers.Count > 0)
            {
                // Рабочий есть - обновление
                state = State.Update;
                // Отображаем ЗП
                ShowSalarysList();
            }
            else
            {
                // Рабочего нет - добавление
                state = State.Create;
                // Скрываем ЗП
                HideSalarysList();
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms["Form1"];

            if (main != null)
            {
                main.Show();
            }

            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Сохранение позиции отред. работника
            int current_position = this.workersBindingSource1.Position;

            // Завершение редактирования
            this.workersBindingSource1.EndEdit();

            // сохранение изменений
            this.workersTableAdapter.Update(this.dBDataSet.workers);

            // Активация нового работника
            if (state == State.Create)
            {
                // Режим создания
                ShowSalarysList();
                state = State.Update;
            }
            else
            {
                // Режим сохранения
                this.salarysTableAdapter.Update(this.dBDataSet.salarys);
            }

            // Обновление формы
            this.workersTableAdapter.Fill(this.dBDataSet.workers);
            this.workersBindingSource1.Position = current_position;

        }

        private void workersBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // Если текущий режим создане - выход
            if (state == State.Create) return;

            // Если текущий элемент не доступен - выход
            if (this.workersBindingSource1.Current == null) return;

            // выполнение загрузки ЗП работника
            this.salarysTableAdapter.FillByWorkerId(
                this.dBDataSet.salarys, 
                GetCurrentWorkerID()
            );
        }

        // Получить ID активного работника
        int GetCurrentWorkerID()
        {
            if (this.workersBindingSource1.Current == null)
                return -1;

            var row = ((DataRowView)this.workersBindingSource1.Current).Row;
            var col = this.dBDataSet.workers.Columns["worker_id"];
            return Convert.ToInt32(row[col]);
        }

        // Получить ID активного ЗП
        int GetCurrentSalaryID()
        {
            var row = ((DataRowView)this.salarysBindingSource.Current).Row;
            var col = this.dBDataSet.salarys.Columns["salary_id"];
            return Convert.ToInt32(row[col]);
        }

        // Отобразить таблицу ЗП
        void ShowSalarysList()
        {
            lb_warning.Visible = false;
            groupBoxSalarus.Visible = true;
        }
        // Скрыть таблицу ЗП
        void HideSalarysList()
        {
            lb_warning.Visible = true;
            groupBoxSalarus.Visible = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            state = State.Create;
            HideSalarysList();
        } 

        private void salarysBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            // Автоматическая подстановка Работника в Таблицу
            // Создаем новый объект DataRowView
            // Получаем ID текущего выбранного сотрудника
            int currentWorkerId = GetCurrentWorkerID();
            if (currentWorkerId == -1)
            {
                MessageBox.Show("Сначала выберите сотрудника в списке выше.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем новую строку из источника данных
            DataRowView newRow = (DataRowView)this.salarysBindingSource.AddNew();
            // Устанавливаем worker_id
            newRow["worker_id"] = currentWorkerId;
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            int currentWorkerId = GetCurrentWorkerID();
            if (currentWorkerId == -1)
            {
                MessageBox.Show("Пожалуйста, сначала выберите сотрудника.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SalaryFormUnit vfu = new SalaryFormUnit();
            vfu.CreateItem(currentWorkerId);

            if (vfu.ShowDialog() == DialogResult.OK)
            {
                this.salarysTableAdapter.Update(this.dBDataSet.salarys);
                workersBindingSource1_CurrentChanged(null, null);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Отображение формы редактирования
            SalaryFormUnit vfu = new SalaryFormUnit();
            vfu.LoadItem(GetCurrentSalaryID());
            // Если пользователь нажал "Сохранить"
            if (vfu.ShowDialog() == DialogResult.OK)
            {
                // Обновть данные таблицы
                workersBindingSource1_CurrentChanged(null, null);
            }
        }
    }
}
