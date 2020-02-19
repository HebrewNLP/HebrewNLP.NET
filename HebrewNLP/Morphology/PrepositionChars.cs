using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewNLP.Morphology
{

    /// <summary>
    /// אותיות יחוס
    /// </summary>
    public enum PrepositionChars
    {

        /// <summary>
        /// אף אחד
        /// </summary>
        NONE,

        /// <summary>
        /// ב
        /// </summary>
        BET,

        /// <summary>
        /// מ
        /// </summary>
        MEM,

        /// <summary>
        /// ל
        /// </summary>
        LAMED,

        /// <summary>
        /// כ
        /// </summary>
        KAF,

        /// <summary>
        ///כב...
        /// </summary>
        KAF_BET,

        /// <summary>
        ///כל...
        /// </summary>
        KAF_LAMED,

        /// <summary>
        ///כמ...
        /// </summary>
        KAF_MEM,

        /// <summary>
        ///בכ...
        /// </summary>
        BET_KAF,

        /// <summary>
        ///מכ
        /// </summary>
        MEM_KAF,

        /// <summary>
        ///מב
        /// </summary>
        MEM_BET,

        /// <summary>
        ///מל
        /// </summary>
        MEM_LAMED,

        /// <summary>
        ///לכ
        /// </summary>
        LAMED_KAF,

        /// <summary>
        /// כל אחת מן האפשרויות
        /// </summary>
        ANY

    }
}
