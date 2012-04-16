using System;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace DizControl.Module.App.Movimento.Entity
{
    /// <summary>
    /// Endereço do fiel
    /// </summary>
    public class FielEndereco: Fiel
    {
        #region Attribute
        /// <summary>
        /// Número da casa ou apartamento
        /// </summary>
        private string _TxNumero;

        /// <summary>
        /// Complemento do endereço
        /// </summary>
        private string _TxComplemento;


        /// <summary>
        /// Endereço do fiél
        /// </summary>
        private Endereco _Endereco;
        #endregion

        #region Properties
        /// <summary>
        /// Número da casa ou apartamento
        /// </summary>
        [Custom("Caption", "Número")]
        public string TxNumero 
        {
            get { return _TxNumero; }
            set { SetPropertyValue<string>("TxNumero", ref _TxNumero, value); }
        }

        /// <summary>
        /// Complemento do endereço
        /// </summary>
        [Custom("Caption", "Complemento")]
        public string TxComplemento 
        {
            get { return _TxComplemento; }
            set { SetPropertyValue<string>("TxComplemento", ref _TxComplemento, value); }
        }
        
        /// <summary>
        /// Endereço do fiél
        /// </summary>
        [Custom("Caption", "Endereço")]
        public Endereco Endereco
        {
            get { return _Endereco; }
            set { SetPropertyValue<Endereco>("Endereco", ref _Endereco, value); }
        }
        #endregion
    }
}
