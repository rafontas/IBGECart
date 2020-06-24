using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace IBGECart
{
    public class Orquestrador
    {
        public IDictionary<int, string> Arquivos { get; private set; }
        public IList<TipoArquivo> ArquivosDisponiveis { get; private set; }

        public Orquestrador()
        {
            this.ArquivosFactory();
        }

        private void ArquivosFactory()
        {
            this.Arquivos = new Dictionary<int, string>();
            this.Arquivos.Add(new KeyValuePair<int, string>((int)TipoArquivo.Cartinf01, "CARTINF01.TXT"));
        }

        public IList<TipoArquivo> VerificarSeHaArquivosDisponiveis()
        {
            IList<TipoArquivo> ArquivosDisponiveis = new List<TipoArquivo>();

            foreach(var a in this.Arquivos)
            {
                //Console.WriteLine(Directory.GetCurrentDirectory() + "\\" + a.Value);

                if (File.Exists(Directory.GetCurrentDirectory() + "\\" + a.Value))
                    ArquivosDisponiveis.Add((TipoArquivo) a.Key);
            }

            this.ArquivosDisponiveis = ArquivosDisponiveis ?? null;
            return ArquivosDisponiveis;
        }

        public void CorrigirArquivosDisponiveis() 
        {
            if (this.ArquivosDisponiveis.Count <= 0) {
                Console.WriteLine("Erro: Correção pedida sem arquivos disponíveis.");
                return;
            }

            foreach(int arqCorrecao in this.ArquivosDisponiveis) 
            {
                switch(arqCorrecao)
                {
                    case (int) TipoArquivo.Cartinf01:
                        Cartinf01 c = new Cartinf01();
                        Console.Write("    " + c.NOME_ARQUIVO + " - Em andamento...");
                        c.CorrigeArquivo();
                        Console.SetCursorPosition(Console.CursorLeft - " Em andamento...".Length, Console.CursorTop);
                        Console.Write(" Concluído.            " + Environment.NewLine + Environment.NewLine);
                        Thread.Sleep(10);
                        break;

                    default: 
                        Console.WriteLine("Erro: não há existe o arquivo pedido - " + arqCorrecao);
                        break;


                }
            }
        }
    }

    public enum TipoArquivo
    {
        Cartinf01 = 1,
    }
}
