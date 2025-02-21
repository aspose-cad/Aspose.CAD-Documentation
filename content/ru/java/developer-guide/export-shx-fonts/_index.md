---
title: Экспорт шрифтов SHX
type: docs
weight: 40
url: /ru/java/developer-guide/export-shx-fonts/
---

## **Экспорт шрифтов SHX для чертежей DXF/DWG**

Некоторые чертежи могут содержать шрифты в специальном формате SHX, который хранит символы шрифта в форме фигур.
Этот формат требует дополнительной загрузки для каждого шрифта, используемого в чертеже.
Apose.CAD может экспортировать чертежи с текстом, написанным в SHX, и имеет различные варианты для этого.
Самый простой способ сделать это - просто использовать [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) 
свойство объекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Каждый шрифт SHX поставляется с соответствующей кодовой страницей. Эти ассоциации известны и частично встроены в Aspose.CAD для известных шрифтов SHX.
Если используется пользовательский шрифт SHX, можно применить свойство **setShxCodePages** и задать путь к файлу SHX и соответствующую кодовую страницу.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
