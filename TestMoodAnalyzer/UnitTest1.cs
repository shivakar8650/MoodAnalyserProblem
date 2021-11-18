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
    }
}
