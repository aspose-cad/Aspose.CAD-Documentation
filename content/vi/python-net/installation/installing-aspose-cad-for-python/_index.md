---
title: Cài đặt Aspose.CAD cho Python
type: docs
weight: 20
url: /vi/python-net/installation/installing-aspose-cad-for-python/
---

## **Cài đặt gói aspose-cad**

### Sử dụng pip để cài đặt một gói

1. Để cài đặt gói [aspose.cad](https://pypi.org/project/aspose-cad/), các trang có gói này có mô tả bổ sung về lệnh cần thực thi trong terminal:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. Một ví dụ về lệnh để cài đặt một gói thông qua terminal:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### Sử dụng tệp WHL để cài đặt một gói

1. Để tải xuống tệp whl, hãy truy cập trang pypi của gói [aspose.cad](https://pypi.org/project/aspose-cad/#files) và tải xuống tệp<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. Để cài đặt gói [aspose.cad](https://pypi.org/project/aspose-cad/), bạn cần sử dụng lệnh pip với đường dẫn đầy đủ đến tệp whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. Sau khi cài đặt, chúng ta sẽ thấy gói trong thư mục site-package<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## Mã ví dụ
Mã ví dụ để chuyển đổi một tệp

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
