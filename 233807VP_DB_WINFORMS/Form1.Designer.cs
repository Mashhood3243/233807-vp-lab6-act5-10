namespace _233807VP_DB_WINFORMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 89);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer Name";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(51, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Painting";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(158, 26);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(86, 24);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Reading";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 146);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 6;
            label3.Text = "Country";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(57, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(157, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pakistan", "India ", "Bangladesh" });
            comboBox1.Location = new Point(324, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 12;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(56, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 24);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Married";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(144, 26);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(100, 24);
            radioButton4.TabIndex = 14;
            radioButton4.TabStop = true;
            radioButton4.Text = "Unmarried";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(613, 432);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 15;
            button1.Text = "Preview";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(236, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 67);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(236, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 61);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Status";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Location = new Point(236, 271);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 60);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hobbies";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 504);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        public Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
