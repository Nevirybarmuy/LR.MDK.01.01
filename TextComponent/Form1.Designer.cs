namespace TextComponent
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
            this.components = new System.ComponentModel.Container();
            this.brokeText = new System.Windows.Forms.RichTextBox();
            this.NumberXX = new System.Windows.Forms.TextBox();
            this.NumberLable = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.Proverka = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // brokeText
            // 
            this.brokeText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.brokeText.Location = new System.Drawing.Point(-9, 231);
            this.brokeText.Name = "brokeText";
            this.brokeText.Size = new System.Drawing.Size(706, 127);
            this.brokeText.TabIndex = 0;
            this.brokeText.Text = "";
            // 
            // NumberXX
            // 
            this.NumberXX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberXX.Location = new System.Drawing.Point(383, 181);
            this.NumberXX.Name = "NumberXX";
            this.NumberXX.Size = new System.Drawing.Size(165, 29);
            this.NumberXX.TabIndex = 2;
            // 
            // NumberLable
            // 
            this.NumberLable.AutoSize = true;
            this.NumberLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLable.ForeColor = System.Drawing.Color.Lime;
            this.NumberLable.Location = new System.Drawing.Point(54, 181);
            this.NumberLable.Name = "NumberLable";
            this.NumberLable.Size = new System.Drawing.Size(323, 29);
            this.NumberLable.TabIndex = 3;
            this.NumberLable.Text = "Введите число от 1 до 100:";
            // 
            // Data
            // 
            this.Data.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data.Enabled = false;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Data.Location = new System.Drawing.Point(195, 100);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(305, 29);
            this.Data.TabIndex = 6;
            // 
            // Proverka
            // 
            this.Proverka.BackColor = System.Drawing.Color.GreenYellow;
            this.Proverka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Proverka.Location = new System.Drawing.Point(554, 181);
            this.Proverka.Name = "Proverka";
            this.Proverka.Size = new System.Drawing.Size(107, 29);
            this.Proverka.TabIndex = 7;
            this.Proverka.Text = "Проверка";
            this.Proverka.UseVisualStyleBackColor = false;
            this.Proverka.Click += new System.EventHandler(this.Proverka_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(690, 351);
            this.Controls.Add(this.Proverka);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.NumberLable);
            this.Controls.Add(this.NumberXX);
            this.Controls.Add(this.brokeText);
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox brokeText;
        private System.Windows.Forms.TextBox NumberXX;
        private System.Windows.Forms.Label NumberLable;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.Button Proverka;
        private System.Windows.Forms.Timer timer1;
    }
}

