namespace Blurryluna
{
    partial class MainWindow
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
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.creationLabel = new System.Windows.Forms.Label();
            this.dontsaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(12, 25);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(272, 20);
            this.nameTextbox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(209, 51);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // creationLabel
            // 
            this.creationLabel.AutoSize = true;
            this.creationLabel.Location = new System.Drawing.Point(12, 9);
            this.creationLabel.Name = "creationLabel";
            this.creationLabel.Size = new System.Drawing.Size(102, 13);
            this.creationLabel.TabIndex = 2;
            this.creationLabel.Text = "Name your creation:";
            // 
            // dontsaveButton
            // 
            this.dontsaveButton.Location = new System.Drawing.Point(128, 51);
            this.dontsaveButton.Name = "dontsaveButton";
            this.dontsaveButton.Size = new System.Drawing.Size(75, 23);
            this.dontsaveButton.TabIndex = 3;
            this.dontsaveButton.Text = "Don\'t Save";
            this.dontsaveButton.UseVisualStyleBackColor = true;
            this.dontsaveButton.Click += new System.EventHandler(this.dontsaveButton_Click);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.dontsaveButton;
            this.ClientSize = new System.Drawing.Size(296, 86);
            this.Controls.Add(this.dontsaveButton);
            this.Controls.Add(this.creationLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameTextbox);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blurryluna";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label creationLabel;
        private System.Windows.Forms.Button dontsaveButton;
    }
}

