using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.ExceptionHandling.Models.Concretes
{
    public class PdfDownloader
    {
        private readonly int _maxFileSize = 1024;

        private string _fileUrl = "";
        private int _fileSize = 1024;

        public PdfDownloader(string fileUrl, int fileSize)
        {
            _fileUrl = fileUrl;
            _fileSize = fileSize;
        }

        public void DownloadFile()
        {
            if(string.IsNullOrEmpty( _fileUrl))
            {
                throw new FileUrlEmptyException("File url can not be empty");
            }

            if(_fileSize > _maxFileSize)
            {
                throw new FileTooLargeException("File is too large");
            }

            throw new NotImplementedException("DownloadFile not implemented");
        }
    }
}
