namespace Prime
{
    partial class PrimeMain
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
            this.primeOutputTB = new System.Windows.Forms.RichTextBox();
            this.primeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primeOutputTB
            // 
            this.primeOutputTB.Location = new System.Drawing.Point(213, 12);
            this.primeOutputTB.Name = "primeOutputTB";
            this.primeOutputTB.ReadOnly = true;
            this.primeOutputTB.Size = new System.Drawing.Size(245, 210);
            this.primeOutputTB.TabIndex = 0;
            this.primeOutputTB.Text = "";
            // 
            // primeBox
            // 
            this.primeBox.Location = new System.Drawing.Point(15, 56);
            this.primeBox.Name = "primeBox";
            this.primeBox.Size = new System.Drawing.Size(100, 20);
            this.primeBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prime Number:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(25, 95);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // PrimeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 234);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.primeBox);
            this.Controls.Add(this.primeOutputTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PrimeMain";
            this.Text = "Prime Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox primeOutputTB;
        private System.Windows.Forms.TextBox primeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
    }
}

