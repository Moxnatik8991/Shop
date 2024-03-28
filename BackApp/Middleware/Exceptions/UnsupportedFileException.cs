namespace Shop.BackApp.Middleware.Exceptions
{
    public class UnsupportedFileException : Exception
    {
        public UnsupportedFileException(string message) : base(message) { }
    }
}
