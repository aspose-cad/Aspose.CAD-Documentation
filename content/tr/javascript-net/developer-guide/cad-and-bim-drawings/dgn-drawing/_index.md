---
title: DGN Çizimi
type: docs
weight: 10
url: /tr/javascript-net/developer-guide/cad-and-bim-drawings/dgn-drawing/
---

## **DGN Formatını PNG'ye Aktarma**

Aspose.CAD for Javascript in Angular, geliştiricilerin bir [DGN](https://docs.fileformat.com/cad/dgn/) dosyasını [PNG](https://docs.fileformat.com/image/png/) formatına aktarmasına olanak tanır.
[DGN](https://docs.fileformat.com/cad/dgn/) dosyasını [PNG](https://docs.fileformat.com/image/png/) formatına dönüştürme yaklaşımı şu şekilde çalışır:

1. **Image.load** metodunu kullanarak [DGN](https://docs.fileformat.com/cad/dgn/) çizim dosyasını yükleyin.
2. İkinci parametre olarak **PngOptions** nesnesini geçirirken **Image.save** metodunu çağırın.

## Örnek Kod

Aşağıdaki kod, Aspose.CAD for JavaScript kullanarak aynı amaca ulaşmanın nasıl yapılacağını göstermektedir.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DGN-to-PNG-Export.js" >}}
