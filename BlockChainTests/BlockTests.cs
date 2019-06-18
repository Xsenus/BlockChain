using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlockChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain.Tests
{
    [TestClass()]
    public class BlockTests
    {
        [TestMethod()]
        public void SerializeTest()
        {
            var bloc = new Block();
            var json = "{\"Created\":\"\\/Date(1535734800000+0700)\\/\",\"Data\":\"Hello World\",\"Hash\":\"0b86466cfa3fd5504ca33c9c9d86a48e3eed63ce1ac5ca413a996bc32d6c9ec1\",\"PreviousHash\":\"111111\",\"User\":\"Admin\"}";

            var resultString = bloc.Serialize();

            Assert.AreEqual(json, resultString);
        }

        [TestMethod()]
        public void DeserializeTest()
        {
            var bloc = new Block();
            var json = "{\"Created\":\"\\/Date(1535734800000+0700)\\/\",\"Data\":\"Hello World\",\"Hash\":\"0b86466cfa3fd5504ca33c9c9d86a48e3eed63ce1ac5ca413a996bc32d6c9ec1\",\"PreviousHash\":\"111111\",\"User\":\"Admin\"}";

            var resultBlock = Block.Deserialize(json);

            Assert.AreEqual(bloc.Hash, resultBlock.Hash);
            Assert.AreEqual(bloc.Created, resultBlock.Created);
            Assert.AreEqual(bloc.Data, resultBlock.Data);
            Assert.AreEqual(bloc.PreviousHash, resultBlock.PreviousHash);
            Assert.AreEqual(bloc.User, resultBlock.User);

        }
    }
}