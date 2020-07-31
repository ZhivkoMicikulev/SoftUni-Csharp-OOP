
using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        private Database.Database database;
        private readonly int[] initialData = new int[] { 1, 2 };
        [SetUp]
        public void Setup()
        {
            this.database = new Database.Database(initialData);
        }

        [Test]
        public void TestIfConstructorWorksCorectly()
        {
            int[] data = new int[] { 1, 2, 3 };
            this.database = new Database.Database(data);

            int expectedCount = data.Length;
            int actualCount = this.database.Count;
            Assert.AreEqual(expectedCount, actualCount);
        }
        [Test]
        public void ConstructorShouldThrowExceptionInitializingWithBigger()
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database = new Database.Database(data);
            });
        }

        [Test]
        public void AddShouldIncreaseCount()
        {
            this.database.Add(3);
            int expectedCount = 3;
            int actualCount = this.database.Count;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddShouldThrowException()
        {
            for (int i = 3; i <= 16; i++)
            {
                this.database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(17);
            });
        }

        [Test]
        public void RemoveShouldDecraseCountWhenSuccess()
        {
            database.Remove();

            var expected = 1;
            var actual = database.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenDatabaseIsEmpty()
        {
            for (int i = 0; i < 2; i++)
            {
                database.Remove();
            }

            Assert.Throws<InvalidOperationException>
                (() =>

                {
                    database.Remove();
                }
                );
        }
        [TestCase(new int[] {1,2,3 })]
       [TestCase(new int[] { })]
       [TestCase(new int[] {1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7})]
        public void FetchShouldReturnCopyOFData(int[] expectedData)
        {
            this.database = new Database.Database(expectedData);
            var actualData = this.database.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }

    }
}