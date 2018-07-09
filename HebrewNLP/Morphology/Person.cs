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
        /// אין
        /// </summary>
        NONE,

        BOTH,

        /// <summary>
        /// גוף ראשון
        /// </summary>
        FIRST_PERSON,

        /// <summary>
        /// גוף שני
        /// </summary>
        SECOND_PERSON,

        /// <summary>
        /// גוף שלישי
        /// </summary>
        THIRD_PERSON

    }
}
