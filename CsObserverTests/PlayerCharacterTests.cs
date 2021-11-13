using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsObserver.Tests
{
    [TestClass()]
    public class PlayerCharacterTests
    {
        private PlayerCharacter playerCharacter;
        [TestInitialize()]
        public void Initialize()
        {
            playerCharacter = new PlayerCharacter("Ramon", 10, 20);
        }
        [TestCleanup()]
        public void Cleanup()
        {
            playerCharacter = null;
        }
        [TestMethod()]
        public void GetStateTest()
        {
            State state = playerCharacter.GetState();
            Assert.AreEqual(20, playerCharacter.Years);
            Assert.AreEqual(10, playerCharacter.Life);
            Assert.AreEqual("Ramon", playerCharacter.Name);
        }

        [TestMethod()]
        public void NotifyTest()
        {
            ObserverInterface dummyObserver = new DummyObserver();
            playerCharacter.Subscribe(dummyObserver);
            playerCharacter.Years = 34;
            Assert.AreEqual(34, playerCharacter.Years);

        }

        [TestMethod()]
        public void SubscribeTest()
        {
            ObserverInterface dummyObserver = new DummyObserver();
            playerCharacter.Subscribe(dummyObserver);
            Assert.IsTrue(playerCharacter.GetObservers().Contains(dummyObserver));
        }

        [TestMethod()]
        public void UnsubscribeTest()
        {
            ObserverInterface dummyObserver = new DummyObserver();
            playerCharacter.Subscribe(dummyObserver);
            playerCharacter.Unsubscribe(dummyObserver);

            Assert.IsFalse(playerCharacter.GetObservers().Contains(dummyObserver));
        }
    }
}