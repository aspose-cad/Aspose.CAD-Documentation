---
title: הגדרה של זמן קצוב בעת שמירה
type: docs
weight: 70
url: /he/java/developer-guide/set-timeout-on-save/
---

## **הגדרה של זמן קצוב בעת שמירה**

Aspose.CAD עבור Java API מאפשר לך לקבוע זמן קצוב בעת שמירה. זה יכול להיות מועיל במקרים שבהם תהליך השמירה לוקח הרבה זמן או צורך בזיכרון רב. לשם כך, ה-API מספק את ה-[**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) כיתה. ה-[**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) כיתה מספקת אסימון שמשמש להפרעת פעולות ארוכות.

## דוגמת קוד

הקוד הבא מדגים את השימוש בכיתה ה-[**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
