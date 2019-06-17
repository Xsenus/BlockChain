using System.Data.Entity;

namespace BlockChain
{
    class BlockchainContext : DbContext 
    {
        public BlockchainContext() : base("BlockchainConnection") { }

        public DbSet<Block> Blocks { get; set; }
    }
}
