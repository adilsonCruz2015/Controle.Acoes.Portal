using Solucoes.Auxiliares.Interfaces.Validacao;
using System;
using System.ComponentModel.DataAnnotations;

namespace Controle.Acoes.Portal.Dominio.Comandos.Comum
{
    public abstract class GuidIdCmd : IAutoValidacao
    {
        public GuidIdCmd()
        {

        }

        public GuidIdCmd(Guid? id)
            :this()
        {
            this.Id = id;
        }

        [Required(
            ErrorMessageResourceType = typeof(ValidacaoMsg),
            ErrorMessageResourceName = ValidacaoNomeMsg.EhRequirido)]
        [GuidValido]
        public virtual Guid? Id { get; set; }

        public INotificarValidacao Notificacoes => throw new System.NotImplementedException();

        public bool EhValido()
        {
            throw new System.NotImplementedException();
        }
    }
}
