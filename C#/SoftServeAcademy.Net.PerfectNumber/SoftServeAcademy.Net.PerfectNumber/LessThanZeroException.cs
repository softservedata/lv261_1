using System;


namespace SoftServeAcademy.Net.PerfectNumber
{
    class LessThanZeroException:Exception
    {
        public LessThanZeroException() : base() { }
        public LessThanZeroException(string message) : base(message) { }
    }
}
