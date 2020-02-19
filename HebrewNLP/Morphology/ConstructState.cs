using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewNLP.Morphology
{

    /// <summary>
    /// סמיכות
    /// </summary>
    public enum ConstructState
    {
        /// <summary>
        /// אין סמיכות
        /// </summary>
        NONE,

        /// <summary>
        /// נסמך
        /// </summary>
        POSSESED,

        /// <summary>
        /// נפרד
        /// </summary>
        POSSESOR,

        /// <summary>
        /// יכול להיות גם נפרד וגם נסמך
        /// </summary>
        BOTH

    }
}
