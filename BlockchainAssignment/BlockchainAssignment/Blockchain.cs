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

        public Blockchain()
        {
            Blocks.Add(new Block());
        }
        public String getInfo(int id)
        {
            return Blocks[id].getInfo();
        }
    }
}
