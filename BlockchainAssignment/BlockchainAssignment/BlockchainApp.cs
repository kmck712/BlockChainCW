using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;
        Wallet.Wallet newWallet;
        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();
            richTextBox1.Text = blockchain.getInfo(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            int blockInp = Convert.ToInt32(textBox1.Text);
            
            richTextBox1.Text = blockchain.getInfo(blockInp);
        }

        private void walletButton_Click(object sender, EventArgs e)
        {
            
            String privKey;
            newWallet = new Wallet.Wallet(out privKey);
            String publicKey = newWallet.publicID;
            privateBox.Text = privKey;
            publicBox.Text = publicKey;

        }

        private void valWal_Click(object sender, EventArgs e)
        {
            bool result  = Wallet.Wallet.ValidatePrivateKey(privateBox.Text, publicBox.Text);
            richTextBox1.Text = " the keys are " + result;
        }

        private void transactionBox_Click(object sender, EventArgs e)
        {
           transcations newTransaction = new transcations(publicBox.Text, recipientBox.Text, Convert.ToDouble(amountText.Text), Convert.ToDouble(fee.Text), privateBox.Text);
            richTextBox1.Text = newTransaction.getInfo();
            blockchain.addTransactionPool(newTransaction);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createBut_Click(object sender, EventArgs e)
        {
             blockchain.newBlock(recipientBox.Text);
            richTextBox1.Text = blockchain.getMostRecentBlock();

        }

        private void printAll_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.getAllInfo();
        }

        private void transactionsBut_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.printTransactions();
        }

    }
}
