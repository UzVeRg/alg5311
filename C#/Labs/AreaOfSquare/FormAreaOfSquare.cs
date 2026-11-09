using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AreaOfSquare
{
    public partial class FormAreaOfSquare : Form
    {
        private string fileName = string.Empty;
        private bool isSaved = true;

        public FormAreaOfSquare()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(textBoxSide.Text, out a))
            {
                textBoxResult.Text = Calculator.calculate(a).ToString();
                errorProvider1.SetError(textBoxSide, string.Empty);
            }
            else
            {
                textBoxResult.Text = "Ошибка";
                errorProvider1.SetError(textBoxSide, "Число написано неправильно!");
            }
            /// активация элемента управления
            isSaved = false;
            textBoxSide.Select();

        }

        /// активация кнопки выхода
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void writerData()
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(fileName))
                {
                    streamWriter.WriteLine(textBoxSide.Text);
                    streamWriter.WriteLine(textBoxResult.Text);
                }
                isSaved = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка вывода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fileName) || sender == сохранитькакToolStripMenuItem)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы|*.txt";
                DialogResult dialogResult = saveFileDialog.ShowDialog();
                if (dialogResult != DialogResult.OK)
                    return;
                fileName = saveFileDialog.FileName;
            }

            writerData();
            textBoxSide.Select();
        }

        private void clearControls()
        {
            textBoxSide.Clear();
            textBoxResult.Clear();
            errorProvider1.Clear();
        }

        private void readData()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    textBoxSide.Text = streamReader.ReadLine();
                    textBoxResult.Text = streamReader.ReadLine();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            isSaved = true;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;
            fileName = openFileDialog.FileName;
            clearControls();
            readData();
            textBoxSide.Select();
        }

        private void FormAreaOfSquare_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved)
                return;

            DialogResult dialogResult = MessageBox.Show("Закрыть приложение?", "Данные не сохранены",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult dialogResult = MessageBox.Show("Удалить данные?", "Данные не сохранены",
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult != DialogResult.Yes)
                    return;
            }
            clearControls();
            fileName = string.Empty;
            isSaved = true;
            textBoxSide.Select();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Площадь квадрата", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
