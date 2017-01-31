using CroweCodingExercise.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CroweCodingExercise.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        #region Public Methods

        [TestMethod]
        public void GetHelloMessageTest()
        {
            MessageFactory.Bridge = new MessageBridge(new HelloMessage());
            var message = MessageFactory.RetrieveMessage();
            Assert.AreEqual("Hello World", message, "The text from HelloMessage did not return correctly.");
        }

        #endregion Public Methods
    }
}