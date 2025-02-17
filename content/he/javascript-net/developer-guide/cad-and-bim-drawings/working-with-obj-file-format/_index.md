---
title: עבודה עם פורמט קובץ OBJ
type: docs
weight: 120
url: /he/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD עכשיו תומך בפורמט קובץ OBJ. פורמט קובץ OBJ הוא גאומטריה תלת ממדית המכילה מפות טקסטורה, קואורדינטות תלת ממדיות, פאות פוליגונליות ומידע נוסף על האובייקט.

{{% /alert %}}

## **יצוא פורמט OBJ ל-PNG**

Aspose.CAD עבור Javascript ב-Angular מאפשר למפתחים לייצא קובץ [OBJ](https://docs.fileformat.com/3d/obj/) לפורמט [PNG](https://docs.fileformat.com/image/png/).
הג approach המרה של [OBJ](https://docs.fileformat.com/3d/obj/) ל[PNG](https://docs.fileformat.com/image/png/) פועל כדלקמן:

1. טען קובץ שרטוט [OBJ](https://docs.fileformat.com/3d/obj/) באמצעות שיטת **Image.load**.
1. קרא ל-**Image.save** תוך העברת אובייקט של **PngOptions** כפרמטר השני.

## דוגמת קוד

הקוד למטה מראה כיצד להשיג את אותו יעד באמצעות Aspose.CAD עבור JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
