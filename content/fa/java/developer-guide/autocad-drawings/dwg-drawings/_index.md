---
title: نقشه‌های DWG
type: docs
weight: 40
url: /fa/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **صادرات نقشه‌های DWG به PDF**

API Aspose.CAD برای جاوا می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و به PDF تبدیل کند. این موضوع استفاده از API Aspose.CAD را برای دستیابی به تبدیل DWG به فرمت PDF از طریق مراحل ساده توضیح می‌دهد.

{{% alert color="primary" %}}

API از اصلاحات زیر DWG AutoCAD پشتیبانی می‌کند:

- نسخه 16.0 انتشار 18 DWG 2004  
- نسخه 16.1 DWG 2005  
- نسخه 18.0 DWG 2010  
- نسخه 19.0 DWG 2013  

{{% /alert %}}

### **فرمت فایل DWG**

DWG یک فایل باینری است که حاوی داده‌های تصویر وکتور و متادیتا می‌باشد. داده‌های تصویر وکتور دستورات لازم برای برنامه CAD را درباره نحوه نمایش DWG فراهم می‌کند؛ متادیتا ممکن است شامل انواع اطلاعات در مورد فایل از جمله داده‌های خاص مکان و همچنین داده‌های مشتری باشد. مشخصات باز برای فرمت فایل DWG را می‌توانید [در این PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) پیدا کنید.

### **تبدیل فایل‌های DWG به PDF**

مراحل ساده زیر برای تبدیل DWG به PDF لازم است.

1. فایل DWG را به یک نمونه از [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) بارگذاری کنید.
1. یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کرده و ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) را تنظیم کنید.
1. یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ایجاد کرده و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) را تنظیم کنید.
1. متد [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) را فراخوانی کرده و شی [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) را به عنوان پارامتر دوم ارسال کنید.

نمونه کد زیر نشان می‌دهد چگونه نقشه‌های DWG را به PDF صادر کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **ایجاد یک PDF واحد با اندازه‌های مختلف صفحه**

Aspose.CAD برای جاوا به شما امکان می‌دهد فایل DWG را به یک PDF واحد با اندازه‌های مختلف صفحه تبدیل کنید. این رویکرد به صورت زیر عمل می‌کند:

1. یک فایل DWG را با استفاده از روش کارخانه [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کرده و ارتفاع و عرض صفحه نتیجه را تنظیم کنید.
1. اندازه‌های صفحه مورد نیاز [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) را برای شی [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) اضافه کنید.
1. یک نمونه از کلاس [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ایجاد کرده و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) آن را تنظیم کنید.
1. تصویر را با استفاده از متد [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) به PDF صادر کنید.

نمونه کد زیر نشان می‌دهد چگونه یک PDF واحد با طرح‌های مختلف ایجاد کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **صادرات DWG به PDF/A و PDF/E**

مراحل ساده زیر برای تبدیل DWG به PDF لازم است.

1. فایل DWG را به یک نمونه از [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) بارگذاری کنید.
1. یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کرده و ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) را تنظیم کنید.
1. یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ایجاد کرده و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) را تنظیم کنید.
1. متد [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) را فراخوانی کرده و شی [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) را به عنوان پارامتر دوم ارسال کنید.

نمونه کد زیر نشان می‌دهد چگونه نقشه‌های DWG را به PDF صادر کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **اشیاء پشتیبانی شده AutoCAD**

اجزای پشتیبانی شده AutoCAD به شرح زیر است.

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

## **صادرات یک طرح خاص DWG به PDF**

این رویکرد به صورت زیر عمل می‌کند:

1. یک فایل DWG را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کرده و ارتفاع و عرض صفحه نتیجه را تنظیم کنید.
1. ویژگی [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) را برای شی [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) تنظیم کنید.
1. یک نمونه از کلاس [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ایجاد کرده و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) آن را تنظیم کنید.
1. تصویر را با استفاده از متد [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) به PDF صادر کنید.

