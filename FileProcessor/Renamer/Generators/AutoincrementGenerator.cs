﻿

namespace FileProcessor.Renamer.Generators
{
    internal class AutoincrementGenerator : IStringGenerator
    {
        public int CurrentValue { get; set; }
        public int Step { get; set; }
        public AutoincrementGenerator(int startValue, int step) 
        {
            CurrentValue = startValue;
            Step = step;
        }
        public string GetNext()
        {
            return (CurrentValue += Step).ToString();
        }
    }
}
