---
title: Instalacja Aspose.CAD dla Pythona
type: docs
weight: 20
url: /pl/python-net/installation/installing-aspose-cad-for-python/
---

## **Instalacja pakietu aspose-cad**

### Instalacja pakietu za pomocą pip

1. Aby zainstalować pakiet [aspose.cad](https://pypi.org/project/aspose-cad/), strony z pakietem mają dodatkowy opis polecenia, które należy wykonać w terminalu:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. Przykład polecenia do zainstalowania pakietu przez terminal:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### Instalacja pakietu za pomocą pliku WHL

1. Aby pobrać plik whl, przejdź na stronę pypi pakietu [aspose.cad](https://pypi.org/project/aspose-cad/#files) i pobierz plik<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. Aby zainstalować pakiet [aspose.cad](https://pypi.org/project/aspose-cad/), musisz użyć polecenia pip z pełną ścieżką do pliku whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. Po instalacji zobaczymy pakiet w folderze site-package<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## Przykład kodu
Przykład kodu do konwersji pliku

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
