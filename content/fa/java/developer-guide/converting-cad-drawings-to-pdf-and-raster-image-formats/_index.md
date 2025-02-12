---
title: تبدیل نقشه‌های CAD به فرمت‌های PDF و تصویر Raster
type: docs
weight: 30
url: /fa/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java به طور مستقیم اطلاعات مربوط به API و شماره نسخه را در اسناد خروجی می‌نویسد. به عنوان مثال، هنگام رندر کردن سند به PDF، Aspose.CAD for Java فیلد Application را با مقدار 'Aspose.CAD' و فیلد PDF Producer را با مقداری مانند 'Aspose.CAD v 17.9' پر می‌کند.

لطفاً توجه داشته باشید که نمی‌توانید از Aspose.CAD for Java بخواهید که این اطلاعات را از اسناد خروجی تغییر دهد یا حذف کند.

{{% /alert %}} 
## **تبدیل نقشه‌های CAD به فرمت‌های تصویر Raster**
Aspose.CAD for Java قادر به تبدیل فرمت‌های نقشه CAD مانند [**DXF**](https://docs.fileformat.com/cad/dxf/) و [**DWG**](https://docs.fileformat.com/cad/dwg/) به فرمت‌های تصویر Raster پشتیبانی‌شده مانند [**PNG**](https://docs.fileformat.com/image/png/)، [**BMP**](https://docs.fileformat.com/image/bmp/)، [**TIFF**](https://docs.fileformat.com/image/tiff/)، [**JPEG**](https://docs.fileformat.com/image/jpeg/) و [**GIF**](https://docs.fileformat.com/image/gif/) است. API Aspose.CAD for Java روش‌های کارآمد و آسانی را برای دستیابی به این هدف فراهم کرده است.
شما می‌توانید با استفاده از مراحل ساده زیر هر فرمت نقشه CAD پشتیبانی‌شده را به فرمت‌های تصویر Raster تبدیل کنید.

1. فایل CAD را به یک نمونه از [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) بارگزاری کنید.
1. یک نمونه از [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) بسازید و ویژگی‌های الزامی آن مانند [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) و [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) را تنظیم کنید.
1. یک نمونه از **ImageOptionsBase** ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) آن را به نمونه **CadRasterizationOptions** ایجادشده در مرحله قبل اختصاص دهید.
1. **Image.save** را با ارسال مسیر فایل (یا یک شیء از MemoryStream) و همچنین نمونه [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) ایجادشده در مرحله قبل فراخوانی کنید.

در اینجا کد منبع کامل آورده شده است.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



