using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;

namespace TestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {

        //TC 1.1 "I am in Sad Mood "  message should return SAD
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "SAD";
            string actual = moodAnalyser.AnalyseMood("I am in Sad Mood ");
            Assert.AreEqual(expected, actual);
        }

        //TC 1.2 "I am in Any Mood "  chekc for only SAD id not found return HAPPY
        [TestMethod]
        public void TestMethod2()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "HAPPY";
            string actual = moodAnalyser.AnalyseMood("I am in Any Mood");
            Assert.AreEqual(expected, actual);
        }
    }
}
