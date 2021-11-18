using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }


        }
    }
}
