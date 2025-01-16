---
title: Поддръжка на CTB файлове
type: docs
weight: 40
url: /bg/java/support-ctb/
---

## **Поддръжка на CTB файлове**

Понякога цветът, дебелината на линиите и някои други опции за чертежите могат да бъдат използвани не само от самите чертежи, но и от стиловете за печат в отделни CTB файлове. 
Най-простият начин да се използва тази информация е да се поставят съответните CTB файлове до файла с чертежа в DWG/DXF формат и информацията от тях ще бъде приложена 
автоматично по време на експортиране.

Също така е възможно да се заредят всички CTB файлове под формата на поток, използвайки 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) свойството на 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) обект.

Ето пример как да го направите:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
