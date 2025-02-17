---
title: ייצוא עם אפשרויות תלת מימד
type: docs
weight: 40
url: /he/java/developer-guide/export-with-3d-options/
---

## **ייצוא עם אפשרויות תלת מימד**

מעט אפשרויות הוצגו לייצוא מודלים תלת מימדיים ל-PDF/ראסטר מהפורמטים FBX, OBJ, STL המתאימים.

הנה הדוגמאות של סצנת תלת מימד מנקודות מבט שונות:

![דמויות](/_assets/guide/3d/fig1.png)

![דמויות מנקודות מבט אחרות](/_assets/guide/3d/fig2.png)

מאפיין ObserverPoint מאפשר לסובב את סצנת התלת מימד בזוויות שנקבעו סביב הציר. דוגמה זו מציגה את הקוד ואת תוצאת הייצוא תוך שימוש בזוויות סיבוב אקראיות.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![ייצוא עם סיבוב](/_assets/guide/3d/fig3.png)

שינוי ה-ObserverAngle ל-ObserverPoint = new ObserverPoint(5, 60, 0) מאפשר לסובב את הסצנה.

![ייצוא עם סיבוב משתנה](/_assets/guide/3d/fig4.png)

מאפיין RenderMode3D אחר מאפשר לקבוע כיצד תוצאת הייצוא תוצג. ישנם 3 מצבים: Solid (ברירת המחדל), Wireframe, ו-SolidWithEdges.

הדוגמה למטה מאפשרת ליצור מודל ויירפריים עבור האובייקט הספירלי.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![מצב ויירפריים](/_assets/guide/3d/fig5.png)

הדוגמה למטה מציגה את ההבדל בין מצבי Solid ל-SolidWithEdges.

![מצב Solid](/_assets/guide/3d/fig6.png)
![מצב Solid עם קצוות](/_assets/guide/3d/fig7.png)
