using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cafeshka
{
    public partial class FormCafe : Form
    {
        public FormCafe()
        {
            InitializeComponent();
            setToolTip();
            всплывающиеПодсказкиToolStripMenuItem.Checked = toolTipCafe.Active;
        }

        private void setToolTip()
        {

            toolTipCafe.SetToolTip(radioButtonTia, "Хотите чайковского?");
            toolTipCafe.SetToolTip(radioButtonBubleTi, "Хотите китайского чайковского?");
            toolTipCafe.SetToolTip(radioButtonYougurt, "Хотите ЙООгурта?");
            toolTipCafe.SetToolTip(GroupBoxDrink, "Хотите Чего нибудь выпить?");
            toolTipCafe.SetToolTip(buttonOrder, "Сделать заказ!");
            toolTipCafe.SetToolTip(checkBoxShugar, "Добавить сахорку?");
            toolTipCafe.SetToolTip(comboBoxCyndy, "Конфетки желаете?");
            toolTipCafe.SetToolTip(numericUpDownKoocie, "Печенюхи будэ?");
            toolTipCafe.SetToolTip(textBoxZakaz, "Окно заказика-_-");

        }

        private void всплывающиеПодсказкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolTipCafe.Active = всплывающиеПодсказкиToolStripMenuItem.Checked;

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

            String orderInfo = "Напиток: ";
            if (radioButtonTia.Checked)
            {
                orderInfo += "Чай";
            }else if (radioButtonBubleTi.Checked)
            {
                orderInfo += "Бабл ти";
            }
            else if (radioButtonYougurt.Checked)
            {
                orderInfo += "Йогурт";
            }


            if (checkBoxShugar.Checked)
            {
                orderInfo += " с сахаром. ";
            }
            else
            {
                orderInfo += " без сахара. ";
            }

            orderInfo += Environment.NewLine;

            if (string.IsNullOrWhiteSpace(comboBoxCyndy.Text))
                orderInfo += "Вы не заказали конфету!";
            else
                orderInfo += "Конфета: " + comboBoxCyndy.Text + ".";

            orderInfo += Environment.NewLine;

            orderInfo += "Печенье: " +Math.Round( numericUpDownKoocie.Value) + ".";    


            textBoxZakaz.Text = orderInfo;
            

        }

    }
}
