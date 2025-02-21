---
title: การวาด DRC
type: docs
weight: 15
url: /th/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **การส่งออกการวาด DRC เป็น PDF**

Aspose.CAD มีฟีเจอร์ในการโหลดรายการการวาด [DRC](https://docs.fileformat.com/3d/drc/) ของ AutoCAD และเรนเดอร์เป็นการวาดทั้งหมดในรูปแบบ [PDF](https://docs.fileformat.com/pdf/) วิธีการแปลง [DRC](https://docs.fileformat.com/3d/drc/) เป็น [PDF](https://docs.fileformat.com/pdf/) ทำงานตามขั้นตอนดังต่อไปนี้:

1. โหลดไฟล์การวาด [DRC](https://docs.fileformat.com/3d/drc/) โดยใช้วิธีการสร้างแฟกทอรี [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. สร้างออบเจ็กต์ของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าคุณสมบัติ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. สร้างออบเจ็กต์ของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. เรียก [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ในขณะที่ส่งออบเจ็กต์ของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง.

### โค้ดตัวอย่าง

โค้ดตัวอย่างด้านล่างแสดงวิธีการแปลงไฟล์โดยใช้การตั้งค่าเริ่มต้น.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
