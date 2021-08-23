namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : System.ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
