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
            this.okButton = new System.Windows.Forms.Button();
            this.creationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(12, 25);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(272, 20);
            this.nameTextbox.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(209, 51);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 86);
            this.Controls.Add(this.creationLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nameTextbox);
            this.Name = "MainWindow";
            this.Text = "Blurryluna";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label creationLabel;
    }
}

