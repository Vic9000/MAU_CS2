namespace Assignment1
{
    partial class MainForm
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
            grpCreate = new GroupBox();
            lbxSpecies = new ListBox();
            lbxCategory = new ListBox();
            grpInput = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtWeight = new TextBox();
            cmbGender = new ComboBox();
            label1 = new Label();
            lblName = new Label();
            btnAdd = new Button();
            lbxInfo = new ListBox();
            lbx = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbxInfo2 = new ListBox();
            btnDelete = new Button();
            btnChange = new Button();
            grpCreate.SuspendLayout();
            grpInput.SuspendLayout();
            SuspendLayout();
            // 
            // grpCreate
            // 
            grpCreate.Controls.Add(lbxSpecies);
            grpCreate.Controls.Add(lbxCategory);
            grpCreate.Location = new Point(12, 12);
            grpCreate.Name = "grpCreate";
            grpCreate.Size = new Size(260, 192);
            grpCreate.TabIndex = 1;
            grpCreate.TabStop = false;
            grpCreate.Text = "Create Animal";
            // 
            // lbxSpecies
            // 
            lbxSpecies.FormattingEnabled = true;
            lbxSpecies.Location = new Point(132, 22);
            lbxSpecies.Name = "lbxSpecies";
            lbxSpecies.Size = new Size(120, 154);
            lbxSpecies.TabIndex = 2;
            lbxSpecies.SelectedIndexChanged += lbxSpecies_SelectedIndexChanged;
            // 
            // lbxCategory
            // 
            lbxCategory.FormattingEnabled = true;
            lbxCategory.Location = new Point(6, 22);
            lbxCategory.Name = "lbxCategory";
            lbxCategory.Size = new Size(120, 154);
            lbxCategory.TabIndex = 1;
            lbxCategory.SelectedIndexChanged += lbxCategory_SelectedIndexChanged_1;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(label3);
            grpInput.Controls.Add(label2);
            grpInput.Controls.Add(txtName);
            grpInput.Controls.Add(txtAge);
            grpInput.Controls.Add(txtWeight);
            grpInput.Controls.Add(cmbGender);
            grpInput.Controls.Add(label1);
            grpInput.Controls.Add(lblName);
            grpInput.Location = new Point(278, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(283, 155);
            grpInput.TabIndex = 3;
            grpInput.TabStop = false;
            grpInput.Text = "General Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Weight";
            // 
            // txtName
            // 
            txtName.Location = new Point(111, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 23);
            txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(177, 51);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(177, 80);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 3;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(177, 109);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(100, 23);
            cmbGender.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(6, 59);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Location = new Point(6, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(367, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbxInfo
            // 
            lbxInfo.FormattingEnabled = true;
            lbxInfo.Location = new Point(467, 216);
            lbxInfo.Name = "lbxInfo";
            lbxInfo.Size = new Size(157, 199);
            lbxInfo.TabIndex = 5;
            // 
            // lbx
            // 
            lbx.FormattingEnabled = true;
            lbx.Location = new Point(12, 231);
            lbx.Name = "lbx";
            lbx.Size = new Size(449, 184);
            lbx.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 213);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Species";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 213);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 8;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 213);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 9;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(320, 213);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 10;
            label7.Text = "Age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 213);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 11;
            label8.Text = "Weight";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(405, 213);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 12;
            label9.Text = "Gender";
            // 
            // lbxInfo2
            // 
            lbxInfo2.FormattingEnabled = true;
            lbxInfo2.Location = new Point(630, 216);
            lbxInfo2.Name = "lbxInfo2";
            lbxInfo2.Size = new Size(157, 199);
            lbxInfo2.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(255, 421);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(101, 421);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(111, 34);
            btnChange.TabIndex = 16;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 460);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(lbxInfo2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbx);
            Controls.Add(lbxInfo);
            Controls.Add(btnAdd);
            Controls.Add(grpInput);
            Controls.Add(grpCreate);
            Name = "MainForm";
            Text = "E-Animal Management System";
            grpCreate.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grpCreate;
        private ListBox lbxSpecies;
        private ListBox lbxCategory;
        private GroupBox grpInput;
        private Label label1;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtWeight;
        private ComboBox cmbGender;
        private Label label3;
        private Label label2;
        private Button btnAdd;
        private ListBox lbxInfo;
        private ListBox lbx;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox lbxInfo2;
        private Button btnDelete;
        private Button btnChange;
    }
}
