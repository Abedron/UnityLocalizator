using System.Collections.Generic;
using UnityLocalizator.Readers;

namespace UnityLocalizator
{
    public class LocalizatorBook
    {
        public delegate void LanguageChange(string language);
        public event LanguageChange OnLanguageChange;

        private string currentLanguage;
        public string CurrentLanguage { get { return currentLanguage; } private set { currentLanguage = value; } }

        private List<IReader> readers = new List<IReader>();

        public void AddReader(IReader reader)
        {
            readers.Add(reader);
        }

        public void RemoveReader(IReader reader)
        {
            readers.Remove(reader);
        }

        public string Read(string key)
        {
            foreach (IReader reader in readers)
            {
                string word = reader.Read(key);
                if (word != string.Empty)
                    return word;
            }

            return "None";
        }

        public void SetLanguage(string language)
        {
            currentLanguage = language;

            foreach (IReader reader in readers)
            {
                reader.ChangeLanguage(language);
            }

            if (OnLanguageChange != null)
                OnLanguageChange.Invoke(language);
        }
    }
}
