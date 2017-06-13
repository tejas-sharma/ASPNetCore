using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ASPNetCore.Data
{
    public class EFConfigSource : IConfigurationSource 
    {
        private readonly Action<DbContextOptionsBuilder> _optionsAction;
        public EFConfigSource(Action<DbContextOptionsBuilder> optionsAction)
        {
            _optionsAction = optionsAction;
        }
        
    }
}