---
title: Експорт на SHX шрифтове
type: docs
weight: 40
url: /bg/net/export-shx-fonts/
---

## **Експорт на SHX шрифтове за DXF/DWG чертежи**

Някои чертежи може да съдържат шрифтове в специален SHX формат, който съхранява символите на шрифта под формата на форми. Този формат изисква допълнителна 
процедура за зареждане за всеки използван шрифт в чертежа. Apose.CAD може да експортира чертежи с текст, написан в SHX и предлага различни опции за това. Най-простият начин да го направите е просто да използвате 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) свойството на 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) обект.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


Възможно е да се избегне задаването на всички пътища към множество SHX шрифтове с помощта на следния пример:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}
	
Всеки SHX шрифт идва с подходящата кодова страница, свързана с него. Тези асоциации са известни и частично вградени в Aspose.CAD за известни SHX шрифтове.
В случай, че се използва собствен SHX шрифт, е възможно да се приложи свойството ShxCodePages и да се зададе път към SHX файл и съответната кодова страница. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
