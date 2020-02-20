using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewNLP.Morphology
{

    /// <summary>
    /// זמן
    /// </summary>
    public enum Tense
    {

        /// <summary>
        /// אין
        /// </summary>
        NONE,

        /// <summary>
        /// עבר
        /// </summary>
        PAST,

        /// <summary>
        /// הווה
        /// </summary>
        PRESENT,

        /// <summary>
        /// עתיד
        /// </summary>
        FUTURE,

        /// <summary>
        /// הווה סביל (פעול)
        /// </summary>
        PRESENT_PASSIVE,

        /// <summary>
        /// ציווי
        /// </summary>
        IMPERATIVE,

        /// <summary>
        /// מקור
        /// </summary>
        INFINITIVE

    }
}
