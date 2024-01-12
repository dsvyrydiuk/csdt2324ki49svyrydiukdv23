namespace test5
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
            label1 = new Label();
            numericUpDownStartAngle = new NumericUpDown();
            numericUpDownEndAngle = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButtonTrue = new RadioButton();
            radioButtonFalse = new RadioButton();
            numericUpDownRotationDelay = new NumericUpDown();
            numericUpDownStereoTone = new NumericUpDown();
            button1 = new Button();
            buttonSendData = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartAngle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEndAngle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRotationDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStereoTone).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Microsoft Uighur", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(1, -2);
            label1.Name = "label1";
            label1.Size = new Size(391, 71);
            label1.TabIndex = 0;
            label1.Text = "CHANGE DATA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownStartAngle
            // 
            numericUpDownStartAngle.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownStartAngle.Location = new Point(15, 116);
            numericUpDownStartAngle.Margin = new Padding(3, 4, 3, 4);
            numericUpDownStartAngle.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numericUpDownStartAngle.Name = "numericUpDownStartAngle";
            numericUpDownStartAngle.Size = new Size(85, 32);
            numericUpDownStartAngle.TabIndex = 3;
            numericUpDownStartAngle.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDownEndAngle
            // 
            numericUpDownEndAngle.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownEndAngle.Location = new Point(15, 212);
            numericUpDownEndAngle.Margin = new Padding(3, 4, 3, 4);
            numericUpDownEndAngle.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numericUpDownEndAngle.Name = "numericUpDownEndAngle";
            numericUpDownEndAngle.Size = new Size(85, 32);
            numericUpDownEndAngle.TabIndex = 3;
            numericUpDownEndAngle.TextAlign = HorizontalAlignment.Center;
            numericUpDownEndAngle.Value = new decimal(new int[] { 180, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 76);
            label2.Name = "label2";
            label2.Size = new Size(85, 29);
            label2.TabIndex = 4;
            label2.Text = "Start angle";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 172);
            label3.Name = "label3";
            label3.Size = new Size(85, 36);
            label3.TabIndex = 4;
            label3.Text = "End angle";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(129, 76);
            label4.Name = "label4";
            label4.Size = new Size(157, 29);
            label4.TabIndex = 4;
            label4.Text = "Delay for rotation";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(281, 116);
            label5.Name = "label5";
            label5.Size = new Size(101, 29);
            label5.TabIndex = 4;
            label5.Text = "Work status";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(149, 172);
            label6.Name = "label6";
            label6.Size = new Size(101, 29);
            label6.TabIndex = 4;
            label6.Text = "Stereo tone";
            // 
            // radioButtonTrue
            // 
            radioButtonTrue.AutoSize = true;
            radioButtonTrue.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonTrue.Location = new Point(293, 149);
            radioButtonTrue.Margin = new Padding(3, 4, 3, 4);
            radioButtonTrue.Name = "radioButtonTrue";
            radioButtonTrue.Size = new Size(67, 33);
            radioButtonTrue.TabIndex = 5;
            radioButtonTrue.TabStop = true;
            radioButtonTrue.Text = "True";
            radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonFalse
            // 
            radioButtonFalse.AutoSize = true;
            radioButtonFalse.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonFalse.Location = new Point(293, 184);
            radioButtonFalse.Margin = new Padding(3, 4, 3, 4);
            radioButtonFalse.Name = "radioButtonFalse";
            radioButtonFalse.Size = new Size(69, 33);
            radioButtonFalse.TabIndex = 5;
            radioButtonFalse.TabStop = true;
            radioButtonFalse.Text = "False";
            radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRotationDelay
            // 
            numericUpDownRotationDelay.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownRotationDelay.Location = new Point(154, 116);
            numericUpDownRotationDelay.Margin = new Padding(3, 4, 3, 4);
            numericUpDownRotationDelay.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownRotationDelay.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownRotationDelay.Name = "numericUpDownRotationDelay";
            numericUpDownRotationDelay.Size = new Size(85, 32);
            numericUpDownRotationDelay.TabIndex = 3;
            numericUpDownRotationDelay.TextAlign = HorizontalAlignment.Center;
            numericUpDownRotationDelay.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // numericUpDownStereoTone
            // 
            numericUpDownStereoTone.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownStereoTone.Location = new Point(154, 212);
            numericUpDownStereoTone.Margin = new Padding(3, 4, 3, 4);
            numericUpDownStereoTone.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numericUpDownStereoTone.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownStereoTone.Name = "numericUpDownStereoTone";
            numericUpDownStereoTone.Size = new Size(85, 32);
            numericUpDownStereoTone.TabIndex = 3;
            numericUpDownStereoTone.TextAlign = HorizontalAlignment.Center;
            numericUpDownStereoTone.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Microsoft Uighur", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 281);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(181, 66);
            button1.TabIndex = 6;
            button1.Text = "Save change";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonSendData
            // 
            buttonSendData.BackColor = SystemColors.Highlight;
            buttonSendData.Font = new Font("Microsoft Uighur", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSendData.ForeColor = SystemColors.ButtonFace;
            buttonSendData.Location = new Point(199, 281);
            buttonSendData.Margin = new Padding(3, 4, 3, 4);
            buttonSendData.Name = "buttonSendData";
            buttonSendData.Size = new Size(173, 66);
            buttonSendData.TabIndex = 6;
            buttonSendData.Text = "Send in port";
            buttonSendData.UseVisualStyleBackColor = false;
            buttonSendData.Click += buttonSendData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 362);
            Controls.Add(buttonSendData);
            Controls.Add(button1);
            Controls.Add(radioButtonFalse);
            Controls.Add(radioButtonTrue);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(numericUpDownEndAngle);
            Controls.Add(numericUpDownStereoTone);
            Controls.Add(numericUpDownRotationDelay);
            Controls.Add(numericUpDownStartAngle);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartAngle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEndAngle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRotationDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStereoTone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public NumericUpDown numericUpDownStartAngle;
        public NumericUpDown numericUpDownEndAngle;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public RadioButton radioButtonTrue;
        public RadioButton radioButtonFalse;
        public NumericUpDown numericUpDownRotationDelay;
        public NumericUpDown numericUpDownStereoTone;
        public Button button1;
        public Button buttonSendData;
    }
}

