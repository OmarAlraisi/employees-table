import json
import os
from googletrans import Translator

def translateStr(jsonStr, lang):
    tr = Translator()
    if isinstance(jsonStr, dict):
        return {key: translateStr(value, lang) for key, value in jsonStr.items()}
    else:
        return tr.translate(jsonStr, dest=lang).text

enJSONFile = os.path.join(os.path.dirname(__file__), '../src/Common/Utilities/Translation/en.json')
langList = [
    'ar',
    'es',
    'fr'
]

for lang in langList:
    print("translating", lang)
    with open(enJSONFile, 'r') as enFile:
        translatedJSON = translateStr(json.load(enFile), lang)
        trJSONFile = os.path.join("./src/Common/Utilities/Translation/" + lang + '.json')
        with open(trJSONFile, 'w') as trFile:
            trFile.write(json.dumps(translatedJSON, indent=2, ensure_ascii=False))