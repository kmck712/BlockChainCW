using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BlockchainAssignment
{
    
    class transcations
    {
        String hash;
        String signiture;
        String senderAdd;
        String recipientAdd;
        DateTime timeStamp;
        double amount;
        double fee;

        public transcations(string senderAdd, String recipientAdd, double amount, double fee, String privateKey)
        {
            this.senderAdd = senderAdd;
            this.recipientAdd = recipientAdd;
            this.amount = amount;
            timeStamp = DateTime.Now;
            this.fee = fee;
            hash = createHash();
            signiture = Wallet.Wallet.CreateSignature(senderAdd, privateKey, hash);

        }

        public String getInfo()
        {
            String info = "Transaction Hash:" + hash +
                "\nDigital Signiture: " + signiture +
                "\nTimeStamp: " + timeStamp +
                "\nTransfered: " + amount + " coins" +
                "\nFees: " + fee +
                "\nSender Address: " + senderAdd +
                "\nRecipient Addres: " + recipientAdd;
            return info;
        }
        private string createHash()
        {
            SHA256 hasher;
            hasher = SHA256Managed.Create();
            String input = senderAdd + recipientAdd + timeStamp.ToString() + amount.ToString() +fee.ToString();
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes((input)));

            String hash = string.Empty;

            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;
        }
    }
}
