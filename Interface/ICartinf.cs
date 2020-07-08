using System;
using System.Collections.Generic;
using System.Text;

namespace IBGECart.Interface
{
    interface ICartinf
    {
        string NOME_ARQUIVO { get; }
        string NOME_ARQUIVO_VELHO { get; }
        TipoArquivo TipoArquivo { get; }
        string CorrigeTudo();
        void CorrigeArquivo();
    }
}
