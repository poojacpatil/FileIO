namespace WindowsFormsApp1
{
    partial class fomStudentLogin
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.textEmailId = new System.Windows.Forms.TextBox();
            this.textContactNumber = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(162, 284);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(395, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(170, 58);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(170, 113);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(44, 13);
            this.lblEmailId.TabIndex = 3;
            this.lblEmailId.Text = "Email Id";
            this.lblEmailId.Click += new System.EventHandler(this.lblEmailId_Click);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(170, 167);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number";
            this.lblContactNumber.Click += new System.EventHandler(this.lblContactNumber_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(170, 225);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(384, 60);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(160, 20);
            this.textFullName.TabIndex = 6;
            // 
            // textEmailId
            // 
            this.textEmailId.Location = new System.Drawing.Point(384, 110);
            this.textEmailId.Name = "textEmailId";
            this.textEmailId.Size = new System.Drawing.Size(160, 20);
            this.textEmailId.TabIndex = 7;
            // 
            // textContactNumber
            // 
            this.textContactNumber.Location = new System.Drawing.Point(384, 164);
            this.textContactNumber.Name = "textContactNumber";
            this.textContactNumber.Size = new System.Drawing.Size(160, 20);
            this.textContactNumber.TabIndex = 8;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(384, 218);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(160, 20);
            this.textAddress.TabIndex = 9;
            // 
            // fomStudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textContactNumber);
            this.Controls.Add(this.textEmailId);
            this.Controls.Add(this.textFullName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Name = "fomStudentLogin";
            this.Text = "Student Login";
            this.Load += new System.EventHandler(this.fomStudentLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.TextBox textEmailId;
        private System.Windows.Forms.TextBox textContactNumber;
        private System.Windows.Forms.TextBox textAddress;
    }
}