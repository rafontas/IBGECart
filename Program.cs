using System;
using System.Collections.Generic;
using System.Threading;

namespace IBGECart
{
    public class Program
    {

        private static int counter;

        public static void Turn()
        {
            counter++;
            switch (counter % 4)
            {
                case 0: Console.Write("/"); counter = 0; break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Thread.Sleep(1);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        public static string ComoUsar()
        {
            string comoUsar = @"Instruções de uso:" + Environment.NewLine + Environment.NewLine;
            comoUsar += @"  Coloque na mesma pasta este arquivo executável e o(s) arquivo(s) que você quer corrigir." + Environment.NewLine;
            comoUsar += @"  Eles tem que estar EXATAMENTE com um dos nomes abaixo: " + Environment.NewLine;

            return comoUsar;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao IBGE Cartinf Util!" + Environment.NewLine);

            Orquestrador orquestrador = new Orquestrador();
            IList<TipoArquivo> ArquivosDisponiveis = orquestrador.VerificarSeHaArquivosDisponiveis();

            if (ArquivosDisponiveis.Count > 0)
            {
                Console.WriteLine("Foram identificado os arquivos: " + Environment.NewLine);
                foreach (var f in orquestrador.Arquivos)
                {
                    Console.WriteLine("   " + f.Value);
                }

                Console.WriteLine();
                Console.WriteLine("Deseja prosseguir e ajeitar todos eles? Pressione S para sim ou N para não, depois aperte Enter.");

                string consoleInput = Console.ReadLine();

                if (consoleInput.ToLower() == "sim" || consoleInput.ToLower() == "s")
                {
                    Console.WriteLine("Corrigindo os arquivos. Isso pode demorar alguns minutos." + Environment.NewLine);
                    orquestrador.CorrigirArquivosDisponiveis();

                }
                else if (consoleInput.ToLower() != "nao" && consoleInput.ToLower() != "não" && consoleInput.ToLower() != "n")
                {
                    Console.WriteLine("Não entendi, sou literal.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Digite \"C\" para criar arquivos de teste, depois aperte enter. Caso os arquivos existam, eles serão substituídos.");

                string consoleInput = Console.ReadLine();

                if (consoleInput.ToLower() == "c")
                {
                    orquestrador.CriarArquivosTeste();
                }
                else
                {
                    Console.WriteLine(Program.ComoUsar());
                    
                    foreach (var arq in orquestrador.Arquivos) 
                        Console.WriteLine("    " + arq.Value + Environment.NewLine);

                    Console.WriteLine(Environment.NewLine + "Se você está lendo esta mensagem é porque não foi encontrado nenhum arquivo.");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para fechar...");
            Console.ReadLine();
        }
    }
}
