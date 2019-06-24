namespace GuysMoney
{
    partial class Form1
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
            this.joeText = new System.Windows.Forms.TextBox();
            this.bobText = new System.Windows.Forms.TextBox();
            this.bankText = new System.Windows.Forms.TextBox();
            this.giveButton = new System.Windows.Forms.Button();
            this.ReceiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeText
            // 
            this.joeText.BackColor = System.Drawing.SystemColors.Control;
            this.joeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.joeText.Location = new System.Drawing.Point(45, 32);
            this.joeText.Name = "joeText";
            this.joeText.Size = new System.Drawing.Size(224, 13);
            this.joeText.TabIndex = 2;
            // 
            // bobText
            // 
            this.bobText.BackColor = System.Drawing.SystemColors.Control;
            this.bobText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bobText.Location = new System.Drawing.Point(45, 72);
            this.bobText.Name = "bobText";
            this.bobText.Size = new System.Drawing.Size(224, 13);
            this.bobText.TabIndex = 3;
            // 
            // bankText
            // 
            this.bankText.BackColor = System.Drawing.SystemColors.Control;
            this.bankText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bankText.Location = new System.Drawing.Point(45, 116);
            this.bankText.Name = "bankText";
            this.bankText.Size = new System.Drawing.Size(224, 13);
            this.bankText.TabIndex = 4;
            // 
            // giveButton
            // 
            this.giveButton.Location = new System.Drawing.Point(55, 203);
            this.giveButton.Name = "giveButton";
            this.giveButton.Size = new System.Drawing.Size(184, 44);
            this.giveButton.TabIndex = 5;
            this.giveButton.Text = "Give $ 10 to Joe";
            this.giveButton.UseVisualStyleBackColor = true;
            // 
            // ReceiveButton
            // 
            this.ReceiveButton.Location = new System.Drawing.Point(291, 203);
            this.ReceiveButton.Name = "ReceiveButton";
            this.ReceiveButton.Size = new System.Drawing.Size(181, 43);
            this.ReceiveButton.TabIndex = 6;
            this.ReceiveButton.Text = "Recieve 5$ from Bob";
            this.ReceiveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 301);
            this.Controls.Add(this.ReceiveButton);
            this.Controls.Add(this.giveButton);
            this.Controls.Add(this.bankText);
            this.Controls.Add(this.bobText);
            this.Controls.Add(this.joeText);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox joeText;
        private System.Windows.Forms.TextBox bobText;
        private System.Windows.Forms.TextBox bankText;
        private System.Windows.Forms.Button giveButton;
        private System.Windows.Forms.Button ReceiveButton;
    }
}

