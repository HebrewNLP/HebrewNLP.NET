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
        public string BaseWordMenukad { get; set; }

        public bool Vav { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Subordination Subordination { get; set; }

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
        public ConstructState ConstructState { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Tense Tense { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender OwnershipGender { get; set; }

        public bool OwnershipPlural { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Person OwnershipPerson { get; set; }

        public override int GetHashCode()
        {
            int hashcode = Vav.GetHashCode() * 17;
            hashcode += Subordination.GetHashCode() * 17;
            hashcode += PrepositionChars.GetHashCode() * 17;
            hashcode += DefiniteArticle.GetHashCode() * 17;
            hashcode += PartOfSpeech.GetHashCode() * 17;
            hashcode += Gender.GetHashCode() * 17;
            hashcode += Plural.GetHashCode() * 17;
            hashcode += Person.GetHashCode() * 17;
            hashcode += ConstructState.GetHashCode() * 17;
            hashcode += OwnershipGender.GetHashCode() * 17;
            hashcode += OwnershipPlural.GetHashCode() * 17;
            hashcode += OwnershipPerson.GetHashCode() * 17;
            return hashcode;
        }

        public override bool Equals(object obj)
        {
            if (obj is MorphInfo info)
            {
                if (BaseWord != info.BaseWord) return false;
                if (Vav != info.Vav) return false;
                if (Subordination != info.Subordination) return false;
                if (PrepositionChars != info.PrepositionChars) return false;
                if (DefiniteArticle != info.DefiniteArticle) return false;
                if (PartOfSpeech != info.PartOfSpeech) return false;
                if (Gender != info.Gender) return false;
                if (Plural != info.Plural) return false;
                if (Person != info.Person) return false;
                if (ConstructState != info.ConstructState) return false;
                if (Tense != info.Tense) return false;
                if (OwnershipGender != info.OwnershipGender) return false;
                if (OwnershipPlural != info.OwnershipPlural) return false;
                if (OwnershipPerson != info.OwnershipPerson) return false;
                return true;
            }
            return false;
        }

    }
}
