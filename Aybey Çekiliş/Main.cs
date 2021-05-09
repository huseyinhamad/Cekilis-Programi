using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aybey_Çekiliş
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text)) {
                if (!listBoxNames.Items.Contains(textBoxName.Text))
                    listBoxNames.Items.Add(textBoxName.Text);
                else
                    MessageBox.Show("Eklemek istediğiniz isim listede bulunmaktadır. Lütfen Başka bir isim giriniz.", "Hata");

            }
            else
            {
                MessageBox.Show("Lütfen bir isim giriniz.", "Hata");
            }
            textBoxName.Clear();
        }

        private void listBoxNames_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxNames.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Kişiyi Silmek İstediğinizden Emin Misiniz?", "Katılımcı Silme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    listBoxNames.Items.Remove(listBoxNames.SelectedItem);
            }
        }

        private void buttonGiveAway_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxGiveAway.Text)){
                if ((int)numericUpDownHowMany.Value > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Çekilişi Gerçekleştirmek İstediğinize Emin Misiniz?", "Çekiliş", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Random _random = new Random();
                        labelGz.Visible = true;
                        dataGridViewGiveAwayResults.Visible = true;
                        for (int i = 0; i < (int)numericUpDownHowMany.Value; i++)
                        {
                            dataGridViewGiveAwayResults.Rows.Add();
                            for (int j = 0; j < dataGridViewGiveAwayResults.Rows.Count; j++)
                            {
                                if (string.IsNullOrEmpty((string)dataGridViewGiveAwayResults.Rows[j].Cells[0].Value))
                                {
                                    int randomNumber = _random.Next(0, listBoxNames.Items.Count);
                                    dataGridViewGiveAwayResults.Rows[j].Cells[0].Value = listBoxNames.Items[randomNumber];
                                    dataGridViewGiveAwayResults.Rows[j].Cells[1].Value = textBoxGiveAway.Text;
                                    listBoxNames.Items.RemoveAt(randomNumber); 
                                }
                            }
                        }
                        textBoxGiveAway.Clear();
                        numericUpDownHowMany.Value = 0;
                        buttonClearGiveAway.Visible = true;
                        buttonSaveGiveAway.Visible = true;
                    }
                }
                else
                    MessageBox.Show("Çekilecek Kişi Sayısı 0'dan büyük olmalıdır.", "Hata");
            }
            else
                MessageBox.Show("Çekiliş Öğesi Boş Girilemez.", "Hata");
        }

        private void numericUpDownHowMany_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDownHowMany.Value > listBoxNames.Items.Count)
            {
                MessageBox.Show("Çekilecek Kişi Sayısı Katılımcı Sayısından Fazla Olamaz.", "Hata");
                numericUpDownHowMany.Value = listBoxNames.Items.Count;
            }
        }

        private void buttonClearAttendance_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bütün Katılımcıları Silmek İstediğinizden Emin Misiniz?", "Katılımcı Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listBoxNames.Items.Clear();
                numericUpDownHowMany.Value = 0;
            }
        }

        private void buttonClearGiveAway_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çekiliş Sonucunu Silmek İstediğinizden Emin Misiniz?", "Çekiliş Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridViewGiveAwayResults.Rows.Clear();
                dataGridViewGiveAwayResults.Visible = false;
                labelGz.Visible = false;
                buttonClearGiveAway.Visible = false;
                buttonSaveGiveAway.Visible = false;
            }
        }

        private void buttonSaveGiveAway_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çekiliş Sonuçlarını Kaydetmek İstediğinizden Emin Misiniz?", "Çekiliş Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridViewGiveAwayResults.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dataGridViewGiveAwayResults.Columns.Count + 1; i++)
                    {
                        xcelApp.Cells[1, i] = dataGridViewGiveAwayResults.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridViewGiveAwayResults.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewGiveAwayResults.Columns.Count; j++)
                        {
                            xcelApp.Cells[i + 2, j + 1] = dataGridViewGiveAwayResults.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
                }
            }
        }
    }
}
