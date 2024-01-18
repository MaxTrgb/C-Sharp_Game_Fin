using C_CLASS25._11._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
