using System;
using System.Windows.Forms;

namespace AisOfTheRailwayStationDispatcherMy
{
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
        }

        private void Train_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.поезд". При необходимости она может быть перемещена или удалена.
            this.поездTableAdapter.Fill(this.dbDataSet.поезд);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                поездTableAdapter.Update(dbDataSet.поезд);
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Train_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
