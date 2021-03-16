using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BlockchainAssignment
{
    class Blockchain
    {
        List<Block> Blocks = new List<Block>();
        List<transcations> transactionPool = new List<transcations>();

        int poolType;
        private String desiredAddress;

        public Blockchain()
        {
            Blocks.Add(new Block());
            
        }
       
        public String getInfo(int id)
        {
            return Blocks[id].getInfo();
        }
        public String getMostRecentBlock()
        {
            return getInfo(Blocks.Count - 1);
        }
        public void newBlock(String minerAddress)
        {
            int currentSize = Blocks.Count  -1 ;
            String lastHash = Blocks[currentSize].getHash();
            int lastInx = Blocks[currentSize].getIndx();

            List<transcations> sendingPool = getTransactions();
            if (poolType == 3)
            {
                foreach (transcations i in sendingPool)
                {
                    if (i.getSenderAdd() == desiredAddress)
                    {
                        Blocks.Add(new Block(lastHash, lastInx, sendingPool, minerAddress));
                        break;
                    }
                }
            }
            else
            {
                Blocks.Add(new Block(lastHash, lastInx, sendingPool, minerAddress));
            }
        }


        public List<transcations> getTransactions() 
        {
            List<transcations> sending = new List<transcations>();
            
            if (transactionPool.Count == 0)
            {
                
            }
            else if(transactionPool.Count < 1)
            {
                int count = transactionPool.Count;
                for (int i = 0;  i < count; i++)
                {
                    int pos = settings(poolType);
                    if (pos != -1)
                    {
                        sending.Add(transactionPool[pos]);
                        transactionPool.RemoveAt(pos);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 1; i++)
                {
                    int pos = settings(poolType);
                    if (pos != -1)
                    {
                        sending.Add(transactionPool[pos]);
                        transactionPool.RemoveAt(pos);
                    }
                }
            }
            return sending;
        }

        private int settings(int type)
        {
            switch (type)
            {
                case 0:
                    return altuAlgo();
                case 1:
                    return greedyAlgo();
                case 2:
                    return randAlgo();
                case 3:
                    return adressAlgo(desiredAddress);

            }
            return 0;
        }
        
        private int altuAlgo()
        {
            int highestInx = 0; 
            for (int i = 1; i < transactionPool.Count; i++)
            {
                if (DateTime.Compare(transactionPool[highestInx].getTimeStamp(),transactionPool[i].getTimeStamp())>0)
                {
                    highestInx = i;
                }
            }
            return highestInx;
        }

        private int greedyAlgo()
        {
            int highestInx = 0;
            for (int i = 1; i < transactionPool.Count; i++)
            {
                if (transactionPool[i].getFee() > transactionPool[highestInx].getFee())
                {
                    highestInx = i;
                }
            }
            return highestInx;
        }
        private int randAlgo()
        {
            Random rand = new Random();
            int randTran = rand.Next(0, transactionPool.Count);
            return randTran;
        }

        private int adressAlgo(String targetAdd)
        {
            int pos = -1;
            for (int i = 0; i < transactionPool.Count; i ++)
            {
                if (transactionPool[i].getSenderAdd() == targetAdd)
                {
                    pos = i;
                    return pos;
                }
            }
            return pos;
        }


        public String getAllInfo()
        {
            String results = null;
            for (int i = 0; i < Blocks.Count ; i++)
            {
                results += getInfo(i);
            }
            return results;
        }

        public void addTransactionPool (transcations newestTrans)
        {
            transactionPool.Add(newestTrans);
        
        }
        public string printTransactions()
        {
            string result = null;
            foreach (transcations t in transactionPool)
            {
                result +=  t.getInfo() + "\n";
            }
            return result;
        }
        public double clacBalence(String pubKey)
        {
            double balence = 0.0;
            foreach (Block i in Blocks)
            {
                balence += i.getBalence( pubKey);
            }
            return balence;
        }

        public int getTransactionnum()
        {
            return transactionPool.Count;
        }
        public int getSetType() { return poolType; }

        public void setAlgType(int type)
        {
            poolType = type;
        }

        public void setDesiredAddress(String add)
        {
            desiredAddress = add;
        }

        public bool validate()
        {
            bool valid = true;
            for (int i = 0; i < Blocks.Count - 1; i++)
            {
                if (Blocks[i].getHash() != Blocks[i + 1].getPreviousHash())
                {
                    valid = false;
                }
            }
            return valid;
        }
    }
}
