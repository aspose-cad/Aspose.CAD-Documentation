---
title: 측정
type: docs
weight: 40
url: /ko/net/developer-guide/measurements/
---

## **면적 및 길이 측정**

특정 엔티티는 면적 및 길이(둘레) 계산을 지원합니다: 원, 타원, 호 및 LWPOLYLINE. 추가로, POLYLINE 엔티티는 면적이 아닌 길이 계산을 지원합니다. 다른 엔티티는 NotImplementedException을 발생시킵니다.

면적과 길이를 계산하는 방법의 예는 다음과 같습니다:

```csharp
using (CadImage cadImage = (CadImage)Aspose.CAD.Image.Load(sourceFilePath))
{
     foreach (CadEntityBase eb in cadImage.Entities)
     {
         try
         {
             System.Console.WriteLine(eb.TypeName + " " + eb.Area + " " + eb.Length);
         }
         catch (NotImplementedException ex)
         {
              // 구현되지 않음 예외 처리
         }
     }
}
```
