namespace Assignment2
{
    partial class ReptileView
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
            grpGeneral = new GroupBox();
            txtLength = new TextBox();
            label1 = new Label();
            rbtnTrue = new RadioButton();
            rbtnFalse = new RadioButton();
            label2 = new Label();
            grpSpecific = new GroupBox();
            txtSpecific = new TextBox();
            lblSpecific = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            grpGeneral.SuspendLayout();
            grpSpecific.SuspendLayout();
            SuspendLayout();
            // 
            // grpGeneral
            // 
            grpGeneral.Controls.Add(label2);
            grpGeneral.Controls.Add(rbtnFalse);
            grpGeneral.Controls.Add(rbtnTrue);
            grpGeneral.Controls.Add(label1);
            grpGeneral.Controls.Add(txtLength);
            grpGeneral.Location = new Point(12, 12);
            grpGeneral.Name = "grpGeneral";
            grpGeneral.Size = new Size(220, 84);
            grpGeneral.TabIndex = 0;
            grpGeneral.TabStop = false;
            grpGeneral.Text = "General Reptile Data";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(114, 22);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Body Length";
            // 
            // rbtnTrue
            // 
            rbtnTrue.AutoSize = true;
            rbtnTrue.Location = new Point(114, 51);
            rbtnTrue.Name = "rbtnTrue";
            rbtnTrue.Size = new Size(42, 19);
            rbtnTrue.TabIndex = 3;
            rbtnTrue.TabStop = true;
            rbtnTrue.Text = "Yes";
            rbtnTrue.UseVisualStyleBackColor = true;
            // 
            // rbtnFalse
            // 
            rbtnFalse.AutoSize = true;
            rbtnFalse.Location = new Point(162, 51);
            rbtnFalse.Name = "rbtnFalse";
            rbtnFalse.Size = new Size(41, 19);
            rbtnFalse.TabIndex = 4;
            rbtnFalse.TabStop = true;
            rbtnFalse.Text = "No";
            rbtnFalse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 5;
            label2.Text = "Lives in Water";
            // 
            // grpSpecific
            // 
            grpSpecific.Controls.Add(lblSpecific);
            grpSpecific.Controls.Add(txtSpecific);
            grpSpecific.Location = new Point(12, 102);
            grpSpecific.Name = "grpSpecific";
            grpSpecific.Size = new Size(220, 54);
            grpSpecific.TabIndex = 1;
            grpSpecific.TabStop = false;
            grpSpecific.Text = "Specific Data for Lizard";
            // 
            // txtSpecific
            // 
            txtSpecific.Location = new Point(114, 22);
            txtSpecific.Name = "txtSpecific";
            txtSpecific.Size = new Size(100, 23);
            txtSpecific.TabIndex = 0;
            // 
            // lblSpecific
            // 
            lblSpecific.AutoSize = true;
            lblSpecific.Location = new Point(6, 25);
            lblSpecific.Name = "lblSpecific";
            lblSpecific.Size = new Size(64, 15);
            lblSpecific.TabIndex = 1;
            lblSpecific.Text = "Tail Length";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(23, 162);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(140, 162);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // LizardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 198);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(grpSpecific);
            Controls.Add(grpGeneral);
            Name = "LizardView";
            Text = "LizardView";
            grpGeneral.ResumeLayout(false);
            grpGeneral.PerformLayout();
            grpSpecific.ResumeLayout(false);
            grpSpecific.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpGeneral;
        private Label label2;
        private RadioButton rbtnFalse;
        private RadioButton rbtnTrue;
        private Label label1;
        private TextBox txtLength;
        private GroupBox grpSpecific;
        private Label lblSpecific;
        private TextBox txtSpecific;
        private Button btnOk;
        private Button btnCancel;
    }
}