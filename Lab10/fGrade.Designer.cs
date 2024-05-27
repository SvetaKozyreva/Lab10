namespace Lab10
{
    partial class fGrade
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
            btnOK = new Button();
            label1 = new Label();
            tBGrade = new TextBox();
            tBCourse = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(49, 76);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(119, 29);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Введіть оцінки";
            // 
            // tBGrade
            // 
            tBGrade.Location = new Point(129, 42);
            tBGrade.Name = "tBGrade";
            tBGrade.Size = new Size(66, 27);
            tBGrade.TabIndex = 3;
            // 
            // tBCourse
            // 
            tBCourse.Location = new Point(129, 9);
            tBCourse.Name = "tBCourse";
            tBCourse.Size = new Size(66, 27);
            tBCourse.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "К-ть оцінок";
            // 
            // fGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 117);
            Controls.Add(label2);
            Controls.Add(tBCourse);
            Controls.Add(tBGrade);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Name = "fGrade";
            Text = "Оцінки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Label label1;
        private TextBox tBGrade;
        private TextBox tBCourse;
        private Label label2;
    }
}