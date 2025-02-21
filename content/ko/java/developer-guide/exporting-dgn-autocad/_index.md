---
title: DGN 오토캐드 내보내기
type: docs
weight: 50
url: /ko/java/developer-guide/exporting-dgn-autocad/
---

## **DGN 오토캐드 형식을 PDF로 내보내기**

Aspose.CAD for Java API는 [DGN](https://docs.fileformat.com/cad/dgn/) 오토캐드 파일을 로드하고 [PDF](https://docs.fileformat.com/pdf/) 형식으로 변환하는 기능을 도입했습니다. [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) 클래스가 이 목적을 제공합니다.

기존 DGN 파일을 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)로 로드해야 합니다. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 인스턴스를 생성하고 다양한 속성을 설정합니다. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) 클래스의 인스턴스를 생성하고 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 인스턴스를 전달합니다. 이제 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) 클래스 인스턴스의 [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메서드를 호출합니다.

### 샘플 코드

다음은 DGN을 PDF 형식으로 변환/내보내는 코드 예제입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **DGN 오토캐드 형식을 래스터 이미지 형식으로 내보내기**

Aspose.CAD for Java API는 [DGN](https://docs.fileformat.com/cad/dgn/) 오토캐드 파일을 로드하고 래스터 이미지로 변환하는 기능을 도입했습니다. [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) 클래스가 이 목적을 제공합니다.

기존 DGN 파일을 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)로 로드해야 합니다. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스의 인스턴스를 생성하고 다양한 속성을 설정합니다. [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) 클래스의 인스턴스를 생성하고 [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 인스턴스를 전달합니다. 이제 [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) 클래스 인스턴스의 [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) 메서드를 호출합니다.

### 샘플 코드

다음은 [DGN](https://docs.fileformat.com/cad/dgn/)을 [JPEG](https://docs.fileformat.com/image/jpeg/) 이미지로 변환/내보내는 코드 예제입니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
