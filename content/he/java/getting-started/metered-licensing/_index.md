---
title: רישוי מדוד
type: docs
weight: 60
url: /he/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD מאפשרת למפתחים להשתמש במפתחות מדודים. זוהי מכניקת רישוי חדשה. המכניקה החדשה תעשה שימוש לצד שיטת הרישוי הקיימת. לקוחות שרוצים שהתשלום עבור שימוש בפיצ'רים של ה-API יתבצע על בסיס השימוש יכולים להשתמש ברישוי המדוד. למידע נוסף, אנא הפנו ל[שאלות נפוצות על רישוי מדוד](https://purchase.aspose.com/faqs/licensing/metered) section.

{{% /alert %}} 
## **רישוי מדוד**
הנה הצעדים הפשוטים לשימוש במחלקת Metered.

1. צרו מופע של מחלקת Metered.
1. העבירו את המפתחות הציבוריים והפרטיים למתודת setMeteredKey.
1. בצעו עיבוד (בצעו משימה).
1. קראו למתודה getConsumptionQuantity של מחלקת Metered.
1. היא תחזיר את כמות/מספר הקריאות API שצרכתם עד כה.

להלן דוגמת קוד המדגימה כיצד להגדיר את המפתחות הציבוריים והפרטיים המדודים:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
