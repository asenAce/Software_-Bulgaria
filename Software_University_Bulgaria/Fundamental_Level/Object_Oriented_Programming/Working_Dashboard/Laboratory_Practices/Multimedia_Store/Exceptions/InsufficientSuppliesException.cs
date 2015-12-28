namespace MultimediaShop.Exceptions
{
    using System;

    public class InsufficientSuppliesException : ApplicationException
    {
        public InsufficientSuppliesException(string message)
            : base(message)
        {
        }
    }
}
