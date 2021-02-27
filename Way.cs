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
    public partial class Way : Form
    {
        public Way()
        {
            InitializeComponent();
        }

        private void Way_Load(object sender, EventArgs e)
        {
            fillGrid();

        }
        private void fillGrid() {
            this.пункт_назначенияTableAdapter.Fill(this.dbDataSet.пункт_назначения);
            this.районыTableAdapter.Fill(this.dbDataSet.районы);
            this.областиTableAdapter.Fill(this.dbDataSet.области);
            this.поездTableAdapter.Fill(this.dbDataSet.поезд);
            this.пункты_маршрутаTableAdapter.Fill(this.dbDataSet.пункты_маршрута);
            this.маршрутTableAdapter.Fill(this.dbDataSet.маршрут);
            this.районыTableAdapter.Fill(this.dbDataSet.районы);
            this.областиTableAdapter.Fill(this.dbDataSet.области);
            fixName();
        }
        private void textBox_OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsLetter(number)) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }


        private void fixName()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.SelectedItem = comboBox1.Items[
                                                           поездBindingSource.Find(
                                                                       "Код",
                                                                       int.Parse(dataGridView1[4, i].Value.ToString())
                                                                       )
                                                           ];
                dataGridView1[5, i].Value = comboBox1.Text;
            }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                comboBox5.SelectedItem = comboBox5.Items[
                                                           пунктНазначенияBindingSource.Find(
                                                                       "Код",
                                                                       int.Parse(dataGridView2[2, i].Value.ToString())
                                                                       )
                                                           ];
                dataGridView2[4, i].Value = comboBox5.Text;
            }
        }



        private void Way_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

           private bool isFill()
        {
            if (textBox1.Text.Length < 1 || comboBox1.Items.Count < 1)
            {
                MessageBox.Show("Не все поля заполнены!");
                return false;
            }
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    DataRowView row = (DataRowView)маршрутBindingSource.AddNew();

                    row[1] = textBox1.Text;
                    row[2] = dateTimePicker1.Value;
                    row[3] = dateTimePicker2.Value;
                    row[4] = comboBox1.SelectedValue;

                    маршрутBindingSource.EndEdit();
                    this.маршрутTableAdapter.Update(dbDataSet);
                    clearFields();
                    MessageBox.Show("Сохранено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            fillGrid();
        }
        //edit
        private void button2_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                    dataGridView1.CurrentRow.Cells[4].Value = comboBox1.SelectedValue;
                    dataGridView1.CurrentRow.Cells[5].Value = comboBox1.Text;
                    маршрутBindingSource.EndEdit();
                    this.маршрутTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);

                    clearFields();
                    MessageBox.Show("Сохранено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            fillGrid();
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                try
                {
                    dbDataSet.AcceptChanges();
                    маршрутBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    маршрутBindingSource.EndEdit();
                    маршрутTableAdapter.Update(dbDataSet.маршрут);
                    MessageBox.Show("Удалено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                fillGrid();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                fixName();
            }
        }
        /// //////////////////////////////////////////////////////
        // нижедля пунктов маршрута
        private bool isFill2()
        {
            if (textBox2.Text.Length < 1 || comboBox4.Items.Count < 1 || dataGridView1.CurrentRow == null || dataGridView1.RowCount<1)
            {
                MessageBox.Show("Не выбраны или не заполнены все поля!");
                return false;
            }
            return true;
        }
        private void clearFields2()
        {
            textBox2.Text = "";
        }
        //add
        private void button4_Click(object sender, EventArgs e)
        {
            if (isFill2())
                try
                {
                    DataRowView row = (DataRowView)пунктыМаршрутаibfk1BindingSource.AddNew();

                    row[1] = dataGridView1.CurrentRow.Cells[0].Value;
                    row[2] = comboBox4.SelectedValue;
                    row[3] = textBox2.Text;

                    пунктыМаршрутаibfk1BindingSource.EndEdit();
                    this.пункты_маршрутаTableAdapter.Update(dbDataSet);
                    clearFields();
                    MessageBox.Show("Сохранено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            fillGrid();
        }
        //edit
        private void button5_Click(object sender, EventArgs e)
        {
            if (isFill2())
                try
                {
                    dataGridView2.CurrentRow.Cells[2].Value = comboBox4.SelectedValue;
                    dataGridView2.CurrentRow.Cells[3].Value = textBox2.Text;
                    пунктыМаршрутаibfk1BindingSource.EndEdit();
                    this.пункты_маршрутаTableAdapter.Update(((DataRowView)dataGridView2.CurrentRow.DataBoundItem).Row);

                    clearFields();
                    MessageBox.Show("Сохранено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            fillGrid();
        }

        //delete
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0 && dataGridView2.CurrentRow != null)
            {
                try
                {
                    dbDataSet.AcceptChanges();
                    пунктыМаршрутаibfk1BindingSource.RemoveAt(dataGridView2.CurrentRow.Index);
                    пунктыМаршрутаibfk1BindingSource.EndEdit();
                    пункты_маршрутаTableAdapter.Update(dbDataSet.пункты_маршрута);
                    MessageBox.Show("Удалено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                fillGrid();
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0 && dataGridView2.CurrentRow != null)
            {
                comboBox5.SelectedItem = comboBox5.Items[
                                                          пунктНазначенияBindingSource.Find(
                                                                      "Код",
                                                                      int.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString())
                                                                      )
                                                          ];
               comboBox4.Text = comboBox5.Text;
                textBox2.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
