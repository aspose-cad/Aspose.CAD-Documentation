---
title: การแปลงภาพ CAD เป็นไฟล์ PDF และรูปแบบภาพ Raster
type: docs
weight: 30
url: /th/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD สำหรับ Java จะเขียนข้อมูลเกี่ยวกับ API และหมายเลขเวอร์ชันในเอกสารเอาต์พุตโดยตรง ตัวอย่างเช่น เมื่อเรนเดอร์เอกสารเป็น PDF Aspose.CAD สำหรับ Java จะเติมฟิลด์แอปพลิเคชันด้วยค่าที่ชื่อว่า 'Aspose.CAD' และฟิลด์ผู้ผลิต PDF ด้วยค่า เช่น 'Aspose.CAD v 17.9'

โปรดทราบว่าคุณไม่สามารถสั่งให้ Aspose.CAD สำหรับ Java เปลี่ยนแปลงหรือเอาข้อมูลนี้ออกจากเอกสารเอาต์พุตได้

{{% /alert %}} 
## **การแปลงภาพ CAD เป็นรูปแบบภาพ Raster**
Aspose.CAD สำหรับ Java สามารถแปลงรูปแบบไฟล์ CAD เช่น [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) เป็นรูปแบบภาพ Raster ที่รองรับ เช่น [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). API ของ Aspose.CAD สำหรับ Java ได้เปิดเผยวิธีการที่มีประสิทธิภาพและใช้งานง่ายเพื่อบรรลุเป้าหมายนี้
คุณสามารถแปลงรูปแบบภาพ CAD ที่รองรับใด ๆ เป็นรูปแบบภาพ Raster โดยใช้ขั้นตอนที่ง่ายด้านล่างนี้

