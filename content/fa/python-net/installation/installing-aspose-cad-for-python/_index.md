---
title: نصب Aspose.CAD برای Python
type: docs
weight: 20
url: /fa/python-net/installing-aspose-cad-for-python/
---

## **نصب بسته aspose-cad**

### استفاده از pip برای نصب یک بسته

1. برای نصب بسته [aspose.cad](https://pypi.org/project/aspose-cad/) ، سایت‌های مربوط به بسته توضیحات اضافی درباره دستوری که باید در ترمینال اجرا شود دارند:<br/>
![pypi-install](/fa/_assets/pypi-aspose-cad.png)
1. یک مثال از یک دستور برای نصب یک بسته از طریق ترمینال:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/fa/_assets/pip-install-aspose.png)

### استفاده از فایل WHL برای نصب یک بسته

1. برای دانلود فایل whl به صفحه pypi بسته [aspose.cad](https://pypi.org/project/aspose-cad/#files) بروید و فایل را دانلود کنید<br/>
![whl-download](/fa/_assets/download-whl-file.png)<br/>
1. برای نصب بسته [aspose.cad](https://pypi.org/project/aspose-cad/) ، شما باید از دستور pip با مسیر کامل به فایل whl استفاده کنید:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/fa/_assets/install-whl-file-terminal.png)

1. بعد از نصب، ما بسته را در پوشه site-package خواهیم دید<br/>
![site-package-aspose-cad](/fa/_assets/site-package-aspose.png)

## کد نمونه
کد نمونه برای تبدیل یک فایل

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
