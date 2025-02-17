---
title: רישוי מדוד
type: docs
weight: 40
url: /he/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD מאפשרת למפתחים להשתמש במפתח מדוד. זהו מנגנון רישוי חדש. מנגנון הרישוי החדש ישמש יחד עם שיטת הרישוי הקיימת. לקוחות המעוניינים להיחשב לפי השימוש בתכונות ה-API יכולים להשתמש ברישוי מדוד. למידע נוסף, אנא עיינו בסעיף [שאלות ותשובות על רישוי מדוד](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **רישוי מדוד**
הנה השלבים הפשוטים לשימוש במחלקת Metered.

1. צרו מופע של מחלקת Metered.
1. העבירו את המפתחות הציבוריים והפרטיים למתודת SetMeteredKey.
1. בצעו עיבוד (בצעו משימה).
1. קראו למתודת GetConsumptionQuantity של מחלקת Metered.
1. זה יחזיר את כמות הבקשות API שהשתמשתם בהן עד כה.

להלן דוגמת קוד המדגימה כיצד להגדיר מפתח ציבורי ופרטי מדוד.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
