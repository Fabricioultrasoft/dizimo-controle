using System;
using DevExpress.Persistent.BaseImpl;

namespace DizControl.Module
{
    /// <summary>
    /// Dados profissionais do fiel
    /// </summary>
    public class Profissao: BaseObject
    {
        #region Attribute
        /// <summary>
        /// Nome da Empresa
        /// </summary>
        private string _NomeEmpresa;

        /// <summary>
        /// CNPJ da empresa
        /// </summary>
        private uint _CNPJ;

        /// <summary>
        /// Telefone da empresa
        /// </summary>
        private uint _Telfone;
        #endregion

        #region Properties
        /// <summary>
        /// Nome da Empresa
        /// </summary>
        public string NomeEmpresa 
        {
            get { return _NomeEmpresa; }
            set { SetPropertyValue<string>("NomeEmpresa", ref _NomeEmpresa, value); }
        }

        /// <summary>
        /// CNPJ da empresa
        /// </summary>
        public uint CNPJ
        {
            get { return _CNPJ; }
            set { SetPropertyValue<uint>("CNPJ", ref _CNPJ, value); }
        }

        /// <summary>
        /// Telefone da empresa
        /// </summary>
        public uint Telfone 
        {
            get { return _Telfone; }
            set { SetPropertyValue<uint>("Telfone", ref _Telfone, value); }
        }
        #endregion
    }
}
