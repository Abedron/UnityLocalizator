using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

namespace UnityLocalizator.Readers
{
    class LocoReader : IReader
    {
        private Dictionary<string, string> languageLibrary = new Dictionary<string, string>();

        private string language;
        public string Language { get { return language; } }

        public LocoReader(string language)
        {
            ChangeLanguage(language);
        }

        public void ChangeLanguage(string language)
        {
            this.language = language;

            TextAsset asset = Resources.Load<TextAsset>("locales/" + language + "/localizatron-" + language);

            languageLibrary = JsonConvert.DeserializeObject<Dictionary<string, string>>(asset.text);
        }

        public string Read(string key)
        {
            if (!languageLibrary.ContainsKey(key))
                return string.Empty;
            
            return languageLibrary[key];
        }
    }
}
