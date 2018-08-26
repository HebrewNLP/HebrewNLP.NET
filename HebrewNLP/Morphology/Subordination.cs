using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewNLP.Morphology
{

    /// <summary>
    /// שיעבוד
    /// </summary>
    public enum Subordination
    {

        /// <summary>
        /// אף אחד
        /// </summary>
        NONE,

        /// <summary>
        /// ש...
        /// </summary>
        SHE,

        /// <summary>
        /// כש...
        /// </summary>
        KSHE,

        /// <summary>
        /// לכש...
        /// </summary>
        LEKSHE,

        /// <summary>
        /// שכש...
        /// </summary>
        SHEKSHE,

        /// <summary>
        /// ה...
        /// </summary>
        HA,

        /// <summary>
        /// לא ידוע
        /// </summary>
        ANY,

        /// <summary>
        /// שה...
        /// </summary>
        SHEHA

    }
}
