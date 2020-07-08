using IBGECart.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IBGECart
{
    public class Cartinf01 : Cartinf
    {
        private string _NOME_ARQUIVO => "CARTINF01.TXT";
        private string _NOME_ARQUIVO_VELHO => "CARTINF01_BACKUP_";

        public override string NOME_ARQUIVO => _NOME_ARQUIVO;

        public override string NOME_ARQUIVO_VELHO => _NOME_ARQUIVO_VELHO;

        public override TipoArquivo TipoArquivo => TipoArquivo.Cartinf01;

        public bool ExisteArquivoNaPasta() => File.Exists(_NOME_ARQUIVO);

        public override string CorrigeTudo()
        {
            string _content = File.ReadAllText(this._NOME_ARQUIVO);
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
    }
}
