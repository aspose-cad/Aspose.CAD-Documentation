---
title: Installation av Aspose.CAD för Python
type: docs
weight: 20
url: /sv/python-net/installation/installing-aspose-cad-for-python/
---

## **Installation av aspose-cad paketet**

### Använda pip för att installera ett paket

1. För att installera paketet [aspose.cad](https://pypi.org/project/aspose-cad/) har sidorna med paketet en ytterligare beskrivning av kommandot som ska köras i terminalen:<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
1. Ett exempel på ett kommando för att installera ett paket via terminalen:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### Använda WHL-fil för att installera ett paket

1. För att ladda ner whl-filen, gå till pypi-sidan för paketet [aspose.cad](https://pypi.org/project/aspose-cad/#files) och ladda ner filen<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
1. För att installera paketet [aspose.cad](https://pypi.org/project/aspose-cad/) behöver du använda pip-kommandot med den fullständiga sökvägen till whl-filen:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

1. Efter installationen kommer vi att se paketet i site-package-mappen<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## Exempel kod
Exempel kod för att konvertera en fil

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
