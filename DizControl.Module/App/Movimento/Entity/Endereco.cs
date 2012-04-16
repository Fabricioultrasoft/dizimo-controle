using System;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DizControl.Module
{
    /// <summary>
    /// Endereço dos fiéis
    /// </summary>
    public class Endereco: BaseObject
    {
        #region Attribute
        /// <summary>
        /// Tipo do logradouro
        /// </summary>
        private CsTipoLogradouro _Tipo;

        /// <summary>
        /// Logradouro
        /// </summary>
        private string _TxLogradouro;

        /// <summary>
        /// Bairro
        /// </summary>
        private string _TxBairro;

        /// <summary>
        /// Cidade 
        /// </summary>
        private string _TxCidade;

        /// <summary>
        /// Unidade da federação
        /// </summary>
        private CsUnidadeFederacao _Estado;

        /// <summary>
        /// CEP do logradouro
        /// </summary>
        private uint _CEP;
        #endregion
        
        #region Propeties
        /// <summary>
        /// Tipo do logradouro
        /// </summary>
        [Custom("Caption", "Tipo")]
        public CsTipoLogradouro Tipo 
        {
            get { return _Tipo; }
            set { SetPropertyValue<CsTipoLogradouro>("Tipo", ref _Tipo, value); }
        }

        /// <summary>
        /// Logradouro
        /// </summary>
        [Custom("Caption", "Logradouro")]
        public string TxLogradouro
        {
            get { return _TxLogradouro; }
            set { SetPropertyValue<string>("TxLogradouro", ref _TxLogradouro, value); }
        }

        /// <summary>
        /// Bairro
        /// </summary>
        [Custom("Caption", "Bairro")]
        public string TxBairro
        {
            get { return _TxBairro; }
            set { SetPropertyValue<string>("TxBairro", ref _TxBairro, value); }
        }

        /// <summary>
        /// Cidade 
        /// </summary>
        [Custom("Caption", "Cidade")]
        public string TxCidade
        {
            get { return _TxCidade; }
            set { SetPropertyValue<string>("TxCidade", ref _TxCidade, value); }
        }

        /// <summary>
        /// Unidade da federação
        /// </summary>
        [Custom("Caption", "Estado")]
        public CsUnidadeFederacao Estado
        {
            get { return _Estado; }
            set { SetPropertyValue<CsUnidadeFederacao>("Estado", ref _Estado, value); }
        }

        /// <summary>
        /// CEP do logradouro
        /// </summary>
        [Custom("Caption", "CEP")]
        public uint CEP
        {
            get { return _CEP; }
            set { SetPropertyValue<uint>("CEP", ref _CEP, value); }
        }
        #endregion

        #region Rule Business
        /// <summary>
        /// Busca o endereço pelo cep
        /// </summary>
        /// <param name="session">sessão atual</param>
        /// <param name="cep">CEP</param>
        /// <returns>Endereço</returns>
        public static Endereco GetEndereco(Session session, uint cep) 
        {
            return session.FindObject<Endereco>(CriteriaOperator.Parse("[CEP] = ?", cep));
        }
        #endregion
    }
}
