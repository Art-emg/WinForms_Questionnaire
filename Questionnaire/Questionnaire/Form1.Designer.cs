namespace Questionnaire
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
            this.Q1panel = new System.Windows.Forms.Panel();
            this.Q1textBoxOtherColor = new System.Windows.Forms.TextBox();
            this.Q1radioButtonNoColor = new System.Windows.Forms.RadioButton();
            this.Q1radioButtonOtherColor = new System.Windows.Forms.RadioButton();
            this.Q1radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.Q1radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.Q1radioButtonRed = new System.Windows.Forms.RadioButton();
            this.Q1text = new System.Windows.Forms.Label();
            this.Q2panel = new System.Windows.Forms.Panel();
            this.Q2checkBoxNoAnswer = new System.Windows.Forms.CheckBox();
            this.Q2checkBoxOther = new System.Windows.Forms.CheckBox();
            this.Q2checkBoxEmotions = new System.Windows.Forms.CheckBox();
            this.Q2checkBoxNature = new System.Windows.Forms.CheckBox();
            this.Q2checkBoxHome = new System.Windows.Forms.CheckBox();
            this.Q2textBoxOther = new System.Windows.Forms.TextBox();
            this.Q2text = new System.Windows.Forms.Label();
            this.Q3panel = new System.Windows.Forms.Panel();
            this.FinishPanel = new System.Windows.Forms.Panel();
            this.SaveCSVbutton = new System.Windows.Forms.Button();
            this.FinishLabel = new System.Windows.Forms.Label();
            this.Q3checkBoxNum1 = new System.Windows.Forms.CheckBox();
            this.Q3checkBoxNum11 = new System.Windows.Forms.CheckBox();
            this.Q3checkBoxNum9 = new System.Windows.Forms.CheckBox();
            this.Q3checkBoxNum7 = new System.Windows.Forms.CheckBox();
            this.Q3checkBoxNum5 = new System.Windows.Forms.CheckBox();
            this.Q3checkBoxNum3 = new System.Windows.Forms.CheckBox();
            this.Q3text = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveCSVasButton = new System.Windows.Forms.Button();
            this.Q1panel.SuspendLayout();
            this.Q2panel.SuspendLayout();
            this.Q3panel.SuspendLayout();
            this.FinishPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Q1panel
            // 
            this.Q1panel.Controls.Add(this.Q1textBoxOtherColor);
            this.Q1panel.Controls.Add(this.Q1radioButtonNoColor);
            this.Q1panel.Controls.Add(this.Q1radioButtonOtherColor);
            this.Q1panel.Controls.Add(this.Q1radioButtonWhite);
            this.Q1panel.Controls.Add(this.Q1radioButtonBlack);
            this.Q1panel.Controls.Add(this.Q1radioButtonRed);
            this.Q1panel.Controls.Add(this.Q1text);
            this.Q1panel.Location = new System.Drawing.Point(71, 12);
            this.Q1panel.Name = "Q1panel";
            this.Q1panel.Size = new System.Drawing.Size(446, 293);
            this.Q1panel.TabIndex = 0;
            // 
            // Q1textBoxOtherColor
            // 
            this.Q1textBoxOtherColor.Location = new System.Drawing.Point(99, 131);
            this.Q1textBoxOtherColor.Name = "Q1textBoxOtherColor";
            this.Q1textBoxOtherColor.Size = new System.Drawing.Size(100, 20);
            this.Q1textBoxOtherColor.TabIndex = 6;
            // 
            // Q1radioButtonNoColor
            // 
            this.Q1radioButtonNoColor.AutoSize = true;
            this.Q1radioButtonNoColor.Location = new System.Drawing.Point(33, 155);
            this.Q1radioButtonNoColor.Name = "Q1radioButtonNoColor";
            this.Q1radioButtonNoColor.Size = new System.Drawing.Size(130, 17);
            this.Q1radioButtonNoColor.TabIndex = 5;
            this.Q1radioButtonNoColor.TabStop = true;
            this.Q1radioButtonNoColor.Text = "Нет любимого цвета";
            this.Q1radioButtonNoColor.UseVisualStyleBackColor = true;
            this.Q1radioButtonNoColor.CheckedChanged += new System.EventHandler(this.Q1radioButton_CheckedChanged);
            // 
            // Q1radioButtonOtherColor
            // 
            this.Q1radioButtonOtherColor.AutoSize = true;
            this.Q1radioButtonOtherColor.Location = new System.Drawing.Point(33, 131);
            this.Q1radioButtonOtherColor.Name = "Q1radioButtonOtherColor";
            this.Q1radioButtonOtherColor.Size = new System.Drawing.Size(65, 17);
            this.Q1radioButtonOtherColor.TabIndex = 4;
            this.Q1radioButtonOtherColor.TabStop = true;
            this.Q1radioButtonOtherColor.Text = "Другой:";
            this.Q1radioButtonOtherColor.UseVisualStyleBackColor = true;
            this.Q1radioButtonOtherColor.CheckedChanged += new System.EventHandler(this.Q1radioButton_CheckedChanged);
            // 
            // Q1radioButtonWhite
            // 
            this.Q1radioButtonWhite.AutoSize = true;
            this.Q1radioButtonWhite.Location = new System.Drawing.Point(33, 107);
            this.Q1radioButtonWhite.Name = "Q1radioButtonWhite";
            this.Q1radioButtonWhite.Size = new System.Drawing.Size(58, 17);
            this.Q1radioButtonWhite.TabIndex = 3;
            this.Q1radioButtonWhite.TabStop = true;
            this.Q1radioButtonWhite.Text = "Белый";
            this.Q1radioButtonWhite.UseVisualStyleBackColor = true;
            this.Q1radioButtonWhite.CheckedChanged += new System.EventHandler(this.Q1radioButton_CheckedChanged);
            // 
            // Q1radioButtonBlack
            // 
            this.Q1radioButtonBlack.AutoSize = true;
            this.Q1radioButtonBlack.Location = new System.Drawing.Point(33, 83);
            this.Q1radioButtonBlack.Name = "Q1radioButtonBlack";
            this.Q1radioButtonBlack.Size = new System.Drawing.Size(65, 17);
            this.Q1radioButtonBlack.TabIndex = 2;
            this.Q1radioButtonBlack.TabStop = true;
            this.Q1radioButtonBlack.Text = "Черный";
            this.Q1radioButtonBlack.UseVisualStyleBackColor = true;
            this.Q1radioButtonBlack.CheckedChanged += new System.EventHandler(this.Q1radioButton_CheckedChanged);
            // 
            // Q1radioButtonRed
            // 
            this.Q1radioButtonRed.AutoSize = true;
            this.Q1radioButtonRed.Location = new System.Drawing.Point(33, 59);
            this.Q1radioButtonRed.Name = "Q1radioButtonRed";
            this.Q1radioButtonRed.Size = new System.Drawing.Size(70, 17);
            this.Q1radioButtonRed.TabIndex = 1;
            this.Q1radioButtonRed.TabStop = true;
            this.Q1radioButtonRed.Text = "Красный";
            this.Q1radioButtonRed.UseVisualStyleBackColor = true;
            this.Q1radioButtonRed.CheckedChanged += new System.EventHandler(this.Q1radioButton_CheckedChanged);
            // 
            // Q1text
            // 
            this.Q1text.AutoSize = true;
            this.Q1text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Q1text.Location = new System.Drawing.Point(30, 30);
            this.Q1text.Name = "Q1text";
            this.Q1text.Size = new System.Drawing.Size(134, 13);
            this.Q1text.TabIndex = 0;
            this.Q1text.Text = "[Q1] Ваш любимый цвет?";
            // 
            // Q2panel
            // 
            this.Q2panel.Controls.Add(this.Q2checkBoxNoAnswer);
            this.Q2panel.Controls.Add(this.Q2checkBoxOther);
            this.Q2panel.Controls.Add(this.Q2checkBoxEmotions);
            this.Q2panel.Controls.Add(this.Q2checkBoxNature);
            this.Q2panel.Controls.Add(this.Q2checkBoxHome);
            this.Q2panel.Controls.Add(this.Q2textBoxOther);
            this.Q2panel.Controls.Add(this.Q2text);
            this.Q2panel.Location = new System.Drawing.Point(71, 12);
            this.Q2panel.Name = "Q2panel";
            this.Q2panel.Size = new System.Drawing.Size(446, 293);
            this.Q2panel.TabIndex = 7;
            // 
            // Q2checkBoxNoAnswer
            // 
            this.Q2checkBoxNoAnswer.AutoSize = true;
            this.Q2checkBoxNoAnswer.Location = new System.Drawing.Point(33, 155);
            this.Q2checkBoxNoAnswer.Name = "Q2checkBoxNoAnswer";
            this.Q2checkBoxNoAnswer.Size = new System.Drawing.Size(141, 17);
            this.Q2checkBoxNoAnswer.TabIndex = 11;
            this.Q2checkBoxNoAnswer.Text = "Затрудняюсь ответить";
            this.Q2checkBoxNoAnswer.UseVisualStyleBackColor = true;
            this.Q2checkBoxNoAnswer.CheckedChanged += new System.EventHandler(this.Q2checkBoxNoAnswer_CheckedChanged);
            // 
            // Q2checkBoxOther
            // 
            this.Q2checkBoxOther.AutoSize = true;
            this.Q2checkBoxOther.Location = new System.Drawing.Point(33, 131);
            this.Q2checkBoxOther.Name = "Q2checkBoxOther";
            this.Q2checkBoxOther.Size = new System.Drawing.Size(66, 17);
            this.Q2checkBoxOther.TabIndex = 10;
            this.Q2checkBoxOther.Text = "Другое:";
            this.Q2checkBoxOther.UseVisualStyleBackColor = true;
            this.Q2checkBoxOther.CheckedChanged += new System.EventHandler(this.Q2checkBox_CheckedChanged);
            // 
            // Q2checkBoxEmotions
            // 
            this.Q2checkBoxEmotions.AutoSize = true;
            this.Q2checkBoxEmotions.Location = new System.Drawing.Point(33, 107);
            this.Q2checkBoxEmotions.Name = "Q2checkBoxEmotions";
            this.Q2checkBoxEmotions.Size = new System.Drawing.Size(88, 17);
            this.Q2checkBoxEmotions.TabIndex = 9;
            this.Q2checkBoxEmotions.Text = "С эмоциями";
            this.Q2checkBoxEmotions.UseVisualStyleBackColor = true;
            this.Q2checkBoxEmotions.CheckedChanged += new System.EventHandler(this.Q2checkBox_CheckedChanged);
            // 
            // Q2checkBoxNature
            // 
            this.Q2checkBoxNature.AutoSize = true;
            this.Q2checkBoxNature.Location = new System.Drawing.Point(33, 83);
            this.Q2checkBoxNature.Name = "Q2checkBoxNature";
            this.Q2checkBoxNature.Size = new System.Drawing.Size(84, 17);
            this.Q2checkBoxNature.TabIndex = 8;
            this.Q2checkBoxNature.Text = "С природой";
            this.Q2checkBoxNature.UseVisualStyleBackColor = true;
            this.Q2checkBoxNature.CheckedChanged += new System.EventHandler(this.Q2checkBox_CheckedChanged);
            // 
            // Q2checkBoxHome
            // 
            this.Q2checkBoxHome.AutoSize = true;
            this.Q2checkBoxHome.Location = new System.Drawing.Point(33, 59);
            this.Q2checkBoxHome.Name = "Q2checkBoxHome";
            this.Q2checkBoxHome.Size = new System.Drawing.Size(70, 17);
            this.Q2checkBoxHome.TabIndex = 7;
            this.Q2checkBoxHome.Text = "С домом";
            this.Q2checkBoxHome.UseVisualStyleBackColor = true;
            this.Q2checkBoxHome.CheckedChanged += new System.EventHandler(this.Q2checkBox_CheckedChanged);
            // 
            // Q2textBoxOther
            // 
            this.Q2textBoxOther.Location = new System.Drawing.Point(99, 131);
            this.Q2textBoxOther.Name = "Q2textBoxOther";
            this.Q2textBoxOther.Size = new System.Drawing.Size(100, 20);
            this.Q2textBoxOther.TabIndex = 6;
            // 
            // Q2text
            // 
            this.Q2text.AutoSize = true;
            this.Q2text.Location = new System.Drawing.Point(30, 30);
            this.Q2text.Name = "Q2text";
            this.Q2text.Size = new System.Drawing.Size(251, 13);
            this.Q2text.TabIndex = 0;
            this.Q2text.Text = "[Q2] С чем Вы связываете свой любимый цвет?";
            // 
            // Q3panel
            // 
            this.Q3panel.Controls.Add(this.FinishPanel);
            this.Q3panel.Controls.Add(this.Q3checkBoxNum1);
            this.Q3panel.Controls.Add(this.Q3checkBoxNum11);
            this.Q3panel.Controls.Add(this.Q3checkBoxNum9);
            this.Q3panel.Controls.Add(this.Q3checkBoxNum7);
            this.Q3panel.Controls.Add(this.Q3checkBoxNum5);
            this.Q3panel.Controls.Add(this.Q3checkBoxNum3);
            this.Q3panel.Controls.Add(this.Q3text);
            this.Q3panel.Location = new System.Drawing.Point(71, 12);
            this.Q3panel.Name = "Q3panel";
            this.Q3panel.Size = new System.Drawing.Size(446, 293);
            this.Q3panel.TabIndex = 7;
            // 
            // FinishPanel
            // 
            this.FinishPanel.Controls.Add(this.SaveCSVasButton);
            this.FinishPanel.Controls.Add(this.SaveCSVbutton);
            this.FinishPanel.Controls.Add(this.FinishLabel);
            this.FinishPanel.Location = new System.Drawing.Point(0, 0);
            this.FinishPanel.Name = "FinishPanel";
            this.FinishPanel.Size = new System.Drawing.Size(446, 293);
            this.FinishPanel.TabIndex = 12;
            // 
            // SaveCSVbutton
            // 
            this.SaveCSVbutton.Location = new System.Drawing.Point(26, 54);
            this.SaveCSVbutton.Name = "SaveCSVbutton";
            this.SaveCSVbutton.Size = new System.Drawing.Size(111, 23);
            this.SaveCSVbutton.TabIndex = 1;
            this.SaveCSVbutton.Text = "сохранить .csv";
            this.SaveCSVbutton.UseVisualStyleBackColor = true;
            this.SaveCSVbutton.Click += new System.EventHandler(this.SaveCSVbutton_Click);
            // 
            // FinishLabel
            // 
            this.FinishLabel.AutoSize = true;
            this.FinishLabel.Location = new System.Drawing.Point(23, 29);
            this.FinishLabel.Name = "FinishLabel";
            this.FinishLabel.Size = new System.Drawing.Size(79, 13);
            this.FinishLabel.TabIndex = 0;
            this.FinishLabel.Text = "Тест пройден!";
            // 
            // Q3checkBoxNum1
            // 
            this.Q3checkBoxNum1.AutoSize = true;
            this.Q3checkBoxNum1.Location = new System.Drawing.Point(33, 178);
            this.Q3checkBoxNum1.Name = "Q3checkBoxNum1";
            this.Q3checkBoxNum1.Size = new System.Drawing.Size(32, 17);
            this.Q3checkBoxNum1.TabIndex = 11;
            this.Q3checkBoxNum1.Text = "1";
            this.Q3checkBoxNum1.UseVisualStyleBackColor = true;
            this.Q3checkBoxNum1.CheckedChanged += new System.EventHandler(this.Q3checkBox_CheckedChanged);
            // 
            // Q3checkBoxNum11
            // 
            this.Q3checkBoxNum11.AutoSize = true;
            this.Q3checkBoxNum11.Location = new System.Drawing.Point(33, 155);
            this.Q3checkBoxNum11.Name = "Q3checkBoxNum11";
            this.Q3checkBoxNum11.Size = new System.Drawing.Size(38, 17);
            this.Q3checkBoxNum11.TabIndex = 11;
            this.Q3checkBoxNum11.Text = "11";
            this.Q3checkBoxNum11.UseVisualStyleBackColor = true;
            this.Q3checkBoxNum11.CheckedChanged += new System.EventHandler(this.Q3checkBox_CheckedChanged);
            // 
            // Q3checkBoxNum9
            // 
            this.Q3checkBoxNum9.AutoSize = true;
            this.Q3checkBoxNum9.Location = new System.Drawing.Point(33, 131);
            this.Q3checkBoxNum9.Name = "Q3checkBoxNum9";
            this.Q3checkBoxNum9.Size = new System.Drawing.Size(32, 17);
            this.Q3checkBoxNum9.TabIndex = 10;
            this.Q3checkBoxNum9.Text = "9";
            this.Q3checkBoxNum9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Q3checkBoxNum9.UseVisualStyleBackColor = true;
            this.Q3checkBoxNum9.CheckedChanged += new System.EventHandler(this.Q3checkBox_CheckedChanged);
            // 
            // Q3checkBoxNum7
            // 
            this.Q3checkBoxNum7.AutoSize = true;
            this.Q3checkBoxNum7.Location = new System.Drawing.Point(33, 107);
            this.Q3checkBoxNum7.Name = "Q3checkBoxNum7";
            this.Q3checkBoxNum7.Size = new System.Drawing.Size(32, 17);
            this.Q3checkBoxNum7.TabIndex = 9;
            this.Q3checkBoxNum7.Text = "7";
            this.Q3checkBoxNum7.UseVisualStyleBackColor = true;
            this.Q3checkBoxNum7.CheckedChanged += new System.EventHandler(this.Q3checkBox_CheckedChanged);
            // 
            // Q3checkBoxNum5
            // 
            this.Q3checkBoxNum5.AutoSize = true;
            this.Q3checkBoxNum5.Location = new System.Drawing.Point(33, 83);
            this.Q3checkBoxNum5.Name = "Q3checkBoxNum5";
            this.Q3checkBoxNum5.Size = new System.Drawing.Size(32, 17);
            this.Q3checkBoxNum5.TabIndex = 8;
            this.Q3checkBoxNum5.Text = "5";
            this.Q3checkBoxNum5.UseVisualStyleBackColor = true;
            this.Q3checkBoxNum5.CheckedChanged += new System.EventHandler(this.Q3checkBox_CheckedChanged);
            // 
            // Q3checkBoxNum3
            // 
            this.Q3checkBoxNum3.AutoSize = true;
            this.Q3checkBoxNum3.Location = new System.Drawing.Point(33, 59);
            this.Q3checkBoxNum3.Name = "Q3checkBoxNum3";
            this.Q3checkBoxNum3.Size = new System.Drawing.Size(32, 17);
            this.Q3checkBoxNum3.TabIndex = 7;
            this.Q3checkBoxNum3.Text = "3";
            this.Q3checkBoxNum3.UseVisualStyleBackColor = true;
            this.Q3checkBoxNum3.CheckedChanged += new System.EventHandler(this.Q3checkBox_CheckedChanged);
            // 
            // Q3text
            // 
            this.Q3text.AutoSize = true;
            this.Q3text.Location = new System.Drawing.Point(30, 30);
            this.Q3text.Name = "Q3text";
            this.Q3text.Size = new System.Drawing.Size(285, 13);
            this.Q3text.TabIndex = 0;
            this.Q3text.Text = "[Q3] Назовити ваши любимые числа среди названных.";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(170, 150);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(250, 74);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(212, 340);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(93, 23);
            this.previousButton.TabIndex = 9;
            this.previousButton.Text = "Предыдущий";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(311, 340);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(93, 23);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "Следующий";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SaveCSVasButton
            // 
            this.SaveCSVasButton.Location = new System.Drawing.Point(143, 53);
            this.SaveCSVasButton.Name = "SaveCSVasButton";
            this.SaveCSVasButton.Size = new System.Drawing.Size(117, 23);
            this.SaveCSVasButton.TabIndex = 2;
            this.SaveCSVasButton.Text = "сохранить .csv в ...";
            this.SaveCSVasButton.UseVisualStyleBackColor = true;
            this.SaveCSVasButton.Click += new System.EventHandler(this.SaveCSVasButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.Q3panel);
            this.Controls.Add(this.Q2panel);
            this.Controls.Add(this.Q1panel);
            this.MaximumSize = new System.Drawing.Size(600, 420);
            this.MinimumSize = new System.Drawing.Size(600, 420);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Q1panel.ResumeLayout(false);
            this.Q1panel.PerformLayout();
            this.Q2panel.ResumeLayout(false);
            this.Q2panel.PerformLayout();
            this.Q3panel.ResumeLayout(false);
            this.Q3panel.PerformLayout();
            this.FinishPanel.ResumeLayout(false);
            this.FinishPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Q1panel;
        private System.Windows.Forms.RadioButton Q1radioButtonNoColor;
        private System.Windows.Forms.RadioButton Q1radioButtonOtherColor;
        private System.Windows.Forms.RadioButton Q1radioButtonWhite;
        private System.Windows.Forms.RadioButton Q1radioButtonBlack;
        private System.Windows.Forms.RadioButton Q1radioButtonRed;
        private System.Windows.Forms.Label Q1text;
        private System.Windows.Forms.TextBox Q1textBoxOtherColor;
        private System.Windows.Forms.Panel Q2panel;
        private System.Windows.Forms.CheckBox Q2checkBoxNoAnswer;
        private System.Windows.Forms.CheckBox Q2checkBoxOther;
        private System.Windows.Forms.CheckBox Q2checkBoxEmotions;
        private System.Windows.Forms.CheckBox Q2checkBoxNature;
        private System.Windows.Forms.CheckBox Q2checkBoxHome;
        private System.Windows.Forms.TextBox Q2textBoxOther;
        private System.Windows.Forms.Label Q2text;
        private System.Windows.Forms.Panel Q3panel;
        private System.Windows.Forms.CheckBox Q3checkBoxNum1;
        private System.Windows.Forms.CheckBox Q3checkBoxNum11;
        private System.Windows.Forms.CheckBox Q3checkBoxNum9;
        private System.Windows.Forms.CheckBox Q3checkBoxNum7;
        private System.Windows.Forms.CheckBox Q3checkBoxNum5;
        private System.Windows.Forms.CheckBox Q3checkBoxNum3;
        private System.Windows.Forms.Label Q3text;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel FinishPanel;
        private System.Windows.Forms.Button SaveCSVbutton;
        private System.Windows.Forms.Label FinishLabel;
        private System.Windows.Forms.Button SaveCSVasButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

