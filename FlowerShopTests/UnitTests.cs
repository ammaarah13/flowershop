using NUnit.Framework;
using NSubstitute;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //ARRANGE
            IClient c = Substitute.For<IClient>();
            IOrderDAO y = Substitute.For<IOrderDAO>();
            IOrder o = new Order (y,c,false);

            //ACT
            o.Deliver();

            //ASSERT
            y.SetDelivered(Arg.Any<IOrder>());

            //Assert.Pass();
        }
    }
}