---
title: แปลง DWG DXF เป็น PDF C# | แปลงไฟล์ Auto CAD เป็น PDF JPEG PNG ใน C# .NET
type: docs
weight: 30
url: /th/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG เป็น PDF C#, DXF เป็น PDF C#, DWF DWT เป็น PDF C#, แปลง AutoCAD, แปลง DWG, แปลง DWF, แปลง DWT, แปลง DXF, แปลง autocad เป็น pdf, แปลง DWG เป็น PDF, แปลง DWG เป็น PNG, แปลง DWG เป็น TIFF, แปลง DWG เป็น JPG"
description: ใช้ C# .NET AutoCAD เพื่อแปลงเป็น PDF เป็นไฟล์ DWG หรือ DXF ใน C# คุณสามารถแปลง DWG, DWF, DWT และ DXF เป็น PDF, JPEG, PNG, BMP, GIF และ TIFF ใน C# .NET ได้เช่นกัน
---

## **แปลง DWG หรือ DXF เป็น PNG JPEG BMP GIF หรือ TIFF ใน C#**

Aspose.CAD สำหรับ .NET สามารถแปลงรูปแบบการวาด AutoCAD เช่น [DXF](https://docs.fileformat.com/cad/dxf/) และ [DWG](https://docs.fileformat.com/cad/dwg/) เป็น [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) และ [GIF](https://docs.fileformat.com/image/gif/) ได้ มันมี API ที่มีประสิทธิภาพและใช้งานง่ายเพื่อบรรลุเป้าหมายนี้

คุณสามารถแปลงรูปแบบการวาด AutoCAD ที่รองรับทั้งหมดเป็นรูปแบบภาพเรเซอร์ด้วยขั้นตอนง่ายๆ ตามที่ได้กล่าวไว้ด้านล่างนี้

1. โหลดไฟล์ AutoCAD DWG หรือ DXF ลงในคลาส [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. สร้างอินสแตนซ์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. ตั้ง/เปลี่ยนขนาดของภาพโดยใช้ [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) และ [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. สร้างอินสแตนซ์ของ [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. ตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) เป็น [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ที่สร้างในขั้นตอนก่อนหน้า
1. บันทึกการวาด AutoCAD เป็น PDF ด้วย [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) โดยการส่งเส้นทางไฟล์ (หรือวัตถุ MemoryStream) รวมถึงอินสแตนซ์ของ [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) ที่สร้างในขั้นตอนก่อนหน้า

นี่คือโค้ดต้นฉบับทั้งหมด

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

โดยค่าเริ่มต้น, API จะแสดงเฉพาะเลย์เอาต์ "Model" อย่างไรก็ตามคุณสามารถระบุเลย์เอาต์ที่คุณเลือกขณะแปลงการวาด CAD เป็นรูปแบบภาพ

## **ปรับแต่งการแปลง CAD**

ขั้นตอนการแปลง CAD เป็น [PDF](https://docs.fileformat.com/pdf/) & การแปลง CAD เป็นรูปภาพเรเซอร์นั้นสามารถปรับแต่งได้อย่างมาก เนื่องจากคลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ถูกนำไปใช้อย่างสามารถปรับแต่งได้มากมาย ซึ่งเมื่อมีการตั้งค่าก็สามารถควบคุมกระบวนการเรนเดอร์ตามความต้องการของแอปพลิเคชันได้

### **คลาส CadRasterizationOptions**

คลาส **CadRasterizationOptions** เป็นมาตรฐานสำหรับรูปแบบ CAD ที่รองรับทั้งหมด เช่น DWG & DXF ดังนั้น ข้อมูลที่แบ่งปันในบทความนี้จึงถูกต้องสำหรับรูปแบบ CAD ทั้งสองประเภทข้างต้น

คุณสมบัติของคลาส **CadRasterizationOptions** ที่มีประโยชน์คือ:

|**Property**|**Default Value**|**Required**|**Description**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|ใช่|ระบุความกว้างของหน้า|
|**PageHeight**|**0**|ใช่|ระบุความสูงของหน้า|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|ไม่|ระบุว่าการวาดควรถูกปรับขนาดโดยอัตโนมัติหรือไม่ ค่าเริ่มต้นจะย่อภาพให้อยู่ในขนาดผืนผ้าใบ สลับไปที่โหมด **GrowToFit** หรือใช้การตั้งค่า **None** เพื่อปิดการปรับขนาดอัตโนมัติ|
|**BackgroundColor**|**Color.White**|ไม่|ระบุสีพื้นหลังของภาพที่ส่งออก|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|ไม่|ระบุโหมดการระบายสีของเอนทิตี ระบุตัวเลือก **UseObjectColor** เพื่อวาดเอนทิตีโดยใช้สีของมัน หรือใช้ตัวเลือก **UseDrawColor** เพื่อเขียนทับสีดั้งเดิม|
|**DrawColor**|**Color.Black**|ไม่|ระบุสีที่ถูกเขียนทับของเอนทิตี (เฉพาะเมื่อ **DrawType** ถูกตั้งค่าเป็นค่าของตัวแปร **UseDrawColor**)|
|**AutomaticLayoutsScaling**|False|ไม่|ระบุว่าต้องทำการปรับขนาดเลย์เอาต์อัตโนมัติให้ตรงกับเลย์เอาต์โมเดลหรือไม่|

### **การตั้งค่าขนาดและโหมดผืนผ้าใบ**

การส่งออกจาก CAD ไปยัง PDF หรือรูปภาพเรเซอร์เป็นงานที่ไม่ธรรมดา เนื่องจาก PDF หรือภาพที่ได้จะต้องกำหนดขนาดผืนผ้าใบ เราจึงต้องระบุมิติของหน้าสำหรับ PDF เพื่อให้การวาดแสดงผลอย่างถูกต้อง ตั้งค่าคุณสมบัติ **CadRasterizationOptions.PageWidth** และ **CadRasterizationOptions.PageHeight** อย่างชัดเจน หรือคุณอาจพบ **ImageSaveException**

นอกจากนี้คุณยังสามารถกำหนดตัวเลือกการปรับขนาดมิติได้ ตัวเลือกการปรับขนาดถูกตั้งค่าด้วยคุณสมบัติ **CadRasterizationOptions.ScaleMethod** ใช้ตัวเลือกนี้เพื่อปรับขนาดของภาพตามค่าของ **CadRasterizationOptions.PageWidth** และ **CadRasterizationOptions.PageHeight** โดยค่าเริ่มต้น **CadRasterizationOptions.ScaleMethod** จะตั้งค่าเป็นโหมด **ScaleType.ShrinkToFit** คุณสมบัตินี้จะกำหนดพฤติกรรมดังต่อไปนี้:

- หากขนาดการวาด CAD ใหญ่กว่าขนาดผืนผ้าใบผลลัพธ์ ขนาดการวาดจะถูกลดขนาดเพื่อลงในผืนผ้าใบโดยรักษาสัดส่วน
- หากขนาดการวาด CAD เล็กกว่าขนาดผืนผ้าใบผลลัพธ์ ให้ตั้งค่าคุณสมบัติ **CadRasterizationOptions.ScaleMethod** เป็น **ScaleType.GrowToFit** เพื่อเพิ่มขนาดการวาดให้พอดีกับผืนผ้าใบ PDF โดยรักษาสัดส่วน
- หรือปิดการปรับขนาดอัตโนมัติด้วยตัวเลือก **ScaleType.None**

โค้ดตัวอย่างด้านล่างแสดงการใช้ตัวเลือกการปรับขนาดอัตโนมัติ

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **การตั้งค่าพื้นหลังและสีการวาด**

โดยค่าเริ่มต้น แผนภูมิสีสำหรับผืนผ้าใบผลลัพธ์จะตั้งค่าเป็นแผนผังเอกสารทั่วไป ซึ่งหมายความว่าทุกเอนทิตีภายในการวาด CAD จะถูกวาดด้วยปากกาสีดำบนพื้นหลังสีขาวแข็ง สถานะเหล่านี้สามารถเปลี่ยนแปลงได้ด้วยคุณสมบัติ **CadRasterizationOptions.BackgroundColor** และ **CadRasterizationOptions.DrawColor** การเปลี่ยนคุณสมบัติ **CadRasterizationOptions.DrawColor** ยังต้องมีการตั้งค่าคุณสมบัติ **CadRasterizationOptions.DrawType** เพื่อใช้สีการวาดที่ใช้ คุณสมบัติ **CadRasterizationOptions.DrawType** กำหนดว่าเอนทิตี CAD จะรักษาสีของมันหรือถูกแปลงเป็นสีที่กำหนดเอง เพื่อรักษาสีของเอนทิตี ให้ตั้งค่าคุณสมบัติ **CadRasterizationOptions.DrawType** เป็น **CadDrawTypeMode.UseObjectColor** มิฉะนั้นให้ระบุค่า **CadDrawTypeMode.UseDrawColor**

โค้ดตัวอย่างด้านล่างแสดงวิธีการใช้คุณสมบัติสีที่แตกต่างกัน

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **การตั้งค่าการปรับขนาดเลย์เอาต์อัตโนมัติ**

การวาด CAD ส่วนใหญ่มีเลย์เอาต์มากกว่าหนึ่งชุดที่เก็บไว้ในไฟล์เดียว และแต่ละเลย์เอาต์อาจมีขนาดที่แตกต่างกัน ในขณะที่เรนเดอร์การวาด CAD เหล่านั้นเป็น PDF แต่ละหน้าของ PDF อาจมีการปรับขนาดที่แตกต่างกันตามขนาดเลย์เอาต์ เพื่อให้การเรนเดอร์มีความเป็นเอกลักษณ์ API ของ Aspose.CAD ได้เปิดเผยคุณสมบัติ **CadRasterizationOptions.AutomaticLayoutsScaling** ค่าเริ่มต้นคือ **false** แต่เมื่อเป็นจริง API จะพยายามค้นหาอัตราส่วนที่สอดคล้องกันสำหรับแต่ละเลย์เอาต์แยกต่างหากและวาดพวกเขาอย่างเหมาะสมด้วยการทำการปรับขนาดอัตโนมัติตามขนาดหน้า

นี่คือวิธีการทำงานของคุณสมบัติ **CadRasterizationOptions.AutomaticLayoutsScaling** ร่วมกับคุณสมบัติ **CadRasterizationOptions.ScaleMethod**

1. ถ้าหาก **ScaleMethod** ถูกตั้งค่าเป็น **ScaleType.ShrinkToFit** หรือ **ScaleType.GrowToFit** พร้อมการตั้งค่าของ **AutomaticLayoutsScaling** เป็น false แล้วทุกเลย์เอาต์ (รวมถึงโมเดล) จะถูกประมวลผลตามตัวเลือกแรก
1. ถ้าหาก **ScaleMethod** ถูกตั้งค่าเป็น **ScaleType.ShrinkToFit** หรือ **ScaleType.GrowToFit** พร้อมการตั้งค่าของ **AutomaticLayoutsScaling** เป็น true แล้วทุกเลย์เอาต์ (ยกเว้นโมเดล) จะถูกประมวลผลตามขนาดขณะที่โมเดลจะถูกประมวลผลตามตัวเลือกแรก
1. ถ้าหาก **ScaleMethod** ถูกตั้งค่าเป็น **ScaleType.None** พร้อมการตั้งค่าของ **AutomaticLayoutsScaling** เป็น true หรือ false จะไม่มีการปรับขนาดเกิดขึ้น

โค้ดตัวอย่างด้านล่างแสดงวิธีการตั้งค่าการปรับขนาดเลย์เอาต์อัตโนมัติสำหรับการแปลง CAD เป็น PDF

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **แปลงเลย์เอาต์ AutoCAD DXF หรือ DWG เป็น PNG หรือรูปภาพอื่นใน C#**

Aspose.CAD สำหรับ .NET API สามารถแปลงเลย์เอาต์ CAD ของรูปแบบที่รองรับ เช่น DXF และ DWG เป็น PNG BMP TIFF JPEG และ GIF API ยังให้การสนับสนุนในการเรนเดอร์เลย์เอาต์เฉพาะของการวาด CAD ลงในเลเยอร์ PSD ที่แตกต่างกัน

นี่คือวิธีการที่คุณสามารถบรรลุสิ่งเดียวกันนี้ในขั้นตอนที่ง่ายดายดังต่อไปนี้

- โหลดไฟล์ AutoCAD DWG หรือ DXF โดยใช้คลาส **Image** 
- ตั้ง/เปลี่ยนความกว้างและความสูงของภาพ
- ตั้งชื่อเลย์เอาต์ที่ต้องการโดยใช้คุณสมบัติ CadRasterizationOptions.Layouts
- สร้างอินสแตนซ์ของ **ImageOptionsBase** และตั้งค่าคุณสมบัติ **VectorRasterizationOptions** เป็นอินสแตนซ์ของ **CadRasterizationOptions** ที่สร้างในขั้นตอนก่อนหน้า
- บันทึกเลย์เอาต์ CAD เป็น TIFF หรือรูปภาพ

นี่คือโค้ดต้นฉบับทั้งหมด

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

คุณสมบัติ **CadRasterizationOptions.Layouts** เป็นชนิดอาเรย์สตริง ดังนั้นคุณสามารถระบุเลย์เอาต์ได้มากกว่าหนึ่งเลย์เอาต์ในครั้งเดียวสำหรับการแปลงเป็นรูปแบบภาพที่เป็นไปได้ ขณะที่ระบุเลย์เอาต์หลายตัวสำหรับคุณสมบัติ **CadRasterizationOptions.Layouts** รูปภาพ TIFF ที่มีผลลัพธ์จะมีหลายหน้า รูปภาพ GIF จะมีหลายเฟรม และรูปแบบ [PSD](https://docs.fileformat.com/image/psd/) จะมีหลายเลเยอร์ โดยแต่ละหน้า/เฟรม/เลเยอร์แสดงถึงเลย์เอาต์ AutoCAD แบบแยกต่างหาก ในกรณีที่เลือกโหมดรูปภาพอื่น ๆ เช่น PNG, BMP, JPEG เพื่อจัดเก็บผลลัพธ์แล้ว API จะเรนเดอร์เฉพาะเลย์เอาต์เริ่มต้นเท่านั้น นั่นคือ "Model"

{{% /alert %}}

## **เปิดใช้งานการติดตามกระบวนการเรนเดอร์ CAD**

Aspose.CAD ได้แนะนำชุดของคลาสและฟิลด์การระบุที่รองรับเพื่อช่วยในการติดตามกระบวนการเรนเดอร์ CAD ด้วยการเปลี่ยนแปลงเหล่านี้ การแปลง CAD เป็น PDF สามารถทำได้ดังต่อไปนี้ในขณะที่เปิดใช้งานการติดตาม

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

การติดตามกระบวนการเรนเดอร์ CAD สามารถตรวจจับปัญหาได้ดังนี้

1. ข้อมูลหัวข้อที่ขาดหายไปหรือเสียหาย
1. ข้อมูลเลย์เอาต์ที่ขาดหายไป
1. เอนทิตีบล็อคที่ขาดหายไป
1. รูปแบบขนาดที่ขาดหายไป
1. รูปแบบที่ขาดหายไป

## **การแทนที่ฟอนต์ขณะแปลงการวาด CAD**

อาจเป็นไปได้ว่าการวาด CAD บางอย่างใช้ฟอนต์เฉพาะที่ไม่มีอยู่ในเครื่องที่ทำการแปลง CAD เป็น PDF หรือ CAD เป็นรูปภาพเรเซอร์ ในสถานการณ์เช่นนี้ API ของ Aspose.CAD จะกระตุ้นให้มีข้อยกเว้นที่เหมาะสมเพื่อเน้นฟอนต์ที่ขาดหายไปและหยุดกระบวนการแปลง เนื่องจาก API ต้องการฟอนต์เหล่านี้เพื่อแสดงเนื้อหาอย่างถูกต้องไปยัง PDF หรือรูปภาพที่ส่งออก

Aspose.CAD API มีวิธีที่ง่ายต่อการใช้กลไกในการแทนที่ฟอนต์ที่จำเป็นด้วยฟอนต์ที่มีอยู่ คุณสมบัติ **CadImage.Styles** คืนค่าอินสแตนซ์ของ **CadStylesDictionary** ซึ่งมี **CadStyleTableObject** สำหรับแต่ละสไตล์ในการวาด CAD ขณะที่ **CadStyleTableObject.PrimaryFontName** สามารถใช้เพื่อระบุชื่อฟอนต์ที่มีอยู่

โค้ดตัวอย่างต่อไปนี้แสดงการใช้งานของ Aspose.CAD สำหรับ .NET API เพื่อเปลี่ยนฟอนต์ของทุกรูปแบบในการวาด CAD

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

นอกจากนี้ยังสามารถเปลี่ยนฟอนต์ของรูปแบบเฉพาะโดยเข้าถึงผ่านชื่อสไตล์ โค้ดตัวอย่างต่อไปนี้แสดงการใช้งานวิธีนี้

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **การแปลงเลเยอร์ CAD เป็นรูปภาพเรเซอร์รูปแบบ**

Aspose.CAD สำหรับ .NET API ได้มีวิธีการที่มีประสิทธิภาพและใช้งานง่ายเพื่อระบุชื่อของเลเยอร์ CAD ที่ต้องการและเรนเดอร์มันเป็นรูปภาพเรเซอร์ ในที่นี้คือการทำใน 5 ขั้นตอนง่ายๆ ดังที่ระบุไว้ด้านล่างนี้

1. โหลดไฟล์ CAD ลงในอินสแตนซ์ของ **Image** โดยใช้วิธี **Load**
1. สร้างอินสแตนซ์ของ **CadRasterizationOptions** และตั้งค่าคุณสมบัติที่จำเป็น เช่น **PageWidth** & **PageHeight**
1. เพิ่มชื่อเลเยอร์ที่ต้องการโดยใช้วิธี **CadRasterizationOptions.Layers.Add**
1. สร้างอินสแตนซ์ของ **ImageOptionsBase** และตั้งค่าคุณสมบัติ **VectorRasterizationOptions** เป็นอินสแตนซ์ของ **CadRasterizationOptions** ที่สร้างในขั้นตอนก่อนหน้า
1. เรียกใช้วิธี **Image.Save** โดยส่งเส้นทางไฟล์ (หรือวัตถุ MemoryStream) รวมถึงอินสแตนซ์ของ **ImageOptionsBase** ที่สร้างในขั้นตอนก่อนหน้า

นี่คือโค้ดต้นฉบับทั้งหมด

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **แปลงเลเยอร์ CAD ทั้งหมดเป็นรูปภาพแยกต่างหาก**

คุณสามารถรับเลเยอร์ทั้งหมดจากการวาด CAD โดยใช้ **CadImage.Layers** และเรนเดอร์แต่ละเลเยอร์เป็นรูปภาพแยกต่างหากตามที่แสดงด้านล่าง

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **การแปลงเลเยอร์ CAD DWF เป็นรูปภาพเรเซอร์รูปแบบ**

Aspose.CAD สำหรับ .NET API ได้มีวิธีการที่มีประสิทธิภาพและใช้งานง่ายเพื่อระบุชื่อของเลเยอร์ CAD ที่ต้องการและเรนเดอร์มันเป็นรูปภาพเรเซอร์ ในที่นี้คือการทำใน 5 ขั้นตอนง่ายๆ ดังที่ระบุไว้ด้านล่างนี้

1. โหลดไฟล์ CAD DWF ลงในอินสแตนซ์ของ **Image** โดยใช้วิธี **Load**
1. สร้างอินสแตนซ์ของ **CadRasterizationOptions** และตั้งค่าคุณสมบัติที่จำเป็น เช่น **PageWidth** & **PageHeight**
1. เพิ่มชื่อเลเยอร์ที่ต้องการโดยใช้วิธี **CadRasterizationOptions.Layers.Add**
1. สร้างอินสแตนซ์ของ **ImageOptionsBase** และตั้งค่าคุณสมบัติ **VectorRasterizationOptions** เป็นอินสแตนซ์ของ **CadRasterizationOptions** ที่สร้างในขั้นตอนก่อนหน้า
1. เรียกใช้วิธี **Image.Save** โดยส่งเส้นทางไฟล์ (หรือวัตถุ MemoryStream) รวมถึงอินสแตนซ์ของ **ImageOptionsBase** ที่สร้างในขั้นตอนก่อนหน้า

นี่คือโค้ดต้นฉบับทั้งหมด

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD สำหรับ .NET จะเขียนข้อมูลเกี่ยวกับ API และหมายเลขเวอร์ชันในเอกสารผลลัพธ์โดยตรง ตัวอย่างเช่น ขณะเรนเดอร์เอกสารเป็น PDF Aspose.CAD สำหรับ .NET จะเติมข้อมูลในฟิลด์ **Application** ด้วยค่า 'Aspose.CAD' และฟิลด์ **PDF Producer** ด้วยค่า เช่น 'Aspose.CAD v 17.10'

กรุณาทราบว่าคุณไม่สามารถสั่งให้ Aspose.CAD สำหรับ .NET เปลี่ยนแปลงหรือเอาข้อมูลนี้ออกจากเอกสารผลลัพธ์ได้
