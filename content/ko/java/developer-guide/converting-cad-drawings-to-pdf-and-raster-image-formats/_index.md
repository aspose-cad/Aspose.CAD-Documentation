---
title: CAD 도면을 PDF 및 래스터 이미지 포맷으로 변환하기
type: docs
weight: 30
url: /ko/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java는 출력 문서에 API 및 버전 번호에 대한 정보를 직접 기록합니다. 예를 들어, 문서를 PDF로 렌더링할 때, Aspose.CAD for Java는 응용 프로그램 필드를 'Aspose.CAD'로 설정하고 PDF Producer 필드를 'Aspose.CAD v 17.9'와 같은 값으로 채웁니다.

Aspose.CAD for Java에 이 정보를 출력 문서에서 변경하거나 제거하도록 요청할 수 없다는 점에 유의하세요.

{{% /alert %}} 
## **CAD 도면을 래스터 이미지 포맷으로 변환하기**
Aspose.CAD for Java는 다음과 같은 지원되는 래스터 이미지 포맷으로 글을 변환할 수 있는 CAD 도면 형식인 [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/)를 지원합니다 [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). Aspose.CAD for Java API는 이 목표를 달성하기 위한 효율적이고 사용하기 쉬운 수단을 제공합니다.
지원되는 모든 CAD 도면 형식을 래스터 이미지 포맷으로 변환할 수 있는 간단한 단계는 아래에 설명되어 있습니다.

1. CAD 파일을 [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) 인스턴스에 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 인스턴스를 만들고 [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-)와 같은 필수 속성을 설정합니다.
1. **ImageOptionsBase** 인스턴스를 만들고 이전 단계에서 생성된 **CadRasterizationOptions** 인스턴스로 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) 속성을 설정합니다.
1. **Image.save**를 호출하여 파일 경로(또는 MemoryStream 객체)와 이전 단계에서 생성된 **ImageOptionsBase** 인스턴스를 전달합니다.

여기 전체 소스 코드가 있습니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