نمونه کد زیر نشان می‌دهد چگونه یک طرح خاص DWG را به PDF تبدیل کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **صادرات DWG به Raster یا PDF با استفاده از اندازه ثابت**

API Aspose.CAD برای جاوا می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و به PDF یا Raster با استفاده از اندازه ثابت تبدیل کند.

نمونه کد زیر نشان می‌دهد چگونه این ویژگی را پیاده‌سازی کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **پشتیبانی از خطوط پنهان گرد هنگام صادرات DWG/DXF به BMP و PDF**

این رویکرد به صورت زیر عمل می‌کند:

1. یک فایل DWG را با استفاده از روش کارخانه [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کنید.
1. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کرده و ارتفاع و عرض صفحه نتیجه را تنظیم کنید.
1. یک نمونه از کلاس [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ایجاد کرده و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) آن را تنظیم کنید.
1. تصویر را با استفاده از متد [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) به PDF صادر کنید.

نمونه کد زیر نشان می‌دهد چگونه این ویژگی را پیاده‌سازی کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **پشتیبانی از تنظیم ناحیه چاپ برای تصویر DWG در PDF صادر شده**

API Aspose.CAD برای جاوا می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و به PDF تبدیل کند. این موضوع استفاده از API Aspose.CAD را برای دستیابی به پشتیبانی از تنظیم یک ناحیه چاپ برای تصویر DWG در PDF صادر شده توضیح می‌دهد.

نمونه کد زیر نشان می‌دهد چگونه این ویژگی را پیاده‌سازی کنید.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **پشتیبانی از خواندن متادیتای XREF برای فایل DWG**

1. یک فایل DWG را با استفاده از روش کارخانه [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. از طریق هر موجودیت تصویر پیمایش کنید.
1. اگر موجودیت [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) باشد، آنگاه موجودیت XREF با متادیتا.

نمونه کد زیر نشان می‌دهد چگونه این ویژگی را به دست آورید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **مدارک DWG با مشخص کردن مختصات**

API Aspose.CAD برای جاوا اکنون ویژگی‌ای برای رندر مدارک DWG با ارائه مختصات عرض و ارتفاع مدارک فراهم می‌آورد.

نمونه کد زیر نشان می‌دهد چگونه یک سند DWG را رندر کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

ویژگی [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) از نوع آرایه رشته‌ای است، بنابراین می‌توانید بیش از یک طرح را به طور همزمان برای تبدیل به فرمت PDF مشخص کنید. در هنگام مشخص کردن چندین طرح برای ویژگی [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) ، PDF نتیجه دارای صفحات متعدد خواهد بود که هر صفحه یک طرح فردی AutoCAD را نمایش می‌دهد.

### **فهرست همه طرح‌ها**

شما می‌توانید همه طرح‌های موجود در یک نقشه AutoCAD را با استفاده از کد snippet زیر فهرست کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **دریافت مقدار ویژگی Block از مرجع خارجی**

API Aspose.CAD برای جاوا به شما امکان می‌دهد تا مرجع خارجی یک ویژگی بلوک را دریافت کنید. API Aspose.CAD ویژگی [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) را برای دریافت مرجع خارجی یک ویژگی بلوک در مجموعه [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary) فراهم می‌کند.

کد زیر نشان می‌دهد چگونه می‌توان یک مرجع خارجی از یک ویژگی بلوک را به دست آورد.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **جستجوی متن در فایل DWG AutoCAD**

API Aspose.CAD برای جاوا به شما امکان می‌دهد تا متن را در یک فایل DWG AutoCAD جستجو کنید. API Aspose.CAD کلاس [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) را ارائه می‌دهد که نمایانگر موجودیت‌های متنی در فایل DWG AutoCAD است. کلاس [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) نیز در API Aspose.CAD گنجانده شده زیرا برخی از موجودیت‌های دیگر نیز ممکن است شامل متن باشند.

کد زیر نشان می‌دهد چگونه متن را در فایل DWG AutoCAD جستجو کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **جستجوی متن در طرح خاص**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **دسترسی به پرچم‌های زیرلایه برای فرمت DWG**

Aspose.CAD برای جاوا پرچم‌های زیرلایه را برای فرمت DWG پیاده‌سازی کرده و به توسعه‌دهندگان اجازه دسترسی به آنها را می‌دهد. در زیر یک نمایش ساده کد گنجانده شده است.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **پشتیبانی از موجودیت‌های DWG**

API Aspose.CAD برای جاوا می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و از موجودیت‌های مختلفی پشتیبانی کند.

### **پشتیبانی از موجودیت MLeader**

DWG یک فایل باینری است که حاوی داده‌های تصویر وکتور و متادیتا می‌باشد. موجودیت‌های مختلفی در یک فایل DWG وجود دارد. بخش زیر مثالی از کار با موجودیت MLeader در داخل فایل DWG را توصیف می‌کند.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **پشتیبانی از صادرات موجودیت DWG به تصویر**

DWG یک فایل باینری است که حاوی داده‌های تصویر وکتور و متادیتا می‌باشد. موجودیت‌های مختلفی در یک فایل DWG وجود دارد. بخش زیر مثالی از صادرات یک موجودیت خاص DWG به تصویر را توصیف می‌کند.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **پشتیبانی از وارد کردن تصویر به فایل DWG**

API Aspose.CAD برای جاوا می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و از موجودیت‌های مختلفی پشتیبانی کند. DWG یک فایل باینری است که حاوی داده‌های تصویر وکتور و متادیتا می‌باشد. موجودیت‌های مختلفی در یک فایل DWG وجود دارد. بخش زیر توصیف می‌کند که چگونه می‌توان تصاویر را در داخل فایل DWG وارد کرد.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **پشتیبانی از افزودن متن در DWG**

API Aspose.CAD برای جاوا می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و از موجودیت‌های مختلفی پشتیبانی کند. DWG یک فایل باینری است که حاوی داده‌های تصویر وکتور و متادیتا می‌باشد. موجودیت‌های مختلفی در یک فایل DWG وجود دارد. بخش زیر توصیف می‌کند که چگونه می‌توان متن را در داخل فایل DWG اضافه کرد.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **پشتیبانی از مش در DWG**

API Aspose.CAD برای جاوا اکنون به موجودیت‌های پشتیبانی شده مش که شامل انواع [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) و [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) است دسترسی دارد. مثال زیر توصیف می‌کند که چگونه می‌توان به انواع مش دسترسی داشت.

## **تبدیل نقشه‌های DWG به DXF**

Aspose.CAD ویژگی‌ای دارد که به شما امکان می‌دهد فایل اتوکاد DWG را بارگذاری کرده و به فرمت DXF صادر کنید. رویکرد تبدیل DWG به DXF به صورت زیر عمل می‌کند:

1. فایل نقشه DWG را با استفاده از روش [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. نقشه DWG را با استفاده از متد [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) به DXF صادر کنید.

نمونه کد زیر نشان می‌دهد چگونه یک فایل DWG را به فرمت DXF تبدیل کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **تبدیل نقشه‌های DWG به SVG**

API Aspose.CAD می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کند و آنها را به SVG تبدیل کند. این موضوع نحوه استفاده از API Aspose.CAD را برای دستیابی به تبدیل DWG به فرمت SVG از طریق مراحل ساده زیر توضیح می‌دهد.

1. فایل DWG را به یک نمونه از [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) بارگذاری کنید.
1. یک شی از کلاس [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) ایجاد کرده و ویژگی‌های مورد نیاز را تنظیم کنید.
1. نقشه DWG را با استفاده از متد [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) به SVG صادر کنید.

نمونه کد زیر نشان می‌دهد چگونه یک فایل DWG را به فرمت SVG تبدیل کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
