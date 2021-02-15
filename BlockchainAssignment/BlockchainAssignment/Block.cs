using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
//using System.Diagnostics;

namespace BlockchainAssignment
{
    class Block
    {
        DateTime creationT;
        int positionInx;
        String currentHash; //block o is the current hash. block 1 is the pervious hash
        String previousHash;
        List<transcations> transactionList = new List<transcations>();
        int nonce;
        int difficulty;
        double rewards;
        double fees;
        String minerAddress;
        
        public Block(String lastHash, int lastInx, List<transcations> curentTrans,String  minerAddress)
        {
            creationT = DateTime.Now;
            positionInx = lastInx + 1;
            previousHash = lastHash;
            transactionList = curentTrans;
            difficulty = 4;
            nonce = 0;
            calcRewards();
            this.minerAddress = minerAddress;
            transcations transaction = new transcations("Mine Rewards", minerAddress,(rewards + fees), 0, "");
            transactionList.Add(transaction);
            mine();
        }
        public Block()
        {
            creationT = DateTime.Now;
            positionInx = 0;
            previousHash = "";
            difficulty = 4;
            nonce = 0;
            mine();
        }

        private String createHash()
        {
            SHA256 hasher;
            hasher = SHA256Managed.Create();
            String input = positionInx.ToString() + creationT.ToString() + previousHash + nonce.ToString() + difficulty.ToString() + rewards.ToString();
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes((input)));

            String hash = string.Empty;

            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;

        }

        private void calcRewards()
        {
            foreach (transcations t in transactionList)
            {
                rewards += t.getAmount();
                fees += t.getFee();
            }
           
        }

        public String getInfo()
        {
            String info = "Date Created: " + creationT 
                + "\nBlock Index: " + positionInx 
                + "\nHash: " + currentHash
                + "\nPrevious Hash: " + previousHash 
                + "\nDifficulty: " + difficulty 
                + "\nNonce: " + nonce 
                + "\nRewards: " + rewards 
                + "\nFees: " + fees 
                + "\nMiner Address: " + minerAddress +"\n\n";
            for (int i = 0; i < transactionList.Count; i++)
            {
                info += "\n\n" + transactionList[i].getInfo();
            }
            return info;
        }
        public String getHash()
        {
            return currentHash;
        }
        public String getPreviousHash()
        {
            return previousHash;
        }
        public double getBalence(String pubKey)
        {
            double balence = 0.0;
            foreach (transcations i in transactionList)
            {
                if (i.getSenderAdd() == pubKey)
                {
                    balence -= i.getAmount();
                }
                else if (i.getRecipientAdd() == pubKey && i.getRecipientAdd() != "Mine Rewards")
                {
                    balence += i.getAmount();
                }
            }
            return balence;
        }
        public int getIndx()
        {
            return positionInx;
        }
        private void mine()
        {
            Boolean difficult = false;
            while (difficult == false)
            {
                currentHash = createHash();
                int count = 0;
                for (int i = 0; i < difficulty; i++)
                {
                    char c = currentHash[i];
                    if (c.Equals('0'))
                    {
                        count += 1;
                    }
                }
                if (count == difficulty)
                {
                    difficult = true;
                }
                else
                {
                    nonce++;
                }
            }
        }

        /*
         * 
        public String getTransactions()
        {
            String result = null;
            for (int i = 0; i < transactionList.Count; i++)
            {
                result += "\n" + transactionList[i].getInfo();
            }
           
            return result;
        }
        */
    }

}
