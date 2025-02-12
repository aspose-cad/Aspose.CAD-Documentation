---
title: نقاشی‌های DWG
type: docs
weight: 70
url: /fa/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **صادرات نقاشی‌های DWG به PDF**

Aspose.CAD برای API پایتون می‌تواند نقاشی‌های AutoCAD را در فرمت [DWG](https://docs.fileformat.com/cad/dwg/) بارگذاری کرده و آن را به [PDF](https://docs.fileformat.com/pdf/) تبدیل کند. این موضوع توضیح می‌دهد که چگونه از API Aspose.CAD برای دستیابی به تبدیل DWG به فرمت PDF از طریق مراحل ساده‌ای که در ادامه تعریف شده استفاده کنیم.

{{% alert color="primary" %}}

API از بازبینی‌های زیر DWG AutoCAD پشتیبانی می‌کند:

- DWG نسخه 16.0 انتشار 18 سال 2004 
- DWG نسخه  16.1 سال 2005
- DWG نسخه 18.0 سال 2010
- DWG نسخه 19.0 سال 2013

{{% /alert %}}

### **فرمت فایل DWG**

یک [DWG](https://docs.fileformat.com/cad/dwg/) یک فایل باینری است که داده‌های تصویر وکتور و متا داده‌ها را شامل می‌شود. داده‌های تصویر وکتور دستورالعمل‌هایی به برنامه CAD می‌دهند که چگونه DWG را نمایش دهد؛ متا داده‌ها ممکن است شامل انواع مختلفی از اطلاعات درباره فایل از جمله داده‌های خاص موقعیت و همچنین داده‌های مشتری باشند. مشخصات باز برای فرمت فایل DWG را می‌توان [در این PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) یافت.

### **تبدیل فایل‌های DWG به PDF**

مراحل ساده زیر برای تبدیل [DWG](https://docs.fileformat.com/cad/dwg/) به [PDF](https://docs.fileformat.com/pdf/) مورد نیاز است.

1. فایل DWG را در یک نمونه از **Image** بارگذاری کنید.
1. یک شی از کلاس **CadRasterizationOptions** ایجاد کرده و خصوصیات **page_height** و **page_width** را تنظیم کنید.
1. یک شی از کلاس **PdfOptions** ایجاد کرده و خصوصیت **VectorRasterizationOptions** را تنظیم کنید.
1. **Image.save** را صدا بزنید در حالی که یک شی از **PdfOptions** را به عنوان پارامتر دوم منتقل می‌کنید.

قطعه کد زیر نشان می‌دهد که چگونه نقاشی‌های DWG را به PDF صادر کنیم.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **پرایمیتی‌های AutoCAD پشتیبانی شده**

پرایمیتی‌های AutoCAD زیر پشتیبانی می‌شوند.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **صادرات لایه DWG خاص به PDF**

این روش به شرح زیر کار می‌کند:

1. یک فایل DWG را با استفاده از روش کارخانه **Aspose.CAD.Image.load** بارگذاری کنید.
1. یک نمونه از کلاس **CadRasterizationOptions** ایجاد کرده و ارتفاع و عرض صفحه نتیجه را تنظیم کنید.
1. خصوصیت **Layouts** را برای شی **CadRasterizationOptions** تنظیم کنید.
1. یک نمونه از کلاس **PdfOptions** ایجاد کرده و خصوصیت **VectorRasterizationOptions** آن را تنظیم کنید.
1. تصویر را با استفاده از روش **Image.save()** به PDF صادر کنید.

قطعه کد زیر نشان می‌دهد که چگونه یک لایه خاص از DWG را به PDF تبدیل کنیم.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **صادرات DWG به PDF/A و PDF/E**

این روش به شرح زیر کار می‌کند:

1. یک فایل DWG را با استفاده از **Image.load** روش کارخانه بارگذاری کنید.
1. یک نمونه از کلاس **CadRasterizationOptions** ایجاد کنید.
1. یک نمونه از کلاس **PdfOptions** ایجاد کرده و خصوصیت **VectorRasterizationOptions** آن را تنظیم کنید.
1. خصوصیت انطباق PDF را تنظیم کرده و آن را ذخیره کنید.
1. تصویر را با استفاده از **Image.save()** روش به PDF صادر کنید.

قطعه کد زیر نشان می‌دهد که چگونه یک فایل DWG را به PDF/A و PDF/E تبدیل کنیم.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **تبدیل نقاشی‌های DWG به DXF**

Aspose.CAD قابلیت بارگذاری فایل DWG AutoCAD و صادرات آن به فرمت DXF را فراهم می‌کند. روش تبدیل DWG به DXF به صورت زیر کار می‌کند:

1. فایل نقاشی DWG را با استفاده از روش کارخانه **Image.load** بارگذاری کنید.
1. نقاشی DWG را با استفاده از روش **Image.save()** به DXF صادر کنید.

قطعه کد زیر نشان می‌دهد که چگونه یک فایل DWG را به فرمت DXF تبدیل کنیم.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **تبدیل نقاشی‌های DWG به SVG**

Aspose.CAD برای API پایتون می‌تواند نقاشی‌های AutoCAD را در فرمت DWG بارگذاری کرده و آن‌ها را به SVG تبدیل کند. این موضوع توضیح می‌دهد که چگونه از API Aspose.CAD برای دستیابی به تبدیل DWG به فرمت SVG از طریق مراحل ساده‌ای که در زیر تعریف شده استفاده کنید.

1. فایل DWG را در یک نمونه از **Image** بارگذاری کنید.
1. یک شی از کلاس **SvgOptions** ایجاد کرده و خصوصیات مورد نیاز را تنظیم کنید.
1. نقاشی DWG را با استفاده از **Image.save()** روش به SVG صادر کنید.

قطعه کد زیر نشان می‌دهد که چگونه یک فایل DWG را به فرمت SVG تبدیل کنیم.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
