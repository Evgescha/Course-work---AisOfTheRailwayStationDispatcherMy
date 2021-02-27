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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.dbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.пассажир". При необходимости она может быть перемещена или удалена.
            this.пассажирTableAdapter.Fill(this.dbDataSet.пассажир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.билет". При необходимости она может быть перемещена или удалена.
            this.билетTableAdapter.Fill(this.dbDataSet.билет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.маршрут". При необходимости она может быть перемещена или удалена.
            this.маршрутTableAdapter.Fill(this.dbDataSet.маршрут);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.маршрут". При необходимости она может быть перемещена или удалена.
            this.маршрутTableAdapter.Fill(this.dbDataSet.маршрут);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.билет". При необходимости она может быть перемещена или удалена.
            this.билетTableAdapter.Fill(this.dbDataSet.билет);

        }

        private void Ticket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void сохранитьToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 || dataGridView1.CurrentRow == null)
                MessageBox.Show("Не выбран маршрут");
            else
                try
                {
                    билетTableAdapter.Update(dbDataSet.билет); 
                    MessageBox.Show("Изменения сохранены");
                    this.билетTableAdapter.Fill(this.dbDataSet.билет);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
