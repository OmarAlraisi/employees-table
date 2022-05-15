# Translation Script

This is a python script used to translate some strings from English to other languages using google translate.

At the moment the script translates from English to Arabic, Spanish and French.

[Script code here.](../scripts/translate.py)

##

### How to use

- Add a translation key in [translation-keys.cs.](../src/Common/Utilities/Translation/translation-keys.cs) **_This is done to later access the translated strings_**

  - ex: `public string KEY_NAME { get; set; }`

- Only in the [en.json](../src/Common/Utilities/Translation/en.json) add the English value to that key.

  - ex: `"KEY_NAME": "Key value in english",`

- Open terminal and run `npm run translate`.

### Running the script

`npm run translate` which runs `python3 ./scripts/translate.py`.

### Adding more languages

To add more languages go to [translate](../scripts/translate.py) and add language code from google translate to the variable `destLangCodeList` on line 16. This will cause a new JSON file with the name `languagecode.json` in the `Utilities/Translate` directory.
