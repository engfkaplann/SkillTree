using System;
using System.Threading.Tasks;
using System.Threading;

namespace SkilTree.AsyncProgramming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            var progress = new Progress<int>(percent =>
            {
                Console.WriteLine($"İlerleme: {percent}%");
            });

            Task processTask = ProcessAsync(progress, cancellationToken);

            await Task.Delay(5000);

            cancellationTokenSource.Cancel();

            try
            {
                await processTask;
                Console.WriteLine("İşlem tamamlandı.");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("İşlem iptal edildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }

        static async Task ProcessAsync(IProgress<int> progress, CancellationToken cancellationToken)
        {
            try
            {
                for (int i = 0; i <= 100; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    await Task.Delay(100);
                    progress.Report(i);
                }
                Console.WriteLine("İşlem tamamlandı.");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("İşlem iptal edildi.");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
