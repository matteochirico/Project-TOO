using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TOO
{
    public abstract class Math
    {
        protected Random random = new Random();

        protected int numberOne;
        protected int numberTwo;

        protected int currentNumberOne;
        protected int currentNumberTwo;

        public int NumberOne { get { return numberOne; } }
        public int NumberTwo { get { return numberTwo; } }

        public abstract bool CorrectAnswer(string answer);
        public abstract void GetRandomNumbers(int minRange, int maxRange);
    }

    public class Multiplication : Math
    {
        public override bool CorrectAnswer(string answer)
        {
            try
            {
                if (Int32.Parse(answer) == NumberOne * NumberTwo)
                {
                    return true;
                }
            }
            catch { }

            return false;
        }

        public override void GetRandomNumbers(int minRange, int maxRange)
        {
            numberOne = random.Next(minRange, maxRange);
            numberTwo = random.Next(minRange, maxRange);

            if (currentNumberOne == numberOne || currentNumberTwo == numberTwo)
            {
                numberOne = random.Next(minRange, maxRange);
                numberTwo = random.Next(minRange, maxRange);
            }

            currentNumberOne = numberOne;
            currentNumberTwo = numberOne;
        }
    }
}
