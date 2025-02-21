---
title: DWF 도면
type: docs
weight: 20
url: /ko/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **DWF 도면을 PDF로 내보내기**

Aspose.CAD for Java API는 DWF 형식의 AutoCAD 도면을 로드하고 이를 PDF로 변환할 수 있습니다. 이 주제에서는 DWF를 PDF 형식으로 변환하는 Aspose.CAD API의 사용법을 간단한 단계로 설명합니다.

### **DWF 파일을 PDF로 변환하기**

DWF를 PDF로 변환하기 위해 필요한 간단한 단계는 다음과 같습니다.

1. [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 인스턴스로 DWF 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 객체를 생성하고 [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) 및 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) 속성을 설정합니다.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 클래스의 객체를 생성하고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)를 호출하면서 [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) 객체를 두 번째 매개변수로 전달합니다.

아래의 코드 샘플은 DWF 도면을 PDF로 내보내는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **DWF의 레이어 지원**

Aspose.CAD는 AutoCAD DWF 도면 엔터티를 로드하고 이를 전체 도면으로 JPG 형식으로 렌더링하는 기능을 제공합니다.

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) 팩토리 메서드를 사용하여 DWF 도면 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 객체를 생성합니다.
1. 원하는 레이어를 추가합니다.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)를 호출하면서 두 번째 매개변수로 [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) 객체를 전달합니다.

아래의 코드 샘플은 기본 설정을 사용하여 파일을 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
