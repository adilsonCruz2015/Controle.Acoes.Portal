using Controle.Acoes.Portal.Dominio.ObjetoDeValor;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Controle.Acoes.Portal.Dominio.Entidades
{
    public class Nota 
    {
        public Nota()
        {
            this.Id = Guid.NewGuid();
            this.CriadoEm = DateTime.Now;
            this.AlteradoEm = DateTime.Now;
        }

        [Display(Name = "Nota")]
        public virtual Guid Id { get; protected internal set; }

        [Display(Name = "Tipo de Operação")]
        public TipoOperacao Tipo { get; set; }

        public string Ativo { get; set; }

        public int Qauntidade { get; set; }

        public double Preco { get; set; }

        [Display(Name = "Data da Operação")]
        public DateTime DataOperacao { get;  set; }

        [Display(Name = "Criado Em")]
        public DateTime CriadoEm { get; protected internal set; }

        [Display(Name = "Alterado Em")]
        public DateTime AlteradoEm { get; protected internal set; }

        [Display(Name = "Taxa de Corretagem")]
        public double TaxaCorretagem { get; set; }

        [Display(Name = "Emolumento Bovespa")]
        public double EmolumentoBovespa { get; set; }

        [Display(Name = "Taxa Liquida CBLC")]
        public double TaxaLiquidaCBLC { get; set; }

        [Display(Name = "IRRF Final")]
        public double IRRFFinal { get; set; }

        [Display(Name = "Lucro Day Trade")]
        public double LucroDayTrade { get; set; }

        [Display(Name = "IRRF Day Trade")]
        public double IRRFDayTrade { get; set; }

        #region Operador ----------------------------------

        public override bool Equals(object obj)
        {
            Nota comparar = obj as Nota;
            return !object.Equals(comparar, null)
                && this.GetHashCode() == comparar.GetHashCode();
        }

        public override int GetHashCode()
        {
            return string.Format("[Nota:{0}]", this.Id).GetHashCode();
        }

        public static bool operator ==(Nota a, Nota b)
        {
            return object.Equals(a, null) && object.Equals(b, null)
                || (!object.Equals(a, null) && !object.Equals(b, null) && a.Equals(b));
        }

        public static bool operator !=(Nota a, Nota b)
        {
            return !(object.Equals(a, null) && object.Equals(b, null)
                || (!object.Equals(a, null) && !object.Equals(b, null) && a.Equals(b)));
        }

        #endregion        
    }
}
