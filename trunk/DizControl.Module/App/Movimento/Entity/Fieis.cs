using System;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace DizControl.Module
{
    /// <summary>
    /// Fiéis da congregação
    /// </summary>
    public class Fieis: BaseObject
    {
        #region Attributes
        /*Todo atribute deve ter o prefixo _ */
        /// <summary>
        /// Nome do fiels
        /// </summary>
        private string _Nome;

        /// <summary>
        /// Último nome
        /// </summary>
        private string _UltimoNome;

        /// <summary>
        /// Registro geral do fiél
        /// </summary>
        private uint _Rg;

        /// <summary>
        /// Cadastro de Pessoa Física do fiél
        /// </summary>
        private uint _CPF;

        /// <summary>
        /// Endereço do fiél
        /// </summary>
        private Endereco _Endereco;
        #endregion
       
        #region Properties
        /// <summary>
        /// Nome do fiels
        /// </summary>
        [Custom("Caption", "Nome")]
        public string Nome 
        {
            get { return _Nome; }
            set { SetPropertyValue<string>("Nome", ref _Nome, value); } 
        }

        /// <summary>
        /// Último nome
        /// </summary>
        [Custom("Caption", "Último Nome")]
        public string UltimoNome 
        {
            get { return _UltimoNome; }
            set { SetPropertyValue<string>("UltimoNome", ref _UltimoNome, value); } 
        }

        /// <summary>
        /// Registro geral do fiél
        /// </summary>
        public uint Rg 
        {
            get { return _Rg; }
            set { SetPropertyValue<uint>("Rg", ref _Rg, value); } 
        }

        /// <summary>
        /// Cadastro de Pessoa Física do fiél
        /// </summary>
        public uint CPF 
        {
            get { return _CPF; }
            set { SetPropertyValue<uint>("CPF", ref _CPF, value); } 
        }

        /// <summary>
        /// Endereço do fiél
        /// </summary>
        public Endereco Endereco 
        {
            get { return _Endereco; }
            set { SetPropertyValue<Endereco>("Endereco", ref _Endereco, value); } 
        }
        #endregion

        #region Rule Business

        #endregion
    }
}
