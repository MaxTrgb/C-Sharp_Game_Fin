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
    public class WarriorTest
    {
        public Hero hero = new Warrior();

        [TestMethod]
        public void SkillTestWarrior()
        {
            int damage = 50;
            int expected = 150;

            int actual = hero.Skill(damage);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HealTest()
        {
            Hero hero = new Warrior();
            int initialHealth = hero.Health;
            int expectedHealth = initialHealth + 50;

            hero.Heal();

            Assert.AreEqual(expectedHealth, hero.Health);
        }
        [TestMethod]
        public void LocationTestArena()
        {
            Hero hero = new Warrior();
            BattleLocation location = BattleLocation.Arena;

            int expectedEffect = hero.ResistanceToPhysical + 2;

            hero.Location(location);

            Assert.AreEqual(expectedEffect, hero.ResistanceToPhysical);
        }
        [TestMethod]
        public void LocationTestEverest()
        {
            Hero hero = new Warrior();
            BattleLocation location = BattleLocation.Everest;

            int expectedEffect = hero.ResistanceToPhysical - 2;

            hero.Location(location);

            Assert.AreEqual(expectedEffect, hero.ResistanceToPhysical);
        }

        [TestMethod]
        public void LocationTestForest()
        {
            Hero hero = new Warrior();
            BattleLocation location = BattleLocation.Forest;

            int expectedEffect = hero.AttackPower - 25;

            hero.Location(location);

            Assert.AreEqual(expectedEffect, hero.AttackPower);

        }

    }
}
