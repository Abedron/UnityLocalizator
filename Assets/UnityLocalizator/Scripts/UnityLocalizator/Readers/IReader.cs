namespace UnityLocalizator.Readers
{
    public interface IReader
    {
        string Language { get;}
        void ChangeLanguage(string language);
        string Read(string key);
    }
}
