using System;
using DevExpress.Persistent.BaseImpl;

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
        private string _Logradouro;

        /// <summary>
        /// Bairro
        /// </summary>
        private string _Bairro;

        /// <summary>
        /// Cidade 
        /// </summary>
        private string _Cidade;

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
        public CsTipoLogradouro Tipo 
        {
            get { return _Tipo; }
            set { SetPropertyValue<CsTipoLogradouro>("Tipo", ref _Tipo, value); }
        }

        /// <summary>
        /// Logradouro
        /// </summary>
        public string Logradouro
        {
            get { return _Logradouro; }
            set { SetPropertyValue<string>("Logradouro", ref _Logradouro, value); }
        }

        /// <summary>
        /// Bairro
        /// </summary>
        public string Bairro
        {
            get { return _Bairro; }
            set { SetPropertyValue<string>("Bairro", ref _Bairro, value); }
        }

        /// <summary>
        /// Cidade 
        /// </summary>
        public string Cidade
        {
            get { return _Cidade; }
            set { SetPropertyValue<string>("Cidade", ref _Cidade, value); }
        }

        /// <summary>
        /// Unidade da federação
        /// </summary>
        public CsUnidadeFederacao Estado
        {
            get { return _Estado; }
            set { SetPropertyValue<CsUnidadeFederacao>("Estado", ref _Estado, value); }
        }

        /// <summary>
        /// CEP do logradouro
        /// </summary>
        public uint CEP
        {
            get { return _CEP; }
            set { SetPropertyValue<uint>("CEP", ref _CEP, value); }
        }
        #endregion
    }
}
