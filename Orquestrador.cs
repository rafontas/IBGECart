using IBGECart.Interface;
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

        public void CriarArquivosTeste()
        {
            ConteudoCartinfTeste.CriarArquivo(TipoArquivo.Cartinf01);
            ConteudoCartinfTeste.CriarArquivo(TipoArquivo.Cartinf02);
            ConteudoCartinfTeste.CriarArquivo(TipoArquivo.Cartinf03);
            ConteudoCartinfTeste.CriarArquivo(TipoArquivo.Cartinf04);
        }

        private void ArquivosFactory()
        {
            this.Arquivos = new Dictionary<int, string>();
            this.Arquivos.Add(new KeyValuePair<int, string>((int)TipoArquivo.Cartinf01, "CARTINF01.TXT"));
            this.Arquivos.Add(new KeyValuePair<int, string>((int)TipoArquivo.Cartinf02, "CARTINF02.TXT"));
            this.Arquivos.Add(new KeyValuePair<int, string>((int)TipoArquivo.Cartinf03, "CARTINF03.TXT"));
            this.Arquivos.Add(new KeyValuePair<int, string>((int)TipoArquivo.Cartinf04, "CARTINF04.TXT"));
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
                ICartinf c = null;

                switch (arqCorrecao)
                {
                    case (int) TipoArquivo.Cartinf01:
                        c = new Cartinf01();
                        break;

                    case (int) TipoArquivo.Cartinf02:
                        c = new Cartinf02();
                        break;
                    
                    case (int) TipoArquivo.Cartinf03:
                        c = new Cartinf03();
                        break;

                    case (int) TipoArquivo.Cartinf04:
                        c = new Cartinf04();
                        break;

                    default: 
                        throw new Exception("Tipo de arquivo não identificado.");
                }

                Console.Write("    " + c.NOME_ARQUIVO + " - Em andamento...");
                c.CorrigeArquivo();
                Console.SetCursorPosition(Console.CursorLeft - " Em andamento...".Length, Console.CursorTop);
                Console.Write(" Concluído.            " + Environment.NewLine + Environment.NewLine);
                Thread.Sleep(3);
            }
        }
    }

    public enum TipoArquivo
    {
        Cartinf01 = 1,
        Cartinf02 = 2,
        Cartinf03 = 3,
        Cartinf04 = 4,
    }
}
