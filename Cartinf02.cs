﻿using IBGECart.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IBGECart
{
    public class Cartinf02 : Cartinf
    {
        private string _NOME_ARQUIVO => "CARTINF02.TXT";
        private string _NOME_ARQUIVO_VELHO => "CARTINF02_BACKUP_";

        public override string NOME_ARQUIVO => _NOME_ARQUIVO;

        public override string NOME_ARQUIVO_VELHO => _NOME_ARQUIVO_VELHO;

        public override TipoArquivo TipoArquivo => TipoArquivo.Cartinf02;

        public bool ExisteArquivoNaPasta() => File.Exists(NOME_ARQUIVO);

        public override string CorrigeTudo()
        {
            string _content = File.ReadAllText(this.NOME_ARQUIVO);
            char[] content = _content.ToCharArray();
            string newContent = "";
            newContent += content[0];

            for (int i = 0, j = 1; i < content.Length && j < content.Length; i++, j++)
            {
                if ((content[i] == 'B' && content[j] == '0') ||
                    (content[i] == 'R' && content[j] == '0')) continue;

                newContent += content[j];
            }

            return newContent;
        }
    }
}
