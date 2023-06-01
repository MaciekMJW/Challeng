

using Challeng;
using NUnit.Framework;

namespace ChallengApp.Test
{
    public class TypeTests
    {
        [Test]
        public void WhenNumberHasTheSameValue()
        {
            //arrange
            int number1 = 3;
            int number2 = 3;

            //act

            //assert

            Assert.AreEqual(number1, number2); 
        }

        [Test]
        public void ValueIsDifferent()
        {
            //arrange
            float value1 = 3.43f;
            float value2 = 8.22f;

            //act

            //assert

            Assert.AreNotEqual(value1, value2);
        }

        [Test]
        public void UserloginsShouldBeDifferent()
        {
            //arrange
            var user1 = GetUser("Maciek");
            var user2 = GetUser("Artur");

            //act

            //assert

            Assert.AreNotEqual(user1.Login, user2.Login);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
