---
title: การติดตั้ง Aspose.CAD สำหรับ Python
type: docs
weight: 20
url: /th/python-net/installation/installing-aspose-cad-for-python/
---

## **การติดตั้งแพ็คเกจ aspose-cad**

### การใช้ pip เพื่อติดตั้งแพ็คเกจ

1. เพื่อที่จะติดตั้งแพ็คเกจ [aspose.cad](https://pypi.org/project/aspose-cad/) เว็บไซต์ที่มีแพ็คเกจจะมีคำอธิบายเพิ่มเติมเกี่ยวกับคำสั่งที่จะต้องดำเนินการในเทอร์มินัล:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. ตัวอย่างคำสั่งในการติดตั้งแพ็คเกจผ่านทางเทอร์มินัล:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### การใช้ไฟล์ WHL เพื่อติดตั้งแพ็คเกจ

1. เพื่อดาวน์โหลดไฟล์ whl ให้ไปที่หน้า pypi ของแพ็คเกจ [aspose.cad](https://pypi.org/project/aspose-cad/#files) และดาวน์โหลดไฟล์<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. เพื่อติดตั้งแพ็คเกจ [aspose.cad](https://pypi.org/project/aspose-cad/) คุณต้องใช้คำสั่ง pip พร้อมกับเส้นทางเต็มไปยังไฟล์ whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. หลังจากการติดตั้ง เราจะเห็นแพ็คเกจในโฟลเดอร์ site-package<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## โค้ดตัวอย่าง
โค้ดตัวอย่างสำหรับการแปลงไฟล์

{{< highlight plain >}}
import aspose.cad as cad

if __name__ == '__main__':
    
    image = cad.Image.load("drawing.dxf")

    rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
    rasterizationOptions.page_height = 1200.0
    rasterizationOptions.page_width = 1200.0
    
    pdfOptions = cad.imageoptions.PdfOptions()
    pdfOptions.vector_rasterization_options = rasterizationOptions
    image.save("output.pdf", pdfOptions)
{{< /highlight >}}
