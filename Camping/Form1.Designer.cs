namespace Camping
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPersonen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxHond = new System.Windows.Forms.CheckBox();
            this.CheckBoxAutoTent = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxMeter = new System.Windows.Forms.TextBox();
            this.Bereken = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.DateTimeVan = new System.Windows.Forms.DateTimePicker();
            this.DateTimeTot = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hond";
            // 
            // TextBoxPersonen
            // 
            this.TextBoxPersonen.Location = new System.Drawing.Point(130, 101);
            this.TextBoxPersonen.Name = "TextBoxPersonen";
            this.TextBoxPersonen.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPersonen.TabIndex = 1;
            this.TextBoxPersonen.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoeveelheid personen";
            // 
            // CheckBoxHond
            // 
            this.CheckBoxHond.AutoSize = true;
            this.CheckBoxHond.Location = new System.Drawing.Point(130, 133);
            this.CheckBoxHond.Name = "CheckBoxHond";
            this.CheckBoxHond.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxHond.TabIndex = 3;
            this.CheckBoxHond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxHond.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAutoTent
            // 
            this.CheckBoxAutoTent.AutoSize = true;
            this.CheckBoxAutoTent.Location = new System.Drawing.Point(130, 154);
            this.CheckBoxAutoTent.Name = "CheckBoxAutoTent";
            this.CheckBoxAutoTent.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxAutoTent.TabIndex = 5;
            this.CheckBoxAutoTent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxAutoTent.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Auto bij tent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hoeveel meter";
            // 
            // TextBoxMeter
            // 
            this.TextBoxMeter.Location = new System.Drawing.Point(130, 75);
            this.TextBoxMeter.Name = "TextBoxMeter";
            this.TextBoxMeter.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMeter.TabIndex = 6;
            this.TextBoxMeter.Text = "10";
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(130, 174);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(100, 23);
            this.Bereken.TabIndex = 8;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(127, 210);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(103, 13);
            this.Output.TabIndex = 9;
            // 
            // DateTimeVan
            // 
            this.DateTimeVan.Location = new System.Drawing.Point(130, 25);
            this.DateTimeVan.Name = "DateTimeVan";
            this.DateTimeVan.Size = new System.Drawing.Size(200, 20);
            this.DateTimeVan.TabIndex = 10;
            // 
            // DateTimeTot
            // 
            this.DateTimeTot.Location = new System.Drawing.Point(130, 49);
            this.DateTimeTot.Name = "DateTimeTot";
            this.DateTimeTot.Size = new System.Drawing.Size(200, 20);
            this.DateTimeTot.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Van";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 216);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateTimeTot);
            this.Controls.Add(this.DateTimeVan);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxMeter);
            this.Controls.Add(this.CheckBoxAutoTent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckBoxHond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxPersonen);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Camping tarief berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPersonen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxHond;
        private System.Windows.Forms.CheckBox CheckBoxAutoTent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxMeter;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.DateTimePicker DateTimeVan;
        private System.Windows.Forms.DateTimePicker DateTimeTot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