به طور پیش‌فرض، API تنها "مدل" را رندر می‌کند. با این حال، شما همچنین می‌توانید هنگام تبدیل نقشه‌های CAD به فرمت‌های تصویر، چیدمان مورد نظر خود را مشخص کنید.
## **سفارشی‌سازی تبدیل CAD**
روش‌های تبدیلCAD به [PDF](https://docs.fileformat.com/pdf/) و تبدیل CAD به تصویر Raster به شدت قابل تنظیم هستند زیرا کلاس [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) به گونه‌ای پیاده‌سازی شده است که ویژگی‌های زیادی را ارائه می‌کند که با تنظیم آنها می‌توان فرایند رندر را به نیازهای برنامه مطابقت داد.
### **کلاس CadRasterizationOptions**
کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) برای همه فرمت‌های CAD پشتیبانی‌شده مانند [**DWG**](https://docs.fileformat.com/cad/dwg/) و [DXF](https://docs.fileformat.com/cad/dxf/) عمومی است، بنابراین اطلاعات ارائه‌شده در این مقاله برای هر دو فرمت CAD فوق‌الذکر معتبر است.

مفیدترین ویژگی‌های کلاس **CadRasterizationOptions** عبارتند از:

|**ویژگی**|**مقدار پیش‌فرض**|**الزامی**|**توضیحات**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|بله|عرض صفحه را مشخص می‌کند.|
|**PageHeight**|**0**|بله|ارتفاع صفحه را مشخص می‌کند.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|خیر|مشخص می‌کند که آیا طراحی باید به طور خودکار مقیاس‌دهی شود. مقدار پیش‌فرض به طور خودکار تصویر را برای تناسب با اندازه بوم کوچک می‌کند. به حالت **GrowToFit** تغییر دهید یا از تنظیم **None** برای غیرفعال کردن مقیاس‌دهی خودکار استفاده کنید.|
|**BackgroundColor**|**Color.White**|خیر|رنگ پس‌زمینه تصویر خروجی را مشخص می‌کند.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|خیر|حالت رنگ‌آمیزی موجودیت را مشخص می‌کند. گزینه **UseObjectColor** را مشخص کنید تا موجودیت‌ها با رنگ بومی خود رسم شوند، یا گزینه **UseDrawColor** را برای لغو رنگ‌های بومی انتخاب کنید.|
|**DrawColor**|**Color.Black**|خیر|رنگ موجودیت لغو شده را مشخص می‌کند (فقط اگر **DrawType** به مقدار ویژگی **UseDrawColor** تنظیم شده باشد).|
|**AutomaticLayoutsScaling**|False|خیر|مشخص می‌کند که آیا باید مقیاس‌دهی خودکار چیدمان برای مطابقت با چیدمان مدل انجام شود.|
### **تنظیم اندازه بوم و حالت**
صادرات از CAD به PDF یا در فرمت‌های تصویر Raster یک کار ساده نیست. از آنجا که PDF یا تصویر حاصل نیاز به تعریف اندازه بوم دارد، ما باید ابعاد خروجی را برای صفحه PDF به درستی تنظیم کنیم. **CadRasterizationOptions.PageWidth** و **CadRasterizationOptions.PageHeight** را به‌صورت صریح تنظیم کنید، در غیر این صورت ممکن است با **ImageSaveException** مواجه شوید.

علاوه بر این، ممکن است گزینه‌های مقیاس ابعاد را مشخص کنید. گزینه‌های مقیاس‌دهی با ویژگی **CadRasterizationOptions.ScaleMethod** تنظیم می‌شوند. از این گزینه برای تنظیم ابعاد تصویر به‌طور خودکار بر اساس مقادیر **CadRasterizationOptions.PageWidth** و **CadRasterizationOptions.PageHeight** استفاده کنید. به‌طور پیش‌فرض، **CadRasterizationOptions.ScaleMethod** به حالت **ScaleType.ShrinkToFit** تنظیم می‌شود. این ویژگی رفتار زیر را تعریف می‌کند:

- اگر ابعاد نقشه CAD بزرگتر از سایز بوم حاصل باشد، در این صورت ابعاد نقشه به‌منظور تناسب با بوم حاصل در حالی که نسبت ابعاد حفظ می‌شود، کاهش می‌یابد.
- اگر ابعاد نقشه CAD کوچکتر از سایز بوم حاصل باشد، ویژگی **CadRasterizationOptions.ScaleMethod** را به **ScaleType.GrowToFit** تنظیم کنید تا اندازه نقشه افزایش یابد تا در بوم PDF جا شود و در عین حال نسبت ابعاد حفظ شود.
- یا مقیاس‌دهی خودکار را با گزینه **ScaleType.None** غیرفعال کنید.

کد نمونه زیر گزینه مقیاس‌دهی خودکار را در حال استفاده نشان می‌دهد.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **تنظیم رنگ‌های پس‌زمینه و نقاشی**
به‌طور پیش‌فرض، پالت رنگی برای بوم حاصل به طرح سند عمومی تنظیم شده است. این بدان معناست که تمام موجودیت‌ها در داخل نقشه CAD با قلم مشکی روی پس‌زمینه‌ای سفید و جامد رسم می‌شوند. این تنظیمات را می‌توان با ویژگی‌های **CadRasterizationOptions.BackgroundColor** و **CadRasterizationOptions.DrawColor** تغییر داد. تغییر ویژگی **CadRasterizationOptions.DrawColor** همچنین نیاز به تنظیم ویژگی **CadRasterizationOptions.DrawType** دارد تا از رنگ نقاشی استفاده شود. ویژگی **CadRasterizationOptions.DrawType** مشخص می‌کند که آیا موجودیت‌های CAD رنگ‌های خود را حفظ می‌کنند یا به رنگ‌های سفارشی تبدیل می‌شوند. برای حفظ رنگ‌های موجودیت، **CadRasterizationOptions.DrawType** را به **CadDrawTypeMode.UseObjectColor** مشخص کنید، در غیر این صورت مقدار **CadDrawTypeMode.UseDrawColor** را مشخص کنید.

کد نمونه زیر نشان می‌دهد که چگونه از ویژگی‌های رنگ مختلف استفاده کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **تنظیم مقیاس‌دهی خودکار چیدمان**
بیشتر نقشه‌های CAD در یک فایل چندین چیدمان دارند و هر چیدمان می‌تواند ابعاد متفاوتی داشته باشد. هنگام رندر کردن چنین نقشه‌های CAD به PDF، هر صفحه PDF می‌تواند با توجه به اندازه چیدمان مقیاس متفاوتی داشته باشد. به منظور همگن‌سازی رندر، API Aspose.CAD ویژگی **CadRasterizationOptions.AutomaticLayoutsScaling** را ارائه داده است. مقدار پیش‌فرض آن **false** است اما هنگامی که **true** باشد، API تلاش می‌کند تا مقیاس مربوط به هر چیدمان جداگانه را جستجو کند و آنها را به‌صورت مناسب با انجام عملیات تغییر اندازه خودکار بر اساس اندازه صفحه رسم کند.

این‌گونه است که ویژگی **CadRasterizationOptions.AutomaticLayoutsScaling** در همکاری با ویژگی **CadRasterizationOptions.ScaleMethod** کار می‌کند.

1. اگر **ScaleMethod** به **ScaleType.ShrinkToFit** یا **ScaleType.GrowToFit** با **AutomaticLayoutsScaling** تنظیم شده بر روی false، در این صورت تمام چیدمان‌ها (شامل مدل) مطابق با گزینه اول پردازش خواهند شد.
1. اگر **ScaleMethod** به **ScaleType.ShrinkToFit** یا **ScaleType.GrowToFit** با **AutomaticLayoutsScaling** تنظیم شده بر روی true، در این صورت تمام چیدمان‌ها (به جز مدل) مطابق با اندازه آنها پردازش خواهند شد در حالی که مدل مطابق با گزینه اول پردازش خواهد شد.
1. اگر **ScaleMethod** به **ScaleType.None** با **AutomaticLayoutsScaling** تنظیم شده بر روی true یا false، در این صورت هیچ مقیاس‌دهی انجام نخواهد شد.

کد نمونه زیر نشان می‌دهد که چگونه مقیاس‌دهی خودکار چیدمان را برای تبدیل CAD به PDF تنظیم کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **تبدیل چیدمان‌های CAD به فرمت‌های تصویر Raster**
API Aspose.CAD for Java قادر به تبدیل چیدمان‌های CAD از فرمت‌های پشتیبانی‌شده مانند DXF و DWG به تصاویر Raster مانند PNG، BMP، TIFF، JPEG و GIF است. این API همچنین پشتیبانی از رندر چیدمان‌های خاص یک نقشه CAD به لایه‌های مختلف PSD را ارائه می‌دهد.  
API Aspose.CAD for Java روش‌های کارآمد و آسانی را برای مشخص کردن یک لیست از چیدمان‌های CAD مورد نیاز و رندر آنها به فرمت‌های تصویر Raster فراهم کرده است. در اینجا نحوه دستیابی به این هدف در 5 مرحله ساده ذکر شده است:

1. فایل CAD را به یک نمونه از **Image** با استفاده از روش کارخانه **load** بارگزاری کنید.
1. یک نمونه از **CadRasterizationOptions** ایجاد کنید و ویژگی‌های الزامی آن مانند **PageWidth** و **PageHeight** را تنظیم کنید.
1. نام چیدمان مورد نظر خود را با استفاده از ویژگی **CadRasterizationOptions.Layouts** مشخص کنید.
1. یک نمونه از **ImageOptionsBase** بسازید و ویژگی **VectorRasterizationOptions** آن را به نمونه **CadRasterizationOptions** ایجادشده در مرحله قبل اختصاص دهید.
1. **Image.Save** را با ارسال مسیر فایل (یا یک شیء از MemoryStream) و همچنین نمونه **ImageOptionsBase** ایجادشده در مرحله قبل فراخوانی کنید.

در اینجا کد منبع کامل آورده شده است.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

ویژگی **CadRasterizationOptions.Layouts** از نوع آرایه رشته‌ای است، بنابراین می‌توانید بیش از یک چیدمان را به‌صورت همزمان برای امکان تبدیل به فرمت‌های تصویری مشخص کنید. در حین مشخص کردن چندین چیدمان برای ویژگی **CadRasterizationOptions.Layouts**، تصویر TIFF حاصل دارای چندین صفحه، تصویر GIF دارای چندین فریم و فرمت PSD دارای چندین لایه خواهد بود، جایی که هر صفحه/فریم/لایه نمایانگر یک چیدمان مستقل AutoCAD است. اگر هر فرمت تصویری دیگری مانند PNG، BMP، JPEG برای ذخیره نتیجه انتخاب شود، API تنها چیدمان پیش‌فرض را رندر خواهد کرد؛ یعنی "مدل".

{{% /alert %}} 
## **فعال‌سازی ردیابی برای فرایند رندر CAD**
Aspose.CAD یک سری کلاس‌ها و زمینه‌های شمارشی پشتیبانی را برای کمک به ردیابی فرایند رندر CAD معرفی کرده است. با این تغییرات، تبدیل CAD به PDF اکنون می‌تواند به‌صورت زیر انجام شود در حالی که ردیابی فعال است.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



ردیابی فرایند رندر CAD می‌تواند مشکلات زیر را شناسایی کند:

1. اطلاعات هدر مفقود یا خراب.
1. اطلاعات چیدمان مفقود.
1. موجودیت‌های بلوک مفقود.
1. سبک‌های ابعاد مفقود.
1. سبک‌های مفقود.
## **جایگزینی فونت‌ها هنگام تبدیل نقشه‌های CAD**
این امکان وجود دارد که یک نقشه CAD خاص از فونت خاصی استفاده کند که در دستگاهی که تبدیل CAD به PDF یا CAD به تصویر Raster انجام می‌شود، در دسترس نباشد. در چنین مواقعی، API Aspose.CAD یک استثنای مناسب را برای برجسته کردن فونت‌های مفقود و متوقف کردن فرایند تبدیل ایجاد خواهد کرد، زیرا API برای رندر صحیح محتویات بر روی PDF و/یا تصاویر حاصل به این فونت‌ها نیاز دارد.
API Aspose.CAD راهی آسان برای استفاده از مکانیزم جایگزینی فونت‌های مورد نیاز با فونت‌های موجود را فراهم می‌کند. ویژگی **CadImage.Styles** یک نمونه از **CadStylesDictionary** را برمی‌گرداند که به نوبه خود شامل **CadStyleTableObject** برای هر سبک در نقشه CAD است، در حالی که **CadStyleTableObject.PrimaryFontName** می‌تواند برای مشخص کردن نام فونت موجود استفاده شود.

کد زیر استفاده از API Aspose.CAD برای Java را برای تغییر فونت تمام سبک‌ها در یک نقشه CAD نشان می‌دهد.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




همچنین ممکن است فونت فقط یک سبک خاص را با دسترسی به آن از طریق نام سبک تغییر دهید. کد زیر استفاده از این رویکرد را نشان می‌دهد.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **تبدیل لایه‌های CAD به فرمت‌های تصویر Raster**
API Aspose.CAD for Java روش‌های کارآمد و آسانی را برای مشخص کردن نام لایه CAD مورد نیاز و رندر آن به فرمت‌های تصویر Raster ارائه کرده است. در اینجا نحوه دستیابی به این هدف در 5 مرحله ساده ذکر شده است:

1. فایل CAD را به یک نمونه از **Image** با استفاده از روش کارخانه **load** بارگزاری کنید.
1. یک نمونه از **CadRasterizationOptions** ایجاد کنید و ویژگی‌های الزامی آن مانند **PageWidth** و **PageHeight** را تنظیم کنید.
1. نام لایه مورد نظر را با استفاده از روش **CadRasterizationOptions.Layers.add** اضافه کنید.
1. یک نمونه از **ImageOptionsBase** بسازید و ویژگی **VectorRasterizationOptions** آن را به نمونه **CadRasterizationOptions** ایجادشده در مرحله قبل اختصاص دهید.
1. روش **Image.save** را با ارسال مسیر فایل (یا یک شیء از MemoryStream) و همچنین نمونه **ImageOptionsBase** ایجادشده در مرحله قبل فراخوانی کنید.

در اینجا کد منبع کامل آورده شده است.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **تبدیل تمام لایه‌های CAD به تصاویر جداگانه**
شما می‌توانید تمام لایه‌ها را از یک نقشه CAD با استفاده از **CadImage.Layers** دریافت کرده و هر لایه را به تصاویر جداگانه رندر کنید همان‌طور که در زیر نمایش داده شده است.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **تبدیل لایه‌های CAD DWF به فرمت‌های تصویر Raster**
API Aspose.CAD for Java روش‌های کارآمد و آسانی را برای مشخص کردن نام لایه CAD مورد نیاز و رندر آن به فرمت‌های تصویر Raster ارائه کرده است. در اینجا نحوه دستیابی به این هدف در 5 مرحله ساده ذکر شده است:

1. فایل CAD DWF را به یک نمونه از **Image** با استفاده از روش کارخانه **Load** بارگزاری کنید.
1. یک نمونه از **CadRasterizationOptions** ایجاد کنید و ویژگی‌های الزامی آن مانند **PageWidth** و **PageHeight** را تنظیم کنید.
1. نام لایه مورد نظر را با استفاده از روش **CadRasterizationOptions.Layers.Add** اضافه کنید.
1. یک نمونه از **ImageOptionsBase** بسازید و ویژگی **VectorRasterizationOptions** آن را به نمونه **CadRasterizationOptions** ایجادشده در مرحله قبل اختصاص دهید.
1. روش **Image.Save** را با ارسال مسیر فایل (یا یک شیء از MemoryStream) و همچنین نمونه **ImageOptionsBase** ایجادشده در مرحله قبل فراخوانی کنید.

در اینجا کد منبع کامل آورده شده است.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
