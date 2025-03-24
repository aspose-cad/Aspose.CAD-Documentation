---
title: การติดตั้ง
type: docs
weight: 30
url: /th/net/getting-started/installation/
---

## **ติดตั้ง Aspose.CAD สำหรับ .NET ผ่าน NuGet**

NuGet เป็นวิธีที่ง่ายที่สุดในการดาวน์โหลดและติดตั้ง Aspose APIs สำหรับ .NET เปิด Microsoft Visual Studio และตัวจัดการแพ็คเกจ NuGet ค้นหา "aspose" เพื่อค้นหา Aspose API ที่ต้องการ คลิกที่ "ติดตั้ง" API ที่เลือกจะถูกดาวน์โหลดและอ้างอิงในโปรเจคของคุณ

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **การอ้างถึง Aspose.CAD จากโปรเจค .NET**

ทำตามขั้นตอนเหล่านี้ (สมมติว่าคุณใช้ Microsoft Visual Studio):

1. ใน **Solution Explorer** ขยายโหนดโปรเจคที่คุณต้องการเพิ่มการอ้างอิง
1. คลิกขวาที่โหนด **References** สำหรับโปรเจคและเลือก **Add Reference** จากเมนูทางลัด
1. ในกล่องสนทนา **Add Reference** และเรียกดูไปยังตำแหน่งไฟล์ DLL
1. เลือกไฟล์ DLL *Aspose.CAD* และคลิกที่ปุ่ม **OK**
1. การอ้างอิง *Aspose.CAD* จะปรากฏอยู่ใต้โหนด **References** ของโปรเจคของคุณ

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **ติดตั้งหรืออัปเดต Aspose.CAD โดยใช้ Console ของตัวจัดการแพ็คเกจ**

คุณสามารถทำตามขั้นตอนด้านล่างเพื่ออ้างอิง [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) โดยใช้ Console ของตัวจัดการแพ็คเกจ:

1. เปิดโซลูชัน/โปรเจคของคุณใน Visual Studio
1. เลือก Tools -> Library Package Manager -> Package Manager Console จากเมนูเพื่อเปิด Console ของตัวจัดการแพ็คเกจ

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

พิมพ์คำสั่ง “**Install-Package Aspose.CAD**” และกด Enter เพื่อติดตั้งรุ่นล่าสุดเต็มรูปแบบลงในแอปพลิเคชันของคุณ หรือคุณสามารถเพิ่มคำต่อท้าย "**-prerelease**" ในคำสั่งเพื่อระบุว่าต้องการติดตั้งรุ่นล่าสุดที่มีการแก้ไขด่วนด้วย

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

您จะเห็น提示信息“ดาวน์โหลด Aspose.CAD…” ที่ปรากฏที่มุมล่างซ้ายของหน้าต่างบ่งชี้ว่ากำลังดาวน์โหลดอยู่

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

เมื่อดาวน์โหลดเสร็จสิ้น คุณจะเห็นข้อความยืนยันต่อไปนี้ หากคุณไม่คุ้นเคยกับ [Aspose EULA](https://about.aspose.com/legal/eula) ขอแนะนำให้อ่านใบอนุญาตที่อ้างอิงใน URL

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

คุณควรพบว่า Aspose.CAD ได้ถูกเพิ่มและอ้างอิงในแอปพลิเคชันของคุณอย่างสำเร็จแล้ว

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

ใน Console ของตัวจัดการแพ็คเกจ คุณยังสามารถใช้คำสั่ง “**Update-Package Aspose.CAD**” และกด Enter เพื่อตรวจสอบการอัปเดตใด ๆ สำหรับแพ็คเกจ Aspose.CAD และติดตั้งหากมี คุณยังสามารถเพิ่มคำต่อท้าย "-prerelease" เพื่ออัปเดตรุ่นล่าสุด

## **ข้อควรพิจารณาเมื่อทำงานในสภาพแวดล้อมของเซิร์ฟเวอร์ที่แชร์**

แนะนำให้รัน Aspose .NET components ด้วย Full Trust permission set เสมอ เนื่องจาก Aspose .NET component บางครั้งต้องเข้าถึงการตั้งค่าค่าลงทะเบียนและไฟล์ที่ตั้งอยู่ในสถานที่อื่นที่ไม่ใช่virtual directory เช่น การอ่านฟอนต์ เป็นต้น นอกจากนี้ Aspose.NET components ยังอิงจากคลาสระบบ .NET หลัก ซึ่งบางคลาสก็ต้องการ Full Trust permission เพื่อทำงานในบางกรณี

ผู้ให้บริการอินเทอร์เน็ตที่โฮสต์แอปพลิเคชันหลายตัวจากบริษัทที่แตกต่างกันมักจะบังคับใช้ระดับความปลอดภัย Medium Trust ในกรณีของ .NET 2.0 ระดับความปลอดภัยดังกล่าวอาจตั้งข้อจำกัดดังต่อไปนี้ซึ่งอาจส่งผลกระทบต่อความสามารถของ Aspose.CAD ในการทำงานได้อย่างถูกต้อง

- **RegistryPermission** ไม่สามารถใช้งานได้ นั่นหมายความว่าคุณไม่สามารถเข้าถึงค่าลงทะเบียนซึ่งจำเป็นต้องใช้สำหรับการนับฟอนต์ที่ติดตั้งเมื่อเรนเดอร์เอกสาร
- **FileIOPermission** ถูกจำกัด นั่นหมายความว่าคุณสามารถเข้าถึงไฟล์ในลำดับชั้นvirtual directory ของแอปพลิเคชันของคุณเท่านั้น ซึ่งหมายความว่าอาจไม่สามารถอ่านฟอนต์ในระหว่างการส่งออกได้

ด้วยเหตุผลเหล่านี้จึงแนะนำให้รัน Aspose.CAD ด้วย Full Trust permissions คุณอาจพบว่าบางฟีเจอร์ของไลบรารีจะทำงานได้เมื่อทำงานที่งานต่าง ๆ ใน Medium Trust ในขณะที่บางฟีเจอร์จะไม่ทำงาน (เช่น การเรนเดอร์) อาจเป็นเพราะการเรียกใช้งาน GDI+ สำหรับการประมวลผลภาพ

## **ข้อกำหนดระบบ**

### **ระบบปฏิบัติการ**

Aspose.CAD สำหรับ .NET รองรับระบบปฏิบัติการ 32-bit หรือ 64-bit ใด ๆ ที่ติดตั้ง .NET หรือ Mono framework รวมถึงแต่ไม่จำกัดเพียง:

- Microsoft Windows desktop (XP, Vista, 7, 8, 10) และระบบปฏิบัติการเซิร์ฟเวอร์ (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS และอื่น ๆ)
- Mac OS X

### **Frameworks**

Aspose.CAD สำหรับ .NET รองรับ:

- .NET Framework รุ่น 2.0 ถึง 4.5 รวมถึงรุ่น Client Profile
- .NET Core
- Mono 2.6.7 หรือเวอร์ชันที่ใหม่กว่า

### **สภาพแวดล้อมการพัฒนา**

คุณสามารถใช้ Aspose.CAD สำหรับ .NET เพื่อพัฒนาแอปพลิเคชันในสภาพแวดล้อมการพัฒนาใด ๆ ที่มุ่งไปที่แพลตฟอร์ม .NET แต่สภาพแวดล้อมต่อไปนี้ได้รับการสนับสนุนอย่างชัดเจน:

- Microsoft Visual Studio 2010 หรือสูงกว่า
- MonoDevelop 2.4 และเวอร์ชันที่ใหม่กว่า
