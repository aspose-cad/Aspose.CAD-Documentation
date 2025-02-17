---
title: שרטוטי DWF
type: docs
weight: 20
url: /he/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **יצוא שרטוטי DWF ל-PDF**

Aspose.CAD עבור Java API יכול לטעון שרטוטים של AutoCAD בפורמט DWF, ולהמיר אותם ל-PDF. נושא זה מסביר את השימוש ב-Aspose.CAD API כדי להשיג את ההמרה של DWF לפורמט PDF באמצעות צעדים פשוטים כפי שהוגדרו למעלה.

### **המרת קבצי DWF ל-PDF**

לצורך המרת DWF ל-PDF, יש לבצע את הצעדים הפשוטים הבאים.

1. טען את קובץ ה-DWF לתוך מופע של [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) והגדר את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. צור אובייקט של מחלקת [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) והגדר את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. התקשר ל[**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) תוך העברת אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) כפרמטר השני.

דוגמת הקוד למטה מראה כיצד לייצא שרטוטי DWF ל-PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **תמיכה בשכבות ב-DWF**

Aspose.CAD מספקת את הפונקציה לטעון ישויות שרטוט של AutoCAD בפורמט DWF ולהציג אותן כשרטוט שלם בפורמט JPG.

1. טען את קובץ השירטוט DWF באמצעות המתוד של [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. הוסף את השכבות הרצויות.
1. התקשר ל[**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) תוך העברת אובייקט של [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) כפרמטר השני.

דוגמת הקוד למטה מראה כיצד להמיר קובץ באמצעות ההגדרות ברירת המחדל.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
