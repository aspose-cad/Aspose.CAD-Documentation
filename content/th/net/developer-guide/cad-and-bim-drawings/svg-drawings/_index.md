---
title: การวาด SVG
type: docs
weight: 70
url: /th/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **การส่งออกฟอร์แมต SVG เป็น PDF**

Aspose.CAD สำหรับ .NET ช่วยให้นักพัฒนาสามารถส่งออกไฟล์ SVG เป็นฟอร์แมต [PDF](https://docs.fileformat.com/pdf/) วิธีการแปลงจาก SVG เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังนี้:

1. โหลดไฟล์วาด SVG โดยใช้วิธีการโรงงาน [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และกำหนดคุณสมบัติ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. สร้างอ็อบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และกำหนดคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. เรียกใช้ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) โดยส่งอ็อบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง.

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
