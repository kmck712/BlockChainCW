using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BlockchainAssignment
{
    class Block
    {
        DateTime creationT;
        int positionInx;
        String currentHash; //block o is the current hash. block 1 is the pervious hash
        String previousHash;
        public Block(String lastHash, int lastInx)
        {
            creationT = DateTime.Now;
            positionInx = lastInx;
            previousHash = lastHash;
            currentHash = createHash();

        }
        public Block()
        {
            creationT = DateTime.Now;
            positionInx = 0;
            previousHash = "";
            currentHash = createHash();
        }

        private String createHash()
        {
            SHA256 hasher;
            hasher = SHA256Managed.Create();
            String input = positionInx.ToString() + creationT.ToString() + previousHash;
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes((input)));

            String hash = string.Empty;

            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;

        }
        public String getInfo()
        {
            String info = "Date Created: " + creationT 
                + "\nBlock Index: " + positionInx 
                + "\nHash: " + currentHash
                + "\nPrevious Hash" + previousHash;
            return info;
        }
    }

}
