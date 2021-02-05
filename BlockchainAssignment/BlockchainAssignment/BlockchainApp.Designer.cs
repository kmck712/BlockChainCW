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
            this.transactionBox = new System.Windows.Forms.Button();
            this.amountText = new System.Windows.Forms.TextBox();
            this.fee = new System.Windows.Forms.TextBox();
            this.amountLab = new System.Windows.Forms.Label();
            this.feeLab = new System.Windows.Forms.Label();
            this.recipientBox = new System.Windows.Forms.TextBox();
            this.RecipientLab = new System.Windows.Forms.Label();
            this.createBut = new System.Windows.Forms.Button();
            this.printAll = new System.Windows.Forms.Button();
            this.transactionsBut = new System.Windows.Forms.Button();
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
            this.textBox1.Location = new System.Drawing.Point(77, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "please add text here";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print Block";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // walletButton
            // 
            this.walletButton.Location = new System.Drawing.Point(606, 351);
            this.walletButton.Name = "walletButton";
            this.walletButton.Size = new System.Drawing.Size(74, 41);
            this.walletButton.TabIndex = 3;
            this.walletButton.Text = "Create Wallet";
            this.walletButton.UseVisualStyleBackColor = true;
            this.walletButton.Click += new System.EventHandler(this.walletButton_Click);
            // 
            // privateBox
            // 
            this.privateBox.Location = new System.Drawing.Point(249, 344);
            this.privateBox.Name = "privateBox";
            this.privateBox.Size = new System.Drawing.Size(351, 20);
            this.privateBox.TabIndex = 4;
            // 
            // publicBox
            // 
            this.publicBox.Location = new System.Drawing.Point(249, 381);
            this.publicBox.Name = "publicBox";
            this.publicBox.Size = new System.Drawing.Size(351, 20);
            this.publicBox.TabIndex = 5;
            // 
            // priLab
            // 
            this.priLab.AutoSize = true;
            this.priLab.Location = new System.Drawing.Point(246, 328);
            this.priLab.Name = "priLab";
            this.priLab.Size = new System.Drawing.Size(60, 13);
            this.priLab.TabIndex = 6;
            this.priLab.Text = "Private key";
            // 
            // pubLab
            // 
            this.pubLab.AutoSize = true;
            this.pubLab.Location = new System.Drawing.Point(250, 365);
            this.pubLab.Name = "pubLab";
            this.pubLab.Size = new System.Drawing.Size(56, 13);
            this.pubLab.TabIndex = 7;
            this.pubLab.Text = "Public key";
            // 
            // valWal
            // 
            this.valWal.Location = new System.Drawing.Point(606, 405);
            this.valWal.Name = "valWal";
            this.valWal.Size = new System.Drawing.Size(87, 25);
            this.valWal.TabIndex = 8;
            this.valWal.Text = "Validate Wallet";
            this.valWal.UseVisualStyleBackColor = true;
            this.valWal.Click += new System.EventHandler(this.valWal_Click);
            // 
            // transactionBox
            // 
            this.transactionBox.Location = new System.Drawing.Point(0, 419);
            this.transactionBox.Name = "transactionBox";
            this.transactionBox.Size = new System.Drawing.Size(87, 59);
            this.transactionBox.TabIndex = 9;
            this.transactionBox.Text = "Create transaction";
            this.transactionBox.UseVisualStyleBackColor = true;
            this.transactionBox.Click += new System.EventHandler(this.transactionBox_Click);
            // 
            // amountText
            // 
            this.amountText.Location = new System.Drawing.Point(93, 419);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(100, 20);
            this.amountText.TabIndex = 10;
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(93, 458);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(100, 20);
            this.fee.TabIndex = 11;
            // 
            // amountLab
            // 
            this.amountLab.AutoSize = true;
            this.amountLab.Location = new System.Drawing.Point(90, 403);
            this.amountLab.Name = "amountLab";
            this.amountLab.Size = new System.Drawing.Size(43, 13);
            this.amountLab.TabIndex = 12;
            this.amountLab.Text = "Amount";
            this.amountLab.Click += new System.EventHandler(this.label1_Click);
            // 
            // feeLab
            // 
            this.feeLab.AutoSize = true;
            this.feeLab.Location = new System.Drawing.Point(93, 442);
            this.feeLab.Name = "feeLab";
            this.feeLab.Size = new System.Drawing.Size(25, 13);
            this.feeLab.TabIndex = 13;
            this.feeLab.Text = "Fee";
            // 
            // recipientBox
            // 
            this.recipientBox.Location = new System.Drawing.Point(249, 449);
            this.recipientBox.Name = "recipientBox";
            this.recipientBox.Size = new System.Drawing.Size(351, 20);
            this.recipientBox.TabIndex = 14;
            // 
            // RecipientLab
            // 
            this.RecipientLab.AutoSize = true;
            this.RecipientLab.Location = new System.Drawing.Point(250, 433);
            this.RecipientLab.Name = "RecipientLab";
            this.RecipientLab.Size = new System.Drawing.Size(73, 13);
            this.RecipientLab.TabIndex = 15;
            this.RecipientLab.Text = "Recipient Key";
            // 
            // createBut
            // 
            this.createBut.Location = new System.Drawing.Point(0, 357);
            this.createBut.Name = "createBut";
            this.createBut.Size = new System.Drawing.Size(71, 47);
            this.createBut.TabIndex = 16;
            this.createBut.Text = "create Block";
            this.createBut.UseVisualStyleBackColor = true;
            this.createBut.Click += new System.EventHandler(this.createBut_Click);
            // 
            // printAll
            // 
            this.printAll.Location = new System.Drawing.Point(186, 329);
            this.printAll.Name = "printAll";
            this.printAll.Size = new System.Drawing.Size(54, 23);
            this.printAll.TabIndex = 17;
            this.printAll.Text = "Print All";
            this.printAll.UseVisualStyleBackColor = true;
            this.printAll.Click += new System.EventHandler(this.printAll_Click);
            // 
            // transactionsBut
            // 
            this.transactionsBut.Location = new System.Drawing.Point(77, 357);
            this.transactionsBut.Name = "transactionsBut";
            this.transactionsBut.Size = new System.Drawing.Size(90, 47);
            this.transactionsBut.TabIndex = 18;
            this.transactionsBut.Text = "All pending transactions";
            this.transactionsBut.UseVisualStyleBackColor = true;
            this.transactionsBut.Click += new System.EventHandler(this.transactionsBut_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 481);
            this.Controls.Add(this.transactionsBut);
            this.Controls.Add(this.printAll);
            this.Controls.Add(this.createBut);
            this.Controls.Add(this.RecipientLab);
            this.Controls.Add(this.recipientBox);
            this.Controls.Add(this.feeLab);
            this.Controls.Add(this.amountLab);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.transactionBox);
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
        private System.Windows.Forms.Button transactionBox;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.Label amountLab;
        private System.Windows.Forms.Label feeLab;
        private System.Windows.Forms.TextBox recipientBox;
        private System.Windows.Forms.Label RecipientLab;
        private System.Windows.Forms.Button createBut;
        private System.Windows.Forms.Button printAll;
        private System.Windows.Forms.Button transactionsBut;
    }
}

