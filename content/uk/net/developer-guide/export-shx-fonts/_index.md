---
title: Експорт шрифтів SHX
type: docs
weight: 40
url: /uk/net/developer-guide/export-shx-fonts/
---

## **Експорт шрифтів SHX для креслень DXF/DWG**

Деякі креслення можуть містити шрифти у спеціальному форматі SHX, який зберігає символи шрифту у формі фігур. Цей формат вимагає додаткової процедури завантаження для кожного шрифту, що використовується у кресленні. Apose.CAD може експортнути креслення з текстом, написаним у SHX, і має різні варіанти для цього. Найпростіший спосіб зробити це - просто використати 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) властивість об'єкта 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


Можна уникнути налаштування всіх шляхів до декількох шрифтів SHX за допомогою наступного прикладу:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}
	
Кожен шрифт SHX має відповідну кодову сторінку, пов'язану з ним. Ці асоціації відомі і частково вбудовані в Aspose.CAD для відомих шрифтів SHX. У випадку, якщо використовується якийсь кастомний шрифт SHX, можна застосувати властивість ShxCodePages та налаштувати шлях до файлу SHX і відповідної кодової сторінки. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
