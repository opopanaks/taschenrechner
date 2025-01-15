namespace Taschenrechner
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
            plusSymb = new Button();
            minusSymb = new Button();
            multSymb = new Button();
            divSymb = new Button();
            modSymb = new Button();
            equalsSymb = new Button();
            pointSymb = new Button();
            txtDisplay = new TextBox();
            clear = new Button();
            delete = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            SuspendLayout();
            // 
            // plusSymb
            // 
            plusSymb.BackColor = SystemColors.ControlLight;
            plusSymb.Location = new Point(586, 146);
            plusSymb.Name = "plusSymb";
            plusSymb.Size = new Size(67, 49);
            plusSymb.TabIndex = 0;
            plusSymb.Text = "+";
            plusSymb.UseVisualStyleBackColor = false;
            plusSymb.Click += plusSymb_Click;
            // 
            // minusSymb
            // 
            minusSymb.BackColor = SystemColors.ControlLight;
            minusSymb.Location = new Point(586, 196);
            minusSymb.Name = "minusSymb";
            minusSymb.Size = new Size(67, 49);
            minusSymb.TabIndex = 1;
            minusSymb.Text = "-";
            minusSymb.UseVisualStyleBackColor = false;
            minusSymb.Click += minusSymb_Click;
            // 
            // multSymb
            // 
            multSymb.BackColor = SystemColors.ControlLight;
            multSymb.Location = new Point(586, 246);
            multSymb.Name = "multSymb";
            multSymb.Size = new Size(67, 49);
            multSymb.TabIndex = 2;
            multSymb.Text = "*";
            multSymb.UseVisualStyleBackColor = false;
            multSymb.Click += multSymb_Click;
            // 
            // divSymb
            // 
            divSymb.BackColor = SystemColors.ControlLight;
            divSymb.Location = new Point(586, 296);
            divSymb.Name = "divSymb";
            divSymb.Size = new Size(67, 49);
            divSymb.TabIndex = 3;
            divSymb.Text = "/";
            divSymb.UseVisualStyleBackColor = false;
            divSymb.Click += divSymb_Click;
            // 
            // modSymb
            // 
            modSymb.BackColor = SystemColors.ControlLight;
            modSymb.Location = new Point(586, 346);
            modSymb.Name = "modSymb";
            modSymb.Size = new Size(67, 49);
            modSymb.TabIndex = 4;
            modSymb.Text = "%";
            modSymb.UseVisualStyleBackColor = false;
            modSymb.Click += modSymb_Click;
            // 
            // equalsSymb
            // 
            equalsSymb.BackColor = SystemColors.Highlight;
            equalsSymb.BackgroundImageLayout = ImageLayout.Center;
            equalsSymb.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            equalsSymb.ForeColor = SystemColors.ControlLightLight;
            equalsSymb.Location = new Point(515, 296);
            equalsSymb.Name = "equalsSymb";
            equalsSymb.Size = new Size(69, 49);
            equalsSymb.TabIndex = 7;
            equalsSymb.Text = "=";
            equalsSymb.UseVisualStyleBackColor = false;
            equalsSymb.Click += equalsSymb_Click;
            // 
            // pointSymb
            // 
            pointSymb.Location = new Point(445, 296);
            pointSymb.Name = "pointSymb";
            pointSymb.Size = new Size(69, 49);
            pointSymb.TabIndex = 7;
            pointSymb.Text = ".";
            pointSymb.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.ControlLight;
            txtDisplay.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(375, 97);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(276, 43);
            txtDisplay.TabIndex = 5;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.ControlDarkDark;
            clear.Location = new Point(375, 346);
            clear.Name = "clear";
            clear.Size = new Size(104, 49);
            clear.TabIndex = 6;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // delete
            // 
            delete.Location = new Point(480, 346);
            delete.Name = "delete";
            delete.Size = new Size(104, 49);
            delete.TabIndex = 6;
            delete.Text = "D";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(375, 146);
            button1.Name = "button1";
            button1.Size = new Size(69, 49);
            button1.TabIndex = 7;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(445, 146);
            button2.Name = "button2";
            button2.Size = new Size(69, 49);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(515, 146);
            button3.Name = "button3";
            button3.Size = new Size(69, 49);
            button3.TabIndex = 7;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F);
            button4.Location = new Point(375, 196);
            button4.Name = "button4";
            button4.Size = new Size(69, 49);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F);
            button5.Location = new Point(445, 196);
            button5.Name = "button5";
            button5.Size = new Size(69, 49);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F);
            button6.Location = new Point(515, 196);
            button6.Name = "button6";
            button6.Size = new Size(69, 49);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F);
            button7.Location = new Point(375, 246);
            button7.Name = "button7";
            button7.Size = new Size(69, 49);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F);
            button8.Location = new Point(445, 246);
            button8.Name = "button8";
            button8.Size = new Size(69, 49);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F);
            button9.Location = new Point(515, 246);
            button9.Name = "button9";
            button9.Size = new Size(69, 49);
            button9.TabIndex = 7;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 9F);
            button0.Location = new Point(375, 296);
            button0.Name = "button0";
            button0.Size = new Size(69, 49);
            button0.TabIndex = 7;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button0);
            Controls.Add(equalsSymb);
            Controls.Add(pointSymb);
            Controls.Add(clear);
            Controls.Add(delete);
            Controls.Add(txtDisplay);
            Controls.Add(modSymb);
            Controls.Add(divSymb);
            Controls.Add(multSymb);
            Controls.Add(minusSymb);
            Controls.Add(plusSymb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plusSymb;
        private Button minusSymb;
        private Button multSymb;
        private Button divSymb;
        private Button modSymb;
        private Button equalsSymb;
        private Button pointSymb;
        private TextBox txtDisplay;
        private Button clear;
        private Button delete;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
    }
}
