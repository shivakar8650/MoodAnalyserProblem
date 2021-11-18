using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;

namespace TestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {

        //repeat TC 1.1 "I am in Sad Mood "  message should return SAD
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood ");
            string expected = "SAD";
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }

        //repeat TC 1.2  & 2.1 "I am in Any Mood "  chekc for only SAD id not found return HAPPY
        //TC  2.1  return should be HAPPY for the null string is pass  
        [TestMethod]

        [DataRow(null)]
        public void TestCaseShouldReturnHappyForNull(string message)
        {  //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string expected = "HAPPY";
            //Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
