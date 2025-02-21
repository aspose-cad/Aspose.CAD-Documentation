---  
title: DRC 도면  
type: docs  
weight: 15  
url: /ko/net/developer-guide/cad-and-bim-drawings/drc-drawings/  
---  

## **DRC 도면을 PDF로 내보내기**  

Aspose.CAD는 AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) 도면 엔티티를 로드하고 이를 전체 도면으로 [PDF](https://docs.fileformat.com/pdf/) 형식으로 렌더링하는 기능을 제공합니다. [DRC](https://docs.fileformat.com/3d/drc/)에서 [PDF](https://docs.fileformat.com/pdf/)로의 변환 방법은 다음과 같습니다:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 팩토리 메서드를 사용하여 [DRC](https://docs.fileformat.com/3d/drc/) 도면 파일을 로드합니다.  
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스의 객체를 만들고 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 및 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 속성을 설정합니다.  
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 클래스의 객체를 만들고 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 속성을 설정합니다.  
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)를 호출하고 두 번째 매개변수로 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 객체를 전달합니다.  

### 샘플 코드  

아래의 코드 샘플은 기본 설정을 사용하여 파일을 변환하는 방법을 보여줍니다.  

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
