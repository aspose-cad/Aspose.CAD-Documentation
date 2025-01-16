---
title: ضبط حجم رسم CAD
type: docs
weight: 10
url: /ar/net/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

من خلال استخدام مكتبة Aspose.CAD لـ .NET، يمكن للمطورين ضبط حجم رسم CAD أثناء التحويل إلى أي تنسيق مدعوم. توضح هذه الموضوع الطريقة لضبط الحجم تلقائيًا أو يدويًا باستخدام [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) التعداد في فئة [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **ضبط حجم رسم CAD**

توفر Aspose.CAD لـ .NET التعداد [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) لضبط حجم الرسم أثناء تحويل تنسيق CAD. هناك طريقتان لضبط حجم الرسم.

1. ضبط الحجم تلقائيًا.
1. ضبط الحجم باستخدام التعداد [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) لفئة [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

لضبط الحجم تلقائيًا، لا يحتاج المطورون إلى توفير خصائص العرض والارتفاع لفئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). الكود المقدم أدناه هو مثال على ضبط الحجم تلقائيًا.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

التعداد [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) يعطي القدرة على ضبط القياس عندما لا يتم تعيين خصائص العرض والارتفاع. الكود المقدم أدناه يوضح كيفية استخدام [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
