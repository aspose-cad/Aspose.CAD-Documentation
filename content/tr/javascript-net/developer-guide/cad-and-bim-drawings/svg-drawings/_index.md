---
title: SVG Çizimleri
type: docs
weight: 70
url: /tr/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG Formatını PNG'ye Aktarma**

Aspose.CAD for Javascript in Angular, geliştiricilerin bir [SVG](https://docs.fileformat.com/page-description-language/svg/) dosyasını [PNG](https://docs.fileformat.com/image/png/) formatına aktarmasına olanak tanır.
[SVG](https://docs.fileformat.com/page-description-language/svg/) dosyasını [PNG](https://docs.fileformat.com/image/png/) formatına dönüştürme yaklaşımı şu şekilde çalışır:

1. **Image.load** yöntemini kullanarak [SVG](https://docs.fileformat.com/page-description-language/svg/) çizim dosyasını yükleyin.
1. İkinci parametre olarak **PngOptions** nesnesini geçirirken **Image.save** çağrısında bulunun.

## Örnek Kod

Aşağıdaki kod, Aspose.CAD for JavaScript kullanarak aynı amaca nasıl ulaşılacağını göstermektedir.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
