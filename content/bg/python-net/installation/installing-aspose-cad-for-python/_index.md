---
title: Инсталиране на Aspose.CAD за Python
type: docs
weight: 20
url: /bg/python-net/installation/installing-aspose-cad-for-python/
---

## **Инсталиране на пакета Aspose.CAD**

### Използване на pip за инсталиране на пакет

1. За да инсталирате пакета [aspose.cad](https://pypi.org/project/aspose-cad/), сайтовете с пакета имат допълнително описание на командата, която трябва да се изпълни в терминала:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. Пример за команда за инсталиране на пакет чрез терминала:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### Използване на WHL файл за инсталиране на пакет

1. За да изтеглите whl файла, отидете на страницата на pypi на пакета [aspose.cad](https://pypi.org/project/aspose-cad/#files) и го изтеглете<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. За да инсталирате пакета [aspose.cad](https://pypi.org/project/aspose-cad/), трябва да използвате pip командата с пълния път до whl файла:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. След инсталирането, ще видим пакета в папката site-package<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## Примерен код
Примерен код за конвертиране на файл

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
