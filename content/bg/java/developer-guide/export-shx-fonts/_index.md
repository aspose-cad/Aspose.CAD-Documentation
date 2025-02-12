---
title: Експортиране на SHX шрифтове
type: docs
weight: 40
url: /bg/java/developer-guide/export-shx-fonts/
---

## **Експортиране на SHX шрифтове за DXF/DWG чертежи**

Някои чертежи могат да съдържат шрифтове в специален SHX формат, който съхранява символите на шрифта под формата на форми.
Този формат изисква допълнителна процедура за зареждане за всеки шрифт, използван в чертежа.
Apose.CAD може да експортира чертежи с текст, написан на SHX, и предлага различни опции за това.
Най-простият начин да го направите е просто да използвате [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) свойството на обекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Всеки SHX шрифт идва с подходящата кодова страница, свързана с него. Тези асоциации са известни и частично вградени в Aspose.CAD за известни SHX шрифтове.
В случай, че се използва собствен SHX шрифт, е възможно да се приложи свойството **setShxCodePages** и да се зададе пътят до SHX файла и съответстващата кодова страница.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
