namespace Lab10
{
    partial class fStudent
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
            groupBox1 = new GroupBox();
            tBCourse = new TextBox();
            tBSpecialty = new TextBox();
            tBUniversity = new TextBox();
            tBAge = new TextBox();
            tBFullname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            chBLivedrom = new CheckBox();
            chBPaidFree = new CheckBox();
            chBContract = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tBCourse);
            groupBox1.Controls.Add(tBSpecialty);
            groupBox1.Controls.Add(tBUniversity);
            groupBox1.Controls.Add(tBAge);
            groupBox1.Controls.Add(tBFullname);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Загальні дані";
            // 
            // tBCourse
            // 
            tBCourse.Location = new Point(175, 186);
            tBCourse.Name = "tBCourse";
            tBCourse.Size = new Size(125, 27);
            tBCourse.TabIndex = 3;
            // 
            // tBSpecialty
            // 
            tBSpecialty.Location = new Point(175, 147);
            tBSpecialty.Name = "tBSpecialty";
            tBSpecialty.Size = new Size(125, 27);
            tBSpecialty.TabIndex = 4;
            // 
            // tBUniversity
            // 
            tBUniversity.Location = new Point(175, 107);
            tBUniversity.Name = "tBUniversity";
            tBUniversity.Size = new Size(125, 27);
            tBUniversity.TabIndex = 5;
            // 
            // tBAge
            // 
            tBAge.Location = new Point(175, 66);
            tBAge.Name = "tBAge";
            tBAge.Size = new Size(125, 27);
            tBAge.TabIndex = 6;
            // 
            // tBFullname
            // 
            tBFullname.Location = new Point(175, 30);
            tBFullname.Name = "tBFullname";
            tBFullname.Size = new Size(125, 27);
            tBFullname.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 3;
            label1.Text = "ПІБ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 4;
            label2.Text = "Вік";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 110);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "Університет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 150);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 6;
            label4.Text = "Спеціальність";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 189);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 7;
            label5.Text = "К-ть дисциплін";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chBLivedrom);
            groupBox2.Controls.Add(chBPaidFree);
            groupBox2.Controls.Add(chBContract);
            groupBox2.Location = new Point(12, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Додатково";
            // 
            // chBLivedrom
            // 
            chBLivedrom.AutoSize = true;
            chBLivedrom.Location = new Point(22, 26);
            chBLivedrom.Name = "chBLivedrom";
            chBLivedrom.Size = new Size(195, 24);
            chBLivedrom.TabIndex = 0;
            chBLivedrom.Text = "Проживає у гуртожитку";
            chBLivedrom.UseVisualStyleBackColor = true;
            // 
            // chBPaidFree
            // 
            chBPaidFree.AutoSize = true;
            chBPaidFree.Location = new Point(22, 55);
            chBPaidFree.Name = "chBPaidFree";
            chBPaidFree.Size = new Size(85, 24);
            chBPaidFree.TabIndex = 1;
            chBPaidFree.Text = "Бюджет";
            chBPaidFree.UseVisualStyleBackColor = true;
            // 
            // chBContract
            // 
            chBContract.AutoSize = true;
            chBContract.Location = new Point(22, 85);
            chBContract.Name = "chBContract";
            chBContract.Size = new Size(94, 24);
            chBContract.TabIndex = 2;
            chBContract.Text = "Контракт";
            chBContract.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(376, 12);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 1;
            btnOK.Text = "ОК";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(376, 47);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fStudent";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chBPaidFree;
        private CheckBox chBLivedrom;
        private GroupBox groupBox2;
        private CheckBox chBContract;
        private Button btnOK;
        private Button btnCancel;
        private TextBox tBFullname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tBCourse;
        private TextBox tBSpecialty;
        private TextBox tBUniversity;
        private TextBox tBAge;
    }
}
