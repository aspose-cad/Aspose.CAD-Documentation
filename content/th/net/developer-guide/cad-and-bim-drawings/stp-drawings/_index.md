---
title: แบบภาพ STP
type: docs
weight: 70
url: /th/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **การส่งออกฟอร์แมต STP เป็น PDF**

Aspose.CAD สำหรับ .NET ช่วยให้นักพัฒนาสามารถส่งออกไฟล์ [STP](https://docs.fileformat.com/3d/stp/) เป็นฟอร์แมต [PDF](https://docs.fileformat.com/pdf/) วิธีการแปลง [STP](https://docs.fileformat.com/3d/stp/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังต่อไปนี้:

1. โหลดไฟล์ภาพวาด [STP](https://docs.fileformat.com/3d/stp/) โดยใช้เมธอดโรงงาน [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. สร้างอ็อบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าคุณสมบัติ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. สร้างอ็อบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. เรียกใช้ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ขณะที่ส่งอ็อบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง.

## Sample Code

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
