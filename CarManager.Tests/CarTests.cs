using NUnit.Framework;
using System;
using CarManager;

namespace CarManager.Tests
{
    [TestFixture]
    public class CarTests
    {
        
        
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void ConstructorShouldInitializeCorrectly()
            {
            //public Car(string make, string model, double fuelConsumption, double fuelCapacity)
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
            


            }

            [Test]
            public void ModelShouldThrowArgExWhenNameIsNull()
            {
            string make = "aaa";
            string model = null;
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));

            }

            [Test]
            public void MakeShouldThrowArgExWhenNameIsNull()
            {
            string make = null;
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

            [Test]
            public void FuelConsumptionShouldThrowArgExWhenIsBellowZero()
            {

                string make = "aaa";
                string model = "bbb";
                double fuelConsumption = -5;
                double fuelCapacity = 40;

                Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            }

            [Test]
            public void FuelConsumptionShouldThrowArgExWhenIsZero()
            {
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 0;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            }

            [Test]
            public void FuelCapacityShouldThrowArgExWhenIsZero()
            {
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 89;
            double fuelCapacity = 0;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

            [Test]
            public void FuelCapacityShouldThrowArgExWhenIsBellowZero()
            {
                //TO DO
            }

           
            [TestCase] //������ ������, ��� ����� �� ������ ����������
            //TO DO
            public void ValidateAllProperties(string make, string model, double fuelConsumption, double fuelCapacity)
            {
                //TO DO
            }


            [Test]
            public void ShouldRefuelNormally()
            {
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;
            double fuelToRefuel = 7;
            
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(fuelToRefuel);
            Assert.AreEqual(fuelToRefuel, car.FuelAmount);
        }

            [Test]
            public void ShouldRefuelUntillTotalFuelCapacity()
            {
                //TO DO
            }

            [Test]
            //TO DO
            public void ShouldRefuelThrowArgExWhenInputAmountIsBellowZero(double inputAmount)
            {
                //TO DO
            }

            [Test]
            public void ShouldDriveNormally()
            {
                Car car = new Car("Vw", "Golf", 2, 100);
                //TO DO
            }

            [Test]
            public void DriveShouldThrowInvalidOperationExceptionWhenFuelAmountIsNotEnough()
            {
            string make = "aaaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;
            double distance = 20;
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
        }
        }

    }
