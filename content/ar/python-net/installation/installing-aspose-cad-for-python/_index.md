---
title: تثبيت Aspose.CAD لبايثون
type: docs
weight: 20
url: /ar/python-net/installation/installing-aspose-cad-for-python/
---

## **تثبيت حزمة aspose-cad**

### استخدام pip لتثبيت حزمة

1. لتثبيت حزمة [aspose.cad](https://pypi.org/project/aspose-cad/) ، تحتوي المواقع الخاصة بالحزمة على وصف إضافي للأمر الذي يجب تنفيذه في الطرفية:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. مثال على أمر لتثبيت حزمة من خلال الطرفية:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### استخدام ملف WHL لتثبيت حزمة

1. لتنزيل ملف whl، انتقل إلى صفحة pypi لحزمة [aspose.cad](https://pypi.org/project/aspose-cad/#files) وقم بتنزيل الملف<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. لتثبيت حزمة [aspose.cad](https://pypi.org/project/aspose-cad/) ، تحتاج إلى استخدام أمر pip مع المسار الكامل إلى ملف whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. بعد التثبيت، سنرى الحزمة في مجلد site-package<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## مثال على الكود
مثال على كود لتحويل ملف

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
