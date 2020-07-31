
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {

        }
        //Name Validation
        [Test]
        public void TestIfConstructorWorksCorectly()
        {
            var expName = "Pesho";
            var expDmg = 50;
            var expHP= 100;
           
            Warrior warrior = new Warrior(expName, expDmg, expHP);

            var actName = warrior.Name;
            var actDmg = warrior.Damage;
            var actHP = warrior.HP;

            Assert.AreEqual(expName, actName);
            Assert.AreEqual(expDmg, actDmg);
            Assert.AreEqual(expHP, actHP);

        }

        [Test]
        public void TestWithLikeNullName()
        {
            string name = null;
            var dmg = 50;
            var hp = 100;

            Assert.Throws<ArgumentException>(() =>
            {
                var warrior = new Warrior(name, dmg, hp);
            }
            );
        }

        [Test]
        public void TestWithLikeEmptyName()
        {
            var name = string.Empty;
            var dmg = 50;
            var hp = 100;

            Assert.Throws<ArgumentException>
                (() =>
                {
                    var warrior = new Warrior(name, dmg, hp);
                }
                );
        }

        [Test]
        public void TestWithWhiteSpaceName()
        {
            var name ="   ";
            var dmg = 50;
            var hp = 100;

            Assert.Throws<ArgumentException>
                (() =>
                {
                    var warrior = new Warrior(name, dmg, hp);
                }
                );
        }

        //Dmg Validation

        [Test]
        public void TestWithZeroDmg()
        {
            var name = "pesho";
            var dmg = 0;
            var hp = 100;

            Assert.Throws<ArgumentException>
                (() =>
                {
                    var warrior = new Warrior(name, dmg, hp);
                }
                );
        }
        [Test]
        public void TestWithNegativeDmg()
        {
            var name = "pesho";
            var dmg = -1;
            var hp = 100;

            Assert.Throws<ArgumentException>
                (() =>
                {
                    var warrior = new Warrior(name, dmg, hp);
                }
                );
        }

        //Hp Validation

        [Test]
        public void TestWithNegativeHP()
        {
            var name = "pesho";
            var dmg = 10;
            var hp = -10;

            Assert.Throws<ArgumentException>
                (() =>
                {
                    var warrior = new Warrior(name, dmg, hp);
                }
                );
        }

        //Attack Method
        [Test]
        [TestCase(25)]
        [TestCase(30)]
        public void AttackingEnemyWhenLowHPShouldhrowException(int Hp)
        {
            var AName = "Pesho";
            var ADmg = 10;

            var DName = "Gosho";
            var DDmg = 10;
            var DHP = 40;

            var attacker = new Warrior(AName, ADmg, Hp);
            var defender = new Warrior(DName, DDmg, DHP);


            Assert.Throws<InvalidOperationException>
                (() =>
                {
                    attacker.Attack(defender);
                }
                );
        }
        
        [Test]
        [TestCase(25)]
        [TestCase(30)]
        public void AttackingEnemyWithLowHPShouldThrowException(int hp)
        {
            var AName = "Pesho";
            var ADmg = 10;
            var AHP = 100;

            var DName = "Gosho";
            var DDmg = 10;
            

            var attacker = new Warrior(AName, ADmg, AHP);
            var defender = new Warrior(DName, DDmg, hp);

            Assert.Throws<InvalidOperationException>
                (() =>
                {
                    attacker.Attack(defender);
                    }
                );
        }

        [Test]
        public void AttackingStrongerEnemyShouldThrowException()
        {
            var AName = "Pesho";
            var ADmg = 10;
            var AHP = 40;
           
            var DName = "Gosho";
            var DDmg = 50;
            var DHP = 100;

            var attacker = new Warrior(AName, ADmg, AHP);
            var defender = new Warrior(DName, DDmg, DHP);

            Assert.Throws<InvalidOperationException>
                (() =>
                {
                    attacker.Attack(defender); 
                });
        }

        [Test]
        public void AttcakingShouldDecreaseHpWhenIsSeccessful()
        {
            var AName = "Pesho";
            var ADmg = 10;
            var AHP = 40;

            var DName = "Gosho";
            var DDmg = 5;
            var DHP = 40;

            var attacker = new Warrior(AName, ADmg, AHP);
            var defender = new Warrior(DName, DDmg, DHP);

            var expAHp = AHP - DDmg;
            var expDHP = DHP - ADmg;
            
            attacker.Attack(defender);
          
            Assert.AreEqual(expAHp,attacker.HP);
            Assert.AreEqual(expDHP, defender.HP);

        }

        [Test]
        public void TestKillingEnemyWithattack()
        {
            var AName = "Pesho";
            var ADmg = 80;
            var AHp = 100;

            var DName = "Gosho";
            var DDmg = 10;
            var DHP = 40;

            var attacker = new Warrior(AName, ADmg, AHp);
            var defender = new Warrior(DName, DDmg, DHP);

            var expATHp = AHp - DDmg;
            var expDefHp = 0;
           
            attacker.Attack(defender);
           
           
            Assert.AreEqual(expATHp, attacker.HP);
            Assert.AreEqual(expDefHp, defender.HP);
            

        }

    }
}