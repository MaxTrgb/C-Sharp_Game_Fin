using C_CLASS25._11._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
