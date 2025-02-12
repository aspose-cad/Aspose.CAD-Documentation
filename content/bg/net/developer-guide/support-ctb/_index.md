---
title: Поддръжка на CTB файлове
type: docs
weight: 40
url: /bg/net/developer-guide/support-ctb/
---

## **Поддръжка на CTB файлове**

Понякога цветове, дебелини на линии и някои други опции за рисувания може да се използват не само от самите рисувания, но и от стилове на печат в отделни CTB файлове. 
Най-простият начин да използвате тази информация е да поставите съответните CTB файлове близо до файла с рисуването в DWG/DXF формат и информацията от тях ще бъде приложена
автоматично по време на експортиране.

Също така е възможно да се заредят всички CTB файлове под формата на поток, използвайки 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) свойството на 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) обект.

Ето пример как да направите това:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
