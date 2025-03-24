---
title: SAT/SAB 구조를 가진 엔티티
type: docs
weight: 40
url: /ko/java/developer-guide/entities_with-sat-and-sab/
---

## **SAT/SAB 구조를 가진 엔티티**

특정 엔티티는 ACIS SAT/SAB 형식으로 구조 데이터를 저장합니다. 이러한 엔티티는 2D 와이어 프레임 모드에서 부분적으로 내보낼 수 있습니다. 지원되는 엔티티는 다음과 같습니다:

*	3DSOLID 객체: 상자, 구, 피라미드, 쐐기, 원뿔, 원기둥, 도넛, 폴리솔리드
*	SURFACE: 평면, 돌출, 회전, 스윕
*	REGION

다음은 내보내기 결과의 예입니다 (왼쪽 부분은 DWG 파일, 오른쪽 부분은 PDF 결과).

![Export of cone and spheres](/cad/_assets/guide/coneAndSpheres.png)

ACIS 엔티티를 내보내는 데 특별한 옵션이 필요하지 않습니다. 특히 도면에 ACIS 엔티티만 포함된 경우, 초기 도면 치수를 정확하게 조정하기 위해 cadImage.updateSize() 함수를 사용하는 것을 고려하십시오.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
