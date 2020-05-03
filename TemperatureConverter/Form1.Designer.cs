namespace TemperatureConverter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cToFRadio = new System.Windows.Forms.RadioButton();
            this.fToCRadio = new System.Windows.Forms.RadioButton();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input temperature:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cToFRadio);
            this.groupBox1.Controls.Add(this.fToCRadio);
            this.groupBox1.Controls.Add(this.inputTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.outputLabel.Location = new System.Drawing.Point(173, 103);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(73, 23);
            this.outputLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output temperature:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cToFRadio
            // 
            this.cToFRadio.AutoSize = true;
            this.cToFRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cToFRadio.Location = new System.Drawing.Point(10, 76);
            this.cToFRadio.Name = "cToFRadio";
            this.cToFRadio.Size = new System.Drawing.Size(189, 24);
            this.cToFRadio.TabIndex = 3;
            this.cToFRadio.TabStop = true;
            this.cToFRadio.Text = "Celcius to Fahrenheit";
            this.cToFRadio.UseVisualStyleBackColor = true;
            // 
            // fToCRadio
            // 
            this.fToCRadio.AutoSize = true;
            this.fToCRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fToCRadio.Location = new System.Drawing.Point(10, 46);
            this.fToCRadio.Name = "fToCRadio";
            this.fToCRadio.Size = new System.Drawing.Size(189, 24);
            this.fToCRadio.TabIndex = 2;
            this.fToCRadio.TabStop = true;
            this.fToCRadio.Text = "Fahrenheit to Celcius";
            this.fToCRadio.UseVisualStyleBackColor = true;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(173, 18);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(73, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.convertButton.Location = new System.Drawing.Point(12, 157);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(114, 41);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearButton.Location = new System.Drawing.Point(150, 157);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(114, 41);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 209);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.convertButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Temperature Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton cToFRadio;
        private System.Windows.Forms.RadioButton fToCRadio;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
    }
}

