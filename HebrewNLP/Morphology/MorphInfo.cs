using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace HebrewNLP.Morphology
{
    public class MorphInfo
    {

        public string BaseWord { get; set; }

        public bool Vav { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Shiabud Shiabud { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PrepositionChars PrepositionChars { get; set; }

        public bool DefiniteArticle { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PartOfSpeech PartOfSpeech { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        public bool Plural { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Person Person { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Smikut Smikut { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Tense Tense { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender SuffixGender { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public bool SuffixPlural { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Person SuffixPerson { get; set; }

        public bool HasVavOrPrepositionOrShiabud()
        {
            return Vav || (PrepositionChars != PrepositionChars.NONE) || (Shiabud != Shiabud.NONE);
        }

        public bool IsGrammaricallyDefiniteArticle()
        {
            return Smikut == Smikut.NISMAK || HasSuffix() || PartOfSpeech == PartOfSpeech.PROPER_NOUN;
        }

        public bool HasSuffix()
        {
            return SuffixPerson != Person.NONE;
        }

        public bool HasDefinitiveArticle()
        {
            return IsGrammaricallyDefiniteArticle() || DefiniteArticle;
        }

        public bool IsMedium()
        {
            return Tense == Tense.PRESENT || Tense == Tense.PRESENT_PASSIVE;
        }

        public bool IsVerb()
        {
            return PartOfSpeech == PartOfSpeech.VERB || PartOfSpeech == PartOfSpeech.ADVERB;
        }

        public bool Nismak()
        {
            return Smikut == Smikut.NISMAK;
        }

        public bool Is(PartOfSpeech pos)
        {
            return PartOfSpeech == pos;
        }

        public override int GetHashCode()
        {
            int hashcode = Vav.GetHashCode() * 17;
            hashcode += Shiabud.GetHashCode() * 17;
            hashcode += PrepositionChars.GetHashCode() * 17;
            hashcode += DefiniteArticle.GetHashCode() * 17;
            hashcode += PartOfSpeech.GetHashCode() * 17;
            hashcode += Gender.GetHashCode() * 17;
            hashcode += Plural.GetHashCode() * 17;
            hashcode += Person.GetHashCode() * 17;
            hashcode += Smikut.GetHashCode() * 17;
            hashcode += SuffixGender.GetHashCode() * 17;
            hashcode += SuffixPlural.GetHashCode() * 17;
            hashcode += SuffixPerson.GetHashCode() * 17;
            return hashcode;
        }

        public override bool Equals(object obj)
        {
            if (obj is MorphInfo info)
            {
                if (BaseWord != info.BaseWord) return false;
                if (Vav != info.Vav) return false;
                if (Shiabud != info.Shiabud) return false;
                if (PrepositionChars != info.PrepositionChars) return false;
                if (DefiniteArticle != info.DefiniteArticle) return false;
                if (PartOfSpeech != info.PartOfSpeech) return false;
                if (Gender != info.Gender) return false;
                if (Plural != info.Plural) return false;
                if (Person != info.Person) return false;
                if (Smikut != info.Smikut) return false;
                if (Tense != info.Tense) return false;
                if (SuffixGender != info.SuffixGender) return false;
                if (SuffixPlural != info.SuffixPlural) return false;
                if (SuffixPerson != info.SuffixPerson) return false;
                return true;
            }
            return false;
        }

    }
}
