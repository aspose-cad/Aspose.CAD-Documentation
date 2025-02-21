---
title: DWG DXF를 PDF로 변환하는 C# | Auto CAD 파일을 C# .NET에서 PDF JPEG PNG로 변환
type: docs
weight: 30
url: /ko/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG를 PDF C#, DXF를 PDF C#, DWF DWT를 PDF C#, AutoCAD 변환, DWG 변환, DWF 변환, DWT 변환, DXF 변환, AutoCAD를 pdf로 변환, DWG를 PDF로 변환, DWG를 PNG로 변환, DWG를 TIFF로 변환, DWG를 JPG로 변환"
description: C# .NET AutoCAD to PDF 변환기를 사용하여 DWG 또는 DXF를 C#에서 PDF로 변환합니다. C# .NET에서 DWG, DWF, DWT 및 DXF를 PDF, JPEG, PNG, BMP, GIF 및 TIFF로 변환할 수 있습니다.
---

## **C#에서 DWG 또는 DXF를 PNG JPEG BMP GIF 또는 TIFF로 변환**

Aspose.CAD for .NET은 [DXF](https://docs.fileformat.com/cad/dxf/) 및 [DWG](https://docs.fileformat.com/cad/dwg/)와 같은 AutoCAD 도면 형식을 [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) 및 [GIF](https://docs.fileformat.com/image/gif/)로 변환할 수 있습니다. 이를 달성하기 위해 효율적이고 사용하기 쉬운 API를 제공합니다.

아래에 설명된 간단한 단계들을 사용하여 지원되는 AutoCAD 도면 형식을 래스터 이미지 형식으로 변환할 수 있습니다.

1. [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) 클래스에 AutoCAD DWG 또는 DXF 파일을 로드합니다.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 인스턴스를 생성합니다.
1. [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 및 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)를 사용하여 이미지의 크기를 설정/변경합니다.
1. [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) 인스턴스를 생성합니다.
1. 이전 단계에서 생성된 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)로 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 속성을 설정합니다.
1. 파일 경로(또는 MemoryStream의 객체)와 함께 이전 단계에서 생성된 [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) 인스턴스를 전달하여 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save)로 AutoCAD 도면을 PDF로 저장합니다.

여기 전체 소스 코드가 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

기본적으로 API는 "Model" 레이아웃만 렌더링합니다. 그러나 CAD 도면을 이미지 형식으로 변환할 때 사용자 선택의 레이아웃도 지정할 수 있습니다.

## **CAD 변환 사용자 정의**

