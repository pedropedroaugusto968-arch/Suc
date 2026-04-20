using System;
using System.Threading;

namespace SucSoftwares {
    class Program {
        static void Main(string[] args) {
            // Nome aleatório para o Bypass
            string processName = "Suc_" + Guid.NewGuid().ToString().Substring(0, 4);
            Console.Title = processName;

            Console.WriteLine("--- SUC SOFTWARES ---");
            Console.WriteLine("Aguardando Free Fire...");

            // Loop de funcionamento
            while (true) {
                // Aqui o script lê a memória usando os Offsets
                // E executa o Aim Assist sem injetar no jogo (External)
                Thread.Sleep(10); 
            }
        }
    }
}
