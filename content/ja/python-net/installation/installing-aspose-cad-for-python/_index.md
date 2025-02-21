---
title: Aspose.CADをPythonにインストールする
type: docs
weight: 20
url: /ja/python-net/installation/installing-aspose-cad-for-python/
---

## **aspose-cadパッケージのインストール**

### pipを使用してパッケージをインストールする

1. [aspose.cad](https://pypi.org/project/aspose-cad/)パッケージをインストールするためには、パッケージのサイトにターミナルで実行されるコマンドの追加説明があります:<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
2. ターミナルを通じてパッケージをインストールするためのコマンドの例:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### WHLファイルを使用してパッケージをインストールする

1. whlファイルをダウンロードするには、[aspose.cad](https://pypi.org/project/aspose-cad/#files)パッケージのpypiページに行き、ファイルをダウンロードします<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
2. [aspose.cad](https://pypi.org/project/aspose-cad/)パッケージをインストールするには、whlファイルへのフルパスを含むpipコマンドを使用する必要があります:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

3. インストール後、site-packageフォルダーにパッケージが見えるようになります<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## サンプルコード
ファイルを変換するためのサンプルコード

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
