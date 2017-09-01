using System;


namespace SoftServeAcademy.Net.EuclidianAlgorithm
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        
        public Fraction GetFractionWithGretestCommonDivisor(int numberM, int numberN)
        {
            if (numberM < 0 || numberN < 0)
                throw new LessThanZeroException("The number can't be less than zero.");

            int numerator = numberM;
            int denominator = numberN;

            int remainderAfterDividing = 1;
            int greatestCommonDivisor = 1;
            do
            {
                remainderAfterDividing = numerator % denominator;
                if (remainderAfterDividing == 0)
                {
                    greatestCommonDivisor = denominator;

                }
                numerator = denominator;
                denominator = remainderAfterDividing;

            }
            while (remainderAfterDividing != 0);

            
            this.Numerator = numberM / greatestCommonDivisor;
            this.Denominator = numberN / greatestCommonDivisor;


            return this;
        }
    }
}
