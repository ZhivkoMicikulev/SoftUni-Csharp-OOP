
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        private Warrior w1;
        private Warrior attacker;
        private Warrior deffender;
        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
            this.w1 = new Warrior("Pesho", 50, 100);
            this.attacker = new Warrior("Pesho", 10, 80);
            this.deffender = new Warrior("Gosho", 5, 60);
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            Assert.IsNotNull(this.arena.Warriors);
        }

        [Test]
        public void EnrollShouldPhysicallyAddWarriorToTheArena()
        {
            arena.Enroll(w1);

            Assert.That(this.arena.Warriors, Has.Member(this.w1));
        }

        [Test]
        public void EnrollShouldIncreaseCount()
        {
            arena.Enroll(w1);
            var expCount = 1;

            Assert.AreEqual(expCount, arena.Count);
        }

        [Test]
        public void EnrollShouldThrowExceptionWithTheSameWarrior()
        {
            arena.Enroll(w1);

            Assert.Throws<InvalidOperationException>
                (() =>
                {
                    arena.Enroll(w1);
                });
        }
   
        [Test]
        public void 
            EnrollThoWarriorsWithTheSameNameShouldThrowException()
        {
            var w1Copy = new Warrior(w1.Name, w1.Damage, w1.HP);
            arena.Enroll(w1);

            Assert.Throws<InvalidOperationException>
                (() =>
                {
                    arena.Enroll(w1Copy);
                });
        }
   
        [Test]
        public void TestWithMissingDeffenderr()
        {
            arena.Enroll(deffender);

            Assert.Throws<InvalidOperationException>
                (() =>
                {
                    arena.Fight(attacker.Name, deffender.Name);
                });
        }

        [Test]
        public void TestWithMissingAttacker()
        {
            arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>
                (() =>
                {
                    arena.Fight(attacker.Name, deffender.Name);
                });
        }

        [Test]

        public void TestFightOnArena()
        {
            var expAHp = attacker.HP - deffender.Damage;
            var expDHp = deffender.HP - attacker.Damage;
            
            arena.Enroll(attacker);
            arena.Enroll(deffender);

            arena.Fight(attacker.Name, deffender.Name);

            Assert.AreEqual(expAHp, attacker.HP);
            Assert.AreEqual(expDHp, deffender.HP);
            
        }


    }
}
