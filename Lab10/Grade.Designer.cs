namespace Lab10
{
    partial class Grade
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
            tBGrade = new TextBox();
            btnEnd = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "Введіть по черзі оцінки";
            // 
            // tBGrade
            // 
            tBGrade.Location = new Point(32, 33);
            tBGrade.Name = "tBGrade";
            tBGrade.Size = new Size(125, 27);
            tBGrade.TabIndex = 1;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(91, 72);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(94, 29);
            btnEnd.TabIndex = 2;
            btnEnd.Text = "Кінець";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += this.btnEnd_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(163, 32);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(40, 29);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += this.btnOK_Click;
            // 
            // Grades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 113);
            Controls.Add(btnOK);
            Controls.Add(btnEnd);
            Controls.Add(tBGrade);
            Controls.Add(label1);
            Name = "Grades";
            Text = "Оцінки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBGrade;
        private Button btnEnd;
        private Button btnOK;
    }
}