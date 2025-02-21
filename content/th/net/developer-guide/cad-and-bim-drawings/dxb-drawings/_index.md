---
title: แผนผัง DXB
type: docs
weight: 70
url: /th/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **การส่งออกฟอร์แมต DXB เป็น PDF**

Aspose.CAD สำหรับ .NET ช่วยให้นักพัฒนาสามารถส่งออกไฟล์ DXB เป็นฟอร์แมต [PDF](https://docs.fileformat.com/pdf/) ได้ วิธีการแปลงจาก DXB เป็น [PDF](https://docs.fileformat.com/pdf/) มีรายละเอียดดังนี้:

1. โหลดไฟล์แผนผัง DXB โดยใช้วิธีการแฟคทอรี [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 
1. สร้างออบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าคุณสมบัติ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) และ [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth)
1. สร้างออบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)
1. เรียกใช้ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) โดยส่งออบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง

## ตัวอย่างโค้ด

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
