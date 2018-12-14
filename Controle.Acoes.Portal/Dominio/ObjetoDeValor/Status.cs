using System.ComponentModel.DataAnnotations;

namespace Controle.Acoes.Portal.Dominio.ObjetoDeValor
{
    public enum Status
    {
        Inativo,
        Ativo,
        [Display(Name = "Excluído")]
        Excluido,
        Cache
    }
}
