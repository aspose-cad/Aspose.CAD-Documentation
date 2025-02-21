---
title: OBJ Dosya Formatı ile Çalışma
type: docs
weight: 120
url: /tr/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD artık OBJ dosya formatını destekliyor. OBJ dosya formatı, doku haritaları, 3D koordinatlar, çokgen yüzler ve diğer nesne bilgilerini içeren bir 3D geometrisidir.

{{% /alert %}}

## **OBJ Formatını PNG'ye Aktarma**

Angular'da Aspose.CAD for Javascript, geliştiricilerin bir [OBJ](https://docs.fileformat.com/3d/obj/) dosyasını [PNG](https://docs.fileformat.com/image/png/) formatına aktarmasına olanak tanır. [OBJ](https://docs.fileformat.com/3d/obj/) ile [PNG](https://docs.fileformat.com/image/png/) dönüştürme yaklaşımı şu şekilde çalışır:

1. **Image.load** metodunu kullanarak [OBJ](https://docs.fileformat.com/3d/obj/) çizim dosyasını yükleyin.
1. İkinci parametre olarak **PngOptions** nesnesini geçirerek **Image.save** çağrısını yapın.

## Örnek Kod

Aşağıdaki kod, Aspose.CAD for JavaScript kullanarak aynı sonuca nasıl ulaşılacağını göstermektedir.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