기본적으로 API는 "모델" 레이아웃만 렌더링합니다. 그러나 CAD 도면을 이미지 포맷으로 변환할 때 원하는 레이아웃을 지정할 수도 있습니다.
## **CAD 변환 사용자 정의**
CAD에서 [PDF](https://docs.fileformat.com/pdf/) 및 CAD에서 래스터 이미지 변환 절차는 매우 구성 가능하며, [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스는 설치하면 응용 프로그램 요구 사항에 따라 렌더링 프로세스를 오버라이드할 수 있는 많은 선택적 기능을 제공합니다.
### **CadRasterizationOptions 클래스**
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) 클래스는 [**DWG**](https://docs.fileformat.com/cad/dwg/) 및 [DXF](https://docs.fileformat.com/cad/dxf/)와 같은 모든 지원되는 CAD 형식에서 공통됩니다. 이 기사에서 공유된 정보는 위에서 언급한 두 CAD 형식에 유효합니다.

가장 유용한 **CadRasterizationOptions** 클래스 속성은 다음과 같습니다:

|**속성**|**기본값**|**필수**|**설명**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|예|페이지 너비를 지정합니다.|
|**PageHeight**|**0**|예|페이지 높이를 지정합니다.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|아니오|도면이 자동으로 크기 조정되어야 하는지 여부를 지정합니다. 기본값은 이미지를 캔버스 크기에 맞추기 위해 자동으로 줄입니다. **GrowToFit** 모드로 전환하거나 **None** 설정을 사용하여 자동 크기 조정을 비활성화합니다.|
|**BackgroundColor**|**Color.White**|아니오|출력 이미지의 배경 색상을 지정합니다.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|아니오|개체의 색상화 모드를 지정합니다. **UseObjectColor** 옵션을 지정하여 개체를 원래 색상으로 그리고, **UseDrawColor** 옵션을 사용하여 원래 색상을 오버라이드합니다.|
|**DrawColor**|**Color.Black**|아니오|오버라이드된 개체의 색상을 지정합니다(단, **DrawType**이 **UseDrawColor** 속성 값으로 설정된 경우에만 해당).|
|**AutomaticLayoutsScaling**|False|아니오|모델 레이아웃에 맞춰 자동 레이아웃 크기 조정이 수행되어야 하는지 여부를 지정합니다.|
### **캔버스 크기 및 모드 설정**
CAD에서 PDF 또는 CAD에서 래스터 이미지 포맷으로의 내보내기는 단순한 작업이 아닙니다. 결과 PDF 또는 이미지가 올바르게 도면을 렌더링하기 위해 캔버스 크기를 정의해야 하므로, 도면을 올바르게 렌더링하기 위한 PDF 페이지의 출력 치수를 지정해야 합니다. **CadRasterizationOptions.PageWidth** 및 **CadRasterizationOptions.PageHeight** 속성을 명시적으로 설정해야 하며, 그렇지 않으면 **ImageSaveException**을 받을 수 있습니다.

또한 치수 비율 옵션을 지정할 수 있습니다. 크기 조정 옵션은 **CadRasterizationOptions.ScaleMethod** 속성에 의해 설정됩니다. 이 옵션을 사용하여 **CadRasterizationOptions.PageWidth** 및 **CadRasterizationOptions.PageHeight** 값에 따라 이미지 크기를 자동으로 조정합니다. 기본적으로 **CadRasterizationOptions.ScaleMethod**는 **ScaleType.ShrinkToFit** 모드로 설정됩니다. 이 속성은 다음 동작을 정의합니다:

- CAD 도면의 치수가 결과 캔버스 크기보다 크면, 도면의 치수가 비율을 유지하면서 결과 캔버스에 맞게 줄어듭니다.
- CAD 도면의 치수가 결과 캔버스 크기보다 작으면, **CadRasterizationOptions.ScaleMethod** 속성을 **ScaleType.GrowToFit**로 설정하여 도면 크기를 증가시켜 PDF 캔버스에 맞추게 하고 비율을 유지합니다.
- 또는 **ScaleType.None** 옵션으로 자동 크기 조정을 비활성화합니다.

아래의 코드 샘플은 자동 크기 조정 옵션을 사용하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **배경 및 도면 색상 설정**
기본적으로 결과 캔버스의 색상 팔레트는 공통 문서 스킴으로 설정되어 있습니다. 즉, CAD 도면 내부의 모든 개체는 고체 흰색 배경에 검은색 펜으로 그려집니다. 이러한 설정은 **CadRasterizationOptions.BackgroundColor** 및 **CadRasterizationOptions.DrawColor** 속성을 사용하여 변경할 수 있습니다. **CadRasterizationOptions.DrawColor** 속성을 변경하면 **CadRasterizationOptions.DrawType** 속성도 설정해야 하므로 색상 사용을 가능하게 해야 합니다. **CadRasterizationOptions.DrawType** 속성은 CAD 개체가 색상을 유지할 것인지 또는 사용자 정의 색상으로 변환될 것인지를 제어합니다. 개체 색상을 유지하려면 **CadRasterizationOptions.DrawType**를 **CadDrawTypeMode.UseObjectColor**로 지정하고, 그렇지 않으면 **CadDrawTypeMode.UseDrawColor** 값을 지정합니다.

아래의 코드 샘플은 다양한 색상 속성을 사용하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **자동 레이아웃 크기 조정 설정**
대부분의 CAD 도면은 단일 파일에 여러 개의 레이아웃을 저장하고 있으며 각 레이아웃은 다른 치수를 가질 수 있습니다. 이러한 CAD 도면을 PDF로 렌더링할 때 각 페이지는 레이아웃 크기에 따라 서로 다른 크기로 조정될 수 있습니다. 렌더링을 균일하게 만들기 위해 Aspose.CAD API는 **CadRasterizationOptions.AutomaticLayoutsScaling** 속성을 노출했습니다. 기본값은 **false**이지만 true로 설정하면 API는 각 개별 레이아웃에 해당하는 크기를 찾고 페이지 크기에 따라 자동 리사이즈 작업을 수행하여 그에 맞게 스케치합니다.

**CadRasterizationOptions.AutomaticLayoutsScaling** 속성이 **CadRasterizationOptions.ScaleMethod** 속성과 협력하여 어떻게 작동하는지 설명합니다.

1. **ScaleMethod**가 **ScaleType.ShrinkToFit** 또는 **ScaleType.GrowToFit**으로 설정되고 **AutomaticLayoutsScaling**이 false로 설정된 경우 모든 레이아웃(모델 포함)은 첫 번째 옵션에 따라 처리됩니다.
1. **ScaleMethod**가 **ScaleType.ShrinkToFit** 또는 **ScaleType.GrowToFit**으로 설정되고 **AutomaticLayoutsScaling**이 true로 설정된 경우 모든 레이아웃(모델 제외)은 각 레이아웃의 크기에 따라 처리되고 모델은 첫 번째 옵션에 따라 처리됩니다.
1. **ScaleMethod**가 **ScaleType.None**으로 설정되고 **AutomaticLayoutsScaling**이 true 또는 false로 설정된 경우 크기 조정이 수행되지 않습니다.

아래의 코드 샘플은 CAD에서 PDF 변환을 위한 자동 레이아웃 크기 조정을 설정하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **CAD 레이아웃을 래스터 이미지 포맷으로 변환하기**
Aspose.CAD for Java API는 지원되는 형식인 DXF 및 DWG의 CAD 레이아웃을 PNG, BMP, TIFF, JPEG 및 GIF와 같은 래스터 이미지로 변환할 수 있는 효율적이고 사용하기 쉬운 수단을 제공합니다. API는 또한 CAD 도면의 특정 레이아웃을 다른 PSD 레이어로 렌더링하는 것을 지원합니다.
Aspose.CAD for Java API는 필요한 CAD 레이아웃의 목록을 지정하고 이를 래스터 이미지 포맷으로 렌더링하기 위한 효율적이고 사용하기 쉬운 방법을 제공합니다. 다음은 5개의 간단한 단계로 이를 달성하는 방법입니다.

1. 공장 메서드 **load**를 사용하여 CAD 파일을 **Image**의 인스턴스에 로드합니다.
1. **CadRasterizationOptions** 인스턴스를 생성하고 **PageWidth** 및 **PageHeight**와 같은 필수 속성을 설정합니다.
1. CadRasterizationOptions.Layouts 속성을 사용하여 원하는 레이아웃 이름을 지정합니다.
1. **ImageOptionsBase**의 인스턴스를 생성하고 이전 단계에서 생성된 **CadRasterizationOptions** 인스턴스로 **VectorRasterizationOptions** 속성을 설정합니다.
1. 파일 경로(또는 MemoryStream 객체)와 이전 단계에서 생성된 **ImageOptionsBase** 인스턴스를 전달하여 **Image.Save**를 호출합니다.

여기 전체 소스 코드가 있습니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

**CadRasterizationOptions.Layouts** 속성은 문자열 배열 형식이므로 시간에 여러 개의 레이아웃을 지정할 수 있습니다. **CadRasterizationOptions.Layouts** 속성에 대해 여러 개의 레이아웃을 지정할 때, 결과 TIFF 이미지는 여러 페이지, GIF 이미지는 여러 프레임 및 PSD 형식은 여러 레이어를 갖게 되며 각 페이지/프레임/레이어는 개별 AutoCAD 레이아웃을 나타냅니다. PNG, BMP, JPEG와 같은 다른 이미지 형식을 선택하여 결과를 저장하는 경우, API는 기본 레이아웃 즉 "모델"만 렌더링합니다.

{{% /alert %}} 
## **CAD 렌더링 프로세스 추적 활성화**
Aspose.CAD는 CAD 렌더링 프로세스 추적을 지원하기 위한 일련의 클래스와 지원 열거형 필드를 도입했습니다. 이러한 변경 사항이 적용되면 CAD에서 PDF로의 변환은 추적을 활성화하면서 다음과 같이 수행할 수 있습니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



CAD 렌더링 프로세스의 추적은 다음과 같은 가능한 문제를 감지할 수 있습니다.

1. 누락되거나 손상된 헤더 정보.
1. 누락된 레이아웃 정보.
1. 누락된 블록 개체.
1. 누락된 치수 스타일.
1. 누락된 스타일.
## **CAD 도면 변환 시 글꼴 대체**
특정 CAD 도면에서 사용되는 특정 글꼴이 CAD에서 PDF 또는 CAD에서 래스터 이미지 변환이 이루어지는 머신에서 사용할 수 없을 가능성이 있습니다. 이러한 상황에서 Aspose.CAD API는 누락된 글꼴을 강조하고 변환 프로세스를 중단하는 적절한 예외를 트리거합니다. API는 이러한 글꼴이 결과 PDF 및/또는 이미지에 제대로 내용을 렌더링하는 데 필요합니다.
Aspose.CAD API는 필요한 글꼴을 사용 가능한 글꼴로 대체하는 메커니즘을 쉽게 사용할 수 있는 방법을 제공합니다. **CadImage.Styles** 속성은 CAD 도면에 대한 각 스타일의 **CadStyleTableObject**를 포함하는 **CadStylesDictionary** 인스턴스를 반환합니다. 여기서 **CadStyleTableObject.PrimaryFontName**는 사용 가능한 글꼴 이름을 지정하는 데 사용할 수 있습니다.

다음 코드 스니펫은 CAD 도면의 모든 스타일의 글꼴을 변경하기 위한 Aspose.CAD for Java API 사용법을 보여줍니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




특정 스타일의 글꼴만 변경하는 것도 가능합니다. 이러한 접근 방식을 사용하는 방법을 보여주는 코드 스니펫은 다음과 같습니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **CAD 레이어를 래스터 이미지 포맷으로 변환하기**
Aspose.CAD for Java API는 필요한 CAD 레이어의 이름을 지정하고 이를 래스터 이미지 포맷으로 렌더링하기 위한 효율적이고 사용하기 쉬운 수단을 제공합니다. 다음은 5개의 간단한 단계로 이를 달성하는 방법입니다.

1. 공장 메서드 **load**를 사용하여 CAD 파일을 **Image**의 인스턴스에 로드합니다.
1. **CadRasterizationOptions** 인스턴스를 생성하고 **PageWidth** 및 **PageHeight**와 같은 필수 속성을 설정합니다.
1. **CadRasterizationOptions.Layers.add** 메서드를 사용하여 원하는 레이어 이름을 추가합니다.
1. **ImageOptionsBase**의 인스턴스를 생성하고 이전 단계에서 생성된 **CadRasterizationOptions** 인스턴스의 **VectorRasterizationOptions** 속성을 설정합니다.
1. 파일 경로(또는 MemoryStream 객체)와 이전 단계에서 생성된 **ImageOptionsBase** 인스턴스를 전달하여 **Image.save** 메서드를 호출합니다.

여기 전체 소스 코드가 있습니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **모든 CAD 레이어를 별도의 이미지로 변환하기**
**CadImage.Layers**를 사용하여 CAD 도면에서 모든 레이어를 가져오고 각 레이어를 개별 이미지로 렌더링할 수 있습니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **DWF CAD 레이어를 래스터 이미지 포맷으로 변환하기**
Aspose.CAD for Java API는 필요한 CAD 레이어의 이름을 지정하고 이를 래스터 이미지 포맷으로 렌더링하기 위한 효율적이고 사용하기 쉬운 수단을 제공합니다. 다음은 5개의 간단한 단계로 이를 달성하는 방법입니다.

1. DWF CAD 파일을 **Image**의 인스턴스에 로드하기 위해 공장 메서드 **Load**를 사용합니다.
1. **CadRasterizationOptions** 인스턴스를 생성하고 **PageWidth** 및 **PageHeight**와 같은 필수 속성을 설정합니다.
1. **CadRasterizationOptions.Layers.Add** 메서드를 사용하여 원하는 레이어 이름을 추가합니다.
1. **ImageOptionsBase**의 인스턴스를 생성하고 이전 단계에서 생성된 **CadRasterizationOptions** 인스턴스의 **VectorRasterizationOptions** 속성을 설정합니다.
1. 파일 경로(또는 MemoryStream 객체)와 이전 단계에서 생성된 **ImageOptionsBase** 인스턴스를 전달하여 **Image.Save** 메서드를 호출합니다.

여기 전체 소스 코드가 있습니다.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
