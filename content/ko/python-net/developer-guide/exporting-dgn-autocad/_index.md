---
title: DGN AutoCAD 내보내기
type: docs
weight: 50
url: /ko/python-net/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD 형식을 PDF로 내보내기**

Aspose.CAD for Python API는 DGN AutoCAD 파일을 로드하고 PDF 형식으로 변환하는 기능을 도입했습니다. **CadImage** 클래스가 이 목적을 수행합니다.

기존의 DGN 파일을 **CadImage**로 로드해야 합니다. **CadRasterizationOptions** 클래스의 인스턴스를 만들고 다양한 속성을 설정합니다. **PdfOptions** 클래스의 인스턴스를 만들고 **CadRasterizationOptions** 인스턴스를 전달합니다. 이제 **CadImage** 클래스 인스턴스의 **save** 메서드를 호출합니다.

### 샘플 코드

다음은 [DGN](https://docs.fileformat.com/cad/dgn/)을 [PDF](https://docs.fileformat.com/pdf/) 형식으로 변환/내보내기 위한 코드 데모입니다.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **DGN AutoCAD 형식을 래스터 이미지 형식으로 내보내기**

Aspose.CAD for Python API는 DGN AutoCAD 파일을 로드하고 래스터 이미지로 변환하는 기능을 도입했습니다. **CadImage** 클래스가 이 목적을 수행합니다.

기존의 DGN 파일을 **CadImage**로 로드해야 합니다. **CadRasterizationOptions** 클래스의 인스턴스를 만들고 다양한 속성을 설정합니다. **JpegOptions** 클래스의 인스턴스를 만들고 **CadRasterizationOptions** 인스턴스를 전달합니다. 이제 **CadImage** 클래스 인스턴스의 **save** 메서드를 호출합니다.

### 샘플 코드

다음은 [DGN](https://docs.fileformat.com/cad/dgn/)을 [JPEG](https://docs.fileformat.com/image/jpeg/) 이미지로 변환/내보내기 위한 코드 데모입니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **DGN v7에 대한 3D 엔터티 지원**

Aspose.CAD for Python API는 [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD 파일을 로드하고 DGN v7에 대한 3D 엔터티를 지원하는 기능을 도입했습니다. **CadImage** 클래스가 이 목적을 수행합니다. 각 [DGN](https://docs.fileformat.com/cad/dgn/) 이미지는 9개의 미리 정의된 뷰를 지원합니다. 이는 1에서 9까지 열거됩니다. 내보내기 시 뷰가 정의되지 않은 경우, 다중 페이지 출력 형식(예: PDF)의 경우 모든 뷰가 내보내지며 각 뷰는 별도의 페이지에 배치됩니다. DGN 파일 형식에서 3D 엔터티가 지원되며 2D도 지원됩니다. 이를 위해 **VectorRasterizationOptions**가 사용되며, DGN 형식에서는 더 이상 TypeOfEntities가 사용되지 않습니다(2D와 3D가 동시에 지원됨).

### 샘플 코드

다음은 지원되는 DGN 요소를 확인하기 위한 샘플 코드입니다.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
