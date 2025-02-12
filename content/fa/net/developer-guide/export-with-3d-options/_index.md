---
title: صادر کردن با گزینه‌های ۳ بعدی
type: docs
weight: 40
url: /fa/net/export-with-3d-options/
---

## **صادر کردن با گزینه‌های ۳ بعدی**

چند گزینه برای صادرات مدل‌های ۳ بعدی به PDF/رستر از فرمت‌های FBX، OBJ، STL معرفی شده است.

در اینجا مثال‌هایی از صحنه ۳ بعدی از زوایای مختلف آمده است:

![Figures](/fa/_assets/fig1.png)

![Figures from other points of view](/fa/_assets/fig2.png)

خاصیت ObserverPoint اجازه می‌دهد تا صحنه ۳ بعدی را بر اساس زوایای معین در اطراف محور بچرخانید. این مثال کد و نتیجه صادرات را با استفاده از چند زاویه چرخش دلخواه نشان می‌دهد.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Export with rotation](/fa/_assets/fig3.png)

تغییر ObserverAngle به ObserverPoint = new ObserverPoint(5, 60, 0) اجازه می‌دهد تا صحنه را بچرخانید.

![Export with changed rotation](/fa/_assets/fig4.png)

خاصیت دیگر RenderMode3D اجازه می‌دهد تا مشخص کنید که نتیجه صادرات چگونه باید نمایش داده شود. سه حالت وجود دارد: Solid (حالت پیش‌فرض)، Wireframe، و SolidWithEdges.

مثال زیر اجازه می‌دهد تا مدل وایرفریم برای شیء کره‌ای ایجاد کنید.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](/fa/_assets/fig5.png)

مثال زیر تفاوت بین حالت‌های Solid و SolidWithEdges را نشان می‌دهد.

![Solid mode](/fa/_assets/fig6.png)
![Solid with edge mode](/fa/_assets/fig7.png)
