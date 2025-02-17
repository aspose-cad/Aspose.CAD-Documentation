---
title: PDF/A formátumba való exportálás
type: docs
weight: 33
url: /hu/net/developer-guide/how-to/export-to-pdfa-format/
---

## **Hogyan exportáljunk PDF/A formátumba**

**Probléma:** Hogyan exportáljunk PDF/A formátumba (CADNET-281).

**Tippek:** Ehhez hozzon létre pdfOptions.CorePdfOptions-t, és állítsa be a pdfOptions.CorePdfOptions.Compliance-t Aspose.CAD.ImageOptions.PdfCompliance.PdfA1a értékre.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-pdfa-format.cs" >}}
