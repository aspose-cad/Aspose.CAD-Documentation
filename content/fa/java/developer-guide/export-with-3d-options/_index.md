---
title: صادرات با گزینه‌های 3D
type: docs
weight: 40
url: /fa/java/export-with-3d-options/
---

## **صادرات با گزینه‌های 3D**

چندین گزینه برای صادرات مدل‌های 3D به PDF/رستر از فرمت‌های مرتبط FBX، OBJ و STL معرفی شده‌اند.

در اینجا مثال‌هایی از صحنه 3D از نقاط دید مختلف آورده شده است:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

خصوصیت ObserverPoint اجازه می‌دهد تا صحنه 3D را طبق زوایای مشخص شده حول محور بچرخانیم. این مثال کد و نتیجه صادرات را با استفاده از برخی زوایای چرخش دلخواه نشان می‌دهد.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![صادرات با چرخش](/_assets/guide/3d/fig3.png)

تغییر دادن ObserverAngle به ObserverPoint = new ObserverPoint(5, 60, 0) اجازه می‌دهد تا صحنه را بچرخانیم.

![صادرات با چرخش تغییر یافته](/_assets/guide/3d/fig4.png)

خصوصیت RenderMode3D اجازه می‌دهد تا مشخص کنیم که نتیجه صادرات چگونه باید ارائه شود. سه حالت وجود دارد: Solid (حالت پیش‌فرض)، Wireframe و SolidWithEdges.

مثال زیر اجازه می‌دهد تا مدل Wireframe برای جسم کروی ایجاد شود.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![حالت Wireframe](/_assets/guide/3d/fig5.png)

مثال زیر تفاوت بین حالت‌های Solid و SolidWithEdges را نشان می‌دهد.

![حالت Solid](/_assets/guide/3d/fig6.png)
![حالت Solid با لبه](/_assets/guide/3d/fig7.png)
