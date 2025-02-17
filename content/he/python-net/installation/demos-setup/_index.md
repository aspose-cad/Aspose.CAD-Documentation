---
title: התקנת דוגמאות
type: docs
weight: 40
url: /he/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD עבור Python כולל מספר פרויקטי דמו כדי לעזור לך להתחיל.

הדוגמאות המסופקות עם Aspose.CAD עבור Python הן דוגמאות Python סטנדרטיות שהותאמו להדגים את השימוש במפיצים החדשים.

{{% /alert %}}

כדי להריץ את הדוגמאות של Aspose.CAD עבור Python, בצע את השלבים הבאים:

1. הורד את Python (למשל https://sourceforge.net/projects/python-net/files/archive/). ודא שאתה מוריד את הפרויקט המוחלט כולו עם קוד המקור והדוגמאות, ולא רק JAR אחד.
1. פרוק את הפרויקט המוחלט למקום כלשהו באחסון הקשיח שלך, לדוגמה C:\.
1. העבר את כל תיקיות הדמו מהתיקייה \samples של **aspose-cad-xx.x.zip** ל- **\InstallDir\demo\samples**, כאשר "\InstallDir" הוא המקום שבו פרקת את Python. שלב זה נדרש מכיוון שכתבי הסריקה של הדמו מסתמכים על מבנה התיקיות של Python, אחרת תצטרך לשנות את כתבי הסריקה.
1. העבר את **aspose-cad-pythons-xx.x.jar** מהתיקייה \lib של **aspose-cad-pythons-xx.x.zip** ל- **\InstallDir\lib**.
1. הכין את כלי הבנייה של אנט ואת מנהל התלות של אייבי, ראה **\InstallDir\readme.txt**.
1. שנה את **build.xml** ב- **\InstallDir\demo\samples**, הוסף את aspose-cad-pythons-xx.x.jar ל-classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. שנה את התיקיה הנוכחית ל- **\InstallDir\demo\hsqldb** והרץ את הפקודה הבאה בשורת הפקודה:
   **ant runServer**
1. שנה את התיקיה הנוכחית לאחת מהדוגמאות של Aspose.CAD עבור Python, למשל **\InstallDir\demo\samples\charts.ai** והרץ את הפקודות הבאות בשורת הפקודה:
   **ant test** - כדי לייצר קבצי דוח.
1. פתח אחד מהמסמכים המתקבלים לצפייה, למשל **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
