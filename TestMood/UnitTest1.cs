using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProject;
using System;

namespace TestMood
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
        // TC 3.2  Given Empty Mood Should Throw MoodAnalysisException Indicating EmptyMood.
        [TestMethod]


        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {

            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }


        //Test Case 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        [TestMethod]


        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerProject.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);

        }

        //Test Case 4.2 Given Class Name Improper Should throw  MoodAnalysisException.
        [TestMethod]



        public void GiveClassNameImproper_ShouldReturnMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerProject.moodAnalysis", "MoodAnalyser");
                expected.Equals(obj);
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Class not Found", e.Message);
            }

        }


        //Test Case 4.3 Given Class when Constructor not proper Should throw  MoodAnalysisException.
        [TestMethod]
        public void GiveClassNameConstructorNotProper_ShouldReturnMoodAnalysisException()
        {
            try
            {  
                object expected = new MoodAnalyser("shiva");
                object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerProject.MoodAnalyser", "MoodAnalyser");
                expected.Equals(obj);
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Construtor is not Found", e.Message);
            }

        }


        //Test Case 5.1 Given Class when Constructor not proper Should throw  MoodAnalysisException.
        [TestMethod]
        public void GiveMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_USingParameterizecomstructor()
        {
            
                object expected = new MoodAnalyser("HAPPY");
                object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedconstructor("MoodAnalyzerProject.MoodAnalyser", "MoodAnalyser","HAPPY");
                expected.Equals(obj);
                 Console.WriteLine(expected.Equals(obj));
          

        }

        //Test Case 5.2 Given Classname not  Should throw  MoodAnalysisException.
        [TestMethod]
        public void GiveClassNameNotProper_ShouldReturnMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyser("HAPPY");
                object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedconstructor("MoodAnalyzerProject.moodAnalyser", "MoodAnalyser", "HAPPY");
                expected.Equals(obj);
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Class not Found", e.Message);
            }


        }

        //Test Case 5.3 Given Class when Constructor not proper Should throw  MoodAnalysisException.
        [TestMethod]
        public void GiveClassNameConstructorimProper_ShouldReturnMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyser("HAPPY");
                object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedconstructor("MoodAnalyzerProject.MoodAnalyser", "moodAnalyser", "HAPPY");
                expected.Equals(obj);
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Construtor is not Found", e.Message);
            }


        }
    }
}
