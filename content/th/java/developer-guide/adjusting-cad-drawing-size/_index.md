---
title: ปรับขนาดการวาด CAD
type: docs
weight: 10
url: /th/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

การใช้ Aspose.CAD สำหรับ Java นักพัฒนาสามารถปรับขนาดการวาดในระหว่างการแปลงรูปแบบ CAD หัวข้อนี้อธิบายวิธีการปรับขนาดอัตโนมัติหรือปรับขนาดโดยใช้ [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enum ของคลาส [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

{{% /alert %}}

## **การปรับขนาดการวาด CAD**

Aspose.CAD สำหรับ Java มีการระบุ [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) เพื่อปรับขนาดการวาดในระหว่างการแปลงรูปแบบ CAD โดยมีสองวิธีในการปรับขนาดการวาด

1. ปรับขนาดอัตโนมัติ
1. ปรับขนาดโดยใช้การระบุ [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) ของคลาส [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

ในการปรับขนาดอัตโนมัติ นักพัฒนาจะไม่ต้องระบุคุณสมบัติ Width และ Height ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ข้างล่างนี้เป็นตัวอย่างของการปรับขนาดอัตโนมัติ

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

การระบุ [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) ช่วยให้สามารถปรับขนาดได้เมื่อคุณสมบัติ Width และ Height ไม่ถูกตั้งค่า ข้างล่างนี้เป็นตัวอย่างของการใช้ [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType)

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
