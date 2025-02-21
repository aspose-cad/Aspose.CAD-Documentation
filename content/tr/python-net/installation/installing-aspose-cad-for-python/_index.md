---
title: Aspose.CAD'in Python için Kurulumu
type: docs
weight: 20
url: /tr/python-net/installation/installing-aspose-cad-for-python/
---

## **aspose-cad paketi kurulumu**

### Bir paketi yüklemek için pip kullanma

1. [aspose.cad](https://pypi.org/project/aspose-cad/) paketini yüklemek için, paketlerin bulunduğu sitelerde terminalde çalıştırılacak komutun ek bir açıklaması vardır:<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
1. Terminal üzerinden bir paketi yüklemek için bir komut örneği:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### Bir paketi yüklemek için WHL dosyasını kullanma

1. WHL dosyasını indirmek için [aspose.cad](https://pypi.org/project/aspose-cad/#files) paketinin pypi sayfasına gidin ve dosyayı indirin<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
1. [aspose.cad](https://pypi.org/project/aspose-cad/) paketini yüklemek için, WHL dosyasının tam yolunu içeren pip komutunu kullanmanız gerekir:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

1. Kurulumdan sonra paketi site-package klasöründe göreceğiz<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## Örnek kod
Bir dosyayı dönüştürmek için örnek kod

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
