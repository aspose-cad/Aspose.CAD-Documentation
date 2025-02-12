---
title: العمل مع تنسيق ملف OBJ
type: docs
weight: 120
url: /ar/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

يدعم Aspose.CAD الآن تنسيق ملف OBJ. تنسيق ملف OBJ هو هندسة ثلاثية الأبعاد تحتوي على خرائط قوام، و إحداثيات ثلاثية الأبعاد، وأوجه متعددة الأضلاع، ومعلومات أخرى عن الكائنات.

{{% /alert %}}

## **تصدير تنسيق OBJ إلى PNG**

يسمح Aspose.CAD لجافا سكريبت في Angular للمطورين بتصدير ملف [OBJ](https://docs.fileformat.com/3d/obj/) إلى تنسيق [PNG](https://docs.fileformat.com/image/png/).
تعمل طريقة تحويل [OBJ](https://docs.fileformat.com/3d/obj/) إلى [PNG](https://docs.fileformat.com/image/png/) كما يلي:

1. تحميل ملف الرسم [OBJ](https://docs.fileformat.com/3d/obj/) باستخدام طريقة **Image.load**.
1. استدعاء **Image.save** مع تمرير كائن **PngOptions** كمعامل ثانٍ.

## كود العينة

يوضح الكود أدناه كيفية تحقيق نفس الهدف باستخدام Aspose.CAD لجافا سكريبت.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
