---
title: التصدير مع خيارات 3D
type: docs
weight: 40
url: /ar/net/export-with-3d-options/
---

## **التصدير مع خيارات 3D**

تم تقديم بعض الخيارات لتصدير نماذج 3D إلى PDF / صور نقطية من صيغة FBX و OBJ و STL المقابلة.

إليك أمثلة على مشهد 3D من زوايا مختلفة:

![Figures](fig1.png)

![Figures from other points of view](fig2.png)

تسمح خاصية ObserverPoint بتدوير المشهد 3D وفقًا للزوايا المحددة حول المحور. يظهر هذا المثال الكود ونتيجة التصدير باستخدام بعض زوايا الدوران التعسفية.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}


![Export with rotation](fig3.png)

تغيير ObserverAngle إلى ObserverPoint = new ObserverPoint(5, 60, 0) يسمح بتدوير المشهد.

![Export with changed rotation](fig4.png)

تسمح خاصية RenderMode3D الأخرى بتحديد كيفية تقديم نتيجة التصدير. هناك 3 أوضاع: Solid (الافتراضي) ، Wireframe ، و SolidWithEdges.

يسمح المثال أدناه بإنشاء نموذج سلكي للجسم الكروي.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](fig5.png)

يوضح المثال أدناه الفرق بين أوضاع Solid و SolidWithEdges.

![Solid mode](fig6.png)
![Solid with edge mode](fig7.png)
