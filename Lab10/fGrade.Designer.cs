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
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(143, 38);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(52, 29);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Введіть оцінки";
            // 
            // tBGrade
            // 
            tBGrade.Location = new Point(12, 38);
            tBGrade.Name = "tBGrade";
            tBGrade.Size = new Size(125, 27);
            tBGrade.TabIndex = 3;
            // 
            // tBCourse
            // 
            tBCourse.Location = new Point(129, 6);
            tBCourse.Name = "tBCourse";
            tBCourse.Size = new Size(35, 27);
            tBCourse.TabIndex = 4;
            // 
            // fGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 86);
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
    }
}