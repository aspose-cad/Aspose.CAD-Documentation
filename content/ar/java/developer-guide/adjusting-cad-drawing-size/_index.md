---
title: تعديل حجم رسم CAD
type: docs
weight: 10
url: /ar/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

باستخدام Aspose.CAD لجافا، يمكن للمطورين ضبط حجم الرسم أثناء تحويل صيغة CAD. تشرح هذه الموضوع الطريقة التي يقوم من خلالها بتعديل الحجم تلقائيًا أو ضبط الحجم باستخدام التعداد [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) من فئة [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **تعديل حجم رسم CAD**

توفر Aspose.CAD لجافا تعداد [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) لضبط حجم الرسم أثناء تحويل صيغة CAD. هناك طريقتان لتعديل حجم الرسم.

1. تعديل الحجم تلقائيًا
1. تعديل الحجم باستخدام تعداد [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) من فئة [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

لتعديل الحجم تلقائيًا، لا يحتاج المطورون إلى تقديم خصائص العرض والارتفاع من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). الكود المقدم أدناه هو مثال على تعديل الحجم تلقائيًا.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

يوفر تعداد [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) القدرة على تعديل مقياس عندما لا يتم تعيين خصائص العرض والارتفاع. يوضح الكود المقدم أدناه كيفية استخدام [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
