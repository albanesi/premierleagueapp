using NUnit.Framework;
using Blyat23;

namespace Blyat23
{
    [TestFixture]
    public class Tests
    {
     
        [TestCase]
        public void GetName()
        {
            Player player = new Player("alban","selimi");
            Assert.IsTrue(true, "alban selimi",player.Fullname());
        }
    }
}