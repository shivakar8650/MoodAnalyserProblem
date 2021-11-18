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

        //  [DataRow(null)]
        public void TestCaseShouldReturnHappyForNull()
        {  //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Any Mood ");
            string expected = "HAPPY";
            //Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }



        // TC 3.1  Given Null Mood should throw MoodAnalysisException.
        [TestMethod]


        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {  

            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }


        }
    }
}
