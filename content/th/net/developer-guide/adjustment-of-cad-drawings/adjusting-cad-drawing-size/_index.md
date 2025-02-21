---
title: ปรับขนาดการวาด CAD
type: docs
weight: 10
url: /th/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

โดยการใช้ไลบรารี Aspose.CAD สำหรับ .NET นักพัฒนาสามารถปรับขนาดการวาด CAD ระหว่างการแปลงเป็นรูปแบบที่สนับสนุนใด ๆ หัวข้อนี้อธิบายวิธีการปรับขนาดโดยอัตโนมัติหรือด้วยตนเองโดยใช้ [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enum ของ [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) class

{{% /alert %}}

## **ปรับขนาดการวาด CAD**

Aspose.CAD สำหรับ .NET มีการจัดการโดยใช้ [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeration เพื่อปรับขนาดการวาดในระหว่างการแปลงรูปแบบ CAD มีสองวิธีในการปรับขนาดการวาด

1. ปรับขนาดโดยอัตโนมัติ
2. ปรับขนาดโดยใช้ [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeration ของ [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) class

ในการปรับขนาดโดยอัตโนมัติ นักพัฒนาจะไม่ต้องกำหนดคุณสมบัติ Width และ Height ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) class ตัวอย่างด้านล่างคือโค้ดซSnippet ของการปรับขนาดอัตโนมัติ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeration ให้ความสามารถในการปรับขนาดเมื่อคุณสมบัติ Width และ Height ไม่ถูกตั้งค่า ตัวอย่างโค้ดด้านล่างแสดงวิธีการใช้ [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