1. โหลดไฟล์ CAD เข้าไปในอินสแตนซ์ของ [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. สร้างอินสแตนซ์ของ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) และตั้งค่าคุณสมบัติที่จำเป็น เช่น [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. สร้างอินสแตนซ์ของ **ImageOptionsBase** และตั้งค่าคุณสมบัติ [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) เป็นอินสแตนซ์ของ **CadRasterizationOptions** ที่สร้างขึ้นในขั้นตอนก่อนหน้า.
1. เรียกใช้ **Image.save** โดยการส่งผ่านที่อยู่ไฟล์ (หรือวัตถุของ MemoryStream) รวมถึงอินสแตนซ์ของ [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) ที่สร้างขึ้นในขั้นตอนก่อนหน้า.

นี่คือโค้ดต้นฉบับอย่างครบถ้วน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



โดยทั่วไป API จะเรนเดอร์เฉพาะเลย์เอาต์ "โมเดล" เท่านั้น อย่างไรก็ตาม คุณยังสามารถระบุเลย์เอาต์ตามที่คุณต้องการในขณะที่แปลงภาพ CAD เป็นรูปแบบภาพ
## **การปรับแต่งการแปลง CAD**
กระบวนการแปลง CAD เป็น [PDF](https://docs.fileformat.com/pdf/) และจาก CAD เป็นภาพ Raster สามารถกำหนดค่าได้อย่างมาก เนื่องจากคลาส [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) ถูกพัฒนาในลักษณะที่สามารถให้ฟีเจอร์เสริมที่หลากหลายซึ่งเมื่อกำหนดแล้วจะสามารถทำการเรนเดอร์ได้ตามความต้องการของแอปพลิเคชัน
### **คลาส CadRasterizationOptions**
คลาส [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) เป็นร่วมกันสำหรับรูปแบบ CAD ที่รองรับทั้งหมด เช่น [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/) ดังนั้นข้อมูลที่แบ่งปันในบทความนี้จึงใช้ได้กับรูปแบบ CAD ที่กล่าวถึงทั้งสอง

คุณสมบัติที่มีประโยชน์ที่สุดของคลาส **CadRasterizationOptions** คือ:

|**คุณสมบัติ**|**ค่าเริ่มต้น**|**ต้องการ**|**คำอธิบาย**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|ใช่|ระบุความกว้างของหน้า|
|**PageHeight**|**0**|ใช่|ระบุความสูงของหน้า|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|ไม่|ระบุว่าสิ่งวาดควรถูกรับการปรับขนาดโดยอัตโนมัติ ค่าเริ่มต้นจะย่อภาพให้พอดีกับขนาดของผ้าใบ สลับไปที่โหมด **GrowToFit** หรือใช้การตั้งค่า **None** เพื่อปิดการปรับขนาดอัตโนมัติ|
|**BackgroundColor**|**Color.White**|ไม่|ระบุสีพื้นหลังของภาพที่เอาต์พุต|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|ไม่|ระบุโหมดการปรับสีของวัตถุ กำหนดตัวเลือก **UseObjectColor** เพื่อวาดวัตถุโดยใช้สีดั้งเดิมของพวกเขา หรือใช้ตัวเลือก **UseDrawColor** เพื่อแทนที่สีดั้งเดิม|
|**DrawColor**|**Color.Black**|ไม่|ระบุสีของเอนทิตีที่ถูกแทนที่ (เฉพาะเมื่อ **DrawType** ถูกตั้งค่าเป็นค่าของคุณสมบัติ **UseDrawColor**)|
|**AutomaticLayoutsScaling**|False|ไม่|ระบุว่าต้องทำการปรับขนาดเลย์เอาต์อัตโนมัติให้ตรงกับเลย์เอาต์โมเดลหรือไม่|
### **การตั้งค่าขนาดผ้าใบและโหมด**
การส่งออกจาก CAD ไปยัง PDF หรือ CAD ไปยังรูปภาพ Raster ไม่ใช่งานที่ง่าย เพราะว่าภาพ PDF หรือภาพผลลัพธ์ต้องการให้กำหนดขนาดของผ้าใบ โดยเราต้องระบุขนาดของ PDF หน้าเพื่อจะทำการเรนเดอร์ภาพให้ถูกต้อง กำหนดคุณสมบัติ **CadRasterizationOptions.PageWidth** และ **CadRasterizationOptions.PageHeight** อย่างชัดแจ้ง หรืออาจจะเกิด **ImageSaveException** ได้

นอกจากนี้ คุณยังสามารถกำหนดตัวเลือกขนาดการปรับขนาดได้ ตัวเลือกการปรับขนาดจะถูกตั้งค่าผ่านคุณสมบัติ **CadRasterizationOptions.ScaleMethod** ใช้ตัวเลือกนี้เพื่อปรับขนาดภาพให้ตรงตามค่าของ **CadRasterizationOptions.PageWidth** และ **CadRasterizationOptions.PageHeight** โดยค่าเริ่มต้น **CadRasterizationOptions.ScaleMethod** จะถูกตั้งค่าเป็นโหมด **ScaleType.ShrinkToFit** คุณสมบัตินี้จะกำหนดพฤติกรรมต่อไปนี้:

- หากขนาดของภาพ CAD ใหญ่กว่าขนาดผ้าใบที่ได้ ผลขนาดของภาพจะถูกลดลงให้พอดีกับผ้าใบ โดยยังคงรักษาสัดส่วน
- หากขนาดของ CAD ให้น้อยกว่าขนาดผ้าใบจะตั้งค่าคุณสมบัติ **CadRasterizationOptions.ScaleMethod** เป็น **ScaleType.GrowToFit** เพื่อเพิ่มขนาดการวาดให้พอดีกับผ้าใบ PDF โดยยังคงรักษาสัดส่วน
- หรือปิดการปรับขนาดอัตโนมัติด้วยตัวเลือก **ScaleType.None**

ตัวอย่างโค้ดด้านล่างแสดงตัวเลือกการปรับขนาดอัตโนมัติในใช้งาน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **การตั้งค่าสีพื้นหลังและสีภาพวาด**
โดยทั่วไป แปลงสีสำหรับผ้าใบที่เกิดขึ้นได้ถูกตั้งค่าเป็นแบบสาธารณะของเอกสาร นั่นหมายความว่าทุกเอนทิตีภายในการวาด CAD จะถูกวาดด้วยปากกาสีดำบนพื้นหลังสีขาว ตัวตั้งค่าพวกนี้สามารถเปลี่ยนแปลงได้ด้วยคุณสมบัติ **CadRasterizationOptions.BackgroundColor** และ **CadRasterizationOptions.DrawColor** การเปลี่ยนแปลงคุณสมบัติ **CadRasterizationOptions.DrawColor** จะต้องติดตั้งคุณสมบัติ **CadRasterizationOptions.DrawType** เพื่อใช้สีการวาดที่กำหนด คุณสมบัติ **CadRasterizationOptions.DrawType** จะควบคุมว่าธาตุ CAD จะรักษาสีเดิมหรือแปลงเป็นสีที่กำหนดเอง หากต้องการรักษาสีของเอนทิตี ให้กำหนดให้ **CadRasterizationOptions.DrawType** เป็น **CadDrawTypeMode.UseObjectColor** มิฉะนั้นให้ระบุค่า **CadDrawTypeMode.UseDrawColor**

ตัวอย่างโค้ดด้านล่างแสดงวิธีการใช้คุณสมบัติสีที่แตกต่างกัน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **การตั้งการปรับขนาดอัตโนมัติของเลย์เอาต์**
ภาพ CAD ส่วนมากมีเลย์เอาต์มากกว่าหนึ่งรายการที่ถูกจัดเก็บในไฟล์เดียว และเลย์เอาต์แต่ละรายการอาจมีขนาดที่แตกต่างกัน ในการเรนเดอร์ภาพ CAD เหล่านั้นเป็น PDF หน้าของ PDF แต่ละหน้าก็อาจมีการปรับขนาดที่แตกต่างกันตามขนาดของเลย์เอาท์ เพื่อให้การเรนเดอร์มีความเป็นกลุ่มมากขึ้น APIs ของ Aspose.CAD ได้เปิดเผยคุณสมบัติ **CadRasterizationOptions.AutomaticLayoutsScaling** ค่าดีฟอลต์จะถูกตั้งค่าเป็น **false** แต่เมื่อเป็น true API จะพยายามค้นหาสัดส่วนที่สอดคล้องกันสำหรับแต่ละเลย์เอาต์แยกและวาดมันในลักษณะที่ตรงด้วยการดำเนินการปรับขนาดอัตโนมัติตามขนาดหน้า

นี่คือวิธีการที่คุณสมบัติ **CadRasterizationOptions.AutomaticLayoutsScaling** ทำงานร่วมกับคุณสมบัติ **CadRasterizationOptions.ScaleMethod**

1. หาก **ScaleMethod** ถูกตั้งเป็น **ScaleType.ShrinkToFit** หรือ **ScaleType.GrowToFit** โดยที่ **AutomaticLayoutsScaling** ถูกตั้งเป็น false เลย์เอาต์ทั้งหมด (รวมถึงโมเดล) จะถูกประมวลผลตามตัวเลือกแรก
1. หาก **ScaleMethod** ถูกตั้งเป็น **ScaleType.ShrinkToFit** หรือ **ScaleType.GrowToFit** โดยที่ **AutomaticLayoutsScaling** ถูกตั้งเป็น true เลย์เอาต์ทั้งหมด (ยกเว้นโมเดล) จะถูกประมวลผลตามขนาดของพวกเขา ในขณะที่โมเดลจะถูกประมวลผลตามตัวเลือกแรก
1. หาก **ScaleMethod** ถูกตั้งเป็น **ScaleType.None** โดยที่ **AutomaticLayoutsScaling** ถูกตั้งเป็น true หรือ false จะไม่มีการปรับขนาด

ตัวอย่างโค้ดด้านล่างแสดงวิธีการตั้งการปรับขนาดอัตโนมัติสำหรับการแปลง CAD ไปเป็น PDF

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **การแปลงเลย์เอาต์ CAD เป็นรูปแบบภาพ Raster**
Aspose.CAD สำหรับ Java API สามารถเปลี่ยนเลย์เอาต์ CAD ในรูปแบบที่รองรับ เช่น DXF & DWG เป็นภาพ Raster เช่น PNG, BMP, TIFF, JPEG & GIF API ยังให้การสนับสนุนเพื่อเรนเดอร์เลย์เอาต์เฉพาะของการวาด CAD ลงในเลเยอร์ PSD ต่างๆ
Aspose.CAD สำหรับ Java API ได้เปิดเผยวิธีที่มีประสิทธิภาพและใช้งานง่ายเพื่อกำหนดรายการเลย์เอาต์ CAD ที่ต้องการและเรนเดอร์ให้เป็นรูปแบบภาพ Raster นี่คือวิธีที่คุณสามารถทำได้ใน 5 ขั้นตอนง่ายๆ ดังที่แสดงด้านล่างนี้

1. โหลดไฟล์ CAD ลงในอินสแตนซ์ของ **Image** โดยใช้วิธีการโรงงาน **load**.
1. สร้างอินสแตนซ์ของ **CadRasterizationOptions** และตั้งค่าคุณสมบัติที่จำเป็น เช่น **PageWidth** & **PageHeight**.
1. ระบุชื่อเลย์เอาต์ที่ต้องการโดยใช้คุณสมบัติ CadRasterizationOptions.Layouts.
1. สร้างอินสแตนซ์ของ **ImageOptionsBase** และตั้งค่าคุณสมบัติ **VectorRasterizationOptions** เป็นอินสแตนซ์ของ **CadRasterizationOptions** ที่สร้างขึ้นในขั้นตอนก่อนหน้า.
1. เรียกใช้ **Image.Save** โดยการส่งผ่านที่อยู่ไฟล์ (หรือวัตถุของ MemoryStream) รวมถึงอินสแตนซ์ของ **ImageOptionsBase** ที่สร้างขึ้นในขั้นตอนก่อนหน้า.

นี่คือโค้ดต้นฉบับอย่างครบถ้วน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

คุณสมบัติ **CadRasterizationOptions.Layouts** เป็นตัวแปรประเภทอาเรย์สตริง ดังนั้นคุณอาจระบุเลย์เอาต์มากกว่า 1 รายการในครั้งเดียวสำหรับการเปลี่ยนแปลงเป็นรูปแบบภาพ ขณะระบุหลายเลย์เอาต์สำหรับ คุณสมบัติ **CadRasterizationOptions.Layouts** ภาพ TIFF ที่ได้จะมีหลายหน้า ภาพ GIF จะมีหลายเฟรม และรูปแบบ PSD จะมีหลายเลเยอร์ โดยที่แต่ละหน้า/เฟรม/เลเยอร์จะแสดงเลย์เอาต์ AutoCAD รายบุคคล ในกรณีที่เลือกฟอร์แมตภาพอื่น ๆ เช่น PNG, BMP, JPEG เพื่อเก็บผลลัพธ์นั้น API จะเรนเดอร์เพียงเลย์เอาต์ดีฟอลต์ เท่านั้น “โมเดล”

{{% /alert %}} 
## **การเปิดใช้งานการติดตามกระบวนการเรนเดอร์ CAD**
Aspose.CAD ได้แนะนำชุดของคลาสและฟิลด์การประกาศที่สนับสนุนเพื่อช่วยในการติดตามกระบวนการเรนเดอร์ CAD ด้วยการเปลี่ยนแปลงเหล่านี้ การแปลง CAD เป็น PDF สามารถทำได้ตามที่ตามนี้ โดยการเปิดใช้งานการติดตาม

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



การติดตามกระบวนการเรนเดอร์ CAD สามารถตรวจจับปัญหาที่อาจเกิดขึ้นดังต่อไปนี้

1. ข้อมูลหัวข้อที่ขาดหายหรือเสียหาย
1. ข้อมูลเลย์เอาต์ที่ขาดหาย
1. เอนทิตีบล็อคที่ขาดหาย
1. รูปแบบมิติที่ขาดหาย
1. รูปแบบที่ขาดหาย
## **การแทนที่ฟอนต์เมื่อแปลงภาพ CAD**
อาจเป็นไปได้ว่าภาพ CAD บางอย่างใช้ฟอนต์เฉพาะที่ไม่มีอยู่ในเครื่องที่ทำการแปลง CAD เป็น PDF หรือ CAD เป็นรูปภาพ Raster ในสถานการณ์เช่นนั้น API ของ Aspose.CAD จะเรียกใช้งานข้อยกเว้นที่เหมาะสมเพื่อเน้นการขาดฟอนต์และหยุดกระบวนการแปลงเพราะว่ารายการฟอนต์เหล่านี้จำเป็นต้องให้ได้เพื่อเรนเดอร์เนื้อหาให้ถูกต้องบน PDF และ/หรือภาพที่เกิดขึ้น
API ของ Aspose.CAD ให้วิธีการที่ง่ายในการใช้กลไกในการแทนที่ฟอนต์ที่จำเป็นด้วยฟอนต์ที่มีอยู่ โดยใช้คุณสมบัติ **CadImage.Styles** ที่จะส่งคืนอินสแตนซ์ของ **CadStylesDictionary** ซึ่งในทางกลับกันจะเก็บ **CadStyleTableObject** สำหรับแต่ละสไตล์ในภาพ CAD ในขณะที่ **CadStyleTableObject.PrimaryFontName** สามารถใช้เพื่อระบุชื่อฟอนต์ที่มีอยู่

ตัวอย่างโค้ดด้านล่างแสดงถึงการใช้งานของ Aspose.CAD สำหรับ Java API เพื่อเปลี่ยนฟอนต์ของทุกสไตล์ในภาพ CAD

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




นอกจากนี้ยังเป็นไปได้ที่จะเปลี่ยนฟอนต์ของสไตล์เฉพาะโดยการเข้าถึงมันผ่านชื่อสไตล์ ตัวอย่างโค้ดด้านล่างแสดงการใช้งานของแนวทางนี้

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **การแปลงเลเยอร์ CAD เป็นรูปแบบภาพ Raster**
Aspose.CAD สำหรับ Java API ได้เปิดเผยวิธีที่มีประสิทธิภาพและใช้งานง่ายในการระบุชื่อของเลเยอร์ CAD ที่จำเป็นและเรนเดอร์มันเป็นรูปแบบภาพ Raster นี่คือวิธีที่คุณสามารถทำได้ใน 5 ขั้นตอนง่าย ๆ ดังที่แสดงด้านล่างนี้

1. โหลดไฟล์ CAD ลงในอินสแตนซ์ของ **Image** โดยใช้วิธีการโรงงาน **load**.
1. สร้างอินสแตนซ์ของ **CadRasterizationOptions** และตั้งค่าคุณสมบัติที่จำเป็น เช่น **PageWidth** & **PageHeight**.
1. เพิ่มชื่อเลเยอร์ที่ต้องการโดยใช้วิธีการ **CadRasterizationOptions.Layers.add**.
1. สร้างอินสแตนซ์ของ **ImageOptionsBase** และตั้งค่าคุณสมบัติ **VectorRasterizationOptions** เป็นอินสแตนซ์ของ **CadRasterizationOptions** ที่สร้างขึ้นในขั้นตอนก่อนหน้า.
1. เรียกใช้เมธอด **Image.save** โดยการส่งผ่านที่อยู่ไฟล์ (หรือวัตถุของ MemoryStream) รวมถึงอินสแตนซ์ของ **ImageOptionsBase** ที่สร้างขึ้นในขั้นตอนก่อนหน้า.

นี่คือโค้ดต้นฉบับอย่างครบถ้วน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **การแปลงเลเยอร์ CAD ทั้งหมดเป็นภาพแยกต่างหาก**
คุณสามารถรับเลเยอร์ทั้งหมดจากการวาด CAD โดยใช้ **CadImage.Layers** และเรนเดอร์แต่ละเลเยอร์เป็นภาพแยกที่แสดงด้านล่าง

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **การแปลงเลเยอร์ DWF CAD เป็นรูปแบบภาพ Raster**
Aspose.CAD สำหรับ Java API ได้เปิดเผยวิธีที่มีประสิทธิภาพและใช้งานง่ายในการระบุชื่อของเลเยอร์ CAD ที่จำเป็นและเรนเดอร์มันเป็นรูปแบบภาพ Raster นี่คือวิธีที่คุณสามารถทำได้ใน 5 ขั้นตอนง่าย ๆ ดังที่แสดงด้านล่างนี้

1. โหลดไฟล์ DWF CAD ลงในอินสแตนซ์ของ **Image** โดยใช้วิธีการโรงงาน **Load**.
1. สร้างอินสแตนซ์ของ **CadRasterizationOptions** และตั้งค่าคุณสมบัติที่จำเป็น เช่น **PageWidth** & **PageHeight**.
1. เพิ่มชื่อเลเยอร์ที่ต้องการโดยใช้วิธีการ **CadRasterizationOptions.Layers.Add**.
1. สร้างอินสแตนซ์ของ **ImageOptionsBase** และตั้งค่าคุณสมบัติ **VectorRasterizationOptions** เป็นอินสแตนซ์ของ **CadRasterizationOptions** ที่สร้างขึ้นในขั้นตอนก่อนหน้า.
1. เรียกใช้เมธอด **Image.Save** โดยการส่งผ่านที่อยู่ไฟล์ (หรือวัตถุของ MemoryStream) รวมถึงอินสแตนซ์ของ **ImageOptionsBase** ที่สร้างขึ้นในขั้นตอนก่อนหน้า.

นี่คือโค้ดต้นฉบับอย่างครบถ้วน

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
