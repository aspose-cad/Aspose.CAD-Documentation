---
title: صادرات نقشه و طرح‌های DWG/DXF به اندازه مشخص شده
type: docs
weight: 40
url: /fa/java/export-into-size/
---

## **صادرات مدل و همه طرح‌ها به اندازه PDF A4**

API Aspose.CAD به شما امکان می‌دهد که همه صفحات فایل DWG/DXF را به اندازه فیزیکی PDF مشخص شده صادرات کنید. 
کد نمونه زیر اندازه شی [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) را تنظیم می‌کند تا به اندازه PDF مورد نظر برسد. 
اندازه برگه کاغذ A4 برابر با 210x297 میلی‌متر یا 8.27x11.69 اینچ است و این مقادیر در کد استفاده می‌شوند.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **صادرات طرح‌های CAD به PDF با اندازه‌های مختلف**

گاهی اوقات لازم است که طرح را به اندازه فیزیکی خود صادرات کنید. مثال زیر صادرات نقشه را به PDF چند صفحه‌ای نشان می‌دهد که در آن هر صفحه با محتوای طرح دارای اندازه فیزیکی PDF خود است. این مثال از خصوصیت [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) استفاده می‌کند.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
