---
title: 텍스트, 해치 및 호를 위한 품질 옵션 설정
type: docs
weight: 46
url: /ko/net/developer-guide/how-to/setting-up-quality-options-for-the-text-hatches-and-arcs/
---

## **텍스트, 해치 및 호를 위한 품질 옵션 설정 방법**

**문제:** 텍스트, 해치 및 호를 위한 품질 옵션 설정 방법 (CADNET-986).

**팁:** 텍스트, 스트로크 및 호에 대한 품질 매개변수를 조정하기 위해, 이러한 조정은 rasterizationOptions 클래스에서 이루어집니다 (rasterizationOptions.Quality.Text, rasterizationOptions.Quality.Hatch, rasterizationOptions.Quality.Arc, rasterizationOptions.Quality.ObjectsPrecision).
 
**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "setting-up-quality-options-for-the-text-hatches-and-arcs.cs" >}}
