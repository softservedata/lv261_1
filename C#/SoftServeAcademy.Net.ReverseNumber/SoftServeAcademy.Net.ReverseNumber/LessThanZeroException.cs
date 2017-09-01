using System;


namespace SoftServeAcademy.Net.ReverseNumber
{
    class LessThanZeroException:Exception
    {
        public LessThanZeroException() : base() { }
        public LessThanZeroException(string message):base(message){ }
    }
}
