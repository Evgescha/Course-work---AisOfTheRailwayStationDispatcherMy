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
    public partial class Point : Form
    {
        public Point()
        {
            InitializeComponent();
        }

        private void Point_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.пункт_назначения". При необходимости она может быть перемещена или удалена.
            this.пункт_назначенияTableAdapter.Fill(this.dbDataSet.пункт_назначения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.районы". При необходимости она может быть перемещена или удалена.
            this.районыTableAdapter.Fill(this.dbDataSet.районы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.области". При необходимости она может быть перемещена или удалена.
            this.областиTableAdapter.Fill(this.dbDataSet.области);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 || dataGridView1.CurrentRow == null
                || dataGridView2.Rows.Count < 1 || dataGridView2.CurrentRow == null)
                MessageBox.Show("Не выбрана область или район");
            else
                try
                {
                    пункт_назначенияTableAdapter.Update(dbDataSet.пункт_назначения);
                    MessageBox.Show("Изменения сохранены");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Point_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
