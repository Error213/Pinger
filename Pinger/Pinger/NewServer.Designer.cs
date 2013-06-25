namespace Pinger
{
    partial class NewServer
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
            this.btnServerOK = new System.Windows.Forms.Button();
            this.btnServerCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxServerName = new System.Windows.Forms.TextBox();
            this.txtbxServerIP = new System.Windows.Forms.TextBox();
            this.comboBoxGame = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnServerOK
            // 
            this.btnServerOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnServerOK.Location = new System.Drawing.Point(116, 157);
            this.btnServerOK.Name = "btnServerOK";
            this.btnServerOK.Size = new System.Drawing.Size(75, 23);
            this.btnServerOK.TabIndex = 0;
            this.btnServerOK.Text = "OK";
            this.btnServerOK.UseVisualStyleBackColor = true;
            // 
            // btnServerCancel
            // 
            this.btnServerCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnServerCancel.Location = new System.Drawing.Point(197, 157);
            this.btnServerCancel.Name = "btnServerCancel";
            this.btnServerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnServerCancel.TabIndex = 1;
            this.btnServerCancel.Text = "Cancel";
            this.btnServerCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP/DNS: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game: ";
            // 
            // txtbxServerName
            // 
            this.txtbxServerName.Location = new System.Drawing.Point(116, 18);
            this.txtbxServerName.Name = "txtbxServerName";
            this.txtbxServerName.Size = new System.Drawing.Size(156, 20);
            this.txtbxServerName.TabIndex = 5;
            // 
            // txtbxServerIP
            // 
            this.txtbxServerIP.Location = new System.Drawing.Point(116, 65);
            this.txtbxServerIP.Name = "txtbxServerIP";
            this.txtbxServerIP.Size = new System.Drawing.Size(156, 20);
            this.txtbxServerIP.TabIndex = 6;
            // 
            // comboBoxGame
            // 
            this.comboBoxGame.FormattingEnabled = true;
            this.comboBoxGame.Location = new System.Drawing.Point(116, 109);
            this.comboBoxGame.Name = "comboBoxGame";
            this.comboBoxGame.Size = new System.Drawing.Size(156, 21);
            this.comboBoxGame.TabIndex = 7;
            // 
            // NewServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.comboBoxGame);
            this.Controls.Add(this.txtbxServerIP);
            this.Controls.Add(this.txtbxServerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServerCancel);
            this.Controls.Add(this.btnServerOK);
            this.Name = "NewServer";
            this.Text = "NewServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewServer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServerOK;
        private System.Windows.Forms.Button btnServerCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxServerName;
        private System.Windows.Forms.TextBox txtbxServerIP;
        private System.Windows.Forms.ComboBox comboBoxGame;
    }
}