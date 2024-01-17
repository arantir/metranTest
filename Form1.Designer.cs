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
            buttonTestsStart = new Button();
            labelTest1 = new Label();
            labelTest2 = new Label();
            labelTest3 = new Label();
            labelTest1Result = new Label();
            labelTest2Result = new Label();
            labelTest3Result = new Label();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // buttonTestsStart
            // 
            buttonTestsStart.Location = new Point(33, 402);
            buttonTestsStart.Margin = new Padding(5);
            buttonTestsStart.Name = "buttonTestsStart";
            buttonTestsStart.Size = new Size(118, 38);
            buttonTestsStart.TabIndex = 0;
            buttonTestsStart.Text = "запуск";
            buttonTestsStart.UseVisualStyleBackColor = true;
            buttonTestsStart.Click += buttonTestsStart_Click;
            // 
            // labelTest1
            // 
            labelTest1.AutoSize = true;
            labelTest1.Location = new Point(33, 45);
            labelTest1.Name = "labelTest1";
            labelTest1.Size = new Size(64, 25);
            labelTest1.TabIndex = 1;
            labelTest1.Text = "Тест 1";
            // 
            // labelTest2
            // 
            labelTest2.AutoSize = true;
            labelTest2.Location = new Point(33, 96);
            labelTest2.Name = "labelTest2";
            labelTest2.Size = new Size(64, 25);
            labelTest2.TabIndex = 2;
            labelTest2.Text = "Тест 2";
            // 
            // labelTest3
            // 
            labelTest3.AutoSize = true;
            labelTest3.Location = new Point(33, 148);
            labelTest3.Name = "labelTest3";
            labelTest3.Size = new Size(64, 25);
            labelTest3.TabIndex = 3;
            labelTest3.Text = "Тест 3";
            // 
            // labelTest1Result
            // 
            labelTest1Result.AutoSize = true;
            labelTest1Result.Location = new Point(120, 45);
            labelTest1Result.Name = "labelTest1Result";
            labelTest1Result.Size = new Size(36, 25);
            labelTest1Result.TabIndex = 4;
            labelTest1Result.Text = "---";
            // 
            // labelTest2Result
            // 
            labelTest2Result.AutoSize = true;
            labelTest2Result.Location = new Point(120, 96);
            labelTest2Result.Name = "labelTest2Result";
            labelTest2Result.Size = new Size(36, 25);
            labelTest2Result.TabIndex = 5;
            labelTest2Result.Text = "---";
            // 
            // labelTest3Result
            // 
            labelTest3Result.AutoSize = true;
            labelTest3Result.Location = new Point(120, 148);
            labelTest3Result.Name = "labelTest3Result";
            labelTest3Result.Size = new Size(36, 25);
            labelTest3Result.TabIndex = 6;
            labelTest3Result.Text = "---";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(33, 283);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(36, 25);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 499);
            Controls.Add(labelStatus);
            Controls.Add(labelTest3Result);
            Controls.Add(labelTest2Result);
            Controls.Add(labelTest1Result);
            Controls.Add(labelTest3);
            Controls.Add(labelTest2);
            Controls.Add(labelTest1);
            Controls.Add(buttonTestsStart);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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