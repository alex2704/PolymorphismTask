namespace Task2WInForm
{
    partial class MobileOperatorForm
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.minutecost_lbl = new System.Windows.Forms.Label();
            this.coverageArea_lbl = new System.Windows.Forms.Label();
            this.pay_lbl = new System.Windows.Forms.Label();
            this.Check_btn = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.minutecost_box = new System.Windows.Forms.TextBox();
            this.coverageArea_box = new System.Windows.Forms.TextBox();
            this.PayTrue_radio = new System.Windows.Forms.RadioButton();
            this.PayFalse_radio = new System.Windows.Forms.RadioButton();
            this.radio_class1 = new System.Windows.Forms.RadioButton();
            this.radio_class2 = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Choose_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(12, 22);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(147, 17);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Название оператора";
            // 
            // minutecost_lbl
            // 
            this.minutecost_lbl.AutoSize = true;
            this.minutecost_lbl.Location = new System.Drawing.Point(12, 67);
            this.minutecost_lbl.Name = "minutecost_lbl";
            this.minutecost_lbl.Size = new System.Drawing.Size(235, 17);
            this.minutecost_lbl.TabIndex = 1;
            this.minutecost_lbl.Text = "Стоимость 1-ой минуты разговора";
            // 
            // coverageArea_lbl
            // 
            this.coverageArea_lbl.AutoSize = true;
            this.coverageArea_lbl.Location = new System.Drawing.Point(12, 112);
            this.coverageArea_lbl.Name = "coverageArea_lbl";
            this.coverageArea_lbl.Size = new System.Drawing.Size(136, 17);
            this.coverageArea_lbl.TabIndex = 2;
            this.coverageArea_lbl.Text = "Площадь покрытия";
            // 
            // pay_lbl
            // 
            this.pay_lbl.AutoSize = true;
            this.pay_lbl.Location = new System.Drawing.Point(12, 161);
            this.pay_lbl.Name = "pay_lbl";
            this.pay_lbl.Size = new System.Drawing.Size(265, 17);
            this.pay_lbl.TabIndex = 3;
            this.pay_lbl.Text = "Наличие платы за каждое соединение";
            // 
            // Check_btn
            // 
            this.Check_btn.Location = new System.Drawing.Point(823, 323);
            this.Check_btn.Name = "Check_btn";
            this.Check_btn.Size = new System.Drawing.Size(294, 247);
            this.Check_btn.TabIndex = 4;
            this.Check_btn.Text = "Добавить и рассчитать";
            this.Check_btn.UseVisualStyleBackColor = true;
            this.Check_btn.Click += new System.EventHandler(this.Check_btn_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(269, 17);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(256, 22);
            this.name_box.TabIndex = 9;
            // 
            // minutecost_box
            // 
            this.minutecost_box.Location = new System.Drawing.Point(269, 67);
            this.minutecost_box.Name = "minutecost_box";
            this.minutecost_box.Size = new System.Drawing.Size(256, 22);
            this.minutecost_box.TabIndex = 10;
            this.minutecost_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // coverageArea_box
            // 
            this.coverageArea_box.Location = new System.Drawing.Point(269, 107);
            this.coverageArea_box.Name = "coverageArea_box";
            this.coverageArea_box.Size = new System.Drawing.Size(256, 22);
            this.coverageArea_box.TabIndex = 11;
            this.coverageArea_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // PayTrue_radio
            // 
            this.PayTrue_radio.AutoSize = true;
            this.PayTrue_radio.Location = new System.Drawing.Point(466, 161);
            this.PayTrue_radio.Name = "PayTrue_radio";
            this.PayTrue_radio.Size = new System.Drawing.Size(59, 21);
            this.PayTrue_radio.TabIndex = 13;
            this.PayTrue_radio.TabStop = true;
            this.PayTrue_radio.Text = "True";
            this.PayTrue_radio.UseVisualStyleBackColor = true;
            // 
            // PayFalse_radio
            // 
            this.PayFalse_radio.AutoSize = true;
            this.PayFalse_radio.Location = new System.Drawing.Point(346, 161);
            this.PayFalse_radio.Name = "PayFalse_radio";
            this.PayFalse_radio.Size = new System.Drawing.Size(63, 21);
            this.PayFalse_radio.TabIndex = 14;
            this.PayFalse_radio.TabStop = true;
            this.PayFalse_radio.Text = "False";
            this.PayFalse_radio.UseVisualStyleBackColor = true;
            // 
            // radio_class1
            // 
            this.radio_class1.AutoSize = true;
            this.radio_class1.Location = new System.Drawing.Point(51, 37);
            this.radio_class1.Name = "radio_class1";
            this.radio_class1.Size = new System.Drawing.Size(252, 21);
            this.radio_class1.TabIndex = 15;
            this.radio_class1.TabStop = true;
            this.radio_class1.Text = "Мобильный оператор 1-го уровня";
            this.radio_class1.UseVisualStyleBackColor = true;
            // 
            // radio_class2
            // 
            this.radio_class2.AutoSize = true;
            this.radio_class2.BackColor = System.Drawing.SystemColors.Control;
            this.radio_class2.Location = new System.Drawing.Point(51, 90);
            this.radio_class2.Name = "radio_class2";
            this.radio_class2.Size = new System.Drawing.Size(252, 21);
            this.radio_class2.TabIndex = 16;
            this.radio_class2.TabStop = true;
            this.radio_class2.Text = "Мобильный оператор 2-го уровня";
            this.radio_class2.UseVisualStyleBackColor = false;
            this.radio_class2.CheckedChanged += new System.EventHandler(this.Radio_class_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.radio_class1);
            this.groupBox.Controls.Add(this.radio_class2);
            this.groupBox.Location = new System.Drawing.Point(716, 6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(401, 166);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            // 
            // Choose_btn
            // 
            this.Choose_btn.Location = new System.Drawing.Point(805, 205);
            this.Choose_btn.Name = "Choose_btn";
            this.Choose_btn.Size = new System.Drawing.Size(312, 72);
            this.Choose_btn.TabIndex = 17;
            this.Choose_btn.Text = "CreateObject";
            this.Choose_btn.UseVisualStyleBackColor = true;
            this.Choose_btn.Click += new System.EventHandler(this.Choose_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Результат";
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(171, 255);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(286, 22);
            this.resBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 17;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(32, 323);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(767, 247);
            this.dataGridView.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название оператора";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Стоимость 1-ой минуты";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Площадь покрытия";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Наличие платы за каждое соединение";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Результат подсчета";
            this.Column5.Name = "Column5";
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(589, 240);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(178, 57);
            this.Clear_btn.TabIndex = 21;
            this.Clear_btn.Text = "Очистить список";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // MobileOperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 582);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Choose_btn);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.PayFalse_radio);
            this.Controls.Add(this.PayTrue_radio);
            this.Controls.Add(this.coverageArea_box);
            this.Controls.Add(this.minutecost_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.Check_btn);
            this.Controls.Add(this.pay_lbl);
            this.Controls.Add(this.coverageArea_lbl);
            this.Controls.Add(this.minutecost_lbl);
            this.Controls.Add(this.name_lbl);
            this.Name = "MobileOperatorForm";
            this.Text = "Оператор мобильной связи";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label minutecost_lbl;
        private System.Windows.Forms.Label coverageArea_lbl;
        private System.Windows.Forms.Label pay_lbl;
        private System.Windows.Forms.Button Check_btn;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox minutecost_box;
        private System.Windows.Forms.TextBox coverageArea_box;
        private System.Windows.Forms.RadioButton PayTrue_radio;
        private System.Windows.Forms.RadioButton PayFalse_radio;
        private System.Windows.Forms.RadioButton radio_class1;
        private System.Windows.Forms.RadioButton radio_class2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Choose_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Clear_btn;
    }
}

