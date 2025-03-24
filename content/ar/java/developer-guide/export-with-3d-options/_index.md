---
title: تصدير مع خيارات ثلاثية الأبعاد
type: docs
weight: 40
url: /ar/java/developer-guide/export-with-3d-options/
---

## **تصدير مع خيارات ثلاثية الأبعاد**

تم إدخال بعض الخيارات لتصدير نماذج ثلاثية الأبعاد إلى PDF / صورة من تنسيقات FBX و OBJ و STL المناسبة.

إليك أمثلة عن المشهد ثلاثي الأبعاد من زوايا مختلفة:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

تسمح خاصية ObserverPoint بدوران المشهد ثلاثي الأبعاد وفقًا لزوايا محددة حول المحور. يظهر هذا المثال الكود ونتيجة التصدير باستخدام بعض زوايا الدوران التعسفية.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}


![Export with rotation](/cad/_assets/guide/3d/fig3.png)

تغيير ObserverAngle إلى ObserverPoint = new ObserverPoint(5, 60, 0) يسمح بتدوير المشهد.

![Export with changed rotation](/cad/_assets/guide/3d/fig4.png)

تسمح خاصية RenderMode3D الأخرى بتحديد كيفية تقديم نتيجة التصدير. هناك 3 أوضاع: صلبة (الافتراضي) ، إطار سلكي ، وصلبة مع حواف.

يسمح المثال أدناه بإنشاء نموذج إطار سلكي للكائن الكروي.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/cad/_assets/guide/3d/fig5.png)

يوضح المثال أدناه الفرق بين وضعي Solid و SolidWithEdges.

![Solid mode](/cad/_assets/guide/3d/fig6.png)
![Solid with edge mode](/cad/_assets/guide/3d/fig7.png)
