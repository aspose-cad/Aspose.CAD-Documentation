---
title: התקנת דמואים
type: docs
weight: 40
url: /he/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD עבור JasperReports כולל מספר פרויקטי דמו שיעזרו לך להתחיל.

הדמואים המסופקים עם Aspose.CAD עבור JasperReports הם דמואים סטנדרטיים של JasperReports שהותאמו להדגמת השימוש במפיצים החדשים.

{{% /alert %}}

כדי להריץ את הדמואים של Aspose.CAD עבור JasperReports, בצע את הצעדים הבאים:

1. הורד את JasperReports (למשל https://sourceforge.net/projects/jasperreports/files/archive/). ודא שהורדת את כל הפרויקט הארכיאי עם קוד המקור והדמואים, ולא רק JAR בודד.
1. פרוס את הפרויקט הארכיאי לאיזו Location על הדיסק הקשיח שלך, לדוגמה C:\.
1. העתק את כל תיקיות הדמו מתוך תיקיית **\samples** של **aspose-cad-xx.x.zip** ל- **\InstallDir\demo\samples**, כאשר "\InstallDir" הוא המיקום שבו פרסת את JasperReports. שלב זה נדרש כי סקריפטי הבנייה של הדמואים מתבססים על מבנה התיקיות של JasperReports, אחרת תצטרך לשנות את סקריפטי הבנייה.
1. העתק את **aspose-cad-jasperreports-xx.x.jar** מתוך תיקיית \lib של **aspose-cad-jasperreports-xx.x.zip** ל- **\InstallDir\lib**.
1. הכין את כלי הבנייה Ant ואת מנהל התלותים Ivy, ראה **\InstallDir\readme.txt**.
1. שנה את ה- **build.xml** ב- **\InstallDir\demo\samples**, הוסף את aspose-cad-jasperreports-xx.x.jar ל-classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. שנה את הספרייה הנוכחית ל- **\InstallDir\demo\hsqldb** והרץ את שורת הפקודה הבאה:
   **Ant runServer**
1. שנה את הספרייה הנוכחית לאחת הדמואים של Aspose.CAD עבור JasperReports, לדוגמה **\InstallDir\demo\samples\charts.ai** והרץ את הפקודות הבאות בשורת הפקודה:
   **ant test** - כדי להפיק קבצי דוח.
1. פתח אחד מתוך המסמכים המתקבלים לצפייה, לדוגמה **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
