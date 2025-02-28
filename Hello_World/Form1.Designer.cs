namespace Hello_World
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtFullName = new TextBox();
            lblFullName = new Label();
            btnSubmit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 17);
            txtFullName.MaxLength = 20;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(262, 26);
            txtFullName.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(295, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(167, 18);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "لطفا نام خود را وارد کنید :";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 58);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(122, 42);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 70);
            label1.Name = "label1";
            label1.Size = new Size(0, 18);
            label1.TabIndex = 3;
            // 
            // Form1
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 121);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello World";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private Label lblFullName;
        private Button btnSubmit;
        private Label label1;
    }
}
