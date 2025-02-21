---
title: 安装 Aspose.CAD for Python
type: docs
weight: 20
url: /zh/python-net/installation/installing-aspose-cad-for-python/
---

## **aspose-cad 软件包的安装**

### 使用 pip 安装软件包

1. 要安装 [aspose.cad](https://pypi.org/project/aspose-cad/) 软件包，网站上有关于在终端中执行的命令的附加说明：<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
1. 通过终端安装软件包的命令示例：
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### 使用 WHL 文件安装软件包

1. 要下载 whl 文件，访问 [aspose.cad](https://pypi.org/project/aspose-cad/#files) 软件包的 pypi 页面并下载文件<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
1. 要安装 [aspose.cad](https://pypi.org/project/aspose-cad/) 软件包，您需要使用 pip 命令和 whl 文件的完整路径：
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

1. 安装完成后，我们将在 site-package 文件夹中看到该软件包<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## 示例代码
转换文件的示例代码

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
