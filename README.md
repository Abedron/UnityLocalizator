# UnityLocalizator
Universal localizations for variable platform, like localise.biz. It allows you to use even more platforms at once with custom readers.

## Install
* Check how the example ;)
* Copy `/Assets/UnityLocalizator/Scripts/` to you project.
* Create own Reader with `IReader` interface and place him out of UnityLocalizator scripts
* Add you reader with code `Localizator.LocalizatorBook.AddReader(IReader);`
* You can detect change language with event:
```C#
Localizator.LocalizatorBook.OnLanguageChange += (d) =>
{
  FirstText.text = Localizator.Read("Future");
};
```

## Note
Example contains UnityPackage [Newtonsoft.Json.dll](https://github.com/SaladLab/Json.Net.Unity3D). Maybe you want remove it.

## Roadmap
Implement default readers for some platform.
