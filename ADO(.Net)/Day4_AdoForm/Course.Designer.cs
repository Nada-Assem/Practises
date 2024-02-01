namespace Day4_AdoForm
{
    partial class Course
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
            dataGridView1 = new DataGridView();
            btnAddCourse = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            NCrsId = new NumericUpDown();
            NTop_ID = new NumericUpDown();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnGetOne = new Button();
            NCrsDuration = new NumericUpDown();
            btnGetAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NCrsId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NTop_ID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NCrsDuration).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(377, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(445, 426);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnAddCourse.Location = new Point(47, 338);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(94, 34);
            btnAddCourse.TabIndex = 3;
            btnAddCourse.Text = "Add";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label1.Location = new Point(27, 77);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 4;
            label1.Text = "Course Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label2.Location = new Point(27, 163);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 6;
            label2.Text = "Course Duration :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label4.Location = new Point(29, 124);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 8;
            label4.Text = "Topic ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 33);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 17;
            label3.Text = "Course Id :";
            // 
            // NCrsId
            // 
            NCrsId.Location = new Point(194, 33);
            NCrsId.Name = "NCrsId";
            NCrsId.Size = new Size(150, 27);
            NCrsId.TabIndex = 18;
            // 
            // NTop_ID
            // 
            NTop_ID.Location = new Point(193, 118);
            NTop_ID.Name = "NTop_ID";
            NTop_ID.Size = new Size(150, 27);
            NTop_ID.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.Location = new Point(193, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnUpdate.Location = new Point(47, 275);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Updata";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGetOne
            // 
            btnGetOne.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnGetOne.Location = new Point(193, 343);
            btnGetOne.Name = "btnGetOne";
            btnGetOne.Size = new Size(94, 29);
            btnGetOne.TabIndex = 23;
            btnGetOne.Text = "Get One";
            btnGetOne.UseVisualStyleBackColor = true;
            btnGetOne.Click += btnGetOne_Click;
            // 
            // NCrsDuration
            // 
            NCrsDuration.Location = new Point(193, 163);
            NCrsDuration.Name = "NCrsDuration";
            NCrsDuration.Size = new Size(150, 27);
            NCrsDuration.TabIndex = 24;
            // 
            // btnGetAll
            // 
            btnGetAll.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnGetAll.Location = new Point(123, 404);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(94, 34);
            btnGetAll.TabIndex = 26;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(844, 462);
            Controls.Add(btnGetAll);
            Controls.Add(NCrsDuration);
            Controls.Add(btnGetOne);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(NTop_ID);
            Controls.Add(NCrsId);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnAddCourse);
            Controls.Add(dataGridView1);
            Name = "Course";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NCrsId).EndInit();
            ((System.ComponentModel.ISupportInitialize)NTop_ID).EndInit();
            ((System.ComponentModel.ISupportInitialize)NCrsDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddCourse;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label4;
        private TextBox txtDuration;
        private TextBox txtId;
        private Label label3;
        private NumericUpDown NCrsId;
        private NumericUpDown NTop_ID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnGetOne;
        private NumericUpDown NCrsDuration;
        private Button btnGetAll;
    }
}
