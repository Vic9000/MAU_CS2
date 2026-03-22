namespace Assignment2
{
    partial class MammalView
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
            grpMammalData = new GroupBox();
            label2 = new Label();
            txtTail = new TextBox();
            label1 = new Label();
            txtTeeth = new TextBox();
            grpSpecific = new GroupBox();
            cmbCatFur = new ComboBox();
            lblSpecific = new Label();
            txtBreed = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            grpMammalData.SuspendLayout();
            grpSpecific.SuspendLayout();
            SuspendLayout();
            // 
            // grpMammalData
            // 
            grpMammalData.Controls.Add(label2);
            grpMammalData.Controls.Add(txtTail);
            grpMammalData.Controls.Add(label1);
            grpMammalData.Controls.Add(txtTeeth);
            grpMammalData.Location = new Point(12, 12);
            grpMammalData.Name = "grpMammalData";
            grpMammalData.Size = new Size(239, 82);
            grpMammalData.TabIndex = 0;
            grpMammalData.TabStop = false;
            grpMammalData.Text = "General Mammal Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Tail Length";
            // 
            // txtTail
            // 
            txtTail.Location = new Point(143, 51);
            txtTail.Name = "txtTail";
            txtTail.Size = new Size(90, 23);
            txtTail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of Teeth";
            // 
            // txtTeeth
            // 
            txtTeeth.Location = new Point(143, 22);
            txtTeeth.Name = "txtTeeth";
            txtTeeth.Size = new Size(90, 23);
            txtTeeth.TabIndex = 0;
            // 
            // grpSpecific
            // 
            grpSpecific.Controls.Add(cmbCatFur);
            grpSpecific.Controls.Add(lblSpecific);
            grpSpecific.Controls.Add(txtBreed);
            grpSpecific.Location = new Point(12, 100);
            grpSpecific.Name = "grpSpecific";
            grpSpecific.Size = new Size(239, 57);
            grpSpecific.TabIndex = 1;
            grpSpecific.TabStop = false;
            grpSpecific.Text = "Specific Data for Dog";
            // 
            // cmbCatFur
            // 
            cmbCatFur.FormattingEnabled = true;
            cmbCatFur.Location = new Point(94, 22);
            cmbCatFur.Name = "cmbCatFur";
            cmbCatFur.Size = new Size(139, 23);
            cmbCatFur.TabIndex = 2;
            // 
            // lblSpecific
            // 
            lblSpecific.AutoSize = true;
            lblSpecific.Location = new Point(6, 25);
            lblSpecific.Name = "lblSpecific";
            lblSpecific.Size = new Size(37, 15);
            lblSpecific.TabIndex = 1;
            lblSpecific.Text = "Breed";
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(49, 22);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(184, 23);
            txtBreed.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(49, 172);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(155, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // MammalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 207);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(grpSpecific);
            Controls.Add(grpMammalData);
            Name = "MammalView";
            Text = "Mammal View";
            Load += MammalView_Load;
            grpMammalData.ResumeLayout(false);
            grpMammalData.PerformLayout();
            grpSpecific.ResumeLayout(false);
            grpSpecific.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMammalData;
        private Label label2;
        private TextBox txtTail;
        private Label label1;
        private TextBox txtTeeth;
        private GroupBox grpSpecific;
        private TextBox txtBreed;
        private ComboBox cmbCatFur;
        private Label lblSpecific;
        private Button btnOk;
        private Button btnCancel;
    }
}