using C_CLASS25._11._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_CLASS25._11._2.Hero;

namespace UnitTests
{
    [TestClass]
    public class MageTest
    {
        public Hero hero = new Mage();

        [TestMethod]
        public void SkillTestMage()
        {
            int damage = 100;
            int expected = 200;

            int actual = hero.Skill(damage);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HealTest()
        {
            Hero hero = new Mage(); 
            int initialHealth = hero.Health;
            int expectedHealth = initialHealth + 80;

            hero.Heal();

            Assert.AreEqual(expectedHealth, hero.Health);
        }
        [TestMethod]
        public void LocationTestArena()
        {
            Hero hero = new Mage();
            BattleLocation location = BattleLocation.Arena;

            int expectedEffect = hero.CriticalChance - 5;

            hero.Location(location);

            Assert.AreEqual(expectedEffect, hero.CriticalChance);
        }
        [TestMethod]
        public void LocationTestEverest()
        {
            Hero hero = new Mage();
            BattleLocation location = BattleLocation.Everest;

            int expectedEffect = hero.AttackPower + 25;

            hero.Location(location);

            Assert.AreEqual(expectedEffect, hero.AttackPower);
        }

        [TestMethod]
        public void LocationTestForest()
        {
            Hero hero = new Mage();
            BattleLocation location = BattleLocation.Forest;

            int expectedEffect = hero.AttackPower - 25;

            hero.Location(location);

            Assert.AreEqual(expectedEffect, hero.AttackPower);

        }


    }
}
