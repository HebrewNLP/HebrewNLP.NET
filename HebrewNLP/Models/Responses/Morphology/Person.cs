using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewNLP.Morphology
{

    /// <summary>
    /// גוף
    /// </summary>
    public enum Person
    {
        /// <summary>
        /// אין גוף
        /// </summary>
        NONE = 0,

        /// <summary>
        /// גוף ראשון
        /// </summary>
        FIRST = 1,

        /// <summary>
        /// גוף שני
        /// </summary>
        SECOND = 2,

        /// <summary>
        /// גוף שלישי
        /// </summary>
        THIRD = 3,

        /// <summary>
        /// גם וגם
        /// </summary>
        ANY = 4


    }
}
