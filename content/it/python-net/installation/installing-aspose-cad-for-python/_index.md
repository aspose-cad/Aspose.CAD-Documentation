---
title: Installazione di Aspose.CAD per Python
type: docs
weight: 20
url: /it/python-net/installation/installing-aspose-cad-for-python/
---

## **Installazione del pacchetto aspose-cad**

### Utilizzo di pip per installare un pacchetto

1. Per installare il pacchetto [aspose.cad](https://pypi.org/project/aspose-cad/), i siti con il pacchetto hanno una descrizione aggiuntiva del comando da eseguire nel terminale:<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
1. Un esempio di comando per installare un pacchetto tramite il terminale:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### Utilizzo del file WHL per installare un pacchetto

1. Per scaricare il file whl, vai alla pagina pypi del pacchetto [aspose.cad](https://pypi.org/project/aspose-cad/#files) e scarica il file<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
1. Per installare il pacchetto [aspose.cad](https://pypi.org/project/aspose-cad/), è necessario utilizzare il comando pip con il percorso completo al file whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

1. Dopo l'installazione, vedremo il pacchetto nella cartella site-package<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## Codice di esempio
Codice di esempio per convertire un file

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
