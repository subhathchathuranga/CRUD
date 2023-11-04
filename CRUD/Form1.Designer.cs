namespace CRUD
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
            EMPID = new TextBox();
            label1 = new Label();
            FIRSTNAME = new TextBox();
            label2 = new Label();
            MI = new TextBox();
            label3 = new Label();
            GENDER = new TextBox();
            label4 = new Label();
            LASTNAME = new TextBox();
            label5 = new Label();
            POSITION = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            UPDATE = new Button();
            btn_delete = new Button();
            label7 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // EMPID
            // 
            EMPID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPID.Location = new Point(99, 69);
            EMPID.Name = "EMPID";
            EMPID.Size = new Size(226, 34);
            EMPID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 1;
            label1.Text = "EMPID";
            // 
            // FIRSTNAME
            // 
            FIRSTNAME.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FIRSTNAME.Location = new Point(99, 149);
            FIRSTNAME.Name = "FIRSTNAME";
            FIRSTNAME.Size = new Size(226, 34);
            FIRSTNAME.TabIndex = 0;
            FIRSTNAME.TextChanged += txt_fname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(106, 113);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 1;
            label2.Text = "FIRST NAME";
            label2.Click += label2_Click;
            // 
            // MI
            // 
            MI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MI.Location = new Point(99, 240);
            MI.Name = "MI";
            MI.Size = new Size(226, 34);
            MI.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(106, 203);
            label3.Name = "label3";
            label3.Size = new Size(35, 28);
            label3.TabIndex = 1;
            label3.Text = "MI";
            // 
            // GENDER
            // 
            GENDER.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GENDER.Location = new Point(106, 443);
            GENDER.Name = "GENDER";
            GENDER.Size = new Size(226, 34);
            GENDER.TabIndex = 0;
            GENDER.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(113, 405);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 1;
            label4.Text = "GENDER";
            // 
            // LASTNAME
            // 
            LASTNAME.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LASTNAME.Location = new Point(99, 340);
            LASTNAME.Name = "LASTNAME";
            LASTNAME.Size = new Size(226, 34);
            LASTNAME.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(106, 303);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 1;
            label5.Text = "LAST NAME";
            // 
            // POSITION
            // 
            POSITION.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            POSITION.Location = new Point(99, 547);
            POSITION.Name = "POSITION";
            POSITION.Size = new Size(226, 34);
            POSITION.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(106, 509);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 1;
            label6.Text = "POSITION";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(376, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(857, 619);
            dataGridView1.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(99, 619);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(222, 619);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(94, 29);
            UPDATE.TabIndex = 4;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            UPDATE.Click += button1_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(99, 667);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(466, 19);
            label7.Name = "label7";
            label7.Size = new Size(602, 41);
            label7.TabIndex = 1;
            label7.Text = "EMPLOYEE INFORMATION RECORD SYSTEM";
            label7.Click += label7_Click;
            // 
            // button3
            // 
            button3.Location = new Point(222, 667);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "LOAD";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 739);
            Controls.Add(button3);
            Controls.Add(UPDATE);
            Controls.Add(btn_delete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LASTNAME);
            Controls.Add(POSITION);
            Controls.Add(GENDER);
            Controls.Add(MI);
            Controls.Add(FIRSTNAME);
            Controls.Add(EMPID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EMPID;
        private Label label1;
        private TextBox FIRSTNAME;
        private Label label2;
        private TextBox MI;
        private Label label3;
        private TextBox GENDER;
        private Label label4;
        private TextBox LASTNAME;
        private Label label5;
        private TextBox POSITION;
        private Label label6;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button UPDATE;
        private Button btn_delete;
        private Label label7;
        private Button button3;
    }
}