---
title: تنظیم اندازه نقشه CAD
type: docs
weight: 10
url: /fa/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

با استفاده از کتابخانه Aspose.CAD برای .NET، توسعه‌دهندگان می‌توانند اندازه نقشه CAD را در هنگام تبدیل به هر فرمتی که پشتیبانی می‌شود، تنظیم کنند. این موضوع رویکرد تنظیم اندازه به صورت خودکار یا دستی با استفاده از [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) انیم از کلاس [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) را توضیح می‌دهد.

{{% /alert %}}

## **تنظیم اندازه نقشه CAD**

Aspose.CAD برای .NET انمیشن [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) را برای تنظیم اندازه نقشه در حین تبدیل فرمت CAD ارائه می‌دهد. دو روش برای تنظیم اندازه نقشه وجود دارد.

1. تنظیم اندازه به‌صورت خودکار.
2. تنظیم اندازه با استفاده از انیمیشن [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) از کلاس [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)

برای تنظیم خودکار اندازه، توسعه‌دهندگان نیازی به ارائه ویژگی‌های عرض و ارتفاع کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) ندارند. کد نمونه زیر مثال تنظیم اندازه به‌صورت خودکار است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

انیمیشن [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) قابلیت تنظیم مقیاس را زمانی که ویژگی‌های عرض و ارتفاع تنظیم نشده‌اند، فراهم می‌کند. کد نمونه زیر نشان می‌دهد که چگونه از [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) استفاده کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
