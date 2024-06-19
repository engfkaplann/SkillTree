using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.ExceptionHandling.Models
{
    public class FileUrlEmptyException : Exception
    {
        public FileUrlEmptyException()
         : base()
        {

        }

        public FileUrlEmptyException(String message)
            : base(message)

        {
            Console.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.hhh")} - {message}");
        }

        public FileUrlEmptyException(String message, Exception innerException)
            : base(message, innerException)
        {
            Console.WriteLine(message);
        }
    }
}
