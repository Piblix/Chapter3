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
            this.JoeGivesToBob = new System.Windows.Forms.Button();
            this.BobGivesToJoe = new System.Windows.Forms.Button();
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
            this.giveButton.Location = new System.Drawing.Point(45, 203);
            this.giveButton.Name = "giveButton";
            this.giveButton.Size = new System.Drawing.Size(184, 44);
            this.giveButton.TabIndex = 5;
            this.giveButton.Text = "Give $ 10 to Joe";
            this.giveButton.UseVisualStyleBackColor = true;
            this.giveButton.Click += new System.EventHandler(this.GiveButton_Click);
            // 
            // ReceiveButton
            // 
            this.ReceiveButton.Location = new System.Drawing.Point(303, 203);
            this.ReceiveButton.Name = "ReceiveButton";
            this.ReceiveButton.Size = new System.Drawing.Size(181, 43);
            this.ReceiveButton.TabIndex = 6;
            this.ReceiveButton.Text = "Recieve 5$ from Bob";
            this.ReceiveButton.UseVisualStyleBackColor = true;
            this.ReceiveButton.Click += new System.EventHandler(this.ReceiveButton_Click);
            // 
            // JoeGivesToBob
            // 
            this.JoeGivesToBob.Location = new System.Drawing.Point(45, 270);
            this.JoeGivesToBob.Name = "JoeGivesToBob";
            this.JoeGivesToBob.Size = new System.Drawing.Size(184, 38);
            this.JoeGivesToBob.TabIndex = 7;
            this.JoeGivesToBob.Text = "Jo gives $10 to Bob";
            this.JoeGivesToBob.UseVisualStyleBackColor = true;
            this.JoeGivesToBob.Click += new System.EventHandler(this.JoeGivesToBob_Click);
            // 
            // BobGivesToJoe
            // 
            this.BobGivesToJoe.Location = new System.Drawing.Point(303, 270);
            this.BobGivesToJoe.Name = "BobGivesToJoe";
            this.BobGivesToJoe.Size = new System.Drawing.Size(180, 38);
            this.BobGivesToJoe.TabIndex = 8;
            this.BobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.BobGivesToJoe.UseVisualStyleBackColor = true;
            this.BobGivesToJoe.Click += new System.EventHandler(this.BobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 335);
            this.Controls.Add(this.BobGivesToJoe);
            this.Controls.Add(this.JoeGivesToBob);
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
        private System.Windows.Forms.Button JoeGivesToBob;
        private System.Windows.Forms.Button BobGivesToJoe;
    }
}

