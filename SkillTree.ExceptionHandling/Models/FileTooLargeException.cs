using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.ExceptionHandling.Models
{
    public class FileTooLargeException : Exception
    {
        public FileTooLargeException()
         : base()
        { 
        
        }

        public FileTooLargeException(string message)
            : base(message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.hhh")} - {message}");
        }

        public FileTooLargeException(string message, Exception innerException)
            : base(message, innerException)
        {
            Console.WriteLine(message);
        }
    }
}
