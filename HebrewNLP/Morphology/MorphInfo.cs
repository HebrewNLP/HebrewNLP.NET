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
        public Gender OwnershipGender { get; set; }

        public bool OwnershipPlural { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Person OwnershipPerson { get; set; }

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
                if (Shiabud != info.Shiabud) return false;
                if (PrepositionChars != info.PrepositionChars) return false;
                if (DefiniteArticle != info.DefiniteArticle) return false;
                if (PartOfSpeech != info.PartOfSpeech) return false;
                if (Gender != info.Gender) return false;
                if (Plural != info.Plural) return false;
                if (Person != info.Person) return false;
                if (Smikut != info.Smikut) return false;
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
