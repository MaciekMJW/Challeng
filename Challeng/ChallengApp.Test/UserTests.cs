using Challeng;

namespace ChallengApp.Test
{
    public class Tests
    {
        
        [Test]
        public void WhenUserCollectTwoSciores_ShouldReturnedCorrectResult()
        {
            //arrange
            var user = new User("Maciek", "qaz11");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(5);
            user.AddScore(-10);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(6, result);
        }
    }
}