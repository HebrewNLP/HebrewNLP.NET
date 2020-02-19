using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewNLP.Morphology
{

    /// <summary>
    ///  מין
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// אף אחד
        /// </summary>
        NONE=0,

        /// <summary>
        /// זכר
        /// </summary>
        MALE=1,

        /// <summary>
        /// נקבה
        /// </summary>
        FEMALE=2,
        
        /// <summary>
        /// שניהם
        /// </summary>
        BOTH=3

    }
}
