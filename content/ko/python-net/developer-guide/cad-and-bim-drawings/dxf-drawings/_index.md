---
title: DXF 도면
type: docs
weight: 10
url: /ko/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **DXF 도면을 PDF로 내보내기**

Aspose.CAD는 AutoCAD DXF 도면 엔티티를 로드하고 이를 PDF 형식으로 전체 도면으로 렌더링하는 기능을 제공합니다. DXF에서 PDF로 변환하는 방법은 다음과 같습니다:

1. **Image.load** 팩토리 메서드를 사용하여 DXF 도면 파일을 로드합니다.
1. **CadRasterizationOptions** 클래스의 객체를 생성하고 **page_height** 및 **page_width** 속성을 설정합니다.
1. **PdfOptions** 클래스의 객체를 생성하고 **VectorRasterizationOptions** 속성을 설정합니다.
1. **Image.save**를 호출하면서 **PdfOptions** 객체를 두 번째 매개변수로 전달합니다.

아래의 코드 샘플은 기본 설정을 사용하여 파일을 변환하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **지원하는 형식**

현재 우리가 완전히 지원하는 AutoCAD DXF 2010 파일 형식입니다. 이전 DXF 버전은 100% 유효성을 보장하지 않습니다. 향후 Aspose.CAD 버전에서 더 많은 형식과 기능을 포함할 계획입니다.

### **지원하는 엔티티**

현재 우리는 모든 일반적인 2D 엔티티와 그 기본 기본 매개변수를 지원합니다:

1. 정렬된 치수
1. 각도 치수
1. 호
1. 속성
1. 블록 참조
1. 원
1. 지름 치수
1. 타원
1. 해치
1. 선
1. 다중선 텍스트
1. 좌표 치수
1. 점
1. 폴리라인
1. 방사형 치수
1. 광선
1. 회전된 치수
1. 테이블
1. 텍스트
1. X선

{{% alert color="primary" %}}

파싱 중에 지원하지 않는 엔티티 또는 속성을 만나면 해당 엔티티 또는 속성은 조용히 무시됩니다.

{{% /alert %}}

## **DXF 형식의 DGN 언더레이 내보내기**

Aspose.CAD는 AutoCAD DXF 파일을 로드하고 DXF 형식에 대한 내장된 DGN 언더레이를 내보내는 기능을 제공합니다.

아래의 코드 샘플은 지정된 요구사항을 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **DXF 파일 저장 지원**

Aspose.CAD는 AutoCAD DXF 파일을 로드하고 변경 사항을 적용한 후 다시 DXF 파일로 저장하는 기능을 제공합니다.

아래의 코드 샘플은 지정된 요구 사항을 달성하는 방법을 보여줍니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **DXF에서 WMF로 내보내기**

이 방법은 다음과 같이 작동합니다:

1. **Image.load** 팩토리 메서드를 사용하여 DXF 도면 파일을 로드합니다.
1. **CadRasterizationOptions** 클래스의 객체를 생성하고 PDF 파일을 로드합니다.
1. **page_height** 및 **page_width** 속성을 설정합니다.
1. **Image.save**를 호출하여 파일을 저장합니다.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
