namespace clicktime
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.vrema = new System.Windows.Forms.Label();
            this.tiks = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.rest = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.click = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.start.Location = new System.Drawing.Point(100, 97);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(182, 66);
            this.start.TabIndex = 0;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // vrema
            // 
            this.vrema.AutoSize = true;
            this.vrema.BackColor = System.Drawing.SystemColors.Control;
            this.vrema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.vrema.Location = new System.Drawing.Point(318, 9);
            this.vrema.Name = "vrema";
            this.vrema.Size = new System.Drawing.Size(23, 25);
            this.vrema.TabIndex = 1;
            this.vrema.Text = "0";
            // 
            // tiks
            // 
            this.tiks.AutoSize = true;
            this.tiks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tiks.Location = new System.Drawing.Point(238, 9);
            this.tiks.Name = "tiks";
            this.tiks.Size = new System.Drawing.Size(74, 25);
            this.tiks.TabIndex = 2;
            this.tiks.Text = "Время";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.text1.Location = new System.Drawing.Point(126, 221);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(137, 17);
            this.text1.TabIndex = 4;
            this.text1.Text = "Выделить времени:";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.text2.Location = new System.Drawing.Point(316, 218);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(56, 18);
            this.text2.TabIndex = 5;
            this.text2.Text = "секунд";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(269, 220);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(43, 20);
            this.number.TabIndex = 6;
            this.number.Text = "0";
            // 
            // rest
            // 
            this.rest.Location = new System.Drawing.Point(12, 194);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(103, 42);
            this.rest.TabIndex = 7;
            this.rest.Text = "Перезагрузка";
            this.rest.UseVisualStyleBackColor = true;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.error.Location = new System.Drawing.Point(9, 63);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(364, 18);
            this.error.TabIndex = 8;
            this.error.Text = "Внимание, ошибка 246, не выбрано время таймера";
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.point.Location = new System.Drawing.Point(169, 41);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(42, 46);
            this.point.TabIndex = 9;
            this.point.Text = "0";
            // 
            // click
            // 
            this.click.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.click.Location = new System.Drawing.Point(100, 122);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(182, 66);
            this.click.TabIndex = 10;
            this.click.Text = "Тыкай";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.end.Location = new System.Drawing.Point(7, 56);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(167, 25);
            this.end.TabIndex = 11;
            this.end.Text = "последний счет:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 251);
            this.Controls.Add(this.end);
            this.Controls.Add(this.click);
            this.Controls.Add(this.point);
            this.Controls.Add(this.error);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.number);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.tiks);
            this.Controls.Add(this.vrema);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Скорость клика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label vrema;
        private System.Windows.Forms.Label tiks;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Label end;
    }
}

