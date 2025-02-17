---
title: רישוי
type: docs
weight: 50
url: /he/java/getting-started/licensing/
---

{{% alert color="primary" %}}

אתה יכול להוריד גרסה לצורך הערכה של **Aspose.CAD** עבור Java מדף ההורדה [שלו](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). גרסת ההערכה מספקת את אותן יכולות בדיוק כמו גרסת הרישוי של המוצר. יתר על כן, גרסת ההערכה הופכת פשוט לרשויה כאשר אתה רוכש רישיון ומוסיף כמה שורות קוד כדי להחיל את הרישיון.

כשהינך מרוצה מההערכה שלך על **Aspose.CAD**, אתה יכול [לרכוש רישיון](https://purchase.aspose.com/buy) באתר Aspose. הכיר את סוגי המנויים השונים המוצעים. אם יש לך שאלות, אל תהסס לפנות לצוות מכירות של Aspose.

כל רישיון של Aspose כולל מנוי לשדרוגים חינם במשך שנה לכל גרסה או תיקון חדשים שיתפרסמו במהלך הזמן הזה. התמיכה הטכנית היא חינם וללא הגבלה ומסופקת הן למשתמשי רישוי והן למשתמשי הערכה.

{{% /alert %}}

אם אתה רוצה לבדוק את **Aspose.CAD** ללא מגבלות גרסת הערכה, בקש רישיון זמני ל-30 ימים. נא הפנה ל[איך להשיג רישיון זמני?](https://purchase.aspose.com/temporary-license) למידע נוסף.

## **הגדרת רישיון**

הרישיון הוא קובץ XML טקסטואלי המכיל פרטים כגון שם המוצר, מספר המפתחים שהרישיון מוענק להם, תאריך תפוגת המנוי וכן הלאה. הקובץ חתום דיגיטלית, לכן אל תשנה את הקובץ; אפילו הוספת שורה ריקה לא מכוונת תבטל אותו.

עליך להגדיר רישיון לפני ביצוע כל פעולה עם קבצי AutoCAD. יש להגדיר את הרישיון רק פעם אחת לכל יישום או תהליך.

הרישיון יכול להיות מוטען משטף או קובץ במיקומים הבאים:

1. נתיב מפורש.
1. התיקייה שמכילה את Aspose.CAD.jar.

השתמש בשיטה License.setLicense() כדי לרשום את הרכיב. לעיתים הדרך הקלה ביותר להגדיר רישיון היא להניח את קובץ הרישיון באותה תיקייה כמו Aspose.CAD.jar ולציין רק את שם הקובץ ללא נתיב כפי שמוצג בדוגמה הבאה:

### **דוגמה 1**

בדוגמה זו **Aspose.CAD** ינסה למצוא את קובץ הרישיון בתיקייה שמכילה את ה-JARs של היישום שלך.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **דוגמה 2**

מאתחל רישיון משטף.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **אמתת את הרישיון**

ניתן לאמת אם הרישיון הוצב כראוי או לא. למחלקת License יש את השדה isLicensed שיחזיר true אם הרישיון הוקם כראוי.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("הרישיון הוקם!");

}

{{< /highlight >}}
