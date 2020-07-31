
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("bmw", "m3", 6.5, 60);
        }


        [Test]
        public void ConstructorShouldMakeTheCarCorectly()
        {
            var car2 = new Car("bmw", "m3", 6.5, 60);

            Assert.AreEqual(car.Make, car2.Make);
            Assert.AreEqual(car.Model, car2.Model);
            Assert.AreEqual(car.FuelConsumption, car2.FuelConsumption);
            Assert.AreEqual(car.FuelCapacity, car2.FuelCapacity);
        }

        [Test]
        [TestCase("", "m3", 6, 50)]
        [TestCase(null, "m3", 6, 50)]
        [TestCase("bmw", "", 6, 50)]
        [TestCase("bmw", null, 6, 50)]
        [TestCase("bmw", "m3", 0, 50)]
        [TestCase("bmw", "m3", -200, 50)]
        [TestCase("bmw", "m3", 6, 0)]
        [TestCase("bmw", "m3", 6, -20)]
        public void ExceptionWithWrongInput(string make, string model, double consuption, double capacity)
        {
            Assert.Throws<ArgumentException>(() => { car = new Car(make, model, consuption, capacity); });
        }

        //Method Tests
        [Test]
        public void IsItRefulingCorectly()
        {
            car = new Car("bmw", "m3", 6, 55);
            car.Refuel(10);
            var expAmount = 10;
            var actualAmount = car.FuelAmount;

            Assert.AreEqual(expAmount, actualAmount);

        }

        [Test]
        public void IsItRefulingWithMOreThanTheCapcity()
        {
            car = new Car("bmw", "m3", 10, 50);
            car.Refuel(60);

            var expected = 50;
            var actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        [TestCase(null)]
        [TestCase(-15)]
        public void ShouldThrowExceptionWithNegativeOrZeroRefuel(double refuel)
        {
            Assert.Throws<ArgumentException>(() => { car.Refuel(refuel); });
        }

        [Test]
        public void TestingDrivingMethod()
        {
            this.car.Refuel(60);
            this.car.Drive(10);
            double expectedFuelAmount = 59.35;

            Assert.AreEqual(expectedFuelAmount, this.car.FuelAmount);

        }

        [Test]
        [TestCase(6000)]
        public void ShouldThrowExceptionWithNegativeOrBiggerDistance(double distance)
        {

            Assert.Throws<InvalidOperationException>(()=> { car.Drive(distance); });
        }



    }
}