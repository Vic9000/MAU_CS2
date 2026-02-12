namespace Animal_Management
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
            btnCreate = new Button();
            grpCreate = new GroupBox();
            lbxSpecies = new ListBox();
            lbxCategory = new ListBox();
            panelInfo = new Panel();
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
            grpCreate.SuspendLayout();
            grpInput.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.ImageAlign = ContentAlignment.BottomCenter;
            btnCreate.Location = new Point(61, 184);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(121, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Animal";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // grpCreate
            // 
            grpCreate.Controls.Add(lbxSpecies);
            grpCreate.Controls.Add(lbxCategory);
            grpCreate.Controls.Add(btnCreate);
            grpCreate.Location = new Point(12, 27);
            grpCreate.Name = "grpCreate";
            grpCreate.Size = new Size(260, 213);
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
            // 
            // lbxCategory
            // 
            lbxCategory.FormattingEnabled = true;
            lbxCategory.Location = new Point(6, 22);
            lbxCategory.Name = "lbxCategory";
            lbxCategory.Size = new Size(120, 154);
            lbxCategory.TabIndex = 1;
            // 
            // panelInfo
            // 
            panelInfo.Location = new Point(278, 42);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(160, 198);
            panelInfo.TabIndex = 2;
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
            grpInput.Location = new Point(12, 246);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(260, 140);
            grpInput.TabIndex = 3;
            grpInput.TabStop = false;
            grpInput.Text = "General Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(6, 114);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Weight";
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(144, 23);
            txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(154, 53);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(154, 82);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 3;
            txtWeight.TextChanged += textBox1_TextChanged;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(154, 111);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(100, 23);
            cmbGender.TabIndex = 2;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Location = new Point(6, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(97, 392);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 450);
            Controls.Add(btnAdd);
            Controls.Add(grpInput);
            Controls.Add(panelInfo);
            Controls.Add(grpCreate);
            Name = "MainForm";
            Text = "E-Animal Management System";
            grpCreate.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreate;
        private GroupBox grpCreate;
        private ListBox lbxSpecies;
        private ListBox lbxCategory;
        private Panel panelInfo;
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
    }
}
