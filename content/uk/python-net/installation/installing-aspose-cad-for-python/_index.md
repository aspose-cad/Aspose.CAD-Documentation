---
title: Встановлення Aspose.CAD для Python
type: docs
weight: 20
url: /uk/python-net/installation/installing-aspose-cad-for-python/
---

## **Встановлення пакета aspose-cad**

### Використання pip для встановлення пакета

1. Щоб встановити пакет [aspose.cad](https://pypi.org/project/aspose-cad/), сайти з пакетом мають додатковий опис команди, яку потрібно виконати в терміналі:<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
1. Приклад команди для встановлення пакета через термінал:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### Використання WHL файлу для встановлення пакета

1. Щоб завантажити файл whl, перейдіть на сторінку pypi пакета [aspose.cad](https://pypi.org/project/aspose-cad/#files) та завантажте файл<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
1. Щоб встановити пакет [aspose.cad](https://pypi.org/project/aspose-cad/), потрібно використовувати команду pip з повним шляхом до файлу whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

1. Після встановлення ми побачимо пакет у папці site-package<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## Приклад коду
Приклад коду для конвертації файлу

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
