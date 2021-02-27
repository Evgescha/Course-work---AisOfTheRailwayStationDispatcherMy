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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void Area_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.области". При необходимости она может быть перемещена или удалена.
            this.областиTableAdapter.Fill(this.dbDataSet.области);
        }

        private void Area_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                областиTableAdapter.Update(dbDataSet.области);
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
