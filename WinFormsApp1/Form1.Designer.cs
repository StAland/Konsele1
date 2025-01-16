namespace WinFormsApp1
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
            btnConfirm = new Button();
            lblEingabe = new Label();
            txtEingabe = new TextBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(100, 250);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblEingabe
            // 
            lblEingabe.AutoSize = true;
            lblEingabe.Location = new Point(100, 100);
            lblEingabe.Name = "lblEingabe";
            lblEingabe.Size = new Size(112, 15);
            lblEingabe.TabIndex = 1;
            lblEingabe.Text = "Bitte Zahl eingeben:";
            // 
            // txtEingabe
            // 
            txtEingabe.Location = new Point(250, 100);
            txtEingabe.Name = "txtEingabe";
            txtEingabe.Size = new Size(100, 23);
            txtEingabe.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEingabe);
            Controls.Add(lblEingabe);
            Controls.Add(btnConfirm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Label lblEingabe;
        private TextBox txtEingabe;
    }
}
