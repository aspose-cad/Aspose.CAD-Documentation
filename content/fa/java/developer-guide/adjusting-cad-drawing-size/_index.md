---
title: تنظیم اندازه نقشه CAD
type: docs
weight: 10
url: /fa/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

با استفاده از Aspose.CAD برای Java، توسعه‌دهندگان می‌توانند اندازه نقشه را در حین تبدیل فرمت CAD تنظیم کنند. این موضوع رویکرد تنظیم خودکار یا تنظیم اندازه را با استفاده از [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumerations کلاس [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) توضیح می‌دهد.

{{% /alert %}}

## **تنظیم اندازه نقشه CAD**

Aspose.CAD برای Java enumeration [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) را برای تنظیم اندازه نقشه در حین تبدیل فرمت CAD ارائه می‌دهد. دو روش برای تنظیم اندازه نقشه وجود دارد.

1. تنظیم اندازه خودکار
1. تنظیم اندازه با استفاده از enumeration [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) کلاس [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

برای تنظیم خودکار اندازه، توسعه‌دهندگان نیازی به ارائه ویژگی‌های عرض و ارتفاع کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ندارند. کد نمونه‌ای که در زیر ارائه شده است، مثالی از اندازه‌گیری خودکار است.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

enumeration [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) این امکان را می‌دهد که هنگام عدم تنظیم ویژگی‌های عرض و ارتفاع، مقیاس‌بندی را تنظیم کنید. کد نمونه‌ای که در زیر ارائه شده است، نشان می‌دهد که چگونه می‌توان از [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) استفاده کرد.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
