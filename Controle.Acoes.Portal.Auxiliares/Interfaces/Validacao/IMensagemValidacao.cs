

using Controle.Acoes.Portal.Auxiliares.Validacao;
using System;

namespace Controle.Acoes.Portal.Auxiliares.Interfaces.Validacao
{
    public interface IMensagemValidacao
    {
        Guid Id { get; }

        DateTime Data { get; }

        string Mensagem { get; }

        string Referencia { get; }

        TipoMensagem Tipo { get; }
    }
}
