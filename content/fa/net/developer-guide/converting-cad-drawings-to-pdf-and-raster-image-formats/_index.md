---
title: تبدیل DWG DXF به PDF C# | تبدیل فایل‌های اتو کد به PDF JPEG PNG در C# .NET
type: docs
weight: 30
url: /fa/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG به PDF C#, DXF به PDF C#, DWF DWT به PDF C#, تبدیل اتو کد, تبدیل DWG, تبدیل DWF, تبدیل DWT, تبدیل DXF, تبدیل اتو کد به pdf, تبدیل DWG به PDF, تبدیل DWG به PNG, تبدیل DWG به TIFF, تبدیل DWG به JPG"
description: از تبدیل‌کننده DWG یا DXF به PDF در C# .NET استفاده کنید. شما می‌توانید DWG، DWF، DWT و DXF را به PDF، JPEG، PNG، BMP، GIF و TIFF در C# .NET تبدیل کنید.
---

## **تبدیل DWG یا DXF به PNG JPEG BMP GIF یا TIFF در C#**

Aspose.CAD برای .NET می‌تواند فرمت‌های ترسیمی اتو کد مانند [DXF](https://docs.fileformat.com/cad/dxf/) و [DWG](https://docs.fileformat.com/cad/dwg/) را به [PNG](https://docs.fileformat.com/image/png/)، [BMP](https://docs.fileformat.com/image/bmp/)، [TIFF](https://docs.fileformat.com/image/tiff/)، [JPEG](https://docs.fileformat.com/image/jpeg/) و [GIF](https://docs.fileformat.com/image/gif/) تبدیل کند. این ابزار API کارآمد و آسانی را برای دستیابی به این هدف ارائه می‌دهد.

شما می‌توانید هر فرمت ترسیم اتو کد پشتیبانی‌شده را با استفاده از مراحل ساده‌ای که در زیر توضیح داده شده است، به فرمت‌های تصویر رستری تبدیل کنید.

1. فایل DWG یا DXF اتو کد را به کلاس [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) بارگذاری کنید.
1. یک نمونه از [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید.
1. اندازه تصویر را با استفاده از [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) و [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) تنظیم/تغییر دهید.
1. یک نمونه از [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) ایجاد کنید.
1. ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) را به [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد شده در مرحله قبلی تنظیم کنید.
1. ترسیم اتو کد را به PDF با استفاده از [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) با گذراندن مسیر فایل (یا یک شیء از MemoryStream) و همچنین نمونه [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) ایجاد شده در مرحله قبلی ذخیره کنید.

این کد منبع کامل است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

به طور پیش‌فرض، API فقط "مدل" را ترسیم می‌کند. با این حال، شما ممکن است همچنین layouts دلخواه خود را در حین تبدیل ترسیمات CAD به فرمت‌های تصویر مشخص کنید.

## **سفارشی‌سازی تبدیل CAD**

رویه‌های تبدیل CAD به [PDF](https://docs.fileformat.com/pdf/) و CAD به تصویر رستری به شدت قابل تنظیم هستند، زیرا کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) به گونه‌ای پیاده‌سازی شده است که بسیاری از ویژگی‌های اختیاری را ارائه می‌دهد که با تنظیم آن می‌توان روند رندر را بر اساس نیازهای برنامه تغییر داد.

### **کلاس CadRasterizationOptions**

کلاس **CadRasterizationOptions** برای تمام فرمت‌های CAD پشتیبانی شده مانند DWG و DXF مشترک است، بنابراین اطلاعات به اشتراک گذاشته شده در این مقاله برای هر دو فرمت CAD مذکور معتبر است.

مفیدترین ویژگی‌های کلاس **CadRasterizationOptions** به شرح زیر است:

|**ویژگی**|**مقدار پیش‌فرض**|**الزامی**|**توضیحات**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|بله|عرض صفحه را مشخص می‌کند.|
|**PageHeight**|**0**|بله|ارتفاع صفحه را مشخص می‌کند.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|خیر|مشخص می‌کند که آیا ترسیم باید به طور خودکار مقیاس شود. مقدار پیش‌فرض به طور خودکار تصویر را به اندازه بوم کوچک می‌کند. به حالت **GrowToFit** سوئیچ کنید یا از تنظیم **None** برای غیر فعال کردن مقیاس خودکار استفاده کنید.|
|**BackgroundColor**|**Color.White**|خیر|رنگ پس‌زمینه تصویر خروجی را مشخص می‌کند.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|خیر|حالت رنگ‌آمیزی موجودیت را مشخص می‌کند. گزینه **UseObjectColor** را مشخص کنید تا موجودیت‌ها با رنگ ذاتی خود ترسیم شوند، یا گزینه **UseDrawColor** را برای غیرفعال کردن رنگ‌های ذاتی استفاده کنید.|
|**DrawColor**|**Color.Black**|خیر|رنگ موجودیت غیرفعال‌شده را مشخص می‌کند (فقط اگر **DrawType** به مقدار ویژگی **UseDrawColor** تنظیم شده باشد).|
|**AutomaticLayoutsScaling**|خیر|خیر|مشخص می‌کند که آیا باید مقیاس خودکار طرح‌ها برای تطابق با طرح مدل انجام شود.|

### **تنظیم اندازه و حالت بوم**

صادرات از CAD به PDF یا فرمت‌های تصویر رستری کار ساده‌ای نیست. از آنجا که PDF یا تصویر نتیجه به تعریف اندازه بوم نیاز دارد، ما باید ابعاد خروجی صفحه PDF را برای رندر صحیح ترسیم مشخص کنیم. ویژگی‌های **CadRasterizationOptions.PageWidth** و **CadRasterizationOptions.PageHeight** را به صورت صریح تنظیم کنید، در غیر این صورت ممکن است با **ImageSaveException** برخورد کنید.

علاوه بر این، شما می‌توانید گزینه‌های مقیاس ابعاد را مشخص کنید. گزینه‌های مقیاس با ویژگی **CadRasterizationOptions.ScaleMethod** تنظیم می‌شوند. از این گزینه برای تنظیم خودکار ابعاد تصویر بر اساس مقادیر **CadRasterizationOptions.PageWidth** و **CadRasterizationOptions.PageHeight** استفاده کنید. به طور پیش‌فرض، **CadRasterizationOptions.ScaleMethod** به حالت **ScaleType.ShrinkToFit** تنظیم شده است. این ویژگی رفتار زیر را تعریف می‌کند:

- اگر ابعاد ترسیم CAD بزرگتر از اندازه بوم نتیجه باشد، ابعاد ترسیم برای جا دادن در بوم نتیجه کاهش می‌یابند در حالی که نسبت تصویر حفظ می‌شود.
- اگر ابعاد ترسیم CAD کوچکتر از اندازه بوم نتیجه باشد، ویژگی **CadRasterizationOptions.ScaleMethod** را به **ScaleType.GrowToFit** تنظیم کنید تا ابعاد ترسیم بزرگتر شود و در بوم PDF جا بگیرد در حالی که نسبت تصویر حفظ می‌شود.
- یا با گزینه **ScaleType.None** مقیاس خودکار را غیرفعال کنید.

نمونه کد زیر استفاده از گزینه مقیاس خودکار را نشان می‌دهد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **تنظیم رنگ پس‌زمینه و رنگ‌های ترسیم**

به طور پیش‌فرض، پالت رنگ برای بوم نتیجه به طرح سند مشترک تنظیم شده است. به این معنی که همه موجودیت‌ها در داخل ترسیم CAD با یک قلم سیاه رنگ بر روی یک پس‌زمینه سفید کدر ترسیم می‌شوند. این تنظیمات می‌توانند با ویژگی‌های **CadRasterizationOptions.BackgroundColor** و **CadRasterizationOptions.DrawColor** تغییر یابند. تغییر ویژگی **CadRasterizationOptions.DrawColor** همچنین نیاز به تنظیم ویژگی **CadRasterizationOptions.DrawType** دارد تا از رنگ ترسیم استفاده شود. ویژگی **CadRasterizationOptions.DrawType** کنترل می‌کند که آیا رنگ‌های موجودیت‌های CAD حفظ می‌شوند یا به رنگ‌های سفارشی تبدیل می‌شوند. برای حفظ رنگ‌های موجودیت، ویژگی **CadRasterizationOptions.DrawType** را به **CadDrawTypeMode.UseObjectColor** مشخص کنید، در غیر این صورت، مقدار **CadDrawTypeMode.UseDrawColor** را مشخص کنید.

نمونه کد زیر نشان می‌دهد که چگونه از ویژگی‌های رنگ مختلف استفاده کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **تنظیم مقیاس خودکار طرح‌ها**

بیشتر ترسیمات CAD دارای بیش از یک طرح هستند که در یک فایل واحد ذخیره می‌شوند و هر طرح می‌تواند ابعاد مختلفی داشته باشد. در هنگام رندر چنین ترسیمات CAD به PDF، هر صفحه PDF ممکن است مقیاس متفاوتی را مطابق با اندازه طرح داشته باشد. برای همگن ساختن رندرینگ، API‌های Aspose.CAD ویژگی **CadRasterizationOptions.AutomaticLayoutsScaling** را ارائه داده‌اند. مقدار پیش‌فرض آن **false** است، اما وقتی true باشد، API سعی می‌کند مقیاس مربوطه را برای هر طرح جداگانه جستجو کرده و آنها را به شیوه مناسبی با انجام عملیات اندازه‌گیری خودکار مناسب با اندازه صفحه ترسیم کند.

در زیر توضیح می‌دهد که چگونه ویژگی **CadRasterizationOptions.AutomaticLayoutsScaling** به همکاری با ویژگی **CadRasterizationOptions.ScaleMethod** کار می‌کند.

1. اگر **ScaleMethod** به **ScaleType.ShrinkToFit** یا **ScaleType.GrowToFit** با **AutomaticLayoutsScaling** برابر با false تنظیم شود، در این صورت تمام طرح‌ها (شامل مدل) طبق گزینه اول پردازش خواهند شد.
1. اگر **ScaleMethod** به **ScaleType.ShrinkToFit** یا **ScaleType.GrowToFit** با **AutomaticLayoutsScaling** برابر با true تنظیم شود، در این صورت تمام طرح‌ها (به جز مدل) طبق اندازه خود پردازش خواهند شد، در حالی که مدل طبق گزینه اول پردازش خواهد شد.
1. اگر **ScaleMethod** به **ScaleType.None** با **AutomaticLayoutsScaling** برابر با true یا false تنظیم شود، هیچ مقیاسی انجام نخواهد شد.

نمونه کد زیر نشان می‌دهد که چگونه مقیاس خودکار را برای تبدیل CAD به PDF تنظیم کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **تبدیل لایه‌های DXF یا DWG اتو کد به PNG یا دیگر فرمت‌های تصویر در C#**

API Aspose.CAD برای .NET می‌تواند لایه‌های CAD با فرمت‌های پشتیبانی شده مانند DXF و DWG را به PNG BMP TIFF JPEG و GIF تبدیل کند. همچنین API، پشتیبانی برای رندر کردن طرح‌های خاص یک ترسیم CAD به لایه‌های PSD مختلف را ارائه می‌دهد.

در زیر چگونگی دستیابی به این هدف در  مراحل ساده توضیح داده شده است.

- فایل DWG یا DXF اتو کد را با استفاده از کلاس **Image** بارگذاری کنید.
- عرض و ارتفاع تصویر را تنظیم/تغییر دهید.
- نام(های) طرح دلخواه را با استفاده از ویژگی **CadRasterizationOptions.Layouts** مشخص کنید.
- یک نمونه از **ImageOptionsBase** ایجاد کرده و ویژگی **VectorRasterizationOptions** آن را به نمونه **CadRasterizationOptions** ایجاد شده در مرحله قبلی تنظیم کنید.
- طرح CAD را به TIFF یا تصویر ذخیره کنید.

این کد منبع کامل است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

ویژگی **CadRasterizationOptions.Layouts** از نوع آرایه رشته‌ای است، بنابراین شما می‌توانید بیش از یک طرح را به طور همزمان برای تبدیل به فرمت‌های تصویر مشخص کنید. در هنگام مشخص کردن چندین طرح برای ویژگی **CadRasterizationOptions.Layouts**، تصویر TIFF نتیجه چندین صفحه خواهد داشت، تصویر GIF چندین فریم خواهد داشت و فرمت [PSD](https://docs.fileformat.com/image/psd/) نیز چندین لایه خواهد داشت، که در آن هر صفحه/فریم/لایه نمایانگر یک طرح اتو کد جداگانه است. در صورت انتخاب هر فرمت تصویری دیگر مانند PNG، BMP، JPEG برای ذخیره نتیجه، API صرفاً طرح پیش‌فرض، یعنی "مدل" را رندر خواهد کرد.

{{% /alert %}}

## **فعال‌سازی ردیابی برای فرآیند رندرینگ CAD**

Aspose.CAD یک سری از کلاس‌ها و فیلدهای شمارش‌گر پشتیبانی شده را برای کمک به ردیابی فرآیند رندرینگ CAD معرفی کرده است. با این تغییرات، اکنون می‌توان تبدیل CAD به PDF را به صورت زیر انجام داد و ردیابی را فعال کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

ردیابی فرآیند رندرینگ CAD می‌تواند مشکلات زیر را شناسایی کند.

1. اطلاعات هدر گم شده یا خراب.
1. اطلاعات طرح گم شده.
1. موجودیت‌های بلوکی گم شده.
1. سبک‌های ابعاد گم شده.
1. سبک‌های گم شده.

## **جایگزینی قلم‌ها در هنگام تبدیل ترسیمات CAD**

این امکان وجود دارد که یک ترسیم CAD خاص از قلم خاصی استفاده کند که در ماشین مورد نظر برای تبدیل CAD به PDF یا CAD به تصویر رستری موجود نیست. در چنین موقعیت‌هایی، API Aspose.CAD یک استثنای مناسب را برای نشان دادن قلم (قلم‌های) گم شده ایجاد می‌کند و فرآیند تبدیل را متوقف می‌کند زیرا API برای رندر صحیح محتوا بر روی PDF یا تصاویر نتیجه به این قلم‌ها نیاز دارد.

API Aspose.CAD یک روش آسان برای استفاده از مکانیزم جایگزینی قلم‌های مورد نیاز با قلم‌های موجود را ارائه می‌دهد. ویژگی **CadImage.Styles** یک نمونه از **CadStylesDictionary** را برمی‌گرداند که به نوبه خود شامل **CadStyleTableObject** برای هر سبک در ترسیم CAD می‌باشد، در حالی که  **CadStyleTableObject.PrimaryFontName** می‌تواند برای مشخص کردن نام قلم موجود استفاده شود.

نمونه کد زیر استفاده از API Aspose.CAD برای .NET را برای تغییر قلم همه سبک‌ها در یک ترسیم CAD نشان می‌دهد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

همچنین می‌توان قلم تنها یک سبک خاص را با دسترسی به آن از طریق نام سبک تغییر داد. نمونه کد زیر استفاده از این رویکرد را نشان می‌دهد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **تبدیل لایه‌های CAD به فرمت‌های تصویر رستری**

API Aspose.CAD برای .NET یک روش کارآمد و آسان را برای مشخص کردن نام لایه CAD مورد نیاز و رندر آن به فرمت‌های تصویر رستری ارائه می‌دهد. در زیر چگونگی دستیابی به این هدف در 5 مرحله ساده توضیح داده شده است.

1. فایل CAD را به یک نمونه از **Image** با استفاده از روش کارخانه **Load** بارگذاری کنید.
1. یک نمونه از **CadRasterizationOptions** ایجاد کرده و ویژگی‌های الزامی آن مانند **PageWidth** و **PageHeight** را تنظیم کنید.
1. نام لایه دلخواه را با استفاده از روش **CadRasterizationOptions.Layers.Add** اضافه کنید.
1. یک نمونه از **ImageOptionsBase** ایجاد کرده و ویژگی **VectorRasterizationOptions** آن را به نمونه **CadRasterizationOptions** ایجاد شده در مرحله قبلی تنظیم کنید.
1. با گذراندن مسیر فایل (یا یک شیء از MemoryStream) و همچنین نمونه **ImageOptionsBase** ایجاد شده در مرحله قبلی، متد **Image.Save** را فراخوانی کنید.

این کد منبع کامل است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **تبدیل همه لایه‌های CAD به تصاویر جداگانه**

شما می‌توانید تمام لایه‌ها را از یک ترسیم CAD با استفاده از **CadImage.Layers** دریافت کنید و هر لایه را به تصویر جداگانه رندر کنید، همان‌طور که در زیر نشان داده شده است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **تبدیل لایه‌های DWF CAD به فرمت‌های تصویر رستری**

API Aspose.CAD برای .NET یک روش کارآمد و آسان را برای مشخص کردن نام لایه CAD مورد نیاز و رندر آن به فرمت‌های تصویر رستری ارائه می‌دهد. در زیر چگونگی دستیابی به این هدف در 5 مرحله ساده توضیح داده شده است.

1. فایل DWF CAD را به یک نمونه از **Image** با استفاده از روش کارخانه **Load** بارگذاری کنید.
1. یک نمونه از **CadRasterizationOptions** ایجاد کرده و ویژگی‌های الزامی آن مانند **PageWidth** و **PageHeight** را تنظیم کنید.
1. نام لایه دلخواه را با استفاده از روش **CadRasterizationOptions.Layers.Add** اضافه کنید.
1. یک نمونه از **ImageOptionsBase** ایجاد کرده و ویژگی **VectorRasterizationOptions** آن را به نمونه **CadRasterizationOptions** ایجاد شده در مرحله قبلی تنظیم کنید.
1. با گذراندن مسیر فایل (یا یک شیء از MemoryStream) و همچنین نمونه **ImageOptionsBase** ایجاد شده در مرحله قبلی، متد **Image.Save** را فراخوانی کنید.

این کد منبع کامل است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD برای .NET اطلاعات مربوط به API و شماره نسخه را به طور مستقیم در اسناد خروجی می‌نویسد. به عنوان مثال، هنگام رندر کردن سند به PDF، Aspose.CAD برای .NET فیلد Application را با مقدار 'Aspose.CAD' و فیلد PDF Producer را با مقداری مانند 'Aspose.CAD v 17.10' پر می‌کند.

لطفاً توجه داشته باشید که شما نمی‌توانید به Aspose.CAD برای .NET دستور دهید که این اطلاعات را از اسناد خروجی تغییر دهد یا حذف کند.
