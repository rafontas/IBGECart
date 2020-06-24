using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IBGECart
{
    public class Cartinf01
    {
        public string NOME_ARQUIVO = "CARTINF01.TXT";
        public string NOME_ARQUIVO_VELHO = "CARTINF01_BACKUP_";

        public bool ExisteArquivoNaPasta() => File.Exists(NOME_ARQUIVO);

        private void RenomeaArquivo() 
        {
            string nome_arquivo_velho = NOME_ARQUIVO_VELHO + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".txt";

            if (File.Exists(nome_arquivo_velho)) File.Delete(nome_arquivo_velho);

            File.Copy(NOME_ARQUIVO, nome_arquivo_velho);
        }

        public void CorrigeArquivo()
        {
            try
            {
                this.RenomeaArquivo();
                string s = this.CorrigeTudo();
                this.SalvaArquivo(s);
            }
            catch(Exception e)
            {
                File.WriteAllText("erro.txt", e.ToString());
                Console.WriteLine("Ocorreu algum erro ao tentar corrigir este arquivo. Foi criado um arquivo erro.txt com informações necessárias para que eu o corrija. Fale pra Laura enviar os arquivos de erro e o arquivo que você quer corrigir. =)");
            }
        }

        private string CorrigeTudo()
        {
            string _content = File.ReadAllText(this.NOME_ARQUIVO);
            char[] content = _content.ToCharArray();
            string newContent = "";
            newContent += content[0];

            for (int i = 0, j = 1; i < content.Length && j < content.Length; i++, j++)
            {
                if ((content[i] == 'A' && content[j] == '0') ||
                    (content[i] == ' ' && content[j] == '0')) continue;

                newContent += content[j];
            }

            return newContent;
        }

        private void SalvaArquivo(string content)
        {
            File.WriteAllText(this.NOME_ARQUIVO, content);
        }
    }
}
