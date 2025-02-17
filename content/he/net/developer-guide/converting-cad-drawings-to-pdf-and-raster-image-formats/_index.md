---
title: DWG DXF ל-PDF C# | המרת קבצי אוטו CAD ל-PDF JPEG PNG ב-C# .NET
type: docs
weight: 30
url: /he/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG ל-PDF C#, DXF ל-PDF C#, DWF DWT ל-PDF C#, המרת אוטוCAD, המרת DWG, המרת DWF, המרת DWT, המרת DXF, המרת אוטוקד ל-PDF, המרת DWG ל-PDF, המרת DWG ל-PNG, המרת DWG ל-TIFF, המרת DWG ל-JPG"
description: השתמש בממיר DWG ל-PDF של C# .NET להמיר DWG או DXF ל-PDF ב-C#. אתה יכול להמיר DWG, DWF, DWT ו-DXF ל-PDF, JPEG, PNG, BMP, GIF ו-TIFF ב-C# .NET גם כן.
---

## **המרת DWG או DXF ל-PNG JPEG BMP GIF או TIFF ב-C#**

Aspose.CAD עבור .NET יכולה להמיר פורמטים של שרטוטי אוטוCAD כגון [DXF](https://docs.fileformat.com/cad/dxf/) ו-[DWG](https://docs.fileformat.com/cad/dwg/) ל-[PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) ו-[GIF](https://docs.fileformat.com/image/gif/). היא מציעה ממשק API יעיל וקל לשימוש להשגת מטרה זו.

אתה יכול להמיר כל פורמט שרטוט אוטוCAD נתמך לפורמטים של תמונות רסטר באמצעות הצעדים הפשוטים שמפורטטים למטה.

1. טען את קובץ ה-DWG או DXF של אוטוCAD לתוך מחלקת ה-[**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. צור מופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. קבע/שנה את גודל התמונה באמצעות [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) ו-[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. צור מופע של [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase).
1. קבע את מאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) להופעה של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) שנוצרה בשלב הקודם.
1. שמור את שרטוט אוטוCAD כ-PDF עם [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) על ידי העברת מסלול הקובץ (או אובייקט של MemoryStream) כמו גם את המופע של [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) שנוצר בשלב הקודם.

הנה הקוד המלא.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

הברירת מחדל של ה-API מציגה רק את העיצוב "Model". עם זאת, אתה יכול גם לציין את העיצובים לפי בחירתך תוך המרת שרטוטי CAD לפורמטים של תמונות.

## **התאמת המרת CAD**

תהליכי ההמרה מ-CAD ל-[PDF](https://docs.fileformat.com/pdf/) & מ-CAD לפורמטים של תמונות רסטר הם מאוד ניתנים להתאמה מכיוון שמחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) הושמה בצורה כזו שהיא מספקת הרבה אפשרויות אופציונליות שבזמן הגדרתן יכולות להחליף את תהליך ההמרה בהתאם לצרכי האפליקציה.

### **מחלקת CadRasterizationOptions**

מחלקת **CadRasterizationOptions** היא משותפת לכל הפורמטים הנתמכים של CAD כגון DWG ו-DXF, ולכן המידע המשותף במאמר זה תקף לשני הפורמטים הנ"ל.

מאפייני מחלקת **CadRasterizationOptions** השימושיים ביותר הם:

|**מאפיין**|**ערך ברירת מחדל**|**נדרש**|**תיאור**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|כן|מציין את רוחב הדף.|
|**PageHeight**|**0**|כן|מציין את גובה הדף.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|לא|מציין אם השרטוט צריך להיות מותר באופן אוטומטי. ברירת המחדל מקטינה את התמונה שיתאימו לגודל הקנבס. החלף למצב **GrowToFit**, או השתמש בהגדרת **None** כדי להשבית הקטנה אוטומטית.|
|**BackgroundColor**|**Color.White**|לא|מציין את צבע הרקע של התמונה המוצאת.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|לא|מציין את מצב צביעת היישויות. ציין את אפשרות **UseObjectColor** לציור יישויות באמצעות הצבע המקורי שלהן, או את האפשרות **UseDrawColor** כדי לבטל צבעים מקוריים.|
|**DrawColor**|**Color.Black**|לא|מציין את הצבע המוחל על היישות (רק אם **DrawType** מוגדר לערך המאפיין **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|לא|מציין אם צריך לבצע הקטנה אוטומטית כדי להתאים לעיצוב הModel.|

### **הגדרת גודל הקנבס & המצב**

ההמירה מ-CAD ל-PDF או מ-CAD לפורמטים של תמונות רסטר היא לא משימה טריוויאלית. מאחר ומסמך ה-PDF או התמונה שנוצר דורש שהגודל של הקנבס יוגדר, אנו צריכים לציין את ממדי הפלט עבור הדף של PDF כדי להציג את השרטוט כראוי. קבע את מאפייני **CadRasterizationOptions.PageWidth** ו-**CadRasterizationOptions.PageHeight** בצורה מפורשת, אחרת אתה עשוי לקבל **ImageSaveException**.

בנוסף, אתה יכול לציין אפשרויות סקייל ממדי. אפשרויות הסקייל מוגדרות בעת הגדרת מאפיין **CadRasterizationOptions.ScaleMethod**. השתמש באפשרות זו כדי להתאים באופן אוטומטי את ממדי התמונה לפי ערכי **CadRasterizationOptions.PageWidth** ו-**CadRasterizationOptions.PageHeight**. באופן ברירת המחדל **CadRasterizationOptions.ScaleMethod** מוגדר למצב **ScaleType.ShrinkToFit**. מאפיין זה מגדיר את ההתנהגות הבאה:

- אם ממדי השרטוט ב-CAD גדולים מגודל הקנבס התוצאות, אז ממדי השרטוט מצטמצמים כדי להתאים לגודל הקנבס תוך שמירה על יחס הצורה.
- אם ממדי השרטוט ב-CAD קטנים מגודל הקנבס התוצאות, קבע את מאפיין **CadRasterizationOptions.ScaleMethod** ל-**ScaleType.GrowToFit** כדי להגדיל את גודל השרטוט כדי להתאים לקנבס של PDF תוך שמירה על יחס הצורה.
- או להשבית את הסקייל האוטומטי עם האפשרות **ScaleType.None**.

הדוגמה קוד למטה מציגה את אפשרות הסקייל האוטומטי בשימוש.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **הגדרת צבעי הרקע והציור**

באופן ברירת מחדל, לוח הצבעים עבור הקנבס התוצאה מוגדר לתבנית דוקומנט כללית. כלומר, כל היישויות בתוך השרטוט ב-CAD מצויירות עם עט צבע שחור על רקע לבן מוצק. הגדרות אלו יכולות להשתנות עם מאפייני **CadRasterizationOptions.BackgroundColor** ו-**CadRasterizationOptions.DrawColor**. שינוי מאפיין **CadRasterizationOptions.DrawColor** מצריך גם לקבוע את מאפיין **CadRasterizationOptions.DrawType** כדי להשתמש בצבע הציור שצריך להיות בשימוש. מאפיין **CadRasterizationOptions.DrawType** שולט אם היישויות CAD שומרות על הצבעים שלהן או מומרות לצבעים מותאמים אישית. כדי לשמור על צבעי היישות, ציין את **CadRasterizationOptions.DrawType** כ-**CadDrawTypeMode.UseObjectColor**, אחרת ציין את הערך **CadDrawTypeMode.UseDrawColor**.

הדוגמה קוד למטה מראה כיצד להשתמש במאפייני צבע שונים.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **הגדרת סקייל אוטומטי לרכיבים**

רוב השרטוטים CAD שמורים ביותר מעיצוב אחד בקובץ יחיד, וכל עיצוב עשוי שיהיה לו ממדים שונים. בזמן הצגת שרטוטים CAD כ-PDF, כל דף ב-PDF עשוי שיהיה לו הסקייל שונה בהתאם לגודל העיצוב. כדי להפוך את ההצגה להומוגנית, ה-API של Aspose.CAD הצגה את מאפיין **CadRasterizationOptions.AutomaticLayoutsScaling**. הערך ברירת המחדל שלו הוא **false**, אבל כאשר הוא true, ה-API ינסה לחפש סקייל תואם לכל עיצוב נפרד ולצייר אותם בדרך תואמת על ידי ביצוע פעולה אוטומטית לשינוי גודל בהתאם לגודל הדף.

הנה כיצד עובד מאפיין **CadRasterizationOptions.AutomaticLayoutsScaling** בשיתוף פעולה עם מאפיין **CadRasterizationOptions.ScaleMethod**.

1. אם **ScaleMethod** מוגדר ל-**ScaleType.ShrinkToFit** או **ScaleType.GrowToFit** עם **AutomaticLayoutsScaling** מוגדר ל-false אז כל העיצובים (כולל את ה-Model) יעובדו בהתאם לאופציה הראשונה.
1. אם **ScaleMethod** מוגדר ל-**ScaleType.ShrinkToFit** או **ScaleType.GrowToFit** עם **AutomaticLayoutsScaling** מוגדר ל-true אז כל העיצובים (מלבד ה-Model) יעובדו בהתאם לגודלם, בעוד שה-Model יעובד בהתאם לאופציה הראשונה.
1. אם **ScaleMethod** מוגדר ל-**ScaleType.None** עם **AutomaticLayoutsScaling** מוגדר ל-true או false אז לא תתבצע שום הקטנה.

הדוגמה קוד למטה מראה כיצד להגדיר את סקייל האוטומטי עבור המרת CAD ל-PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **המרת עיצובים של DXF או DWG של אוטוCAD ל-PNG או פורמטים אחרים של תמונות ב-C#**

Aspose.CAD עבור API .NET יכול להמיר עיצובים CAD מפורמטים נתמכים כגון DXF ו-DWG ל-PNG BMP TIFF JPEG ו-GIF. ה-API גם מספק תמיכה בהצגת העיצובים הספציפיים של שרטוט CAD לשכבות PSD שונות.

הנה כיצד אתה יכול להשיג את אותו הדבר בצעדים פשוטים הבאים.

- טען את קובץ ה-DWG או DXF של אוטוCAD באמצעות מחלקת **Image**.
- קבע/שנה את הרוחב והגובה של התמונה.
- קבע את שמות העיצוב הרצויים באמצעות מאפיין **CadRasterizationOptions.Layouts**.
- צור מופע של **ImageOptionsBase** וקבע את מאפיין **VectorRasterizationOptions** שלו למופע של **CadRasterizationOptions** שנוצר בשלב הקודם.
- שמור את העיצוב של CAD כ-TIFF או תמונה.

הנה הקוד המלא.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

המאפיין **CadRasterizationOptions.Layouts** הוא מסוג מערך מיתרים כך שאתה יכול לקבוע יותר מעיצוב אחד בו-זמנית להמרה אפשרית לפורמטים של תמונות. בעת קביעת כמה עיצובים למאפיין **CadRasterizationOptions.Layouts**, התמונה של TIFF שנוצרה תהיה בעלת כמה דפים, התמונה של GIF תהיה בעלת כמה מסגרות ועיצוב ה-[PSD](https://docs.fileformat.com/image/psd/) תהיה בעלת כמה שכבות, כאשר כל דף/מסגרת/שכבה מייצגת עיצוב אוטוCAD בודד. אם נבחר פורמט תמונה אחר כגון PNG, BMP, JPEG לאחסן את התוצאה אז ה-API יציג רק את העיצוב ברירת המחדל; כלומר "Model".

{{% /alert %}}

## **הנעת מעקב לתהליך ההמרה של CAD**

Aspose.CAD הציגה סדרת מחלקות ושדות של אנומציות תומכות לסייע במעקב אחרי תהליך ההמרה של CAD. עם שינויים אלו במקום, ההמרה מ-CAD ל-PDF יכולה להתבצע כעת כפי הבא תוך כדי הפעלת מעקב.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

מעקב אחרי תהליך ההמרה של CAD יכול לזהות את הבעיות האפשריות הבאות.

1. מידע כותרת חסר או פגום.
1. מידע עיצוב חסר.
1. ישויות חסרות.
1. סגנונות מימד חסרים.
1. סגנונות חסרים.

## **החלפת גופנים בעת המרת שרטוטי CAD**

זה עשוי להיות שאילן CAD מסוים משתמש בגופן מסוים שלא זמין במכונה בה מתרחשת המרת CAD ל-PDF או CAD לפורמטי תמונות רסטר. במצבים כאלה, API של Aspose.CAD תפעיל חריגה מתאימה להצביע על הגופן(ים) החסרים ולהפסיק את תהליך ההמרה מכיוון שה-API זקוק לגופנים אלו כדי להציג כראוי את התוכן על ה-PDF או התמונות המתקבלות.

API של Aspose.CAD מספקת דרך קלה להשתמש במנגנון להחלפת הגופנים הנדרשים עם הגופנים הזמינים. המאפיין **CadImage.Styles** מחזיר מופע של **CadStylesDictionary** המאגד בתורו את ה**CadStyleTableObject** עבור כל סגנון בשרטוט CAD, כאשר **CadStyleTableObject.PrimaryFontName** יכול לשמש כדי לציין את שם הגופן הזמין.

הקטע הקוד הבא מדגים את השימוש ב-Aspose.CAD עבור API .NET לשנות את הגופן של כל הסגנונות בשרטוט CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

כמו כן, יש אפשרות לשנות את גופן של סגנון אחד מסוים בלבד על ידי גישה אליו דרך שם הסגנון. הקטע הקוד הבא מדגים את השימוש בגישה זו.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **המרת שכבות CAD לפורמטים של תמונות רסטר**

Aspose.CAD עבור API .NET חשפה אמצעי יעיל וקל לשימוש לציין את שם שכבת CAD הנדרשת ולצייר אותה לפורמטים של תמונות רסטר. הנה כיצד תוכל להשיג את אותו הדבר ב-5 צעדים פשוטים המפורטים למטה.

1. טען את הקובץ CAD לתוך מופע של **Image** באמצעות מתודודת המפעל **Load**.
1. צור מופע של **CadRasterizationOptions** וקבע את המאפיינים החיוניים שלו כגון **PageWidth** ו-**PageHeight**.
1. הוסף את שם השכבת הרצוי באמצעות המתוד של **CadRasterizationOptions.Layers.Add**.
1. צור מופע של **ImageOptionsBase** וקבע את המאפיין **VectorRasterizationOptions** שלו למופע של **CadRasterizationOptions** שנוצר בשלב הקודם.
1. קרא למתודה **Image.Save** על ידי העברת מסלול הקובץ (או אובייקט של MemoryStream) כמו גם את המופע של **ImageOptionsBase** שנוצר בשלב הקודם.

הנה הקוד המלא.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **המרת כל שכבות CAD לתמונות נפרדות**

אתה יכול לקבל את כל השכבות משרטוט CAD באמצעות ה-CadImage.Layers ולצייר כל שכבת בנפרד כפי שמוצג למטה.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **המרת שכבות DWF CAD לפורמטי תמונות רסטר**

Aspose.CAD עבור API .NET חשפה אמצעי יעיל וקל לשימוש לציין את שם שכבת CAD הנדרשת ולצייר אותה לפורמטים של תמונות רסטר. הנה כיצד תוכל להשיג את אותו הדבר ב-5 צעדים פשוטים המפורטים למטה.

1. טען את קובץ DWF CAD לתוך מופע של **Image** באמצעות מתודודת המפעל **Load**.
1. צור מופע של **CadRasterizationOptions** וקבע את המאפיינים החיוניים שלו כגון **PageWidth** ו-**PageHeight**.
1. הוסף את שם השכבת הרצוי באמצעות המתוד של **CadRasterizationOptions.Layers.Add**.
1. צור מופע של **ImageOptionsBase** וקבע את המאפיין **VectorRasterizationOptions** שלו למופע של **CadRasterizationOptions** שנוצר בשלב הקודם.
1. קרא למתודה **Image.Save** על ידי העברת מסלול הקובץ (או אובייקט של MemoryStream) כמו גם את המופע של **ImageOptionsBase** שנוצר בשלב הקודם.

הנה הקוד המלא.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD עבור .NET כותבת ישירות את המידע על ה-API ומספר הגרסה במסמכים המתקבלים. לדוגמה, בעת הצגת דוקומנט כ-PDF, Aspose.CAD עבור .NET ממלאת את שדה היישום בערך 'Aspose.CAD' ואת שדה המפיק של PDF עם ערך, לדוגמה 'Aspose.CAD v 17.10'.

אנא שים לב שאינך יכול להנחות את Aspose.CAD עבור .NET לשנות או להסיר מידע זה מן המסמכים המתקבלים.
