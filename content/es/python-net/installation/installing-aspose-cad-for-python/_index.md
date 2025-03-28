---
title: Instalación de Aspose.CAD para Python
type: docs
weight: 20
url: /es/python-net/installation/installing-aspose-cad-for-python/
---

## **Instalación del paquete aspose-cad**

### Usando pip para instalar un paquete

1. Para instalar el paquete [aspose.cad](https://pypi.org/project/aspose-cad/), los sitios con el paquete tienen una descripción adicional del comando que se debe ejecutar en la terminal:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. Un ejemplo de un comando para instalar un paquete a través de la terminal:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### Usando un archivo WHL para instalar un paquete

1. Para descargar el archivo whl, ve a la página pypi del paquete [aspose.cad](https://pypi.org/project/aspose-cad/#files) y descarga el archivo<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. Para instalar el paquete [aspose.cad](https://pypi.org/project/aspose-cad/), necesitas usar el comando pip con la ruta completa al archivo whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. Después de la instalación, veremos el paquete en la carpeta site-package<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## Código de ejemplo
Código de ejemplo para convertir un archivo

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
