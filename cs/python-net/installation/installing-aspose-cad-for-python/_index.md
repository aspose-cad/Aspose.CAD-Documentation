---
title: Instalace Aspose.CAD pro Python
type: docs
weight: 20
url: /cs/python-net/instalace-aspose-cad-pro-python/
---

## **Instalace balíčku aspose-cad**

### Použití nástroje pip k instalaci balíčku

1. Pro instalaci balíčku [aspose.cad](https://pypi.org/project/aspose-cad/) jsou na stránkách s balíčkem k dispozici další informace o příkazu, který je třeba spustit v terminálu:<br/>
![pypi-install](pypi-aspose-cad.png)
1. Příklad příkazu pro instalaci balíčku prostřednictvím terminálu:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](pip-install-aspose.png)

### Použití WHL souboru k instalaci balíčku

1. Pro stažení souboru WHL přejděte na stránku pypi balíčku [aspose.cad](https://pypi.org/project/aspose-cad/#files) a stáhněte soubor<br/>
![whl-download](download-whl-file.png)<br/>
1. Pro instalaci balíčku [aspose.cad](https://pypi.org/project/aspose-cad/) je třeba použít příkaz pip s úplnou cestou k souboru WHL:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](install-whl-file-terminal.png)

1. Po instalaci uvidíme balíček ve složce site-package<br/>
![site-package-aspose-cad](site-package-aspose.png)

## Příklad kódu
Příklad kódu pro konverzi souboru

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
