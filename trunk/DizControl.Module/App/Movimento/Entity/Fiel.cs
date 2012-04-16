using System;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System.ComponentModel;

namespace DizControl.Module
{
    /// <summary>
    /// Fiéis da congregação
    /// </summary>
    public class Fiel: BaseObject
    {
        #region Attributes
        /*Todo atribute deve ter o prefixo _ */
        /// <summary>
        /// Nome do fiels
        /// </summary>
        private string _TxNome;

        /// <summary>
        /// Último nome
        /// </summary>
        private string _TxUltimoNome;

        /// <summary>
        /// Data de Nascimento
        /// </summary>
        private DateTime _DtNascimento;

        /// <summary>
        /// Registro geral do fiél
        /// </summary>
        private uint _Rg;

        /// <summary>
        /// Cadastro de Pessoa Física do fiél
        /// </summary>
        private uint _CPF;

        /// <summary>
        /// Data de Cadastro do fiel
        /// </summary>
        private DateTime _DtCadastro;

        /// <summary>
        /// Profissão do fiel
        /// </summary>
        private ProfissaoFiel _Profissao;

        /// <summary>
        /// Dízimo
        /// </summary>
        private Dizimo _Dizimo;

        /// <summary>
        /// Endereço
        /// </summary>
        private Endereco _Endereco;
        #endregion
       
        #region Properties
        /// <summary>
        /// Nome do fiels
        /// </summary>
        [Custom("Caption", "Nome")]
        public string TxNome 
        {
            get { return _TxNome; }
            set { SetPropertyValue<string>("TxNome", ref _TxNome, value); } 
        }

        /// <summary>
        /// Último nome
        /// </summary>
        [Custom("Caption", "Último Nome")]
        public string TxUltimoNome 
        {
            get { return _TxUltimoNome; }
            set { SetPropertyValue<string>("TxUltimoNome", ref _TxUltimoNome, value); } 
        }

        /// <summary>
        /// Data de Nascimento
        /// </summary>
        [Custom("Caption", "Data Nascimento")]
        public DateTime DtNascimento 
        {
            get { return _DtNascimento; }
            set { SetPropertyValue<DateTime>("DtNascimento", ref _DtNascimento, value); }
        }

        /// <summary>
        /// Registro geral do fiél
        /// </summary>
        [Custom("Caption", "RG")]
        public uint Rg 
        {
            get { return _Rg; }
            set { SetPropertyValue<uint>("Rg", ref _Rg, value); } 
        }

        /// <summary>
        /// Cadastro de Pessoa Física do fiél
        /// </summary>
        [Custom("Caption", "CPF")]
        public uint CPF 
        {
            get { return _CPF; }
            set { SetPropertyValue<uint>("CPF", ref _CPF, value); } 
        }

        /// <summary>
        /// Data de Cadastro do fiel
        /// </summary>        
        [Browsable(false)]
        private DateTime DtCadastro
        {
            get { return _DtCadastro; }
            set { SetPropertyValue<DateTime>("DtCadastro", ref _DtCadastro, value); }
        }

        /// <summary>
        /// Profissão do fiel
        /// </summary>
        public ProfissaoFiel Profissao
        {
            get { return _Profissao; }
            set { SetPropertyValue<ProfissaoFiel>("Profissao", ref _Profissao, value); }
        }

        /// <summary>
        /// Dízimo
        /// </summary>
        public Dizimo Dizimo 
        {
            get { return _Dizimo; }
            set { SetPropertyValue<Dizimo>("Dizimo", ref _Dizimo, value); }
        }

        /// <summary>
        /// Endereço
        /// </summary>
        public Endereco Endereco
        {
            get { return _Endereco; }
            set{ SetPropertyValue<Endereco>("Endereco", ref _Endereco, value);}
        }
        #endregion

        #region Rule Business

        #endregion
    }
}
