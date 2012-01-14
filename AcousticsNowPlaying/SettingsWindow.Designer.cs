namespace AcousticsNowPlaying {
    partial class SettingsWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.chkAskForPass = new System.Windows.Forms.CheckBox();
            this.chkShowExtra = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(176, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "Save";
            this.btnSave.Location = new System.Drawing.Point(95, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Base URL:";
            // 
            // txtServerBase
            // 
            this.txtServerBase.Location = new System.Drawing.Point(15, 25);
            this.txtServerBase.Name = "txtServerBase";
            this.txtServerBase.Size = new System.Drawing.Size(236, 20);
            this.txtServerBase.TabIndex = 3;
            this.txtServerBase.Text = "http://example.com/amp/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(15, 66);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(236, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // chkAskForPass
            // 
            this.chkAskForPass.AutoSize = true;
            this.chkAskForPass.Location = new System.Drawing.Point(15, 131);
            this.chkAskForPass.Name = "chkAskForPass";
            this.chkAskForPass.Size = new System.Drawing.Size(212, 17);
            this.chkAskForPass.TabIndex = 4;
            this.chkAskForPass.Text = "Ask for password when authenticating?";
            this.chkAskForPass.UseVisualStyleBackColor = true;
            // 
            // chkShowExtra
            // 
            this.chkShowExtra.AutoSize = true;
            this.chkShowExtra.Location = new System.Drawing.Point(15, 154);
            this.chkShowExtra.Name = "chkShowExtra";
            this.chkShowExtra.Size = new System.Drawing.Size(139, 17);
            this.chkShowExtra.TabIndex = 4;
            this.chkShowExtra.Text = "Show extra information?";
            this.chkShowExtra.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room:";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(15, 105);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(236, 20);
            this.txtRoom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(56, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "(blank for default)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 212);
            this.Controls.Add(this.chkShowExtra);
            this.Controls.Add(this.chkAskForPass);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox chkAskForPass;
        private System.Windows.Forms.CheckBox chkShowExtra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label4;
    }
}