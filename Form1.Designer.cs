namespace metranTest
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
            this.buttonTestsStart = new System.Windows.Forms.Button();
            this.labelTest1 = new System.Windows.Forms.Label();
            this.labelTest2 = new System.Windows.Forms.Label();
            this.labelTest3 = new System.Windows.Forms.Label();
            this.labelTest1Result = new System.Windows.Forms.Label();
            this.labelTest2Result = new System.Windows.Forms.Label();
            this.labelTest3Result = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTestsStart
            // 
            this.buttonTestsStart.Location = new System.Drawing.Point(33, 402);
            this.buttonTestsStart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTestsStart.Name = "buttonTestsStart";
            this.buttonTestsStart.Size = new System.Drawing.Size(118, 38);
            this.buttonTestsStart.TabIndex = 0;
            this.buttonTestsStart.Text = "запуск";
            this.buttonTestsStart.UseVisualStyleBackColor = true;
            this.buttonTestsStart.Click += new System.EventHandler(this.buttonTestsStart_Click);
            // 
            // labelTest1
            // 
            this.labelTest1.AutoSize = true;
            this.labelTest1.Location = new System.Drawing.Point(33, 45);
            this.labelTest1.Name = "labelTest1";
            this.labelTest1.Size = new System.Drawing.Size(64, 25);
            this.labelTest1.TabIndex = 1;
            this.labelTest1.Text = "Тест 1";
            // 
            // labelTest2
            // 
            this.labelTest2.AutoSize = true;
            this.labelTest2.Location = new System.Drawing.Point(33, 96);
            this.labelTest2.Name = "labelTest2";
            this.labelTest2.Size = new System.Drawing.Size(64, 25);
            this.labelTest2.TabIndex = 2;
            this.labelTest2.Text = "Тест 2";
            // 
            // labelTest3
            // 
            this.labelTest3.AutoSize = true;
            this.labelTest3.Location = new System.Drawing.Point(33, 148);
            this.labelTest3.Name = "labelTest3";
            this.labelTest3.Size = new System.Drawing.Size(64, 25);
            this.labelTest3.TabIndex = 3;
            this.labelTest3.Text = "Тест 3";
            // 
            // labelTest1Result
            // 
            this.labelTest1Result.AutoSize = true;
            this.labelTest1Result.Location = new System.Drawing.Point(120, 45);
            this.labelTest1Result.Name = "labelTest1Result";
            this.labelTest1Result.Size = new System.Drawing.Size(36, 25);
            this.labelTest1Result.TabIndex = 4;
            this.labelTest1Result.Text = "---";
            // 
            // labelTest2Result
            // 
            this.labelTest2Result.AutoSize = true;
            this.labelTest2Result.Location = new System.Drawing.Point(120, 96);
            this.labelTest2Result.Name = "labelTest2Result";
            this.labelTest2Result.Size = new System.Drawing.Size(36, 25);
            this.labelTest2Result.TabIndex = 5;
            this.labelTest2Result.Text = "---";
            // 
            // labelTest3Result
            // 
            this.labelTest3Result.AutoSize = true;
            this.labelTest3Result.Location = new System.Drawing.Point(120, 148);
            this.labelTest3Result.Name = "labelTest3Result";
            this.labelTest3Result.Size = new System.Drawing.Size(36, 25);
            this.labelTest3Result.TabIndex = 6;
            this.labelTest3Result.Text = "---";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(33, 283);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(36, 25);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 499);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTest3Result);
            this.Controls.Add(this.labelTest2Result);
            this.Controls.Add(this.labelTest1Result);
            this.Controls.Add(this.labelTest3);
            this.Controls.Add(this.labelTest2);
            this.Controls.Add(this.labelTest1);
            this.Controls.Add(this.buttonTestsStart);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonTestsStart;
        private Label labelTest1;
        private Label labelTest2;
        private Label labelTest3;
        private Label labelTest1Result;
        private Label labelTest2Result;
        private Label labelTest3Result;
        private Label labelStatus;
    }
}