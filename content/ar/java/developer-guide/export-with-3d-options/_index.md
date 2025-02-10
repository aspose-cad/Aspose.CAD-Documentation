---
title: تصدير مع خيارات ثلاثية الأبعاد
type: docs
weight: 40
url: /ar/java/export-with-3d-options/
---

## **تصدير مع خيارات ثلاثية الأبعاد**

تم إدخال بعض الخيارات لتصدير نماذج ثلاثية الأبعاد إلى PDF / صورة من تنسيقات FBX و OBJ و STL المناسبة.

إليك أمثلة عن المشهد ثلاثي الأبعاد من زوايا مختلفة:

![Figures](/_assets/fig1.png)

![Figures from other points of view](/_assets/fig2.png)

تسمح خاصية ObserverPoint بدوران المشهد ثلاثي الأبعاد وفقًا لزوايا محددة حول المحور. يظهر هذا المثال الكود ونتيجة التصدير باستخدام بعض زوايا الدوران التعسفية.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}


![Export with rotation](/_assets/fig3.png)

تغيير ObserverAngle إلى ObserverPoint = new ObserverPoint(5, 60, 0) يسمح بتدوير المشهد.

![Export with changed rotation](/_assets/fig4.png)

تسمح خاصية RenderMode3D الأخرى بتحديد كيفية تقديم نتيجة التصدير. هناك 3 أوضاع: صلبة (الافتراضي) ، إطار سلكي ، وصلبة مع حواف.

يسمح المثال أدناه بإنشاء نموذج إطار سلكي للكائن الكروي.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/_assets/fig5.png)

يوضح المثال أدناه الفرق بين وضعي Solid و SolidWithEdges.

![Solid mode](/_assets/fig6.png)
![Solid with edge mode](/_assets/fig7.png)
