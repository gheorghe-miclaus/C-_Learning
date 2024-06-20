using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ns_DailyAccountState
{
    public class DailyAccountState
    {
        public int InitialState { get; }

        public int SumOfOperations { get; }

        public DailyAccountState(
            int initialState,
            int sumOfOperations)
        {
            InitialState = initialState;
            SumOfOperations = sumOfOperations;
        }

        //your code goes here

        public int EndOfDayState
        { 
            get => InitialState + SumOfOperations;
                    
        }

        public string Report
        {
            get => $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}" +
                $", year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
        }

    }
}
