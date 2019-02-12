namespace WindowsFormsApp3
{
    partial class Form1
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
            this.panelPol = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.labelPol = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFIO = new System.Windows.Forms.Panel();
            this.txtbxFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.panelDoB = new System.Windows.Forms.Panel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.labelDOB = new System.Windows.Forms.Label();
            this.panelPoB = new System.Windows.Forms.Panel();
            this.txtbxPoB = new System.Windows.Forms.TextBox();
            this.labelPoB = new System.Windows.Forms.Label();
            this.panelEdu = new System.Windows.Forms.Panel();
            this.chlbxEdu = new System.Windows.Forms.CheckedListBox();
            this.labelEdu = new System.Windows.Forms.Label();
            this.panelBrak = new System.Windows.Forms.Panel();
            this.cmbxMarriage = new System.Windows.Forms.ComboBox();
            this.labelBrak = new System.Windows.Forms.Label();
            this.panelBad = new System.Windows.Forms.Panel();
            this.chbxNoBad = new System.Windows.Forms.CheckBox();
            this.lbxBad = new System.Windows.Forms.ListBox();
            this.labelBad = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtxtbxInfo = new System.Windows.Forms.RichTextBox();
            this.panelPol.SuspendLayout();
            this.panelFIO.SuspendLayout();
            this.panelDoB.SuspendLayout();
            this.panelPoB.SuspendLayout();
            this.panelEdu.SuspendLayout();
            this.panelBrak.SuspendLayout();
            this.panelBad.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPol
            // 
            this.panelPol.Controls.Add(this.rbFemale);
            this.panelPol.Controls.Add(this.rbMale);
            this.panelPol.Controls.Add(this.labelPol);
            this.panelPol.Controls.Add(this.panel1);
            this.panelPol.Location = new System.Drawing.Point(12, 50);
            this.panelPol.Name = "panelPol";
            this.panelPol.Size = new System.Drawing.Size(220, 37);
            this.panelPol.TabIndex = 0;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(99, 17);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 17);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Женщина";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(7, 17);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(70, 17);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Мужчина";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(4, 4);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(27, 13);
            this.labelPol.TabIndex = 2;
            this.labelPol.Text = "Пол";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 100);
            this.panel1.TabIndex = 1;
            // 
            // panelFIO
            // 
            this.panelFIO.Controls.Add(this.txtbxFIO);
            this.panelFIO.Controls.Add(this.labelFIO);
            this.panelFIO.Location = new System.Drawing.Point(12, 3);
            this.panelFIO.Name = "panelFIO";
            this.panelFIO.Size = new System.Drawing.Size(220, 43);
            this.panelFIO.TabIndex = 1;
            // 
            // txtbxFIO
            // 
            this.txtbxFIO.Location = new System.Drawing.Point(3, 21);
            this.txtbxFIO.Name = "txtbxFIO";
            this.txtbxFIO.Size = new System.Drawing.Size(214, 20);
            this.txtbxFIO.TabIndex = 1;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(4, 4);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // panelDoB
            // 
            this.panelDoB.Controls.Add(this.dtpDOB);
            this.panelDoB.Controls.Add(this.labelDOB);
            this.panelDoB.Location = new System.Drawing.Point(12, 93);
            this.panelDoB.Name = "panelDoB";
            this.panelDoB.Size = new System.Drawing.Size(220, 51);
            this.panelDoB.TabIndex = 2;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(40, 26);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(147, 20);
            this.dtpDOB.TabIndex = 1;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(4, 10);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(86, 13);
            this.labelDOB.TabIndex = 0;
            this.labelDOB.Text = "Дата рождения";
            // 
            // panelPoB
            // 
            this.panelPoB.Controls.Add(this.txtbxPoB);
            this.panelPoB.Controls.Add(this.labelPoB);
            this.panelPoB.Location = new System.Drawing.Point(12, 149);
            this.panelPoB.Name = "panelPoB";
            this.panelPoB.Size = new System.Drawing.Size(220, 44);
            this.panelPoB.TabIndex = 3;
            // 
            // txtbxPoB
            // 
            this.txtbxPoB.Location = new System.Drawing.Point(3, 21);
            this.txtbxPoB.Name = "txtbxPoB";
            this.txtbxPoB.Size = new System.Drawing.Size(214, 20);
            this.txtbxPoB.TabIndex = 1;
            // 
            // labelPoB
            // 
            this.labelPoB.AutoSize = true;
            this.labelPoB.Location = new System.Drawing.Point(4, 5);
            this.labelPoB.Name = "labelPoB";
            this.labelPoB.Size = new System.Drawing.Size(92, 13);
            this.labelPoB.TabIndex = 0;
            this.labelPoB.Text = "Место рождения";
            // 
            // panelEdu
            // 
            this.panelEdu.Controls.Add(this.chlbxEdu);
            this.panelEdu.Controls.Add(this.labelEdu);
            this.panelEdu.Location = new System.Drawing.Point(12, 198);
            this.panelEdu.Name = "panelEdu";
            this.panelEdu.Size = new System.Drawing.Size(220, 90);
            this.panelEdu.TabIndex = 4;
            // 
            // chlbxEdu
            // 
            this.chlbxEdu.FormattingEnabled = true;
            this.chlbxEdu.Items.AddRange(new object[] {
            "начальное ",
            "основное общее (неполное)",
            "среднее общее",
            "среднее специальное",
            "незаконченное высшее",
            "высшее профессиональное",
            "нету"});
            this.chlbxEdu.Location = new System.Drawing.Point(3, 21);
            this.chlbxEdu.Name = "chlbxEdu";
            this.chlbxEdu.Size = new System.Drawing.Size(214, 64);
            this.chlbxEdu.TabIndex = 1;
            this.chlbxEdu.SelectedIndexChanged += new System.EventHandler(this.chlbxEdu_SelectedIndexChanged);
            // 
            // labelEdu
            // 
            this.labelEdu.AutoSize = true;
            this.labelEdu.Location = new System.Drawing.Point(4, 5);
            this.labelEdu.Name = "labelEdu";
            this.labelEdu.Size = new System.Drawing.Size(75, 13);
            this.labelEdu.TabIndex = 0;
            this.labelEdu.Text = "Образование";
            // 
            // panelBrak
            // 
            this.panelBrak.Controls.Add(this.cmbxMarriage);
            this.panelBrak.Controls.Add(this.labelBrak);
            this.panelBrak.Location = new System.Drawing.Point(12, 293);
            this.panelBrak.Name = "panelBrak";
            this.panelBrak.Size = new System.Drawing.Size(220, 53);
            this.panelBrak.TabIndex = 5;
            // 
            // cmbxMarriage
            // 
            this.cmbxMarriage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMarriage.FormattingEnabled = true;
            this.cmbxMarriage.Items.AddRange(new object[] {
            "Зарегистрированный брак",
            "Незарегистрированный брак",
            "Разведен(а)",
            "Разошелся(лась)",
            "Вдова, вдовец",
            "Не был женат/замужем"});
            this.cmbxMarriage.Location = new System.Drawing.Point(7, 21);
            this.cmbxMarriage.Name = "cmbxMarriage";
            this.cmbxMarriage.Size = new System.Drawing.Size(210, 21);
            this.cmbxMarriage.TabIndex = 1;
            this.cmbxMarriage.SelectedIndexChanged += new System.EventHandler(this.cmbxMarriage_SelectedIndexChanged);
            // 
            // labelBrak
            // 
            this.labelBrak.AutoSize = true;
            this.labelBrak.Location = new System.Drawing.Point(4, 4);
            this.labelBrak.Name = "labelBrak";
            this.labelBrak.Size = new System.Drawing.Size(103, 13);
            this.labelBrak.TabIndex = 0;
            this.labelBrak.Text = "Состояние в браке";
            // 
            // panelBad
            // 
            this.panelBad.Controls.Add(this.chbxNoBad);
            this.panelBad.Controls.Add(this.lbxBad);
            this.panelBad.Controls.Add(this.labelBad);
            this.panelBad.Location = new System.Drawing.Point(12, 352);
            this.panelBad.Name = "panelBad";
            this.panelBad.Size = new System.Drawing.Size(220, 134);
            this.panelBad.TabIndex = 6;
            // 
            // chbxNoBad
            // 
            this.chbxNoBad.AutoSize = true;
            this.chbxNoBad.Location = new System.Drawing.Point(3, 109);
            this.chbxNoBad.Name = "chbxNoBad";
            this.chbxNoBad.Size = new System.Drawing.Size(153, 17);
            this.chbxNoBad.TabIndex = 2;
            this.chbxNoBad.Text = "Не имею и горжусь этим";
            this.chbxNoBad.UseVisualStyleBackColor = true;
            this.chbxNoBad.CheckedChanged += new System.EventHandler(this.chbxNoBad_CheckedChanged);
            // 
            // lbxBad
            // 
            this.lbxBad.FormattingEnabled = true;
            this.lbxBad.Items.AddRange(new object[] {
            "Курение",
            "Алкоголизм",
            "Наркомания",
            "Токсикомания",
            "Грызение ногтей",
            "Уборка",
            "World of Tanks"});
            this.lbxBad.Location = new System.Drawing.Point(3, 20);
            this.lbxBad.Name = "lbxBad";
            this.lbxBad.Size = new System.Drawing.Size(214, 82);
            this.lbxBad.TabIndex = 1;
            this.lbxBad.SelectedIndexChanged += new System.EventHandler(this.lbxBad_SelectedIndexChanged);
            // 
            // labelBad
            // 
            this.labelBad.AutoSize = true;
            this.labelBad.Location = new System.Drawing.Point(7, 4);
            this.labelBad.Name = "labelBad";
            this.labelBad.Size = new System.Drawing.Size(104, 13);
            this.labelBad.TabIndex = 0;
            this.labelBad.Text = "Вредные привычки";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.btnExit);
            this.panelInfo.Controls.Add(this.btnClear);
            this.panelInfo.Controls.Add(this.btnOpen);
            this.panelInfo.Controls.Add(this.btnPrint);
            this.panelInfo.Controls.Add(this.btnSave);
            this.panelInfo.Controls.Add(this.rtxtbxInfo);
            this.panelInfo.Location = new System.Drawing.Point(239, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(483, 483);
            this.panelInfo.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(348, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить все поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(176, 386);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(131, 40);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(4, 435);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 40);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Вывести на экран";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtxtbxInfo
            // 
            this.rtxtbxInfo.Location = new System.Drawing.Point(4, 9);
            this.rtxtbxInfo.Name = "rtxtbxInfo";
            this.rtxtbxInfo.Size = new System.Drawing.Size(476, 371);
            this.rtxtbxInfo.TabIndex = 0;
            this.rtxtbxInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 498);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelBad);
            this.Controls.Add(this.panelBrak);
            this.Controls.Add(this.panelEdu);
            this.Controls.Add(this.panelPoB);
            this.Controls.Add(this.panelDoB);
            this.Controls.Add(this.panelFIO);
            this.Controls.Add(this.panelPol);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 5(анкета)";
            this.panelPol.ResumeLayout(false);
            this.panelPol.PerformLayout();
            this.panelFIO.ResumeLayout(false);
            this.panelFIO.PerformLayout();
            this.panelDoB.ResumeLayout(false);
            this.panelDoB.PerformLayout();
            this.panelPoB.ResumeLayout(false);
            this.panelPoB.PerformLayout();
            this.panelEdu.ResumeLayout(false);
            this.panelEdu.PerformLayout();
            this.panelBrak.ResumeLayout(false);
            this.panelBrak.PerformLayout();
            this.panelBad.ResumeLayout(false);
            this.panelBad.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPol;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFIO;
        private System.Windows.Forms.TextBox txtbxFIO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Panel panelDoB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Panel panelPoB;
        private System.Windows.Forms.TextBox txtbxPoB;
        private System.Windows.Forms.Label labelPoB;
        private System.Windows.Forms.Panel panelEdu;
        private System.Windows.Forms.CheckedListBox chlbxEdu;
        private System.Windows.Forms.Label labelEdu;
        private System.Windows.Forms.Panel panelBrak;
        private System.Windows.Forms.Label labelBrak;
        private System.Windows.Forms.Panel panelBad;
        private System.Windows.Forms.ListBox lbxBad;
        private System.Windows.Forms.Label labelBad;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtxtbxInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbxMarriage;
        private System.Windows.Forms.CheckBox chbxNoBad;
    }
}

