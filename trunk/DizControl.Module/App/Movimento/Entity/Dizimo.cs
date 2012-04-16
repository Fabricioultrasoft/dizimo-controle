using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Persistent.BaseImpl;

namespace DizControl.Module
{
    /// <summary>
    /// Percentual do dízimo
    /// </summary>
    public class Dizimo: BaseObject
    {
        #region Attribute
        /// <summary>
        /// Descrição do dízimo
        /// </summary>
        private string _TxDizimo;

        /// <summary>
        /// Percentual de contribuição do dízimo
        /// </summary>
        private double _Percentual;
        #endregion
        #region Properties
        /// <summary>
        /// Descrição do dízimo
        /// </summary>
        public string TxDizimo 
        {
            get { return _TxDizimo; }
            set { SetPropertyValue<string>("TxDizimo", ref _TxDizimo, value); }
        }

        /// <summary>
        /// Percentual de contribuição do dízimo
        /// </summary>
        public double Percentual
        {
            get { return _Percentual; }
            set { SetPropertyValue<double>("Percentual", ref _Percentual, value); }
        }
        #endregion
    }
}
