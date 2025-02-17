---
title: ציורים ב-SVG
type: docs
weight: 70
url: /he/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **ייצוא פורמט SVG ל-PNG**

Aspose.CAD עבור Javascript ב-Angular מאפשר למפתחים לייצא קובץ [SVG](https://docs.fileformat.com/page-description-language/svg/) לפורמט [PNG](https://docs.fileformat.com/image/png/).
ג approached המרה מ-[SVG](https://docs.fileformat.com/page-description-language/svg/) ל-[PNG](https://docs.fileformat.com/image/png/) מתבצע כך:

1. טען את קובץ הציור [SVG](https://docs.fileformat.com/page-description-language/svg/) באמצעות שיטת **Image.load**.
1. קרא ל-**Image.save** תוך העברת אובייקט של **PngOptions** כפרמטר השני.

## דוגמת קוד

הקוד למטה מציג כיצד להשיג את אותו יעד באמצעות Aspose.CAD עבור JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
