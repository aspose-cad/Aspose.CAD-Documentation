---
title: PDF/A 형식으로 내보내기
type: docs
weight: 33
url: /ko/net/developer-guide/how-to/export-to-pdfa-format/
---

## **PDF/A 형식으로 내보내는 방법**

**문제:** PDF/A 형식으로 내보내는 방법 (CADNET-281).

**팁:** 이를 위해 pdfOptions.CorePdfOptions를 생성하고 pdfOptions.CorePdfOptions.Compliance를 Aspose.CAD.ImageOptions.PdfCompliance.PdfA1a로 설정합니다.

**예제:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-pdfa-format.cs" >}}
