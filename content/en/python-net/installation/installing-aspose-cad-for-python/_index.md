---
title: Installing Aspose.CAD for Python
type: docs
weight: 20
url: /python-net/installing-aspose-cad-for-python/
---

## **Installation of the aspose-cad package**

### Using pip to install a package

1. To install the [aspose.cad](https://pypi.org/project/aspose-cad/) package, the sites with the package have an additional description of the command to be executed in the terminal:<br/>
![pypi-install](/_assets/pypi-aspose-cad.png)
1. An example of a command to install a package through the terminal:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/pip-install-aspose.png)

### Using WHL file to install a package

1. To download the whl file, go to the pypi page of the [aspose.cad](https://pypi.org/project/aspose-cad/#files) package and download the file<br/>
![whl-download](/_assets/download-whl-file.png)<br/>
1. To install the [aspose.cad](https://pypi.org/project/aspose-cad/) package, you need to use the pip command with the full path to the whl file:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/install-whl-file-terminal.png)

1. After the installation, we will see the package in the site-package folder<br/>
![site-package-aspose-cad](/_assets/site-package-aspose.png)

## Example code
Example code for converting a file

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
