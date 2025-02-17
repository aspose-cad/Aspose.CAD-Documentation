---
title: התקנה
type: docs
weight: 30
url: /he/net/getting-started/installation/
---

## **התקנת Aspose.CAD עבור .NET באמצעות NuGet**

NuGet הוא הדרך הקלה ביותר להוריד ולהתקין את ה-API של Aspose עבור .NET. פתח את Microsoft Visual Studio ואת מנהל החבילות NuGet. חפש "aspose" כדי למצוא את ה-API של Aspose המבוקש. לחץ על "התקן", ה-API שנבחר יירד ויתווסף לפרויקט שלך.

![todo:image_alt_text](/_assets/install/installation_1.png)

## **הוספת הפניה ל-Aspose.CAD מפרויקט .NET**

עקוב אחר הצעדים הבאים (בהנחה שאתה משתמש ב-Microsoft Visual Studio):

1. ב-**Solution Explorer**, הרחב את צומת הפרויקט שאליו אתה רוצה להוסיף הפניה.
1. לחץ לחיצה ימנית על צומת ה-**References** עבור הפרויקט ובחר **Add Reference** מהתפריט הקצר.
1. בחלון הדו-שיח **Add Reference** דפדף למיקום קובץ ה-DLL.
1. בחר בקובץ ה-DLL של *Aspose.CAD* ולחץ על לחצן **OK**.
1. ההפניה ל-*Aspose.CAD* תופיע תחת צומת ה-**References** של הפרויקט שלך.

![todo:image_alt_text](/_assets/install/installation_2.png)

### **התקנה או עדכון של Aspose.CAD באמצעות קונסולת מנהל החבילות**

תוכל לעקוב אחר הצעדים הבאים כדי להתייחס ל-[API של Aspose.CAD](https://www.nuget.org/packages/Aspose.CAD/) באמצעות קונסולת מנהל החבילות:

1. פתח את הפתרון/פרויקט שלך ב-Visual Studio.
1. בחר בכלים -> מנהל חבילות ספרייה -> קונסולת מנהל החבילות מהתפריט כדי לפתוח את קונסולת מנהל החבילות.

![todo:image_alt_text](/_assets/install/installation_3.png)

הקלד את הפקודה “**Install-Package Aspose.CAD**” ולחץ על Enter כדי להתקין את הגרסה המלאה האחרונה ביישום שלך. לחלופין, תוכל להוסיף את הסיומת "**-prerelease**" לפקודה כדי לציין שהגרסה האחרונה כולל תיקוני חום צריכה להיות מותקנת גם כן.

![todo:image_alt_text](/_assets/install/installation_4.png)

תראה שההודעה "מוריד את Aspose.CAD..." מופיעה בתחתית השמאלית של החלון, מה שמצביע על כך שההורדה מתבצעת.

![todo:image_alt_text](/_assets/install/installation_5.png)

לאחר ההורדה תראה את הודעות האישור הבאות. אם אינך מכיר את ה-[EULA של Aspose](https://about.aspose.com/legal/eula) אז זה רעיון טוב לקרוא את הרישיון המוזכר ב-URL.

![todo:image_alt_text](/_assets/install/installation_6.png)

כעת תמצא כי Aspose.CAD הוספה בהצלחה והופיעה בהפניות ביישום שלך.

![todo:image_alt_text](/_assets/install/installation_7.png)

בקונסולת מנהל החבילות, תוכל גם להשתמש בפקודה “**Update-Package Aspose.CAD**” ולחץ על Enter כדי לבדוק אם יש עדכונים לחבילה של Aspose.CAD ולהתקין אותם אם הם קיימים. תוכל גם להוסיף את הסיומת "-prerelease" כדי לעדכן את הגרסה האחרונה.

## **שיקולים בעת הפעלה בסביבת שרת משותפת**

כל רכיבי Aspose .NET מומלצים לפעולה עם הרשאות Full Trust. הסיבה לכך היא שרכיב Aspose .NET לפעמים צריך לגשת להגדרות רישום וקבצים הממוקמים במקומות אחרים מאשר הספרייה הווירטואלית, למשל, כדי לקרוא גופנים וכו'. יתרה מכך, רכיבי Aspose.NET מבוססים על מחלקות מערכת ליבה של .NET, שחלקן גם דורשות הרשאות Full Trust כדי לפעול בחלק מהמקרים.

ספקי שירותי אינטרנט המארחים מספר יישומים מחברות שונות אוכפים בדרך כלל רמת אבטחת Medium Trust. במקרה של .NET 2.0, רמת אבטחה כזו עשויה לקבוע את המגבלות הנלוות שעשויות להשפיע על היכולת של Aspose.CAD לפעול כראוי.

- **RegistryPermission** אינה זמינה. המשמעות היא שאינך יכול לגשת לרישום, מה שנדרש כדי למנות גופנים מותקנים בעת רינדור מסמכים.
- **FileIOPermission** מוגבלת. המשמעות היא שאתה יכול לגשת רק לקבצים במבנה הספריות הווירטואלי של היישום שלך. זה עלול לגרום לכך שלא ניתן לקרוא גופנים במהלך הייצוא.

מסיבות אלה שצוין למעלה, מומלץ להריץ את Aspose.CAD עם הרשאות Full Trust. ייתכן שתמצא שחלק מהתכונות של הספרייה יפעלו כאשר מתבצעים משימות שונות במצב Medium Trust בעוד שחלקן לא (רינדור לדוגמה) מה שעשוי להיות בשל קריאות לתהליכי עיבוד תמונה של GDI+.

## **דרישות מערכת**

### **מערכות הפעלה**

Aspose.CAD עבור .NET תומך בכל מערכת הפעלה 32-bit או 64-bit שבה מותקן .NET או Mono framework כולל, אך לא מוגבל ל:

- מערכות הפעלה שולחניות של Microsoft Windows (XP, Vista, 7, 8, 10) ומערכות הפעלה של שרתים (2003, 2008, 2012)
- Windows Azure
- לינוקס (אובונטו, openSUSE, CentOS ואחרים)
- Mac OS X

### **מסגרות**

Aspose.CAD עבור .NET תומך ב:

- גרסאות .NET Framework מ-2.0 עד 4.5 כולל גרסאות Client Profile
- .NET Core
- Mono 2.6.7 או מאוחר יותר

### **סביבות פיתוח**

תוכל להשתמש ב-Aspose.CAD עבור .NET כדי לפתח יישומים בכל סביבות הפיתוח המיועדות לפלטפורמת .NET, אך הסביבות הבאות נתמכות במפורש:

- Microsoft Visual Studio 2010 או יותר
- MonoDevelop 2.4 وما מאוחר יותר
