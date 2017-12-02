using UnityEngine;
using UnityEngine.UI;
using UnityLocalizator.Readers;

public class MainLocalizatron : MonoBehaviour
{
    public Text FirstText;
    public Text SecondText;
    public Text LanguageText;

    private IReader locoReader;

    private void Start()
    {
        locoReader = new LocoReader("en-GB");
        Localizator.LocalizatorBook.AddReader(locoReader);
        Localizator.LocalizatorBook.OnLanguageChange += (d) =>
        {
            FirstText.text = Localizator.Read("Future");
            SecondText.text = Localizator.Read("FutureButton");
            LanguageText.text = Localizator.LocalizatorBook.CurrentLanguage;
        };

        Localizator.SetLanguage("en-GB");
    }

    public void EnClick()
    {
        Localizator.LocalizatorBook.SetLanguage("en-GB");
    }

    public void SkClick()
    {
        Localizator.LocalizatorBook.SetLanguage("sk-SK");
    }
}
