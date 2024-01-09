namespace lab3_send_json
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
            this.numericUpDownStartAngle = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndAngle = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonFalse = new System.Windows.Forms.RadioButton();
            this.numericUpDownRotationDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStereoTone = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSendData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStereoTone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHANGE DATA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownStartAngle
            // 
            this.numericUpDownStartAngle.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStartAngle.Location = new System.Drawing.Point(15, 93);
            this.numericUpDownStartAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownStartAngle.Name = "numericUpDownStartAngle";
            this.numericUpDownStartAngle.Size = new System.Drawing.Size(85, 32);
            this.numericUpDownStartAngle.TabIndex = 3;
            this.numericUpDownStartAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownEndAngle
            // 
            this.numericUpDownEndAngle.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEndAngle.Location = new System.Drawing.Point(15, 170);
            this.numericUpDownEndAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownEndAngle.Name = "numericUpDownEndAngle";
            this.numericUpDownEndAngle.Size = new System.Drawing.Size(85, 32);
            this.numericUpDownEndAngle.TabIndex = 3;
            this.numericUpDownEndAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownEndAngle.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start angle";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "End angle";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Delay for rotation";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Work status";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Stereo tone";
            // 
            // radioButtonTrue
            // 
            this.radioButtonTrue.AutoSize = true;
            this.radioButtonTrue.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrue.Location = new System.Drawing.Point(293, 119);
            this.radioButtonTrue.Name = "radioButtonTrue";
            this.radioButtonTrue.Size = new System.Drawing.Size(67, 33);
            this.radioButtonTrue.TabIndex = 5;
            this.radioButtonTrue.TabStop = true;
            this.radioButtonTrue.Text = "True";
            this.radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonFalse
            // 
            this.radioButtonFalse.AutoSize = true;
            this.radioButtonFalse.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFalse.Location = new System.Drawing.Point(293, 147);
            this.radioButtonFalse.Name = "radioButtonFalse";
            this.radioButtonFalse.Size = new System.Drawing.Size(69, 33);
            this.radioButtonFalse.TabIndex = 5;
            this.radioButtonFalse.TabStop = true;
            this.radioButtonFalse.Text = "False";
            this.radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRotationDelay
            // 
            this.numericUpDownRotationDelay.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRotationDelay.Location = new System.Drawing.Point(154, 93);
            this.numericUpDownRotationDelay.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownRotationDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRotationDelay.Name = "numericUpDownRotationDelay";
            this.numericUpDownRotationDelay.Size = new System.Drawing.Size(85, 32);
            this.numericUpDownRotationDelay.TabIndex = 3;
            this.numericUpDownRotationDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRotationDelay.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numericUpDownStereoTone
            // 
            this.numericUpDownStereoTone.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStereoTone.Location = new System.Drawing.Point(154, 170);
            this.numericUpDownStereoTone.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownStereoTone.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStereoTone.Name = "numericUpDownStereoTone";
            this.numericUpDownStereoTone.Size = new System.Drawing.Size(85, 32);
            this.numericUpDownStereoTone.TabIndex = 3;
            this.numericUpDownStereoTone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownStereoTone.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSendData
            // 
            this.buttonSendData.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSendData.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSendData.Location = new System.Drawing.Point(199, 225);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(173, 53);
            this.buttonSendData.TabIndex = 6;
            this.buttonSendData.Text = "Send in port";
            this.buttonSendData.UseVisualStyleBackColor = false;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 290);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonFalse);
            this.Controls.Add(this.radioButtonTrue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownEndAngle);
            this.Controls.Add(this.numericUpDownStereoTone);
            this.Controls.Add(this.numericUpDownRotationDelay);
            this.Controls.Add(this.numericUpDownStartAngle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStereoTone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStartAngle;
        private System.Windows.Forms.NumericUpDown numericUpDownEndAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.RadioButton radioButtonFalse;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownStereoTone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSendData;
    }
}

