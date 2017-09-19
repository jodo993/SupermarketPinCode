namespace SupermarketCodeFlashCards
{
    partial class Menu
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
            this.flashCardModeButton = new System.Windows.Forms.Button();
            this.pinModeButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flashCardModeButton
            // 
            this.flashCardModeButton.Location = new System.Drawing.Point(221, 14);
            this.flashCardModeButton.Name = "flashCardModeButton";
            this.flashCardModeButton.Size = new System.Drawing.Size(75, 41);
            this.flashCardModeButton.TabIndex = 0;
            this.flashCardModeButton.Text = "Flash Card Mode";
            this.flashCardModeButton.UseVisualStyleBackColor = true;
            this.flashCardModeButton.Visible = false;
            this.flashCardModeButton.Click += new System.EventHandler(this.flashCardModeButton_Click);
            // 
            // pinModeButton
            // 
            this.pinModeButton.Location = new System.Drawing.Point(73, 70);
            this.pinModeButton.Name = "pinModeButton";
            this.pinModeButton.Size = new System.Drawing.Size(75, 50);
            this.pinModeButton.TabIndex = 1;
            this.pinModeButton.Text = "PIN Mode";
            this.pinModeButton.UseVisualStyleBackColor = true;
            this.pinModeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(154, 70);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 50);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick An Option:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.pinModeButton);
            this.Controls.Add(this.flashCardModeButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button flashCardModeButton;
        private System.Windows.Forms.Button pinModeButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label label1;
    }
}