namespace hw_mullty_thread
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_display_num = new System.Windows.Forms.TextBox();
            this.b_stop_num = new System.Windows.Forms.Button();
            this.b_pause_num = new System.Windows.Forms.Button();
            this.b_gen_num = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_up_number = new System.Windows.Forms.TextBox();
            this.tb_bottom_number = new System.Windows.Forms.TextBox();
            this.tb_display_numFi = new System.Windows.Forms.TextBox();
            this.b_numFI_stop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.b_numFi_pause = new System.Windows.Forms.Button();
            this.b_numFi_gen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_display_num);
            this.splitContainer1.Panel1.Controls.Add(this.b_stop_num);
            this.splitContainer1.Panel1.Controls.Add(this.b_pause_num);
            this.splitContainer1.Panel1.Controls.Add(this.b_gen_num);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tb_up_number);
            this.splitContainer1.Panel1.Controls.Add(this.tb_bottom_number);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb_display_numFi);
            this.splitContainer1.Panel2.Controls.Add(this.b_numFI_stop);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.b_numFi_pause);
            this.splitContainer1.Panel2.Controls.Add(this.b_numFi_gen);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 0;
            // 
            // tb_display_num
            // 
            this.tb_display_num.Enabled = false;
            this.tb_display_num.Location = new System.Drawing.Point(42, 143);
            this.tb_display_num.Multiline = true;
            this.tb_display_num.Name = "tb_display_num";
            this.tb_display_num.Size = new System.Drawing.Size(239, 268);
            this.tb_display_num.TabIndex = 6;
            // 
            // b_stop_num
            // 
            this.b_stop_num.Location = new System.Drawing.Point(206, 84);
            this.b_stop_num.Name = "b_stop_num";
            this.b_stop_num.Size = new System.Drawing.Size(75, 23);
            this.b_stop_num.TabIndex = 5;
            this.b_stop_num.Text = "Завершить";
            this.b_stop_num.UseVisualStyleBackColor = true;
            this.b_stop_num.Click += new System.EventHandler(this.b_stop_num_Click);
            // 
            // b_pause_num
            // 
            this.b_pause_num.Location = new System.Drawing.Point(124, 83);
            this.b_pause_num.Name = "b_pause_num";
            this.b_pause_num.Size = new System.Drawing.Size(75, 23);
            this.b_pause_num.TabIndex = 4;
            this.b_pause_num.Text = "Остановка";
            this.b_pause_num.UseVisualStyleBackColor = true;
            this.b_pause_num.Click += new System.EventHandler(this.b_pause_num_Click);
            // 
            // b_gen_num
            // 
            this.b_gen_num.Location = new System.Drawing.Point(42, 84);
            this.b_gen_num.Name = "b_gen_num";
            this.b_gen_num.Size = new System.Drawing.Size(75, 23);
            this.b_gen_num.TabIndex = 3;
            this.b_gen_num.Text = "Генерация";
            this.b_gen_num.UseVisualStyleBackColor = true;
            this.b_gen_num.Click += new System.EventHandler(this.b_gen_num_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(109, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Простые числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Верхняя граница";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Нижняя граница";
            // 
            // tb_up_number
            // 
            this.tb_up_number.Location = new System.Drawing.Point(163, 47);
            this.tb_up_number.Name = "tb_up_number";
            this.tb_up_number.Size = new System.Drawing.Size(74, 20);
            this.tb_up_number.TabIndex = 0;
            this.tb_up_number.Text = "0";
            this.tb_up_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // tb_bottom_number
            // 
            this.tb_bottom_number.Location = new System.Drawing.Point(42, 47);
            this.tb_bottom_number.Name = "tb_bottom_number";
            this.tb_bottom_number.Size = new System.Drawing.Size(74, 20);
            this.tb_bottom_number.TabIndex = 0;
            this.tb_bottom_number.Text = "0";
            this.tb_bottom_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // tb_display_numFi
            // 
            this.tb_display_numFi.Enabled = false;
            this.tb_display_numFi.Location = new System.Drawing.Point(41, 143);
            this.tb_display_numFi.Multiline = true;
            this.tb_display_numFi.Name = "tb_display_numFi";
            this.tb_display_numFi.Size = new System.Drawing.Size(239, 268);
            this.tb_display_numFi.TabIndex = 6;
            // 
            // b_numFI_stop
            // 
            this.b_numFI_stop.Location = new System.Drawing.Point(205, 84);
            this.b_numFI_stop.Name = "b_numFI_stop";
            this.b_numFI_stop.Size = new System.Drawing.Size(75, 23);
            this.b_numFI_stop.TabIndex = 5;
            this.b_numFI_stop.Text = "Завершить";
            this.b_numFI_stop.UseVisualStyleBackColor = true;
            this.b_numFI_stop.Click += new System.EventHandler(this.b_numFI_stop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(125, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Числа фибоначи";
            // 
            // b_numFi_pause
            // 
            this.b_numFi_pause.Location = new System.Drawing.Point(123, 83);
            this.b_numFi_pause.Name = "b_numFi_pause";
            this.b_numFi_pause.Size = new System.Drawing.Size(75, 23);
            this.b_numFi_pause.TabIndex = 4;
            this.b_numFi_pause.Text = "Остановка";
            this.b_numFi_pause.UseVisualStyleBackColor = true;
            this.b_numFi_pause.Click += new System.EventHandler(this.b_numFi_pause_Click);
            // 
            // b_numFi_gen
            // 
            this.b_numFi_gen.Location = new System.Drawing.Point(41, 84);
            this.b_numFi_gen.Name = "b_numFi_gen";
            this.b_numFi_gen.Size = new System.Drawing.Size(75, 23);
            this.b_numFi_gen.TabIndex = 3;
            this.b_numFi_gen.Text = "Генерация";
            this.b_numFi_gen.UseVisualStyleBackColor = true;
            this.b_numFi_gen.Click += new System.EventHandler(this.b_numFi_gen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tb_bottom_number;
        private System.Windows.Forms.TextBox tb_up_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_gen_num;
        private System.Windows.Forms.Button b_stop_num;
        private System.Windows.Forms.Button b_pause_num;
        private System.Windows.Forms.Button b_numFI_stop;
        private System.Windows.Forms.Button b_numFi_pause;
        private System.Windows.Forms.Button b_numFi_gen;
        private System.Windows.Forms.TextBox tb_display_num;
        private System.Windows.Forms.TextBox tb_display_numFi;
    }
}

