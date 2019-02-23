using NUnit.Framework;
using NSubstitute;
using System.Collections.Generic;
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

        public void Test2()
        {
            //ARRANGE
            IClient c = Substitute.For<IClient>();
            IOrderDAO y = Substitute.For<IOrderDAO>();
            IFlowerDAO f = Substitute.For<IFlowerDAO>();
            Flower ff = new Flower (f, "daisy", 60, 6);
            List<Flower> fl = new List <Flower>();
            fl.Add(ff);
            IOrder o = new Order(y, c, false);

            //ACT
            double price = o.Price;

            //ASSERT
            //y.Price(Arg.Any<IOrder>())
            //o.Price = 72;
            Assert.AreEqual(o.Price, 72);
            

            //Assert.Pass();
        }
    }
}