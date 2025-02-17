---
title: המרת שרטוטי CAD לפורמטי PDF ודימויים רסטריים
type: docs
weight: 30
url: /he/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java כותב ישירות את המידע על ה-API ומספר הגרסה במסמכי הפלט. לדוגמה, בעת רינדור מסמך ל-PDF, Aspose.CAD for Java ממלא את שדה היישום בערך 'Aspose.CAD' ואת שדה ה-PDF Producer בערך, לדוגמה 'Aspose.CAD v 17.9'.

אנא שימו לב שאינכם יכולים להורות ל-Aspose.CAD for Java לשנות או להסיר מידע זה מתוך מסמכי הפלט.

{{% /alert %}} 
## **המרת שרטוטי CAD לפורמטי דימוי רסטרי**
Aspose.CAD for Java מסוגל להמיר פורמטי שרטוט CAD כמו [**DXF**](https://docs.fileformat.com/cad/dxf/) ו-[**DWG**](https://docs.fileformat.com/cad/dwg/) לפורמטי דימוי רסטריים נתמכים כמו [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) ו-[**GIF**](https://docs.fileformat.com/image/gif/). API של Aspose.CAD for Java חשף אמצעים יעילים וקלים לשימוש כדי להשיג מטרה זו.
אתם יכולים להמיר כל פורמט שרטוט CAD הנתמך לפורמטי דימוי רסטריים באמצעות הצעדים הפשוטים המפורטים למטה.

1. ט load קובץ CAD למופע של [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. צרו מופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) והגדירו את התכונות החיוניות שלו כמו [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) ו-[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. צרו מופע של **ImageOptionsBase** והגדירו את התכונה [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) למופע של **CadRasterizationOptions** שנוצר בשלב הקודם.
1. קראו ל-**Image.save** על ידי העברת מסלול הקובץ (או אובייקט של MemoryStream) כמו גם את מופע ה-[**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) שנוצר בשלב הקודם.

הנה הקוד המלא.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



כברירת מחדל, ה-API רינדורים רק את פריסת ה"Model". עם זאת, תוכלו גם לציין את הפריסות לפי בחירתכם בעת המרת שרטוטי CAD לפורמטי דימוי.
## **התאמת המרת CAD**
הליך ההמרה מ-CAD ל-[PDF](https://docs.fileformat.com/pdf/) ול-CAD לדימוי רסטרי הוא מאוד ניתן להגדרה מכיוון שכיתת [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) היישום כך שהיא מספקת הרבה תכונות אופציונליות שעל ידי הגדרתן יכולות לשנות את תהליך הרינדור על פי צרכי היישום.
### **כיתת CadRasterizationOptions**
כיתת [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) היא משותפת לכל פורמטי CAD הנתמכים כמו [**DWG**](https://docs.fileformat.com/cad/dwg/) ו-DXF, ולכן, המידע המשותף במאמר זה הוא תקף לשני פורמטי CAD המוזכרים לעיל.

תכונות השימושיות ביותר בכיתת **CadRasterizationOptions** הן:

|**תכונה**|**ערך ברירת מחדל**|**דרוש**|**תיאור**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|כן|מפרט את רוחב העמוד.|
|**PageHeight**|**0**|כן|מפרט את גובה העמוד|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|לא|מפרט אם השרטוט צריך להיות מוקטן אוטומטית. ערך ברירת המחדל מקטין אוטומטית את התמונה כדי להתאים לגודל הקנבס. החלף למצב **GrowToFit**, או השתמש בהגדרת **None** כדי להשבית את ההקטנה האוטומטית.|
|**BackgroundColor**|**Color.White**|לא|מפרט את צבע הרקע של התמונה המפלטה.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|לא|מפרט את מצב הצבע של הישות. ציין את אפשרות **UseObjectColor** כדי לצייר ישויות תוך שימוש בצבען הטבעי, או את אפשרות **UseDrawColor** כדי לבטל את הצבעים הטבעיים.|
|**DrawColor**|**Color.Black**|לא|מפרט את צבע הישות המוחל (רק אם **DrawType** מוגדר לערך של תכונת **UseDrawColor**).|
|**AutomaticLayoutsScaling**|שקר|לא|מפרט אם יש לבצע הקטנת פריסות אוטומטית כדי להתאים לפריסת המודל.|
### **הגדרת גודל ומצב קנבס**
הייצוא מ-CAD ל-PDF או מ-CAD לפורמטי דימוי רסטריים אינו משימה שגרתית. מכיוון שה-PDF או התמונה המתקבלים דורשים שהגודל של הקנבס יהיה מוגדר, עלינו להגדיר את המידות המוציאות לעמוד ה-PDF כדי לרינדור את השרטוט כראוי. הגדירו את התכונות **CadRasterizationOptions.PageWidth** ו-**CadRasterizationOptions.PageHeight** במפורש, אחרת, אתם עלולים לקבל **ImageSaveException**.

בנוסף, אתם יכולים גם לציין אפשרויות קנה מידה. אפשרויות הקנה מידה מוגדרות על ידי תכונת **CadRasterizationOptions.ScaleMethod**. השתמשו באפשרות זו כדי להתאים אוטומטית את מידות התמונה לפי ערכי **CadRasterizationOptions.PageWidth** ו-**CadRasterizationOptions.PageHeight**. כברירת מחדל, **CadRasterizationOptions.ScaleMethod** מוגדר כמצב **ScaleType.ShrinkToFit**. תכונה זו מגדירה את ההתנהגות הבאה:

- אם מידות השרטוט CAD גדולות ממדי הקנבס המתקבל, אזי מידות השרטוט מצטמצמות כדי להתאים לקנבס המתקבל תוך שמירה על פרופורציות.
- אם מידות השרטוט CAD קטנות ממדי הקנבס המתקבל, הגדירו את תכונת **CadRasterizationOptions.ScaleMethod** ל-**ScaleType.GrowToFit** כדי להגדיל את גודל השרטוט להתאים לקנבס PDF תוך שמירה על פרופורציות.
- או השביתו את ההקטנה האוטומטית עם אפשרות **ScaleType.None**.

דוגמת הקוד למטה מציגה את אפשרות ההקטנה האוטומטית בשימוש.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **הגדרת צבע הרקע וצבעי ציור**
כברירת מחדל, פלטת הצבעים עבור הקנבס המתקבל מוגדרת לסכמת המסמך המשותפת. כלומר, כל הישויות בתוך השרטוט CAD מצויירות בעט שחור על רקע לבן מוצק. הגדרות אלו יכולות להיות משתנות עם תכונות **CadRasterizationOptions.BackgroundColor** ו-**CadRasterizationOptions.DrawColor**. שינוי התכונה **CadRasterizationOptions.DrawColor** דורש גם להגדיר את התכונה **CadRasterizationOptions.DrawType** כדי לנצל את צבע הציור שברצונכם להשתמש. תכונת **CadRasterizationOptions.DrawType** קובעת אם ישויות CAD שומרות על צבעיהן או מומרות לצבעים מותאמים אישית. כדי לשמור על צבעי הישויות, ציינו את **CadRasterizationOptions.DrawType** כ-**CadDrawTypeMode.UseObjectColor**, אחרת ציינו את ערך **CadDrawTypeMode.UseDrawColor**.

דוגמת הקוד למטה מציגה כיצד להשתמש בתכונות צבע שונות.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **הגדרת הקטנה אוטומטית של פריסות**
רוב שרטוטי CAD מכילים יותר מפריסה אחת שנשמרת בקובץ אחד, וכל פריסה עשויה להיות עם מידות שונות. בעת רינדור שרטוטי CAD כאלה ל-PDF, כל עמוד ב-PDF עשוי להיות עם הקטנה שונה בהתאם לגודל הפריסה. כדי להפוך את הרינדור להומוגני, ה-API של Aspose.CAD חשף את תכונת **CadRasterizationOptions.AutomaticLayoutsScaling**. ערך ברירת המחדל שלה הוא **שקר**, אבל כאשר זה נכון, ה-API ינסה לחפש קנה מידה מתאים עבור כל פריסה נפרדת ולצייר אותן באופן מתאים על ידי ביצוע פעולה אוטומטית להתאמה בהתאם לגודל העמוד.

הנה כיצד תכונת **CadRasterizationOptions.AutomaticLayoutsScaling** פועלת בשיתוף פעולה עם תכונת **CadRasterizationOptions.ScaleMethod**.

1. אם **ScaleMethod** מוגדר ל-**ScaleType.ShrinkToFit** או **ScaleType.GrowToFit** עם **AutomaticLayoutsScaling** מוגדר ל"שקר", אז כל הפריסות (כולל המודל) יופעלו לפי האפשרות הראשונה.
1. אם **ScaleMethod** מוגדר ל-**ScaleType.ShrinkToFit** או **ScaleType.GrowToFit** עם **AutomaticLayoutsScaling** מוגדר ל"נכון", אז כל הפריסות (מלבד המודל) יתעובדו בהתאם לגודל שלהם ואילו המודל יתעובד בהתאם לאפשרות הראשונה.
1. אם **ScaleMethod** מוגדר ל-**ScaleType.None** עם **AutomaticLayoutsScaling** מוגדר ל"נכון" או "שקר", אז לא תתבצע הקטנה.

דוגמת הקוד למטה מציגה כיצד להגדיר הקטנה אוטומטית להמרת CAD ל-PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **המרת פריסות CAD לפורמטי דימוי רסטרי**
API של Aspose.CAD for Java מסוגל להמיר פריסות CAD של פורמטים נתמכים כמו DXF ו-DWG לדימויים רסטריים כמו PNG, BMP, TIFF, JPEG ו-GIF. ה-API מספק גם תמיכה לרינדור את הפריסות הספציפיות של שרטוט CAD לשכבות PSD שונות.
API של Aspose.CAD for Java חשף אמצעים יעילים וקלים לשימוש כדי לציין את רשימת הפריסות הנדרשות של CAD ולרינדור אותן לפורמטי דימוי רסטריים. הנה כיצד אתם יכולים להשיג זאת ב-5 צעדים פשוטים כמפורט למטה.

1. ט load קובץ CAD למופע של **Image** באמצעות שיטת המפעל **load**.
1. צרו מופע של **CadRasterizationOptions** והגדירו את תכונות החובה שלו כמו **PageWidth** ו-**PageHeight**.
1. ציינו את שמות הפריסות הרצויות באמצעות תכונת CadRasterizationOptions.Layouts.
1. צרו מופע של **ImageOptionsBase** והגדירו את תכונת **VectorRasterizationOptions** למופע של **CadRasterizationOptions** שנוצר בשלב הקודם.
1. קראו ל-**Image.Save** על ידי העברת מסלול הקובץ (או אובייקט של MemoryStream) כמו גם את מופע ה-**ImageOptionsBase** שנוצר בשלב הקודם.

הנה הקוד המלא.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

התכונה **CadRasterizationOptions.Layouts** היא מסוג מערך מיתרים כך שאתם יכולים לציין יותר מפריסה אחת בו זמנית להמרה לפורמטי דימוי. בעת ציון מספר פריסות לתכונת **CadRasterizationOptions.Layouts**, התמונה המתקבלת בפורמט TIFF תהיה בעלת מספר עמודים, התמונה המתקבלת בפורמט GIF תהא בעלת מספר פריימים והפורמט PSD יהיה בעל מספר שכבות, כאשר כל עמוד/פריים/שכבה מייצגים פריסת AutoCAD אינדיבידואלית. במקרה שנבחר פורמט תמונה אחר כמו PNG, BMP, JPEG כדי לשמור את התוצאה, ה-API ייצר רק את הפריסה ברירת מחדל; כלומר "Model".

{{% /alert %}} 
## **הפעלת מעקב עבור תהליך רינדור CAD**
Aspose.CAD הציגה סדרה של כיתות ושדות הנומינציה התומכים כדי לסייע במעקב אחר תהליך רינדור CAD. עם שינויים אלו במקומם, המרת CAD ל-PDF יכולה להיות מושגת באופן הבא תוך הפעלת המעקב.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



מעקב אחר תהליך רינדור CAD יכול לזהות את הבעיות אפשריות הבאות.

1. מידע על כותרת חסר או פגום.
1. מידע על פריסה חסר.
1. ישויות בלוק חסרות.
1. סגנונות מידה חסרים.
1. סגנונות חסרים.
## **החלפת גופנים בעת המרת שרטוטי CAD**
אפשרי מאוד ששרטוט CAD מסוים משתמש בגופן ספציפי שאינו זמין במחשב שבו מתבצע ההמרה מ-CAD ל-PDF או מ-CAD לפורמט דימוי רסטרי. במצבים כאלה, ה-API של Aspose.CAD יפעיל חריגה מתאימה כדי להדגיש את הגופן (ים) החסרים ולהפסיק את תהליך ההמרה מכיוון שה-API דורש גופנים אלה לרינדור נכון של התוכן ל-PDF ול/או התמונות המתקבלות.
API של Aspose.CAD מספק אמצעים קלים להשתמש במנגנון להחלפת הגופנים הנדרשים בגופנים הזמינים. תכונת **CadImage.Styles** מחזירה מופע של **CadStylesDictionary** שמכיל בתורו את **CadStyleTableObject** עבור כל סגנון בשרטוט CAD, בעוד ש-**CadStyleTableObject.PrimaryFontName** יכול לשמש כדי לציין את שם הגופן הזמין.

הקטע הקוד הבא מדגים את השימוש ב-Aspose.CAD for Java API כדי לשנות את הגופן של כל הסגנונות בשרטוט CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




כמו כן, ניתן לשנות את הגופן של סגנון אחד מסוים בלבד על ידי גישה אליו באמצעות שם הסגנון. הקטע הקוד הבא מדגים את השימוש בגישה זו.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **המרת שכבות CAD לפורמטי דימוי רסטרי**
API של Aspose.CAD for Java חשף אמצעים יעילים וקלים לשימוש כדי לציין את שם שכבת CAD הדרושה ולרנדר אותה לפורמטי דימוי רסטריים. הנה כיצד אתם יכולים להשיג את אותו הדבר ב-5 צעדים פשוטים כמפורט למטה.

1. ט load קובץ CAD למופע של **Image** באמצעות שיטת המפעל **load**.
1. צרו מופע של **CadRasterizationOptions** והגדירו את תכונות החובה שלו כמו **PageWidth** ו-**PageHeight**.
1. הוסיפו את שם השכבה הרצויה באמצעות שיטת **CadRasterizationOptions.Layers.add**.
1. צרו מופע של **ImageOptionsBase** והגדירו את תכונת **VectorRasterizationOptions** למופע של **CadRasterizationOptions** שנוצר בשלב הקודם.
1. קראו לשיטת **Image.save** על ידי העברת מסלול הקובץ (או אובייקט של MemoryStream) כמו גם את מופע ה-**ImageOptionsBase** שנוצר בשלב הקודם.

הנה הקוד המלא.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **המרת כל שכבות CAD לדימויים נפרדים**
אתם יכולים לקבל את כל השכבות משרטוט CAD באמצעות **CadImage.Layers** ולרנדר כל שכבה לדימוי נפרד כפי שמודגם למטה.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **המרת שכבות DWF CAD לפורמטי דימוי רסטרי**
API של Aspose.CAD for Java חשף אמצעים יעילים וקלים לשימוש כדי לציין את שם השכבת CAD הדרושה ולרנדר אותה לפורמטי דימוי רסטריים. הנה כיצד אתם יכולים להשיג את אותו הדבר ב-5 צעדים פשוטים כמפורט למטה.

1. ט load קובץ DWF CAD למופע של **Image** באמצעות שיטת המפעל **Load**.
1. צרו מופע של **CadRasterizationOptions** והגדירו את תכונות החובה שלו כמו **PageWidth** ו-**PageHeight**.
1. הוסיפו את שם השכבה הרצויה באמצעות שיטת **CadRasterizationOptions.Layers.Add**.
1. צרו מופע של **ImageOptionsBase** והגדירו את תכונת **VectorRasterizationOptions** למופע של **CadRasterizationOptions** שנוצר בשלב הקודם.
1. קראו לשיטת **Image.Save** על ידי העברת מסלול הקובץ (או אובייקט של MemoryStream) כמו גם את מופע ה-**ImageOptionsBase** שנוצר בשלב הקודם.

הנה הקוד המלא.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
