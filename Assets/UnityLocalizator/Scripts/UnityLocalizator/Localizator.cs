using UnityLocalizator;

public class Localizator
{
    public static LocalizatorBook LocalizatorBook;
	
    static Localizator()
    {
        LocalizatorBook = new LocalizatorBook();
    }

    public static string Read(string key)
    {
        return LocalizatorBook.Read(key);
    }

    internal static void SetLanguage(string language)
    {
        LocalizatorBook.SetLanguage(language);
    }
}
