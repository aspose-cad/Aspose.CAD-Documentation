---
title: Експорт SHX шрифтів
type: docs
weight: 40
url: /uk/python-net/developer-guide/export-shx-fonts/
---

## **Експорт SHX шрифтів для креслень DXF/DWG**

Деякі креслення можуть містити шрифти в особливому форматі SHX, який зберігає символи шрифту у формі фігур. Цей формат вимагає додаткової
процедури завантаження для кожного шрифту, що використовується в кресленні. Apose.CAD може експортувати креслення з текстом, написаним у SHX, і має різні варіанти для цього. Найпростішим способом зробити це є просто використати 
**ShxFonts** властивість об'єкта 
**CadRasterizationOptions**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
