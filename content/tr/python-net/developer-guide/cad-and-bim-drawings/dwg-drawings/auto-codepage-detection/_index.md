---
title: Otomatik Kod Sayfası Algılama
type: docs
weight: 10
url: /tr/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Otomatik Kod Sayfası Algılama**

Aspose.CAD, [DWG](https://docs.fileformat.com/cad/dwg/) ve [DWF](https://docs.fileformat.com/cad/dwf/) dosyaları için otomatik kod sayfası algılamayı destekler. Bu özelliği kullanmak istemiyorsanız, **LoadOptions** sınıfının aşağıdaki özelliklerini ayarlayarak bunu geçersiz kılabilirsiniz.

- **specified_encoding**: Unicode dışındaki DXF ve DWG formatlarından metin verilerini okumak için kullanılan kodlamayı ayarlar. Varsayılan olarak otomatik algılanır.
- **specified_mif_encoding**: CJK kodlamalarının MIF-kodlu sembollerini okumak için kullanılan kodlamayı ayarlar (M+nXXXX formatı). Varsayılan olarak otomatik algılanır.
- **recover_malformed_cif_mif**: CIF (U+XXXX) ve MIF-kodlu karakterlerin uygun AutoCAD formatlaması yoksa çözülüp çözülmeyeceğini tanımlar (AutoCAD bu sembolleri bir ters bölü ile başlatır). Varsayılan olarak, çözülürler.

## Örnek Kod

Aşağıdaki kod örneği, Aspose.CAD'de otomatik kod sayfası algılamayı nasıl geçersiz kılacağınızı göstermektedir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
