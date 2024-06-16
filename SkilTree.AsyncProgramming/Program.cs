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

            // İşlemi 5 saniye sonra iptal etmek için
            await Task.Delay(5000);

            // İptal işlemi
            cancellationTokenSource.Cancel();

            try
            {
                await processTask; // İşlemin tamamlanmasını bekleyin
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

                    await Task.Delay(100); // Gerçek işlem yerine Task.Delay kullanıldı
                    progress.Report(i); // İlerleme raporlama
                }
                Console.WriteLine("İşlem tamamlandı.");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("İşlem iptal edildi.");
                throw; // İptal durumunu tekrar iletmek için
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
