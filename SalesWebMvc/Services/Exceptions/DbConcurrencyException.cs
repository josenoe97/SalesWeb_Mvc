using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string menssage) 
            : base(menssage)
        {
        
        }
    }
}
