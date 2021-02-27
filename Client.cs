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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.пассажир". При необходимости она может быть перемещена или удалена.
            this.пассажирTableAdapter.Fill(this.dbDataSet.пассажир);

        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                пассажирTableAdapter.Update(dbDataSet.пассажир);
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
