using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IBGECart.Interface
{
    public abstract class Cartinf : ICartinf
    {
        public abstract string NOME_ARQUIVO { get; }

        public abstract string NOME_ARQUIVO_VELHO { get; }

        public abstract TipoArquivo TipoArquivo { get; }

        public abstract string CorrigeTudo();

        public void CorrigeArquivo()
        {
            try
            {
                this.RenomeaArquivo();
                string s = this.CorrigeTudo();
                this.SalvaArquivo(s);
            }
            catch (Exception e)
            {
                File.WriteAllText("erro.txt", e.ToString());
                Console.WriteLine("Ocorreu algum erro ao tentar corrigir este arquivo. Foi criado um arquivo erro.txt com informações necessárias para que eu o corrija. Fale pra Laura enviar os arquivos de erro e o arquivo que você quer corrigir. =)");
            }
        }

        protected void RenomeaArquivo()
        {
            string nome_arquivo_velho = this.NOME_ARQUIVO_VELHO + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".txt";

            if (File.Exists(nome_arquivo_velho)) File.Delete(nome_arquivo_velho);

            File.Copy(this.NOME_ARQUIVO, nome_arquivo_velho);
        }

        protected void SalvaArquivo(string content)
        {
            File.WriteAllText(this.NOME_ARQUIVO, content);
        }
    }
}