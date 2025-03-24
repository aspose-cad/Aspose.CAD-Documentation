---
title: Aspose.CAD telepítése Python számára
type: docs
weight: 20
url: /hu/python-net/installation/installing-aspose-cad-for-python/
---

## **Az aspose-cad csomag telepítése**

### Csomag telepítése pip-pel

1. Az [aspose.cad](https://pypi.org/project/aspose-cad/) csomag telepítéséhez a csomagokkal rendelkező oldalakon további leírás található a terminálban végrehajtandó parancsról:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. Példa egy parancsra, amely egy csomag telepítésére szolgál a terminálon:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### WHL fájl használata a csomag telepítéséhez

1. A whl fájl letöltéséhez látogasson el az [aspose.cad](https://pypi.org/project/aspose-cad/#files) csomag pypi oldalára, és töltse le a fájlt<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. Az [aspose.cad](https://pypi.org/project/aspose-cad/) csomag telepítéséhez a pip parancsot kell használni, a whl fájl teljes elérési útjával:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. A telepítés után látni fogjuk a csomagot a site-package mAPPAnnban<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## Példa kód
Példa kód egy fájl konvertálására

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
