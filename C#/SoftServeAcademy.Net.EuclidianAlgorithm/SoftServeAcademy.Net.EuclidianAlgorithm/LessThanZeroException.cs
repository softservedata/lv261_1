using System;


namespace SoftServeAcademy.Net.EuclidianAlgorithm
{
    class LessThanZeroException:Exception
    {
        public LessThanZeroException() : base() { }
        public LessThanZeroException(string message) : base(message) { }
    }
}
