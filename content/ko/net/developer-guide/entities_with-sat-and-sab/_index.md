---
title: SAT/SAB 구조의 엔티티
type: docs
weight: 40
url: /ko/net/developer-guide/entities_with-sat-and-sab/
---

## **SAT/SAB 구조의 엔티티**

특정 엔티티는 ACIS SAT/SAB 형식으로 구조 데이터를 저장합니다. 이러한 엔티티는 2D 와이어프레임 모드로 부분적으로 내보낼 수 있습니다. 지원되는 엔티티는 다음과 같습니다:

* 3DSOLID 객체: 상자, 구, 피라미드, 쐐기, 원뿔, 실린더, 토러스, 폴리솔리드
* SURFACE: 평면, 압출, 회전, 스윕
* REGION

아래는 내보내기 결과의 예시입니다 (왼쪽 부분에 DWG 파일, 오른쪽에 PDF 결과).

![Export of cone and spheres](/_assets/guide/coneAndSpheres.png)

ACIS 엔티티를 내보내기 위해 특별한 옵션이 필요하지 않습니다. 특히 도면이 ACIS 엔티티만 포함하는 경우 도면 크기를 최적화하려면 cadImage.UpdateSize() 함수를 사용하여 초기 도면 치수를 정확하게 조정하는 것을 고려하세요.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "모델" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
