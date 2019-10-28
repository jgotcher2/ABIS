namespace WindowsFormsApp1
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Students = new System.Windows.Forms.ListBox();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataTable2 = new System.Data.DataTable();
            this.ABCDABCDAB = new System.Windows.Forms.ListBox();
            this.Answers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(36, 229);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Grade";
            this.btnClickThis.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grading Program";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Students
            // 
            this.Students.FormattingEnabled = true;
            this.Students.Items.AddRange(new object[] {
            "Jean\t10\tA",
            "Jack\t7\tC",
            "George\t9\tA",
            "Paul\t5\tF",
            "Steven\t7\tC",
            "Jackie\t6\tD",
            "Susan \t0\tF",
            "David\t8\tB",
            "Dan\t8\tB"});
            this.Students.Location = new System.Drawing.Point(36, 63);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(181, 160);
            this.Students.TabIndex = 3;
            this.Students.SelectedIndexChanged += new System.EventHandler(this.Students_SelectedIndexChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Table1";
            // 
            // dataTable2
            // 
            this.dataTable2.TableName = "Table2";
            // 
            // ABCDABCDAB
            // 
            this.ABCDABCDAB.FormattingEnabled = true;
            this.ABCDABCDAB.Location = new System.Drawing.Point(109, 29);
            this.ABCDABCDAB.Name = "ABCDABCDAB";
            this.ABCDABCDAB.Size = new System.Drawing.Size(85, 17);
            this.ABCDABCDAB.TabIndex = 4;
            // 
            // Answers
            // 
            this.Answers.AutoSize = true;
            this.Answers.Location = new System.Drawing.Point(40, 29);
            this.Answers.Name = "Answers";
            this.Answers.Size = new System.Drawing.Size(63, 13);
            this.Answers.TabIndex = 5;
            this.Answers.Text = "Answer Key";
            this.Answers.Click += new System.EventHandler(this.Answers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Answers);
            this.Controls.Add(this.ABCDABCDAB);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Students;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataTable dataTable2;
        private System.Windows.Forms.ListBox ABCDABCDAB;
        private System.Windows.Forms.Label Answers;
    }
}

