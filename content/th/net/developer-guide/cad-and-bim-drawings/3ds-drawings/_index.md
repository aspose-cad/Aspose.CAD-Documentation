---
title: 3DS รูปวาด
type: docs
weight: 70
url: /th/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **การส่งออกฟอร์แมต 3DS เป็น PDF**

Aspose.CAD สำหรับ .NET ช่วยให้ผู้พัฒนาสามารถส่งออกไฟล์ [3DS](https://docs.fileformat.com/3d/3ds/) ไปยังฟอร์แมต [PDF](https://docs.fileformat.com/pdf/) ได้ วิธีการแปลง [3DS](https://docs.fileformat.com/3d/3ds/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังนี้:

1. โหลดไฟล์รูปวาด [3DS](https://docs.fileformat.com/3d/3ds/) โดยใช้วิธีการสร้างแฟคทอรี [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2)
1. สร้างวัตถุของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าคุณสมบัติ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth)
1. สร้างวัตถุของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)
1. เรียกใช้งาน [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ในขณะที่ส่งวัตถุของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
