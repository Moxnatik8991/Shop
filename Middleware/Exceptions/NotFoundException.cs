namespace Shop.Middleware.Exceptions
{
    public class NotFoundException<T> : Exception
    {
        public NotFoundException() : base(GenerateMessage())
        {
        }

        private static string GenerateMessage()
        {
            return $"{typeof(T).Name} not found!";
        }

    }
}
