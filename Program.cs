using System.Diagnostics;

namespace CS_TP1.Aula6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Task
            //Task
            //Task task1 = Task.Run(() =>
            //{
            //    Console.WriteLine("Task 1 iniciada.");
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Task 1 concluída.");
            //});

            //Task task2 = Task.Run(() =>
            //{
            //    Console.WriteLine("Task 2 iniciada.");
            //    Thread.Sleep(5000);
            //    Console.WriteLine("Task 2 concluída.");
            //});

            //Task task3 = Task.Run(() =>
            //{
            //    Console.WriteLine("Task 3 iniciada.");
            //    Thread.Sleep(8000);
            //    Console.WriteLine("Task 3 concluída.");
            //});

            //Task<int> task = Task.Run(() =>
            //{
            //    Console.WriteLine("Task iniciada.");
            //    Thread.Sleep(3000);
            //    Console.WriteLine("Task concluída.");
            //    return 50;
            //});

            ////Task.WhenAll(task1, task2, task3).Wait();
            ////Task.WaitAll(task1, task2, task3);            

            //Console.WriteLine($"Resultado da tarefa = {task.Result}");
            //Console.WriteLine("Aperte qualquer tecla para sair.");
            //Console.ReadKey();
            #endregion

            #region Async/Await
            Task<int> result1 = LongProcess1();
            Task<int> result2 = LongProcess2();

            Console.WriteLine("Depois de 2 longos processos");

            //int val = await LongProcess1();
            //Console.WriteLine(val);

            //val = await LongProcess2();
            //Console.WriteLine(val);

            int val = await result1;
            Console.WriteLine(val);

            val = await result2;
            Console.WriteLine(val);


            //ShortProcess();

            Console.ReadKey();

            #endregion
        }

        static async Task<int> LongProcess1()
        {
            Console.WriteLine("LongProcess 1 started.");

            await Task.Delay(3000);

            Console.WriteLine("LongProcess 1 completed.");

            return 10;
        }

        static async Task<int> LongProcess2()
        {
            Console.WriteLine("LongProcess 2 started.");

            await Task.Delay(4000);

            Console.WriteLine("LongProcess 2 completed.");

            return 20;
        }

        static async Task GetData()
        {
            //faz algo muuuuito demorado
        }

        static async Task ShortProcess()
        {
            Console.WriteLine("ShortProcess started.");

            //faça algo

            Console.WriteLine("ShortProcess completed.");
        }
    }
}