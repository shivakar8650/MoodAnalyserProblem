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

        //repeat TC 1.2 "I am in Any Mood "  chekc for only SAD id not found return HAPPY
        [TestMethod]
        public void TestMethod2()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            string expected = "HAPPY";
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
    }
}
