---
title: Експорт шрифтів SHX
type: docs
weight: 40
url: /uk/java/developer-guide/export-shx-fonts/
---

## **Експорт шрифтів SHX для креслень DXF/DWG**

Деякі креслення можуть містити шрифти у спеціальному форматі SHX, що зберігає символи шрифту у вигляді форм.
Цей формат вимагає додаткової процедури завантаження для кожного шрифту, що використовується у кресленні.
Apose.CAD може експортувати креслення з текстом, написаним у SHX, і має різні варіанти для цього.
Найпростіший спосіб зробити це - просто використати [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-)
властивість об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Кожен шрифт SHX має відповідну кодову сторінку, що асоціюється з ним. Ці асоціації відомі і частково вбудовані в Aspose.CAD для відомих шрифтів SHX.
У випадку, якщо використовується який-небудь власний шрифт SHX, можна застосувати властивість **setShxCodePages** і встановити шлях до файлу SHX та відповідної кодової сторінки.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
