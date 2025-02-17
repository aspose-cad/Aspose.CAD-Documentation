---
title: התקנה
type: docs
weight: 30
url: /he/java/getting-started/installation/
---

## **התקנת Aspose.CAD עבור Java מהמאגרים של Maven**

Aspose מארחת את כל ה-APIs של Java על ה-[מאגרים של Maven](https://releases.aspose.com/java/repo/com/aspose/). ניתן להשתמש בקלות ב-[Aspose.CAD עבור Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API ישירות בפרויקטי Maven שלכם עם קונפיגורציות פשוטות.

### **ציינו את קונפיגורציית מאגר Maven**

ראשית, עליכם לציין את קונפיגורציית/מיקום מאגר Aspose ב-pom.xml של Maven שלכם כמו הבא:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.cloud/java/repo/</url>
        <snapshots>
            <enabled>false</enabled>
        </snapshots>
        <releases>
            <enabled>true</enabled>
        </releases>
    </repository>
</repositories>

{{< /highlight >}}

### **הגדרו את תלות ה-API של Aspose.CAD עבור Java**

לאחר מכן הגדרו את תלות ה-API של Aspose.CAD עבור Java ב-pom.xml שלכם כמו הבא:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

לאחר ביצוע השלבים הנ"ל, תלות Aspose.CAD עבור Java תוגדר לבסוף בפרויקט Maven שלכם.

## **פלטפורמות נתמכות**

Aspose.CAD עבור Java תומכת בפלטפורמות הפיתוח וההפצה הפופולריות ביותר.

|**תכונה**|**תיאור**|
| :- | :- |
|יישומי שולחן עבודה|Aspose.CAD עבור Java יכול לשמש לפיתוח יישומי שולחן עבודה ב-Microsoft Windows.|
|יישומי רשת ארגוניים|Aspose.CAD עבור Java תומך לחלוטין ביישומי רשת.|
|לינוקס/יוניקס|Aspose.CAD עבור Java הוא API עצמאי מפלטפורמה ויכול לפעול בסביבת לינוקס ויוניקס.|

## **גרסאות Java נתמכות**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
