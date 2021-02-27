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
    public partial class Region : Form
    {
        public Region()
        {
            InitializeComponent();
        }

        private void Region_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.районы". При необходимости она может быть перемещена или удалена.
            this.районыTableAdapter.Fill(this.dbDataSet.районы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.области". При необходимости она может быть перемещена или удалена.
            this.областиTableAdapter.Fill(this.dbDataSet.области);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count<1||dataGridView1.CurrentRow==null)
                MessageBox.Show("Не выбрана область");
            else
            try
            {
                районыTableAdapter.Update(dbDataSet.районы);
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Region_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
