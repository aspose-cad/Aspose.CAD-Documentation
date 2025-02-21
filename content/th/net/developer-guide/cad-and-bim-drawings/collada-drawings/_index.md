---
title: การส่งออกภาพ COLLADA
type: docs
weight: 70
url: /th/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **การส่งออกรูปแบบ COLLADA เป็น PDF**

Aspose.CAD สำหรับ .NET ช่วยให้นักพัฒนาสามารถส่งออกไฟล์ [COLLADA](https://docs.fileformat.com/3d/dae/) เป็นรูปแบบ [PDF](https://docs.fileformat.com/pdf/) การแปลง [COLLADA](https://docs.fileformat.com/3d/dae/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานดังนี้:

1. โหลดไฟล์ภาพวาด [COLLADA](https://docs.fileformat.com/3d/dae/) โดยใช้วิธีโรงงาน [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 
1. สร้างวัตถุของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าคุณสมบัติ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 
1. สร้างวัตถุของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 
1. เรียก [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) โดยส่งผ่านวัตถุของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
