

namespace Controle.Acoes.Portal.Auxiliares.Interfaces.Validacao
{
    public interface IAutoValidacao
    {
        INotificarValidacao Notificacoes { get; }

        bool EhValido();
    }
}
