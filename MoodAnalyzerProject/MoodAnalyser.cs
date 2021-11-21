using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProject
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser()
        {
            this.message = "";
    
           }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {

            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                if (message.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");

            }



        }
    }
}
