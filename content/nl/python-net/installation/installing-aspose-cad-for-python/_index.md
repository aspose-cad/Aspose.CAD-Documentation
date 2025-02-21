---
title: Het installeren van Aspose.CAD voor Python
type: docs
weight: 20
url: /nl/python-net/installation/installing-aspose-cad-for-python/
---

## **Installatie van het aspose-cad pakket**

### Gebruik pip om een pakket te installeren

1. Om het [aspose.cad](https://pypi.org/project/aspose-cad/) pakket te installeren, hebben de sites met het pakket een aanvullende beschrijving van de opdracht die in de terminal moet worden uitgevoerd:<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
1. Een voorbeeld van een opdracht om een pakket via de terminal te installeren:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### Gebruik WHL-bestand om een pakket te installeren

1. Om het whl-bestand te downloaden, ga naar de pypi-pagina van het [aspose.cad](https://pypi.org/project/aspose-cad/#files) pakket en download het bestand<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
1. Om het [aspose.cad](https://pypi.org/project/aspose-cad/) pakket te installeren, moet je de pip-opdracht gebruiken met het volledige pad naar het whl-bestand:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

1. Na de installatie zullen we het pakket in de site-package map zien<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## Voorbeeldcode
Voorbeeldcode voor het converteren van een bestand

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
