namespace Pinger
{
    partial class NewGame
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
            this.btnGameOk = new System.Windows.Forms.Button();
            this.btnGameCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxGameName = new System.Windows.Forms.TextBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGameOk
            // 
            this.btnGameOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGameOk.Location = new System.Drawing.Point(116, 116);
            this.btnGameOk.Name = "btnGameOk";
            this.btnGameOk.Size = new System.Drawing.Size(75, 23);
            this.btnGameOk.TabIndex = 0;
            this.btnGameOk.Text = "OK";
            this.btnGameOk.UseVisualStyleBackColor = true;
            // 
            // btnGameCancel
            // 
            this.btnGameCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGameCancel.Location = new System.Drawing.Point(197, 116);
            this.btnGameCancel.Name = "btnGameCancel";
            this.btnGameCancel.Size = new System.Drawing.Size(75, 23);
            this.btnGameCancel.TabIndex = 1;
            this.btnGameCancel.Text = "Cancel";
            this.btnGameCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game Genre: ";
            // 
            // txtbxGameName
            // 
            this.txtbxGameName.Location = new System.Drawing.Point(116, 19);
            this.txtbxGameName.Name = "txtbxGameName";
            this.txtbxGameName.Size = new System.Drawing.Size(156, 20);
            this.txtbxGameName.TabIndex = 4;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(116, 66);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(156, 21);
            this.comboBoxGenre.TabIndex = 5;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.txtbxGameName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGameCancel);
            this.Controls.Add(this.btnGameOk);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewGame_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameOk;
        private System.Windows.Forms.Button btnGameCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxGameName;
        private System.Windows.Forms.ComboBox comboBoxGenre;



    }
}