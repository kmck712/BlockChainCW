using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        List<Block> Blocks = new List<Block>();
        List<transcations> transactionPool = new List<transcations>();

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
            Blocks.Add(new Block(lastHash, lastInx, sendingPool, minerAddress));
        }

        public List<transcations> getTransactions() 
        {
            List<transcations> sending = new List<transcations>();
            if (transactionPool.Count == 0)
            {
                
            }
            else if(transactionPool.Count < 5)
            {
                int count = transactionPool.Count;
                for (int i = 0;  i < count; i++)
                {
                    sending.Add(transactionPool[0]);
                    transactionPool.RemoveAt(0);

                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    sending.Add(transactionPool[0]);
                    transactionPool.RemoveAt(0);
                }
            }
            return sending;
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

        public int getTransactionnum()
        {
            return transactionPool.Count;
        }
    }
}
