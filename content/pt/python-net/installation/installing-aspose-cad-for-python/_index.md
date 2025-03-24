---
title: Instalando Aspose.CAD para Python
type: docs
weight: 20
url: /pt/python-net/installation/installing-aspose-cad-for-python/
---

## **Instalação do pacote aspose-cad**

### Usando pip para instalar um pacote

1. Para instalar o pacote [aspose.cad](https://pypi.org/project/aspose-cad/), os sites com o pacote têm uma descrição adicional do comando a ser executado no terminal:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. Um exemplo de um comando para instalar um pacote através do terminal:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### Usando arquivo WHL para instalar um pacote

1. Para baixar o arquivo whl, vá até a página pypi do pacote [aspose.cad](https://pypi.org/project/aspose-cad/#files) e faça o download do arquivo<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. Para instalar o pacote [aspose.cad](https://pypi.org/project/aspose-cad/), você precisa usar o comando pip com o caminho completo para o arquivo whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. Após a instalação, veremos o pacote na pasta site-package<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## Código de exemplo
Código de exemplo para converter um arquivo

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
