using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AisOfTheRailwayStationDispatcherMy
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.dbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.dbDataSet.должности);

        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 || dataGridView1.CurrentRow == null)
                MessageBox.Show("Не выбрана должность");
            else
                try
                {
                    сотрудникTableAdapter.Update(dbDataSet.сотрудник);
                    MessageBox.Show("Изменения сохранены");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
