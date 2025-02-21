---
title: Установка Aspose.CAD для Python
type: docs
weight: 20
url: /ru/python-net/installation/installing-aspose-cad-for-python/
---

## **Установка пакета aspose-cad**

### Использование pip для установки пакета

1. Чтобы установить пакет [aspose.cad](https://pypi.org/project/aspose-cad/), на сайтах с пакетом имеется дополнительное описание команды, которую необходимо выполнить в терминале:<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
2. Пример команды для установки пакета через терминал:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### Использование WHL файла для установки пакета

1. Чтобы скачать whl файл, перейдите на страницу pypi пакета [aspose.cad](https://pypi.org/project/aspose-cad/#files) и скачайте файл<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
2. Чтобы установить пакет [aspose.cad](https://pypi.org/project/aspose-cad/), нужно использовать команду pip с полным путем к whl файлу:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

3. После установки мы увидим пакет в папке site-package<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## Пример кода
Пример кода для конвертации файла

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
