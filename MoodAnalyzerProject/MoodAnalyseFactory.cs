using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzerProject
{
    public  class MoodAnalyseFactory
    {
    

        public static  object CreateMoodAnalyse(string ClassName,string costructorName)
        {
            string pattern = @"." + costructorName + "$";
            Match result = Regex.Match(ClassName, pattern);

            if(result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch(ArgumentNullException)
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Construtor is not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }

        public static object CreateMoodAnalyseUsingParameterizedconstructor(string ClassName, string costructorName,string message)
        {
            Type type = typeof(MoodAnalyser);

            if (type.Name.Equals(ClassName) || type.FullName.Equals(ClassName))
            {
                if (type.Name.Equals(costructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                     object instance = ctor.Invoke(new object[] {message});
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Construtor is not Found");
                }

            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "Class not Found");

            }
        }
    }
}
