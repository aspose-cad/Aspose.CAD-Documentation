---
title: Экспорт шрифтов SHX
type: docs
weight: 40
url: /ru/net/developer-guide/export-shx-fonts/
---

## **Экспорт шрифтов SHX для чертежей DXF/DWG**

Некоторые чертежи могут содержать шрифты в специальном формате SHX, который хранит символы шрифта в виде фигур. Этот формат требует дополнительной
загрузки для каждого шрифта, используемого в чертеже. Apose.CAD может экспортировать чертежи с текстом, написанным в SHX, и предлагает различные возможности для этого. Самый простой способ сделать это - просто использовать 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) свойство объекта 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Пример ShxFonts.cs">}}


Можно избежать настройки всех путей к нескольким шрифтам SHX с помощью следующего примера:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Пример ShxFonts с папкой.cs">}}
	
Каждый шрифт SHX поставляется с соответствующей кодовой страницей. Эти ассоциации известны и частично встроены в Aspose.CAD для известных шрифтов SHX.
В случае использования какого-либо пользовательского шрифта SHX возможно применить свойство ShxCodePages и установить путь к файлу SHX и соответствующей кодовой странице. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Пример ShxCodePages.cs">}}
