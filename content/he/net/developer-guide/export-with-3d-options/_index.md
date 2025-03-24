---
title: ייצוא עם אפשרויות תלת מימד
type: docs
weight: 40
url: /he/net/developer-guide/export-with-3d-options/
---

## **ייצוא עם אפשרויות תלת מימד**

כמה אפשרויות הוצגו כדי לייצא מודלים תלת מימדיים ל-PDF/ראסטר ממסמכי FBX, OBJ, STL המתאימים.

כאן יש דוגמאות לסצנה תלת מימדית מנקודות מבט שונות:

![צורות](/cad/_assets/guide/3d/fig1.png)

![צורות מנקודות מבט אחרות](/cad/_assets/guide/3d/fig2.png)

מאפיין ObserverPoint מאפשר לסובב את הסצנה התלת מימדית לפי זוויות ספציפיות סביב הציר. דוגמה זו מציגה את הקוד ואת תוצאת הייצוא באמצעות כמה זוויות סיבוב שרירותיות.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![ייצוא עם סיבוב](/cad/_assets/guide/3d/fig3.png)

שינוי ה-ObserverAngle ל-ObserverPoint = new ObserverPoint(5, 60, 0) מאפשר לסובב את הסצנה.

![ייצוא עם סיבוב משתנה](/cad/_assets/guide/3d/fig4.png)

מאפיין RenderMode3D האחר מאפשר לציין כיצד תוצאת הייצוא צריכה להיות מוצגת. יש 3 מצבים: Solid (הברירת מחדל), Wireframe, ו-SolidWithEdges.

הדוגמה למטה מאפשרת ליצור מודל Wireframe עבור האובייקט הספירלי.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![מצב Wireframe](/cad/_assets/guide/3d/fig5.png)

הדוגמה למטה מראה את ההבדל בין המצבים Solid ו-SolidWithEdges.

![מצב Solid](/cad/_assets/guide/3d/fig6.png)
![מצב Solid עם קצה](/cad/_assets/guide/3d/fig7.png)
