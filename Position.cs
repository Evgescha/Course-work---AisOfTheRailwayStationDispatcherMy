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
    public partial class Position : Form
    {
        public Position()
        {
            InitializeComponent();
        }

        private void Position_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.dbDataSet.должности);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                должностиTableAdapter.Update(dbDataSet.должности);
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Position_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
