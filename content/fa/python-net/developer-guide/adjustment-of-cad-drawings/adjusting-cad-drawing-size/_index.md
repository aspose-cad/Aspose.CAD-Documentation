---
title: تنظیم اندازه نقشه CAD
type: docs
weight: 10
url: /fa/python-net/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

با استفاده از کتابخانه Aspose.CAD برای Python، توسعه‌دهندگان می‌توانند اندازه نقشه CAD را در حین تبدیل به هر فرمت پشتیبانی شده تنظیم کنند. این موضوع روش تنظیم اندازه به‌طور خودکار یا دستی با استفاده از enumerated **UnitType** کلاس **ImageOptions** را توضیح می‌دهد.

{{% /alert %}}

## **تنظیم اندازه نقشه CAD**

Aspose.CAD برای Python enumeration **UnitType** را برای تنظیم اندازه نقشه در حین تبدیل فرمت CAD فراهم می‌کند. دو راه برای تنظیم اندازه نقشه وجود دارد.

1. تنظیم اندازه به‌طور خودکار.
1. تنظیم اندازه با استفاده از enumeration **UnitType** کلاس **ImageOptions**

برای تنظیم اندازه به‌طور خودکار، توسعه‌دهندگان نیاز نیست که ویژگی‌های عرض و ارتفاع کلاس **CadRasterizationOptions** را فراهم کنند. کد نمونه زیر مثالی از اندازه‌گیری خودکار است.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

enumeration **UnitType** امکان تنظیم مقیاس‌گذاری را زمانی که ویژگی‌های عرض و ارتفاع تنظیم نشده‌اند، فراهم می‌آورد. کد نمونه زیر نشان می‌دهد که چگونه از **UnitType** استفاده کنید.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
