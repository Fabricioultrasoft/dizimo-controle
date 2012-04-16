using System;
using DevExpress.Xpo;

namespace DizControl.Module
{
    /// <summary>
    /// Endereço da Empresa
    /// </summary>
    public class ProfissaoFiel: Profissao
    {
        #region Attribute
        /// <summary>
        /// Cargo do fiel
        /// </summary>
        private string _TxCargo;

        /// <summary>
        /// TxFunção
        /// </summary>
        private string _TxFuncao;

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
        /// Cargo do fiel
        /// </summary>
        [Custom("Caption", "Cargo")]
        public string TxCargo
        { 
            get { return _TxCargo; }
            set { SetPropertyValue<string>("TxCargo", ref _TxCargo, value); }
        }

        /// <summary>
        /// TxFunção
        /// </summary>
        [Custom("Caption", "Função")]
        public string TxFuncao 
        { 
            get { return _TxFuncao; }
            set { SetPropertyValue<string>("TxFuncao", ref _TxFuncao, value); }
        }
        
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
