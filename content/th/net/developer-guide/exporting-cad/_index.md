---
title: ส่งออก CAD
type: docs
weight: 40
url: /th/net/developer-guide/exporting-cad/
---

## **ส่งออกภาพ 3D AutoCAD ไปยัง PDF**

Aspose.CAD ช่วยให้คุณสามารถส่งออกภาพ 3D AutoCAD ไปยัง PDF ได้ กรุณาใช้ [**Aspose.CAD.ImageOptions.CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) เพื่อระบุว่าคุณต้องการส่งออกเอนทิตี 3D

โค้ดตัวอย่างด้านล่างโหลดไฟล์ AutoCAD 3D และส่งออกไปยัง [PDF](https://docs.fileformat.com/pdf/). เมื่ไฟล์ถูกแปลงเป็น PDF คุณสามารถเปิดไฟล์ด้วยโปรแกรมดู PDF ที่คุณชื่นชอบ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-Export3DImagestoPDF-Export3DImagestoPDF.cs" >}}

## **ส่งออกเลย์เอาต์ CAD ไปยัง PDF**

Aspose.CAD สำหรับ .NET ช่วยให้คุณสามารถส่งออกเลย์เอาต์ CAD ไปยัง PDF ได้ โดยใช้ [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) เมธอดของ [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) เพื่อส่งออกเลย์เอาต์ไปยังรูปแบบ [PDF](https://docs.fileformat.com/pdf/)

โค้ดตัวอย่างด้านล่างโหลดไฟล์ CAD และส่งออกเลย์เอาต์ "Model" ไปยัง PDF เมื่ไฟล์ถูกแปลงเป็น PDF คุณสามารถเปิดไฟล์ด้วยโปรแกรมดู PDF ที่คุณชื่นชอบ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-CADLayoutsToPDF-CADLayoutsToPDF.cs" >}}

## **การสนับสนุนการตั้งค่า Pen ในการส่งออก**

Aspose.CAD สำหรับ .NET ช่วยให้คุณสามารถเพิ่มตัวเลือกปากกาลงในคุณสมบัติการส่งออกของ CAD โดยใช้ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) เราสามารถตั้งค่าคุณสมบัติของปากกาได้

ด้านล่างนี้เป็นโค้ดตัวอย่างเพื่อให้บรรลุความต้องการที่ระบุ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-PenSupportInExport-PenSupportInExport.cs" >}}

## **การแยกวัตถุ CAD Insert**

Aspose.CAD สำหรับ .NET ช่วยให้คุณสามารถแยกวัตถุ CAD และประมวลผลเอนทิตีแยกต่างหากภายใน insert ด้านล่างนี้เป็นโค้ดตัวอย่างเพื่อให้บรรลุความต้องการที่ระบุ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-DecomposeCADInsertObject-DecomposeCADInsertObject.cs" >}}

## **การสนับสนุนสำหรับ ACAD Proxy Entities**

Aspose.CAD สำหรับ .NET ช่วยให้คุณสามารถอ่านและส่งออกเอนทิตี ACAD_PROXY_ENTITY ด้านล่างนี้เป็นโค้ดตัวอย่างเพื่อให้บรรลุความต้องการที่ระบุ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ACADProxyEntities-ACADProxyEntities.cs" >}}

## **รวมฟอร์แมต IGES**

Aspose.CAD สำหรับ .NET ช่วยให้คุณสามารถอ่านและส่งออกฟอร์แมต IGES ด้านล่างนี้เป็นโค้ดตัวอย่างเพื่อให้บรรลุความต้องการที่ระบุ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-IntegrateIGESFormat-IntegrateIGESFormat.cs" >}}

## **การสนับสนุนสำหรับโมเดล Mesh**

Aspose.CAD สำหรับ .NET ช่วยให้คุณสามารถ implement และนับโมเดล mesh เช่น edges, vertices, และ faces ที่ใช้การแสดงผลแบบพหุนาม ด้านล่างนี้เป็นโค้ดตัวอย่างเพื่อให้บรรลุความต้องการที่ระบุ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-MeshSupport-MeshSupport.cs" >}}

## **ตั้งค่ามุมมองเฉพาะ**

Aspose.CAD สำหรับ .NET ช่วยให้คุณสามารถตั้งค่ามุมมองเฉพาะสำหรับเลย์เอาต์โมเดล โดยใช้ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) คุณสามารถตั้งค่ามุมมองเฉพาะได้ โค้ดตัวอย่างด้านล่างแสดงวิธีการตั้งค่ามุมมองเฉพาะ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-FreePointOfView-FreePointOfView.cs" >}}
