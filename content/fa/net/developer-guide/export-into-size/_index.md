---
title: صادرات نقشه و طرح‌های DWG/DXF به اندازه مشخص
type: docs
weight: 40
url: /fa/net/developer-guide/export-into-size/
---

## **صادرات مدل و تمامی طرح‌ها به اندازه PDF A4**

API Aspose.CAD اجازه می‌دهد تا کلیه شیت‌های فایل DWG/DXF را به اندازه فیزیکی مشخص PDF صادر کنید.

کد نمونه زیر اندازه شیء [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) را برای دستیابی به اندازه دلخواه PDF تنظیم می‌کند.
اندازه کاغذ A4 برابر با 210x297 میلی‌متر یا 8.27x11.69 اینچ است و این مقادیر در کد استفاده می‌شوند.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **صادرات طرح‌های CAD به PDF با اندازه‌های مختلف**

گاهی اوقات لازم است تا طرح را به اندازه فیزیکی آن صادر کنید. نمونه زیر صادرات نقشه را به PDF چندصفحه‌ای نشان می‌دهد که در آن هر صفحه با محتوای طرح
دارای اندازه فیزیکی PDF خود است. این مثال از ویژگی [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/)
استفاده می‌کند.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
