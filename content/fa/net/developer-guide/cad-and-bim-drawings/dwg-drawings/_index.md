---
title: نقشه‌های DWG
type: docs
weight: 40
url: /fa/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **صادرات نقشه‌های DWG به PDF**

Aspose.CAD برای API .NET می‌تواند نقشه‌های AutoCAD را در فرمت [DWG](https://docs.fileformat.com/cad/dwg/) بارگذاری کند و آن را به [PDF](https://docs.fileformat.com/pdf/) تبدیل کند. این موضوع نحوه استفاده از API Aspose.CAD را برای تبدیل DWG به فرمت PDF از طریق مراحل ساده که در ادامه تعریف شده است، توضیح می‌دهد.

{{% alert color="primary" %}}

این API از نسخه‌های زیر نقشه‌های AutoCAD DWG پشتیبانی می‌کند:

- نسخه 16.0 از DWG 2004، انتشار 18 
- نسخه 16.1 از DWG 2005
- نسخه 18.0 از DWG 2010
- نسخه 19.0 از DWG 2013

{{% /alert %}}

### **فرمت فایل DWG**

یک [DWG](https://docs.fileformat.com/cad/dwg/) یک فایل باینری است که داده‌های تصویر وکتور و اطلاعات متادیتا را شامل می‌شود. داده‌های تصویر وکتور دستورالعمل‌هایی را به نرم‌افزار CAD ارائه می‌دهند که چگونه DWG را نمایش دهد؛ متادیتا ممکن است شامل اطلاعات متنوعی درباره فایل از جمله داده‌های محلی و همچنین داده‌های کاربر باشد. مشخصات باز برای فرمت فایل DWG را می‌توان [در این PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) یافت.

### **تبدیل فایل‌های DWG به PDF**

مراحل زیر برای تبدیل [DWG](https://docs.fileformat.com/cad/dwg/) به [PDF](https://docs.fileformat.com/pdf/) لازم است.

1. فایل DWG را به یک نمونه از [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) بارگذاری کنید.
2. یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) را تنظیم کنید.
3. یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) را تنظیم کنید.
4. با عبور دادن یک شی از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) به عنوان پارامتر دوم، [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) را صدا بزنید.

کد نمونه زیر نحوه صادرات نقشه‌های DWG به PDF را نشان می‌دهد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **ایجاد یک PDF واحد با اندازه‌های مختلف طرح**

Aspose.CAD برای API .NET به شما امکان می‌دهد فایل DWG را به یک PDF واحد با اندازه‌های مختلف طرح تبدیل کنید. این روش به شرح زیر عمل می‌کند:

1. یک فایل DWG را با استفاده از روش کارخانه [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
2. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ارتفاع و عرض صفحه نتیجه را تنظیم کنید.
3. اندازه‌های صفحه لازم را به شی [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) اضافه کنید.
4. یک نمونه از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کرده و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) را تنظیم کنید.
5. تصویر را با استفاده از روش [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) به PDF صادر کنید.

