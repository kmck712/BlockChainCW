namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.walletButton = new System.Windows.Forms.Button();
            this.privateBox = new System.Windows.Forms.TextBox();
            this.publicBox = new System.Windows.Forms.TextBox();
            this.priLab = new System.Windows.Forms.Label();
            this.pubLab = new System.Windows.Forms.Label();
            this.valWal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(657, 314);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "please add text here";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print Block";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // walletButton
            // 
            this.walletButton.Location = new System.Drawing.Point(593, 358);
            this.walletButton.Name = "walletButton";
            this.walletButton.Size = new System.Drawing.Size(87, 59);
            this.walletButton.TabIndex = 3;
            this.walletButton.Text = "Create Wallet";
            this.walletButton.UseVisualStyleBackColor = true;
            this.walletButton.Click += new System.EventHandler(this.walletButton_Click);
            // 
            // privateBox
            // 
            this.privateBox.Location = new System.Drawing.Point(236, 358);
            this.privateBox.Name = "privateBox";
            this.privateBox.Size = new System.Drawing.Size(351, 20);
            this.privateBox.TabIndex = 4;
            // 
            // publicBox
            // 
            this.publicBox.Location = new System.Drawing.Point(236, 397);
            this.publicBox.Name = "publicBox";
            this.publicBox.Size = new System.Drawing.Size(351, 20);
            this.publicBox.TabIndex = 5;
            // 
            // priLab
            // 
            this.priLab.AutoSize = true;
            this.priLab.Location = new System.Drawing.Point(233, 337);
            this.priLab.Name = "priLab";
            this.priLab.Size = new System.Drawing.Size(60, 13);
            this.priLab.TabIndex = 6;
            this.priLab.Text = "Private key";
            // 
            // pubLab
            // 
            this.pubLab.AutoSize = true;
            this.pubLab.Location = new System.Drawing.Point(237, 381);
            this.pubLab.Name = "pubLab";
            this.pubLab.Size = new System.Drawing.Size(56, 13);
            this.pubLab.TabIndex = 7;
            this.pubLab.Text = "Public key";
            // 
            // valWal
            // 
            this.valWal.Location = new System.Drawing.Point(301, 423);
            this.valWal.Name = "valWal";
            this.valWal.Size = new System.Drawing.Size(148, 25);
            this.valWal.TabIndex = 8;
            this.valWal.Text = "Validate Wallet";
            this.valWal.UseVisualStyleBackColor = true;
            this.valWal.Click += new System.EventHandler(this.valWal_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 481);
            this.Controls.Add(this.valWal);
            this.Controls.Add(this.pubLab);
            this.Controls.Add(this.priLab);
            this.Controls.Add(this.publicBox);
            this.Controls.Add(this.privateBox);
            this.Controls.Add(this.walletButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button walletButton;
        private System.Windows.Forms.TextBox privateBox;
        private System.Windows.Forms.TextBox publicBox;
        private System.Windows.Forms.Label priLab;
        private System.Windows.Forms.Label pubLab;
        private System.Windows.Forms.Button valWal;
    }
}

