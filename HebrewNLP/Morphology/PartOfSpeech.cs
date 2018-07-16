﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewNLP.Morphology
{

    /// <summary>
    /// חלק דיבור
    /// </summary>
    public enum PartOfSpeech
    {

        /// <summary>
        /// אין
        /// </summary>
        NONE,

        /// <summary>
        /// פועל
        /// </summary>
        VERB,

        /// <summary>
        /// עצם
        /// </summary>
        NOUN,

        /// <summary>
        /// תואר
        /// </summary>
        ADJECTIVE,

        /// <summary>
        /// מיספר
        /// </summary>
        NUMBER,

        /// <summary>
        /// מילת יחס
        /// </summary>
        PREPOSITION,

        /// <summary>
        /// סימני פיסוק
        /// </summary>
        PUNCTUATION,

        /// <summary>
        /// מילת גוף
        /// </summary>
        PRONOUN,

        /// <summary>
        /// מילת שאלה
        /// </summary>
        QUESTION_WORD,

        /// <summary>
        /// מילת חיבור
        /// </summary>
        CONJUNCTION,

        /// <summary>
        /// מילית
        /// </summary>
        PARTICLE,

        /// <summary>
        /// תואר הפועל
        /// </summary>
        ADVERB,

        /// <summary>
        /// פועל עזר
        /// </summary>
        MODAL,

        /// <summary>
        /// שם פרטי
        /// </summary>
        PROPER_NOUN

    }
}