کد نمونه زیر چگونگی ایجاد یک [PDF](https://docs.fileformat.com/pdf/) واحد با طرح‌های مختلف را نشان می‌دهد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **پرچم‌های AutoCAD پشتیبانی شده**

پرچم‌های AutoCAD زیر پشتیبانی می‌شوند.

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

## **صادرات طرح خاص DWG به PDF**

این روش به شرح زیر عمل می‌کند:

1. یک فایل DWG را با استفاده از روش کارخانه [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
2. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ارتفاع و عرض صفحه نتیجه را تنظیم کنید.
3. ویژگی [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) را برای شی [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) تنظیم کنید.
4. یک نمونه از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کرده و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) را تنظیم کنید.
5. تصویر را با استفاده از روش [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) به PDF صادر کنید.

کد نمونه زیر نحوه تبدیل یک طرح خاص DWG به PDF را نشان می‌دهد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **رندر سند DWG با تعیین مختصات**

Aspose.CAD برای API .NET اکنون ویژگی رندر کردن اسناد DWG را با ارائه مختصات عرض و ارتفاع سند فراهم می‌کند.

کد نمونه زیر نشان می‌دهد که چگونه یک سند DWG را رندر کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **صادرات DWG به Raster یا PDF با استفاده از اندازه ثابت**

Aspose.CAD برای API .NET می‌تواند نقشه‌های AutoCAD را با فرمت DWG بارگذاری کرده و آن را با اندازه ثابت به PDF یا Raster تبدیل کند.

کد نمونه زیر نحوه پیاده‌سازی این ویژگی را نشان می‌دهد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **صادرات DWG به PDF/A و PDF/E**

این روش به شرح زیر عمل می‌کند:

1. یک فایل DWG را با استفاده از روش کارخانه [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
2. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید.
3. یک نمونه از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) را تنظیم کنید.
4. ویژگی انطباق PDF را تنظیم کرده و آن را ذخیره کنید.
5. تصویر را با استفاده از روش [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) به PDF صادر کنید.

کد نمونه زیر نحوه تبدیل یک فایل DWG به PDF/A و PDF/E را نشان می‌دهد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **پشتیبانی از خطوط پنهان گرد هنگام صادرات DWG/DXF به BMP و PDF**

این روش به شرح زیر عمل می‌کند:

1. یک فایل DWG را با استفاده از روش کارخانه [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
2. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ارتفاع و عرض صفحه نتیجه را تنظیم کنید.
3. یک نمونه از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) را تنظیم کنید.
4. تصویر را با استفاده از روش [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) به PDF صادر کنید.

کد نمونه زیر نشان می‌دهد که چگونه می‌توان این ویژگی را پیاده‌سازی کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **پشتیبانی از تنظیم منطقه چاپ برای تصویر DWG در PDF صادر شده**

Aspose.CAD برای API .NET می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و آن را به PDF تبدیل کند. این موضوع نحوه استفاده از API Aspose.CAD را برای دستیابی به پشتیبانی از تنظیم منطقه چاپ برای تصویر DWG در PDF صادر شده توضیح می‌دهد.

کد نمونه زیر نشان می‌دهد که چگونه می‌توان این ویژگی را پیاده‌سازی کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **پشتیبانی از خواندن متادیتای XREF برای فایل DWG**

1. یک فایل DWG را با استفاده از روش کارخانه [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
2. از طریق هر واحد تصویر عبور کنید.
3. اگر یک واحد CadUnderlay باشد، آن گاه واحد XREF با متادیتا.

کد نمونه زیر نشان می‌دهد که چگونه می‌توان به این ویژگی دست یافت.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

ویژگی [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) از نوع آرایه رشته‌ای است، بنابراین شما می‌توانید بیش از یک طرح را به طور همزمان برای تبدیل به فرمت PDF مشخص کنید. در حین مشخص کردن طرح‌های متعدد برای ویژگی [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts)، PDF حاصل دارای صفحات متعددی خواهد بود که هر صفحه نمایانگر یک طرح مستقل AutoCAD است.

### **لیست همه طرح‌ها**

شما می‌توانید همه طرح‌های موجود در یک نقشه AutoCAD را با استفاده از کد زیر لیست کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **دسترسی به پرچم‌های زیرین برای فرمت DWG**

Aspose.CAD برای API .NET پرچم‌های زیرین را برای فرمت DWG پیاده‌سازی کرده و به توسعه‌دهندگان امکان دسترسی به آن‌ها را می‌دهد. در زیر یک نمایش ساده از کد آمده است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **پشتیبانی از موجودیت‌های DWG**

Aspose.CAD برای API .NET می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و از موجودیت‌های مختلف برای کار با آن‌ها پشتیبانی کند.

### **پشتیبانی از موجودیت MLeader**

یک DWG یک فایل باینری است که داده‌های تصویر وکتور و متادیتا را شامل می‌شود. موجودیت‌های مختلفی در یک فایل DWG وجود دارد. بخش زیر مثالی از کار با موجودیت MLeader در داخل فایل DWG را توصیف می‌کند.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **پشتیبانی از صادرات موجودیت DWG به تصویر**

یک DWG یک فایل باینری است که داده‌های تصویر وکتور و متادیتا را شامل می‌شود. موجودیت‌های مختلفی در یک فایل DWG وجود دارد. بخش زیر مثالی از صادرات یک موجودیت خاص DWG به تصویر را توصیف می‌کند.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **پشتیبانی از افزودن متن در DWG**

Aspose.CAD برای API .NET می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و از موجودیت‌های مختلف برای کار با آن‌ها پشتیبانی کند. یک DWG یک فایل باینری است که داده‌های تصویر وکتور و متادیتا را شامل می‌شود. موجودیت‌های مختلفی در یک فایل DWG وجود دارد. بخش زیر توضیح می‌دهد که چگونه می‌توانیم متن را در داخل فایل DWG اضافه کنیم.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **پشتیبانی از وارد کردن تصویر به فایل DWG**

Aspose.CAD برای API .NET می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و از موجودیت‌های مختلف برای کار با آن‌ها پشتیبانی کند. یک DWG یک فایل باینری است که داده‌های تصویر وکتور و متادیتا را شامل می‌شود. موجودیت‌های مختلفی در یک فایل DWG وجود دارد. بخش زیر توضیح می‌دهد که چگونه می‌توان تصاویر را در داخل فایل DWG وارد کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **پشتیبانی از مش در DWG**

Aspose.CAD برای API .NET اکنون می‌تواند به موجودیت‌هایی که از مش پشتیبانی می‌کنند دسترسی پیدا کند که شامل انواع [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) و [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) است. مثال زیر توضیح می‌دهد که چگونه می‌توانیم به انواع مش دسترسی پیدا کنیم.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **تبدیل نقشه‌های DWG به DXF**

Aspose.CAD ویژگی بارگذاری فایل DWG AutoCAD و صادرات آن به فرمت DXF را ارائه می‌دهد. رویکرد تبدیل DWG به DXF به شرح زیر عمل می‌کند:

1. فایل نقشه DWG را با استفاده از روش کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) بارگذاری کنید.
2. نقشه DWG را با استفاده از روش [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) به DXF صادر کنید.

کد نمونه زیر نشان می‌دهد که چگونه یک فایل DWG را به فرمت DXF تبدیل کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **تبدیل نقشه‌های DWG به SVG**

Aspose.CAD برای API .NET می‌تواند نقشه‌های AutoCAD را در فرمت DWG بارگذاری کرده و آن را به SVG تبدیل کند. این موضوع نحوه استفاده از API Aspose.CAD را برای دستیابی به تبدیل DWG به فرمت SVG از طریق مراحل ساده‌ای که در زیر تعریف شده توضیح می‌دهد.

1. فایل DWG را به یک نمونه از [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) بارگذاری کنید.
2. یک شی از کلاس [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) ایجاد کرده و ویژگی مورد نیاز را تنظیم کنید.
3. نقشه DWG را با استفاده از روش [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) به SVG صادر کنید.

کد نمونه زیر نشان می‌دهد که چگونه یک فایل DWG را به فرمت SVG تبدیل کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **بارگذاری فایل DWG بزرگ**

Aspose.CAD برای API .NET امکانات زیادی برای باز کردن فایل‌های DWG بسیار بزرگ با استفاده از کلاس [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) فراهم می‌کند. اکنون می‌توانید به راحتی فایل‌های بزرگ را با کمک کد نمونه زیر باز کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
