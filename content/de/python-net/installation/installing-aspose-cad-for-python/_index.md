---
title: Installation von Aspose.CAD für Python
type: docs
weight: 20
url: /de/python-net/installing-aspose-cad-for-python/
---

## **Installation des aspose-cad-Pakets**

### Verwendung von pip zur Installation eines Pakets

1. Um das [aspose.cad](https://pypi.org/project/aspose-cad/) Paket zu installieren, enthalten die Websites mit dem Paket eine zusätzliche Beschreibung des Befehls, der im Terminal ausgeführt werden muss:<br/>
![pypi-install](pypi-aspose-cad.png)
1. Ein Beispiel für einen Befehl zur Installation eines Pakets über das Terminal:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](pip-install-aspose.png)

### Verwendung einer WHL-Datei zur Installation eines Pakets

1. Um die WHL-Datei herunterzuladen, gehen Sie zur PyPI-Seite des [aspose.cad](https://pypi.org/project/aspose-cad/#files) Pakets und laden Sie die Datei herunter<br/>
![whl-download](download-whl-file.png)<br/>
1. Um das [aspose.cad](https://pypi.org/project/aspose-cad/) Paket zu installieren, müssen Sie den pip-Befehl mit dem vollständigen Pfad zur WHL-Datei verwenden:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](install-whl-file-terminal.png)

1. Nach der installation sehen wir das Paket im site-package-Ordner<br/>
![site-package-aspose-cad](site-package-aspose.png)

## Beispielcode
Beispielcode zur Umwandlung einer Datei

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