CAD를 [PDF](https://docs.fileformat.com/pdf/) 및 CAD를 래스터 이미지로 변환하는 절차는 매우 구성 가능하며, [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 클래스는 많은 선택적 기능을 제공하도록 구현되었습니다. 이러한 설정을 통해 응용 프로그램의 요구에 따라 렌더링 프로세스를 재정의할 수 있습니다.

### **CadRasterizationOptions 클래스**

**CadRasterizationOptions** 클래스는 DWG 및 DXF와 같은 모든 지원되는 CAD 형식에 공통적으로 사용됩니다. 따라서 이 문서에서 공유된 정보는 앞서 언급한 두 CAD 형식 모두에 유효합니다.

가장 유용한 **CadRasterizationOptions** 클래스 속성은 다음과 같습니다:

|**속성**|**기본 값**|**필수**|**설명**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|예|페이지 너비를 지정합니다.|
|**PageHeight**|**0**|예|페이지 높이를 지정합니다.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|아니오|도면이 자동으로 크기가 조정되는지 여부를 지정합니다. 기본 값은 이미지를 캔버스 크기에 맞게 자동으로 축소합니다. **GrowToFit** 모드로 전환하거나 **None** 설정을 사용하여 자동 크기 조정을 비활성화 할 수 있습니다.|
|**BackgroundColor**|**Color.White**|아니오|출력 이미지의 배경색을 지정합니다.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|아니오|엔터티의 색상화 모드를 지정합니다. 엔터티를 원래 색상으로 그리기 위해 **UseObjectColor** 옵션을 지정하거나 원래 색상을 덮어쓰려면 **UseDrawColor** 옵션을 지정합니다.|
|**DrawColor**|**Color.Black**|아니오|덮어쓴 엔터티의 색상을 지정합니다(단, **DrawType**가 **UseDrawColor** 속성 값으로 설정된 경우).|
|**AutomaticLayoutsScaling**|거짓|아니오|모델 레이아웃에 맞게 자동 레이아웃 크기 조정을 수행할지를 지정합니다.|

### **캔버스 크기 및 모드 설정**

CAD에서 PDF 또는 CAD에서 래스터 이미지 형식으로의 내보내기는 간단한 작업이 아닙니다. 결과 PDF 또는 이미지에는 캔버스 크기를 정의해야 하므로 도면을 적절하게 렌더링하기 위해 PDF 페이지의 출력 크기를 명시해야 합니다. **CadRasterizationOptions.PageWidth** 및 **CadRasterizationOptions.PageHeight** 속성을 명시적으로 설정하거나 **ImageSaveException**을 받을 수 있습니다.

또한, 크기 비율 옵션을 설정할 수 있습니다. 크기 조정 옵션은 **CadRasterizationOptions.ScaleMethod** 속성으로 설정됩니다. 이 옵션을 사용하여 **CadRasterizationOptions.PageWidth** 및 **CadRasterizationOptions.PageHeight** 값에 따라 이미지 크기를 자동으로 조정할 수 있습니다. 기본적으로 **CadRasterizationOptions.ScaleMethod**는 **ScaleType.ShrinkToFit** 모드로 설정됩니다. 이 속성은 다음 동작을 정의합니다:

- CAD 도면의 크기가 결과 캔버스 크기보다 큰 경우, 도면 크기가 가로 세로 비율을 유지하면서 결과 캔버스에 맞도록 축소됩니다.
- CAD 도면의 크기가 결과 캔버스 크기보다 작은 경우, **CadRasterizationOptions.ScaleMethod** 속성을 **ScaleType.GrowToFit**으로 설정하여 도면 크기를 PDF 캔버스에 맞추면서 가로 세로 비율을 유지할 수 있습니다.
- 또는 **ScaleType.None** 옵션으로 자동 크기 조정을 비활성화합니다.

아래 코드 샘플은 자동 크기 조정 옵션을 사용하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **배경 및 그리기 색상 설정**

기본적으로 결과 캔버스의 색상 팔레트는 일반 문서 스킴으로 설정됩니다. 즉, CAD 도면 내 모든 엔터티는 흰색 배경에 검은색 펜으로 그려집니다. 이 설정은 **CadRasterizationOptions.BackgroundColor** 및 **CadRasterizationOptions.DrawColor** 속성을 사용하여 변경할 수 있습니다. **CadRasterizationOptions.DrawColor** 속성을 변경하려면 **CadRasterizationOptions.DrawType** 속성을 설정하여 그리기 색상을 사용할 수 있도록 해야 합니다. **CadRasterizationOptions.DrawType** 속성은 CAD 엔터티가 색상을 유지하는지 사용자 정의 색상으로 변환되는지를 제어합니다. 엔터티 색상을 유지하려면 **CadRasterizationOptions.DrawType**를 **CadDrawTypeMode.UseObjectColor**로 지정하고, 그렇지 않으면 **CadDrawTypeMode.UseDrawColor** 값을 지정합니다.

아래 코드 샘플은 다양한 색상 속성을 사용하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **자동 레이아웃 크기 조정 설정**

대부분의 CAD 도면은 단일 파일에 여러 개의 레이아웃이 저장되어 있으며, 각 레이아웃은 서로 다른 크기를 가질 수 있습니다. CAD 도면을 PDF로 렌더링할 때 PDF의 각 페이지는 레이아웃 크기에 따라 서로 다른 크기를 가질 수 있습니다. 렌더링을 균일하게 만들기 위해 Aspose.CAD API는 **CadRasterizationOptions.AutomaticLayoutsScaling** 속성을 노출했습니다. 기본 값은 **false**이지만, true로 설정하면 API는 각 개별 레이아웃에 대한 해당 크기를 찾아 레이아웃 크기에 따라 자동으로 재조정 작업을 수행하여 그립니다.

다음은 **CadRasterizationOptions.AutomaticLayoutsScaling** 속성이 **CadRasterizationOptions.ScaleMethod** 속성과 협력하여 작동하는 방법입니다.

1. **ScaleMethod**가 **ScaleType.ShrinkToFit** 또는 **ScaleType.GrowToFit**로 설정되고 **AutomaticLayoutsScaling**이 false로 설정되면 모든 레이아웃(모델 포함)이 첫 번째 옵션에 따라 처리됩니다.
1. **ScaleMethod**가 **ScaleType.ShrinkToFit** 또는 **ScaleType.GrowToFit**로 설정되고 **AutomaticLayoutsScaling**이 true로 설정되면 모든 레이아웃(모델 제외)은 크기에 따라 처리되고 모델은 첫 번째 옵션에 따라 처리됩니다.
1. **ScaleMethod**가 **ScaleType.None**으로 설정되고 **AutomaticLayoutsScaling**이 true 또는 false로 설정되면 크기 조정이 수행되지 않습니다.

아래는 CAD에서 PDF로의 변환을 위한 자동 레이아웃 크기 조정을 설정하는 방법을 보여주는 코드 샘플입니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **C#에서 AutoCAD DXF 또는 DWG 레이아웃을 PNG 또는 기타 이미지 형식으로 변환**

Aspose.CAD for .NET API는 DXF 및 DWG와 같은 지원되는 형식의 CAD 레이아웃을 PNG BMP TIFF JPEG 및 GIF로 변환할 수 있습니다. API는 또한 CAD 도면의 특정 레이아웃을 다른 PSD 레이어로 렌더링하는 지원도 제공합니다.

다음 단계로 이를 달성할 수 있는 방법은 다음과 같습니다.

- **Image** 클래스를 사용하여 AutoCAD DWG 또는 DXF 파일을 로드합니다.
- 이미지의 너비와 높이를 설정/변경합니다.
- 원하는 레이아웃 이름을 CadRasterizationOptions.Layouts 속성을 사용하여 설정합니다.
- **ImageOptionsBase** 인스턴스를 생성하고 **VectorRasterizationOptions** 속성을 이전 단계에서 생성한 **CadRasterizationOptions**의 인스턴스로 설정합니다.
- CAD 레이아웃을 TIFF 또는 이미지로 저장합니다.

여기 전체 소스 코드가 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

속성 **CadRasterizationOptions.Layouts**는 문자열 배열 유형이므로 한 번에 여러 레이아웃을 지정할 수 있습니다. **CadRasterizationOptions.Layouts** 속성에 대해 여러 레이아웃을 지정할 때 결과 TIFF 이미지는 여러 페이지가 있고, GIF 이미지는 여러 프레임이 있으며, [PSD](https://docs.fileformat.com/image/psd/) 형식은 여러 레이어가 있어 각 페이지/프레임/레이어가 개별 AutoCAD 레이아웃을 나타냅니다. PNG, BMP, JPEG와 같은 다른 이미지 형식이 선택된 경우 API는 기본 레이아웃 "Model"만 렌더링합니다.

{{% /alert %}}

## **CAD 렌더링 프로세스의 추적 활성화**

Aspose.CAD는 CAD 렌더링 프로세스를 추적하기 위해 일련의 클래스와 지원 열거형 필드를 도입했습니다. 이러한 변경 사항을 통해 CAD를 PDF로 변환할 수 있으며, 추적을 활성화할 수 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

CAD 렌더링 프로세스의 추적은 다음과 같은 문제를 감지할 수 있습니다.

1. 누락되거나 손상된 헤더 정보.
1. 누락된 레이아웃 정보.
1. 누락된 블록 엔터티.
1. 누락된 치수 스타일.
1. 누락된 스타일.

## **CAD 도면을 변환할 때 글꼴 대체하기**

특정 CAD 도면이 CAD를 PDF나 래스터 이미지로 변환하는 기계에서 사용할 수 없는 특정 글꼴을 사용할 가능성이 있습니다. 이러한 경우, Aspose.CAD API는 누락된 글꼴을 강조하고 변환 프로세스를 중지하는 적절한 예외를 발생시킵니다. API는 이러한 글꼴이 결과 PDF나 이미지에 내용을 올바르게 렌더링하는 데 필요합니다.

Aspose.CAD API는 필요한 글꼴을 사용 가능한 글꼴로 대체하는 메커니즘을 사용하도록 쉽게 제공합니다. **CadImage.Styles** 속성은 CAD 도면 내 각 스타일을 위한 **CadStyleTableObject**를 포함하는 **CadStylesDictionary**의 인스턴스를 반환하며, **CadStyleTableObject.PrimaryFontName**을 사용하여 사용 가능한 글꼴 이름을 지정할 수 있습니다.

다음 코드 스니펫은 Aspose.CAD for .NET API를 사용하여 CAD 도면 내 모든 스타일의 글꼴을 변경하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

특정 스타일 이름에 접근하여 오직 하나의 특정 스타일의 글꼴만 변경하는 것도 가능합니다. 아래 코드 스니펫은 이 접근 방식을 사용하는 방법을 보여주고 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **CAD 레이어를 래스터 이미지 형식으로 변환하기**

Aspose.CAD for .NET API는 필요한 CAD 레이어의 이름을 지정하고 이를 래스터 이미지 형식으로 렌더링하는 쉽고 효율적인 방법을 제공합니다. 다음은 5개의 간단한 단계로 이를 달성할 수 있는 방법입니다.

1. **Load** 팩토리 메서드를 사용하여 CAD 파일을 **Image** 인스턴스로 로드합니다.
1. **CadRasterizationOptions**의 인스턴스를 생성하고 **PageWidth** 및 **PageHeight**와 같은 필수 속성을 설정합니다.
1. **CadRasterizationOptions.Layers.Add** 메서드를 사용하여 원하는 레이어 이름을 추가합니다.
1. **ImageOptionsBase**의 인스턴스를 생성하고 **VectorRasterizationOptions** 속성을 이전 단계에서 생성된 **CadRasterizationOptions** 인스턴스로 설정합니다.
1. 파일 경로(또는 MemoryStream의 객체)와 함께 이전 단계에서 생성된 **ImageOptionsBase**의 인스턴스를 전달하며 **Image.Save** 메서드를 호출합니다.

여기 전체 소스 코드가 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **모든 CAD 레이어를 별도의 이미지로 변환하기**

**CadImage.Layers**를 사용하여 CAD 도면 내 모든 레이어를 가져오고 각 레이어를 다음과 같이 별도의 이미지로 렌더링할 수 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **DWF CAD 레이어를 래스터 이미지 형식으로 변환하기**

Aspose.CAD for .NET API는 필요한 CAD 레이어의 이름을 지정하고 이를 래스터 이미지 형식으로 렌더링하는 쉽고 효율적인 방법을 제공합니다. 다음은 5개의 간단한 단계로 이를 달성할 수 있는 방법입니다.

1. **Load** 팩토리 메서드를 사용하여 DWF CAD 파일을 **Image** 인스턴스로 로드합니다.
1. **CadRasterizationOptions**의 인스턴스를 생성하고 **PageWidth** 및 **PageHeight**와 같은 필수 속성을 설정합니다.
1. **CadRasterizationOptions.Layers.Add** 메서드를 사용하여 원하는 레이어 이름을 추가합니다.
1. **ImageOptionsBase**의 인스턴스를 생성하고 **VectorRasterizationOptions** 속성을 이전 단계에서 생성된 **CadRasterizationOptions** 인스턴스로 설정합니다.
1. 파일 경로(또는 MemoryStream의 객체)와 함께 이전 단계에서 생성된 **ImageOptionsBase**의 인스턴스를 전달하며 **Image.Save** 메서드를 호출합니다.

여기 전체 소스 코드가 있습니다.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD for .NET는 출력 문서에 API 및 버전 번호에 대한 정보를 직접 작성합니다. 예를 들어, 문서를 PDF로 렌더링할 경우 Aspose.CAD for .NET는 응용 프로그램 필드를 'Aspose.CAD' 값으로, PDF 프로듀서 필드를 예를 들어 'Aspose.CAD v 17.10'으로 채웁니다.

이 정보를 출력 문서에서 변경하거나 제거하도록 Aspose.CAD for .NET에 지시할 수 없다는 점에 유의하시기 바랍니다.
