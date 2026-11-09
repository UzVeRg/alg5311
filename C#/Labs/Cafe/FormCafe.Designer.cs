
namespace Cafeshka
{
    partial class FormCafe
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всплывающиеПодсказкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxDrink = new System.Windows.Forms.GroupBox();
            this.radioButtonYougurt = new System.Windows.Forms.RadioButton();
            this.radioButtonBubleTi = new System.Windows.Forms.RadioButton();
            this.radioButtonTia = new System.Windows.Forms.RadioButton();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.checkBoxShugar = new System.Windows.Forms.CheckBox();
            this.comboBoxCyndy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownKoocie = new System.Windows.Forms.NumericUpDown();
            this.textBoxZakaz = new System.Windows.Forms.TextBox();
            this.toolTipCafe = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.GroupBoxDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoocie)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всплывающиеПодсказкиToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "&Справка";
            // 
            // всплывающиеПодсказкиToolStripMenuItem
            // 
            this.всплывающиеПодсказкиToolStripMenuItem.CheckOnClick = true;
            this.всплывающиеПодсказкиToolStripMenuItem.Name = "всплывающиеПодсказкиToolStripMenuItem";
            this.всплывающиеПодсказкиToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.всплывающиеПодсказкиToolStripMenuItem.Text = "&Всплывающие подсказки";
            this.всплывающиеПодсказкиToolStripMenuItem.Click += new System.EventHandler(this.всплывающиеПодсказкиToolStripMenuItem_Click);
            // 
            // GroupBoxDrink
            // 
            this.GroupBoxDrink.Controls.Add(this.radioButtonYougurt);
            this.GroupBoxDrink.Controls.Add(this.radioButtonBubleTi);
            this.GroupBoxDrink.Controls.Add(this.radioButtonTia);
            this.GroupBoxDrink.Location = new System.Drawing.Point(12, 27);
            this.GroupBoxDrink.Name = "GroupBoxDrink";
            this.GroupBoxDrink.Size = new System.Drawing.Size(208, 57);
            this.GroupBoxDrink.TabIndex = 1;
            this.GroupBoxDrink.TabStop = false;
            this.GroupBoxDrink.Text = "Напитки";
            this.toolTipCafe.SetToolTip(this.GroupBoxDrink, "Что будете пить?");
            // 
            // radioButtonYougurt
            // 
            this.radioButtonYougurt.AutoSize = true;
            this.radioButtonYougurt.Location = new System.Drawing.Point(128, 19);
            this.radioButtonYougurt.Name = "radioButtonYougurt";
            this.radioButtonYougurt.Size = new System.Drawing.Size(60, 17);
            this.radioButtonYougurt.TabIndex = 2;
            this.radioButtonYougurt.TabStop = true;
            this.radioButtonYougurt.Text = "Йогурт";
            this.toolTipCafe.SetToolTip(this.radioButtonYougurt, "Йогурта желаете?");
            this.radioButtonYougurt.UseVisualStyleBackColor = true;
            // 
            // radioButtonBubleTi
            // 
            this.radioButtonBubleTi.AutoSize = true;
            this.radioButtonBubleTi.Location = new System.Drawing.Point(58, 20);
            this.radioButtonBubleTi.Name = "radioButtonBubleTi";
            this.radioButtonBubleTi.Size = new System.Drawing.Size(64, 17);
            this.radioButtonBubleTi.TabIndex = 1;
            this.radioButtonBubleTi.TabStop = true;
            this.radioButtonBubleTi.Text = "Бабл-ти";
            this.toolTipCafe.SetToolTip(this.radioButtonBubleTi, "Китайского чайковского?");
            this.radioButtonBubleTi.UseVisualStyleBackColor = true;
            // 
            // radioButtonTia
            // 
            this.radioButtonTia.AutoSize = true;
            this.radioButtonTia.Location = new System.Drawing.Point(7, 20);
            this.radioButtonTia.Name = "radioButtonTia";
            this.radioButtonTia.Size = new System.Drawing.Size(45, 17);
            this.radioButtonTia.TabIndex = 0;
            this.radioButtonTia.TabStop = true;
            this.radioButtonTia.Text = "Чай";
            this.toolTipCafe.SetToolTip(this.radioButtonTia, "Чайковкого?");
            this.radioButtonTia.UseVisualStyleBackColor = true;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Image = global::Cafeshka.Properties.Resources.OrderButton;
            this.buttonOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrder.Location = new System.Drawing.Point(245, 38);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(102, 38);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // checkBoxShugar
            // 
            this.checkBoxShugar.AutoSize = true;
            this.checkBoxShugar.Location = new System.Drawing.Point(19, 91);
            this.checkBoxShugar.Name = "checkBoxShugar";
            this.checkBoxShugar.Size = new System.Drawing.Size(56, 17);
            this.checkBoxShugar.TabIndex = 3;
            this.checkBoxShugar.Text = "Cахар";
            this.checkBoxShugar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCyndy
            // 
            this.comboBoxCyndy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCyndy.FormattingEnabled = true;
            this.comboBoxCyndy.Items.AddRange(new object[] {
            "",
            "Коровка",
            "Птичье молоко",
            "Карамелька",
            "Фрутелка",
            "Сникерс",
            "Марс"});
            this.comboBoxCyndy.Location = new System.Drawing.Point(228, 91);
            this.comboBoxCyndy.Name = "comboBoxCyndy";
            this.comboBoxCyndy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCyndy.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Конфета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Печенье:";
            // 
            // numericUpDownKoocie
            // 
            this.numericUpDownKoocie.Location = new System.Drawing.Point(76, 124);
            this.numericUpDownKoocie.Name = "numericUpDownKoocie";
            this.numericUpDownKoocie.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownKoocie.TabIndex = 8;
            // 
            // textBoxZakaz
            // 
            this.textBoxZakaz.Location = new System.Drawing.Point(19, 169);
            this.textBoxZakaz.Multiline = true;
            this.textBoxZakaz.Name = "textBoxZakaz";
            this.textBoxZakaz.ReadOnly = true;
            this.textBoxZakaz.Size = new System.Drawing.Size(223, 76);
            this.textBoxZakaz.TabIndex = 9;
            // 
            // FormCafe
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxZakaz);
            this.Controls.Add(this.numericUpDownKoocie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCyndy);
            this.Controls.Add(this.checkBoxShugar);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.GroupBoxDrink);
            this.Controls.Add(this.menuStrip1);
            this.Icon = global::Cafeshka.Properties.Resources.FormCafeIcon;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCafe";
            this.Text = "Заказ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBoxDrink.ResumeLayout(false);
            this.GroupBoxDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoocie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всплывающиеПодсказкиToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBoxDrink;
        private System.Windows.Forms.RadioButton radioButtonTia;
        private System.Windows.Forms.RadioButton radioButtonYougurt;
        private System.Windows.Forms.RadioButton radioButtonBubleTi;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.CheckBox checkBoxShugar;
        private System.Windows.Forms.ComboBox comboBoxCyndy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownKoocie;
        private System.Windows.Forms.TextBox textBoxZakaz;
        private System.Windows.Forms.ToolTip toolTipCafe;
    }
}

