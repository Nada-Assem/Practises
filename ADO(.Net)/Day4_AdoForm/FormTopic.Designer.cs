namespace Day4_AdoForm
{
    partial class FormTopic
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
            btnDelete = new Button();
            btnAdd = new Button();
            btnGetAll = new Button();
            btnUpdata = new Button();
            btnGetone = new Button();
            TopID = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.Location = new Point(211, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Location = new Point(39, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGetAll
            // 
            btnGetAll.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnGetAll.Location = new Point(131, 357);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(94, 29);
            btnGetAll.TabIndex = 2;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnUpdata
            // 
            btnUpdata.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnUpdata.Location = new Point(39, 304);
            btnUpdata.Name = "btnUpdata";
            btnUpdata.Size = new Size(94, 29);
            btnUpdata.TabIndex = 3;
            btnUpdata.Text = "Updata";
            btnUpdata.UseVisualStyleBackColor = true;
            btnUpdata.Click += btnUpdata_Click;
            // 
            // btnGetone
            // 
            btnGetone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnGetone.Location = new Point(211, 304);
            btnGetone.Name = "btnGetone";
            btnGetone.Size = new Size(94, 29);
            btnGetone.TabIndex = 4;
            btnGetone.Text = "Get One";
            btnGetone.UseVisualStyleBackColor = true;
            btnGetone.Click += btnGetone_Click;
            // 
            // TopID
            // 
            TopID.AutoSize = true;
            TopID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            TopID.Location = new Point(39, 98);
            TopID.Name = "TopID";
            TopID.Size = new Size(76, 23);
            TopID.TabIndex = 5;
            TopID.Text = "Topic ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(34, 175);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 6;
            label2.Text = "Topic Name";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(141, 94);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 110;
            dataGridView1.Size = new Size(426, 344);
            dataGridView1.TabIndex = 9;
            // 
            // FormTopic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(TopID);
            Controls.Add(btnGetone);
            Controls.Add(btnUpdata);
            Controls.Add(btnGetAll);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Name = "FormTopic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Topic";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnAdd;
        private Button btnGetAll;
        private Button btnUpdata;
        private Button btnGetone;
        private Label TopID;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}