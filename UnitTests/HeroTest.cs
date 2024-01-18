using C_CLASS25._11._2;
using System.Xml.Linq;
using static C_CLASS25._11._2.Hero;

namespace UnitTests
{
    [TestClass]
    public class HeroTest
    {
        public Hero hero1 = new Mage();
        public Hero hero2 = new Warrior();

        [TestMethod]
        public void CalculateDamageTest()
        {
            int enemyAttackPower = 100;
            int CriticalChance = 0;
            double expected = 250;
            String Name = "Warrior";
            ConsoleKeyInfo move;
            move = new ConsoleKeyInfo((char)ConsoleKey.D4, ConsoleKey.Enter, false, false, false);

            double actual = hero1.CalculateDamage(enemyAttackPower, AttackType.Physical, CriticalChance, Name, move);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DefendTestMethodTrue()
        {
            int damage = 200;
            int expected = 100;

            hero1.StartDefending();

            int actual = hero1.Defend(damage);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DefendTestMethodFalse()
        {
            int damage = 200;
            int expected = 200;
            int actual = hero1.Defend(damage);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DefendTestMethodZero()
        {
            int damage = 99;
            int expected = 0;

            hero1.StartDefending();
            int actual = hero1.Defend(damage);

            Assert.AreEqual(expected, actual);
        }


    }

}