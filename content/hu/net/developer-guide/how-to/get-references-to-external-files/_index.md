---
title: Hivatkozások megszerzése külső fájlokra
type: docs
weight: 36
url: /hu/net/developer-guide/how-to/get-references-to-external-files/
---

## **Hogyan szerezzen hivatkozásokat külső fájlokra**

**Probléma:** Hogyan szerezzen hivatkozásokat külső fájlokra (CADNET-110).

**Tippek:** A külső fájlokra vonatkozó hivatkozások megszerzéséhez a rajzokban az entitás blokkban van egy XRef PathName mező a raszteres képekhez, a CadRasterImage Def külső alátétként használható, a CadDgnUnderlay pedig alátétként, és annak UnderlayPath mezője.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
