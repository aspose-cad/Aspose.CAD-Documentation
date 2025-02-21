---
title: แบบวาด FBX
type: docs
weight: 70
url: /th/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **การส่งออกไฟล์ FBX เป็น PDF**

Aspose.CAD สำหรับ .NET ช่วยให้นักพัฒนาสามารถส่งออกไฟล์ [FBX](https://docs.fileformat.com/3d/fbx/) เป็นรูปแบบ [PDF](https://docs.fileformat.com/pdf/) ได้ วิธีการแปลง [FBX](https://docs.fileformat.com/3d/fbx/) เป็น [PDF](https://docs.fileformat.com/pdf/) มีดังนี้:

1. โหลดไฟล์แบบวาด [FBX](https://docs.fileformat.com/3d/fbx/) โดยใช้วิธีการสร้าง [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. สร้างวัตถุของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าคุณสมบัติ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. สร้างวัตถุของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. เรียก [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) โดยส่งวัตถุของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง.

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
