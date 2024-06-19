using SkillTree.ExceptionHandling.Models;
using SkillTree.ExceptionHandling.Models.Concretes;
using System;

namespace SkillTree.ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PdfDownloader pdfDownloader = new PdfDownloader("", 2048);

                Console.WriteLine("Download starting...");

                pdfDownloader.DownloadFile();
            }
            catch (FileTooLargeException ex)
            {
                Console.WriteLine("Handling FileTooLargeException...");
            }
            catch (FileUrlEmptyException ex)
            {
                Console.WriteLine("Handling FileUrlEmptyException...");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Handling NotImplementedException...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occured : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Download operation finished");
            }

            Console.ReadLine();
        }
    }
}
