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
    public class ArcherTest
    {
        public Hero hero = new Archer();

        [TestMethod]
        public void SkillTestArcher()
        {
            int damage = 50;
            int expected = 150;

            int actual = hero.Skill(damage);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HealTest()
        {
            Hero hero = new Archer();
            int initialHealth = hero.Health;
            int expectedHealth = initialHealth + 65;

            hero.Heal();

            Assert.AreEqual(expectedHealth, hero.Health);
        }
        [TestMethod]
        public void LocationTestArena()
        {
            Hero hero = new Archer();
            BattleLocation location = BattleLocation.Arena;

            int expectedEffect = hero.DodgeChance - 3;

            hero.Location(location);

            Assert.AreEqual(expectedEffect, hero.DodgeChance);
        }
        [TestMethod]
        public void LocationTestEverest()
        {
            Hero hero = new Archer();
            BattleLocation location = BattleLocation.Everest;

            int expectedEffect = hero.AttackPower - 25;

            hero.Location(location);

            Assert.AreEqual(expectedEffect, hero.AttackPower);
        }

        [TestMethod]
        public void LocationTestForest()
        {
            Hero hero = new Archer();
            BattleLocation location = BattleLocation.Forest;

            int expectedEffect = hero.DodgeChance + 3;

            hero.Location(location);

            Assert.AreEqual(expectedEffect, hero.DodgeChance);

        }


    }
}
