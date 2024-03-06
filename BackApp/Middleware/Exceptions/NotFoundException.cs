namespace Shop.BackApp.Middleware.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string model) : base(GenerateMessage(model))
        {
        }

        private static string GenerateMessage(string model)
        {
            var error = $"{model} not found!";
            return char.ToUpper(error[0]) + error.Substring(1);
        }

    }
}
