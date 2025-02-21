---
title: Aspose.CAD for Python 설치
type: docs
weight: 20
url: /ko/python-net/installation/installing-aspose-cad-for-python/
---

## **aspose-cad 패키지 설치**

### pip를 사용하여 패키지 설치하기

1. [aspose.cad](https://pypi.org/project/aspose-cad/) 패키지를 설치하려면, 패키지가 있는 사이트에서 터미널에서 실행할 명령에 대한 추가 설명을 확인하십시오:<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
1. 터미널을 통해 패키지를 설치하는 명령의 예:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### WHL 파일을 사용하여 패키지 설치하기

1. whl 파일을 다운로드하려면 [aspose.cad](https://pypi.org/project/aspose-cad/#files) 패키지의 pypi 페이지로 가서 파일을 다운로드하십시오<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
1. [aspose.cad](https://pypi.org/project/aspose-cad/) 패키지를 설치하려면, whl 파일의 전체 경로와 함께 pip 명령을 사용해야 합니다:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

1. 설치 후, site-package 폴더에서 패키지를 확인할 수 있습니다<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## 예제 코드
파일 변환을 위한 예제 코드

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
