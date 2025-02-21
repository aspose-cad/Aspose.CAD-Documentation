---
title: รูปวาด DWG
type: docs
weight: 40
url: /th/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **การส่งออก DWG ไปยัง PDF**

Aspose.CAD สำหรับ .NET API สามารถโหลดรูปวาด AutoCAD ในรูปแบบ [DWG](https://docs.fileformat.com/cad/dwg/) และแปลงให้เป็น [PDF](https://docs.fileformat.com/pdf/). หัวข้อนี้อธิบายการใช้งาน Aspose.CAD API เพื่อบรรลุการแปลง DWG เป็น PDF ผ่านขั้นตอนง่ายๆ ที่กำหนดไว้ด้านล่าง

{{% alert color="primary" %}}

API รองรับการปรับปรุง AutoCAD DWG ต่อไปนี้:

- DWG 2004  เวอร์ชัน 16.0 รุ่น 18
- DWG 2005 เวอร์ชัน  16.1
- DWG 2010 เวอร์ชัน 18.0
- DWG 2013 เวอร์ชัน 19.0

{{% /alert %}}

### **รูปแบบไฟล์ DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และข้อมูลเมตา ข้อมูลภาพเวกเตอร์ให้ข้อมูลแก่แอปพลิเคชัน CAD เกี่ยวกับวิธีการแสดง DWG; ข้อมูลเมตาอาจมีข้อมูลต่างๆ เกี่ยวกับไฟล์รวมถึงข้อมูลเฉพาะตำแหน่งและข้อมูลลูกค้า ข้อมูลจำเพาะเปิดสำหรับรูปแบบไฟล์ DWG สามารถพบได้ [ใน PDF นี้](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **แปลงไฟล์ DWG เป็น PDF**

ขั้นตอนง่ายๆ ต่อไปนี้ต้องใช้ในการแปลง [DWG](https://docs.fileformat.com/cad/dwg/) เป็น [PDF](https://docs.fileformat.com/pdf/).

1. โหลดไฟล์ DWG เข้าสู่ตัวอย่างของ [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. สร้างอ็อบเจ็ทของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่า [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) คุณสมบัติ
1. สร้างอ็อบเจ็ทของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่า [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) คุณสมบัติ
1. โทร [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) ในขณะที่ส่งอ็อบเจ็ทของ [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) เป็นพารามิเตอร์ที่สอง

ตัวอย่างโค้ดด้านล่างแสดงวิธีการส่งออก DWG รูปวาดไปยัง PDF

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **สร้าง PDF เดียวที่มีขนาดรูปแบบต่างกัน**

Aspose.CAD สำหรับ .NET อนุญาตให้คุณแปลงไฟล์ DWG เป็น PDF เดียวที่มีขนาดรูปแบบต่างกัน วิธีการนี้ทำงานดังนี้:

1. โหลดไฟล์ DWG โดยใช้วิธีแฟกตอรี [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. สร้างตัวอย่างของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าความสูงและความกว้างของหน้าผลลัพธ์
1. เพิ่ม [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) ที่จำเป็นสำหรับอ็อบเจ็ท [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)
1. สร้างตัวอย่างของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่า [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) คุณสมบัติ
1. ส่งออกภาพไปยัง PDF โดยใช้วิธี [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)

ตัวอย่างโค้ดด้านล่างแสดงวิธีสร้าง [PDF](https://docs.fileformat.com/pdf/) เดียวที่มีรูปแบบต่างๆ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **รูปทรง AutoCAD ที่รองรับ**

รูปทรง AutoCAD ต่อไปนี้ได้รับการสนับสนุน

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **ส่งออกเลย์เอาต์ DWG เฉพาะไปยัง PDF**

วิธีการนี้ทำงานดังนี้:

1. โหลดไฟล์ DWG โดยใช้วิธีแฟกตอรี [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 
1. สร้างตัวอย่างของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าความสูงและความกว้างของหน้าผลลัพธ์
1. ตั้งค่า [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) สำหรับอ็อบเจ็ท [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)
1. สร้างตัวอย่างของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่า [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) คุณสมบัติ
1. ส่งออกภาพไปยัง PDF โดยใช้วิธี [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงเลย์เอาต์เฉพาะของ DWG เป็น PDF

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **เรนเดอร์เอกสาร DWG โดยระบุพิกัด**

Aspose.CAD สำหรับ .NET API ตอนนี้มีฟีเจอร์ในการเรนเดอร์เอกสาร DWG โดยการระบุพิกัดของความกว้างและความสูงของเอกสาร

ตัวอย่างโค้ดด้านล่างแสดงวิธีการเรนเดอร์เอกสาร DWG

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **ส่งออก DWG ไปยัง Raster หรือ PDF โดยใช้ขนาดคงที่**

Aspose.CAD สำหรับ .NET API สามารถโหลดรูปวาด AutoCAD ในรูปแบบ DWG และแปลงเป็น PDF หรือ Raster โดยใช้ขนาดคงที่

ตัวอย่างโค้ดด้านล่างแสดงวิธีการใช้งานคุณสมบัตินี้

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **ส่งออก DWG ไปยัง PDF/A และ PDF/E**

วิธีการนี้ทำงานตามรายละเอียดดังนี้:

1. โหลดไฟล์ DWG โดยใช้วิธีแฟกตอรี [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 
1. สร้างอ็อบเจ็ทของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)
1. สร้างอ็อบเจ็ทของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่า [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) คุณสมบัติ
1. ตั้งค่าคุณสมบัติการปฏิบัติตาม PDF และบันทึก
1. ส่งออกภาพไปยัง PDF โดยใช้วิธี [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ DWG เป็น PDF/A และ PDF/E

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **สนับสนุนเส้นซ่อนที่ทำมุมรอบเมื่อส่งออก DWG/DXF ไปยัง BMP และ PDF**

วิธีการนี้ทำงานตามรายละเอียดดังนี้:

1. โหลดไฟล์ DWG โดยใช้วิธีแฟกตอรี [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 
1. สร้างอ็อบเจ็ทของคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) และตั้งค่าความสูงและความกว้างของหน้าผลลัพธ์
1. สร้างอ็อบเจ็ทของคลาส [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) และตั้งค่า [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) คุณสมบัติ
1. ส่งออกภาพไปยัง PDF โดยใช้วิธี [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)

ตัวอย่างโค้ดด้านล่างแสดงวิธีการใช้งานคุณสมบัตินี้

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **สนับสนุนการตั้งค่าพื้นที่พิมพ์สำหรับภาพ DWG ใน PDF ที่ส่งออก**

Aspose.CAD สำหรับ .NET API สามารถโหลดรูปวาด AutoCAD ในรูปแบบ DWG และแปลงเป็น PDF หัวข้อนี้อธิบายการใช้งาน Aspose.CAD API เพื่อบรรลุการสนับสนุนในการตั้งค่าพื้นที่พิมพ์สำหรับภาพ DWG ใน PDF ที่ส่งออก

ตัวอย่างโค้ดด้านล่างแสดงวิธีการใช้งานคุณสมบัตินี้

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **สนับสนุนการอ่านข้อมูลเมตา XREF สำหรับไฟล์ DWG**

1. โหลดไฟล์ DWG โดยใช้วิธีแฟกตอรี [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 
1. เดินทางผ่านทุกหน่วยภาพ
1. หากหน่วยเป็น CadUnderlay ให้ทำการสร้างหน่วย XREF ที่มีข้อมูลเมตา

ตัวอย่างโค้ดด้านล่างแสดงวิธีการใช้งานคุณสมบัตินี้

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

คุณสมบัติ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) เป็นอาร์เรย์ประเภทสตริง ดังนั้นคุณสามารถระบุรูปแบบมากกว่าหนึ่งแบบในครั้งเดียวสำหรับการแปลงเป็นรูปแบบ PDF ที่เป็นไปได้ ในขณะที่ระบุรูปแบบหลายรูปแบบสำหรับคุณสมบัติ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) PDF ที่ได้จะมีหลายหน้า โดยแต่ละหน้าจะแสดงเลย์เอาต์ AutoCAD เฉพาะ

### **รายการรูปแบบทั้งหมด**

คุณสามารถแสดงรายการรูปแบบทั้งหมดที่มีอยู่ในรูปวาด AutoCAD โดยใช้ตัวอย่างโค้ดด้านล่างนี้

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **การเข้าถึงธงแบบซ้อนทับสำหรับรูปแบบ DWG**

Aspose.CAD สำหรับ .NET ได้จัดทำธงแบบซ้อนทับสำหรับรูปแบบ DWG และอนุญาตให้นักพัฒนาสามารถเข้าถึงได้ โดยมีการสาธิตโค้ดง่ายๆ ดังนี้

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **สนับสนุนสำหรับหน่วย DWG**

Aspose.CAD สำหรับ .NET API สามารถโหลดรูปวาด AutoCAD ในรูปแบบ DWG และรองรับหน่วยต่างๆ สำหรับการทำงานด้วย

### **การสนับสนุนสำหรับหน่วย MLeader**

DWG เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และข้อมูลเมตา มีหน่วยที่แตกต่างกันในไฟล์ DWG ส่วนถัดไปอธิบายถึงตัวอย่างการทำงานกับหน่วย MLeader ภายในไฟล์ DWG

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **การสนับสนุนการส่งออกหน่วย DWG เป็นภาพ**

DWG เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และข้อมูลเมตา มีหน่วยที่แตกต่างกันในไฟล์ DWG ส่วนถัดไปอธิบายถึงตัวอย่างการส่งออกหน่วย DWG เฉพาะไปยังภาพ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **การสนับสนุนการเพิ่มข้อความใน DWG**

Aspose.CAD สำหรับ .NET API สามารถโหลดรูปวาด AutoCAD ในรูปแบบ DWG และรองรับหน่วยต่างๆ สำหรับการทำงานด้วย DWG เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และข้อมูลเมตา มีหน่วยที่แตกต่างกันในไฟล์ DWG ส่วนถัดไปอธิบายถึงวิธีการเพิ่มข้อความภายในไฟล์ DWG

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **การสนับสนุนการนำเข้ารูปภาพในไฟล์ DWG**

Aspose.CAD สำหรับ .NET API สามารถโหลดรูปวาด AutoCAD ในรูปแบบ DWG และรองรับหน่วยต่างๆ สำหรับการทำงานด้วย DWG เป็นไฟล์ไบนารีที่มีข้อมูลภาพเวกเตอร์และข้อมูลเมตา มีหน่วยที่แตกต่างกันในไฟล์ DWG ส่วนถัดไปอธิบายถึงวิธีการนำเข้าไฟล์รูปภาพภายในไฟล์ DWG

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **การสนับสนุนสำหรับ Mesh ใน DWG**

Aspose.CAD สำหรับ .NET API สามารถเข้าถึงหน่วยที่สนับสนุน mesh ซึ่งรวมถึง [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) และ [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) ประเภท ตัวอย่างต่อไปนี้อธิบายถึงวิธีการเข้าถึงประเภท mesh

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **แปลง DWG รูปวาดเป็น DXF**

Aspose.CAD ให้ฟีเจอร์ในการโหลดไฟล์ DWG ของ AutoCAD และส่งออกเป็นรูปแบบ DXF วิธีการแปลงจาก DWG เป็น DXF ทำงานดังนี้:

1. โหลดไฟล์รูปวาด DWG โดยใช้วิธี [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) 
1. ส่งออกรูปวาด DWG เป็น DXF โดยใช้วิธี [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ DWG เป็นรูปแบบ DXF

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **แปลง DWG รูปวาดเป็น SVG**

Aspose.CAD สำหรับ .NET API สามารถโหลดรูปวาด AutoCAD ในรูปแบบ DWG และแปลงให้เป็น SVG หัวข้อนี้อธิบายการใช้งาน Aspose.CAD API เพื่อบรรลุการแปลง DWG เป็นรูปแบบ SVG ผ่านขั้นตอนง่ายๆ ดังนี้

1. โหลดไฟล์ DWG เข้าสู่ตัวอย่างของ [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. สร้างอ็อบเจ็ทของคลาส [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) และตั้งค่าคุณสมบัติที่จำเป็น
1. ส่งออกรูปวาด DWG เป็น SVG โดยใช้วิธี [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)

ตัวอย่างโค้ดด้านล่างแสดงวิธีการแปลงไฟล์ DWG เป็น SVG

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **โหลดไฟล์ DWG ขนาดใหญ่**

Aspose.CAD สำหรับ .NET มีฟีเจอร์ในการเปิดไฟล์ DWG ขนาดใหญ่มากโดยใช้คลาส [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) ตอนนี้คุณสามารถเปิดไฟล์ขนาดใหญ่ได้อย่างง่ายดายด้วยความช่วยเหลือของตัวอย่างโค้ดที่ให้ไว้ด้านล่าง

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
