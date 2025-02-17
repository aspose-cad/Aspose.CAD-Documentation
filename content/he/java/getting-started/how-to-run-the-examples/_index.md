---
title: כיצד להריץ את הדוגמאות
type: docs
weight: 70
url: /he/java/getting-started/how-to-run-the-examples/
---

## **הורדה מ-GitHub**

כל הדוגמאות של Aspose.CAD עבור Java מאוחסנות ב-[Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). אתה יכול לשכפל את המאגר באמצעות לקוח Github המועדף עליך או להוריד את קובץ ה-ZIP מ-[כאן](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

חלץ את התוכן של קובץ ה-ZIP לכל תיקייה במחשב שלך. כל הדוגמאות ממוקמות בתיקיית **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**איור: תיקיית דוגמאות Aspose.CAD**|

## **ייבוא דוגמאות ל-IDEs**

הפרויקט משתמש במערכת הבנייה Maven. כל IDE מודרני יכול בקלות לפתוח או לייבא את הפרויקט ואת התלויות שלו. למטה אנו מראים לך כיצד להשתמש ב-IDEs פופולאריים כדי לבנות ולהריץ את הדוגמאות.

### **IntelliJ IDEA**

לחץ על התפריט **File** ובחר **Open**. עבור לתיקיית הפרויקט ובחר את קובץ **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**איור: בחר קובץ או תיקייה לייבוא**|
זה יפתח את הפרויקט ויוריד את התלויות אוטומטית. מהטאב Project, עבור לדוגמאות בתיקיית **src/main/java**. כדי להריץ דוגמה, פשוט לחץ קליק ימני על הקובץ ובחר "Run ..", הדוגמה תתבצע והתוצאה תוצג בחלון פלט הקונסולה המובנה.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**איור: הרצת דוגמה**|

### **Eclipse**

לחץ על התפריט **File** ובחר **Import**. בחר **Maven** - Existing Maven Projects.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**איור: ייבוא**|
עבור לתיקייה ששכפלת או הורדת מ-GitHub ובחר את קובץ **pom.xml**. זה יפתח את הפרויקט ויוריד את התלויות אוטומטית. מהטאב Package Explorer, עבור לדוגמאות בתיקיית **src/main/java**. כדי להריץ דוגמה, פשוט לחץ קליק ימני על הקובץ ובחר **Run As** - **Java Application**, הדוגמה תתבצע והתוצאה תוצג בחלון פלט הקונסולה המובנה.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**איור: הרצת דוגמה**|

### **NetBeans**

לחץ על התפריט **File** ובחר **Open Project**. עבור לתיקייה ששכפלת או הורדת מ-GitHub. הסמל של תיקיית **Examples** יראה שזהו פרויקט Maven. בחר את Examples ופתח אותו.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**איור: פתח פרויקט**|
זה יפתח את הפרויקט ויוריד את התלויות אוטומטית. מהטאב Projects, עבור לדוגמאות בחבילות המקור **source packages**. כדי להריץ דוגמה, פשוט לחץ קליק ימני על הקובץ ובחר **Run File**, הדוגמה תתבצע והתוצאה תוצג בחלון פלט הקונסולה המובנה.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**איור: הרצת דוגמה**|

## **הוספת ספריית Aspose.CAD למאגר המקומי של Maven**

כאשר אתה מייבא את פרויקט **Aspose.CAD Examples** ל-IDEs, Maven automáticamente מוריד את קובץ ה-JAR של aspose.cad מ-[Aspose Maven Repository](https://releases.aspose.com/java/repo/). במקרה שאין לך גישה לאינטרנט, אתה יכול להוסיף ידנית את ה-JAR למאגר המקומי שלך.

### **mvn install**

הורד את ה-[aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), חלץ אותו והעתק את aspose.cad-version.jar למקום אחר, למשל, לכונן c. הרץ את הפקודה הבאה:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

כעת, ה-JAR **aspose.cad** מועתק למאגר המקומי שלך של Maven.

### **pom.xml**

לאחר ההתקנה, פשוט הכרז על הקואורדינטות של **aspose.cad** ב-pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **סיום**

בנה את זה, עכשיו ה-JAR **aspose.cad** זמין להורדה ממאגר המקומי שלך של Maven.

## **תרום**

אם תרצה להוסיף או לשפר דוגמה, אנו מעודדים אותך לתרום לפרויקט. כל הדוגמאות והפרויקטים המוצגים במאגר זה הם קוד פתוח וניתן להשתמש בהם בחופשיות באפליקציות שלך.

כדי לתרום, אתה יכול לשכפל את המאגר, לערוך את הקוד מקור ולשלוח בקשת Pull. אנו נסקור את השינויים ונכלול אותם במאגר אם נמצא שהם מועילים.
