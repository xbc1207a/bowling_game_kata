using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.SetPins(0);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(0));
        }
        [Test]
        public void AddTwoScore()
        {
            Game g = new Game();
            g.SetPins(2);
            g.SetPins(3);
            Assert.That(g.GetFinalScore(), Is.EqualTo(5));
        }
        [Test]
        public void AllHit()
        {
            Game g = new Game();
            g.SetPins(10);
            // next
            g.SetPins(2);
            g.SetPins(5);
            Assert.That(g.GetFinalScore(), Is.EqualTo(17));
        }
    }
}
