namespace Assignment3
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
            lbxAnimals = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnDelete = new Button();
            btnChange = new Button();
            lbxInfo2 = new ListBox();
            lblInfo1 = new Label();
            lblInfo2 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            lbxFilter = new ListBox();
            label10 = new Label();
            cmbFilter = new ComboBox();
            label11 = new Label();
            txtFilterAge = new TextBox();
            grpCreate.SuspendLayout();
            grpInput.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpCreate
            // 
            grpCreate.Controls.Add(lbxSpecies);
            grpCreate.Controls.Add(lbxCategory);
            grpCreate.Location = new Point(10, 30);
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
            // 
            // lbxCategory
            // 
            lbxCategory.FormattingEnabled = true;
            lbxCategory.Location = new Point(6, 22);
            lbxCategory.Name = "lbxCategory";
            lbxCategory.Size = new Size(120, 154);
            lbxCategory.TabIndex = 1;
            lbxCategory.SelectedIndexChanged += lbxCategory_SelectedIndexChanged;
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
            grpInput.Location = new Point(276, 30);
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
            btnAdd.Location = new Point(365, 191);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbxInfo
            // 
            lbxInfo.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxInfo.FormattingEnabled = true;
            lbxInfo.Location = new Point(406, 249);
            lbxInfo.Name = "lbxInfo";
            lbxInfo.Size = new Size(186, 186);
            lbxInfo.TabIndex = 5;
            // 
            // lbxAnimals
            // 
            lbxAnimals.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxAnimals.FormattingEnabled = true;
            lbxAnimals.Location = new Point(10, 249);
            lbxAnimals.Name = "lbxAnimals";
            lbxAnimals.Size = new Size(390, 186);
            lbxAnimals.TabIndex = 6;
            lbxAnimals.SelectedIndexChanged += lbxAnimals_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 231);
            label4.Name = "label4";
            label4.Size = new Size(56, 14);
            label4.TabIndex = 7;
            label4.Text = "Species";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 231);
            label5.Name = "label5";
            label5.Size = new Size(21, 14);
            label5.TabIndex = 8;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(115, 231);
            label6.Name = "label6";
            label6.Size = new Size(35, 14);
            label6.TabIndex = 9;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(221, 231);
            label7.Name = "label7";
            label7.Size = new Size(28, 14);
            label7.TabIndex = 10;
            label7.Text = "Age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(278, 231);
            label8.Name = "label8";
            label8.Size = new Size(49, 14);
            label8.TabIndex = 11;
            label8.Text = "Weight";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(334, 231);
            label9.Name = "label9";
            label9.Size = new Size(49, 14);
            label9.TabIndex = 12;
            label9.Text = "Gender";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(180, 439);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(45, 439);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(111, 34);
            btnChange.TabIndex = 16;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // lbxInfo2
            // 
            lbxInfo2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxInfo2.FormattingEnabled = true;
            lbxInfo2.Location = new Point(598, 249);
            lbxInfo2.Name = "lbxInfo2";
            lbxInfo2.Size = new Size(175, 186);
            lbxInfo2.TabIndex = 17;
            // 
            // lblInfo1
            // 
            lblInfo1.AutoSize = true;
            lblInfo1.Location = new Point(406, 230);
            lblInfo1.Name = "lblInfo1";
            lblInfo1.Size = new Size(69, 15);
            lblInfo1.TabIndex = 18;
            lblInfo1.Text = "Animal Info";
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Location = new Point(598, 230);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(128, 15);
            lblInfo2.TabIndex = 19;
            lblInfo2.Text = "Additional Information";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(787, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(112, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(112, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(112, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(112, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbxFilter
            // 
            lbxFilter.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxFilter.FormattingEnabled = true;
            lbxFilter.Location = new Point(600, 95);
            lbxFilter.Name = "lbxFilter";
            lbxFilter.Size = new Size(175, 116);
            lbxFilter.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(598, 30);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 22;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(600, 66);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(175, 23);
            cmbFilter.TabIndex = 23;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(598, 40);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 25;
            label11.Text = "Filter by";
            // 
            // txtFilterAge
            // 
            txtFilterAge.Location = new Point(673, 37);
            txtFilterAge.Name = "txtFilterAge";
            txtFilterAge.Size = new Size(100, 23);
            txtFilterAge.TabIndex = 26;
            txtFilterAge.TextChanged += txtFilterAge_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 485);
            Controls.Add(txtFilterAge);
            Controls.Add(label11);
            Controls.Add(cmbFilter);
            Controls.Add(label10);
            Controls.Add(lbxFilter);
            Controls.Add(lblInfo2);
            Controls.Add(lblInfo1);
            Controls.Add(lbxInfo2);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbxAnimals);
            Controls.Add(lbxInfo);
            Controls.Add(btnAdd);
            Controls.Add(grpInput);
            Controls.Add(grpCreate);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "E-Animal Management System";
            grpCreate.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ListBox lbxAnimals;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnDelete;
        private Button btnChange;
        private ListBox lbxInfo2;
        private Label lblInfo1;
        private Label lblInfo2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ListBox lbxFilter;
        private Label label10;
        private ComboBox cmbFilter;
        private Label label11;
        private TextBox txtFilterAge;
    }
}
