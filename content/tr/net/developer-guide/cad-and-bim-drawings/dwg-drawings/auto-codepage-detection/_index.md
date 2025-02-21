---
title: Otomatik Kodu Algılama
type: docs
weight: 10
url: /tr/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Otomatik Kodu Algılama**

Aspose.CAD, [DWG](https://docs.fileformat.com/cad/dwg/) ve [DWF](https://docs.fileformat.com/cad/dwf/) dosyaları için otomatik kod sayfası algılamayı destekler. Bu özelliği kullanmak istemiyorsanız, [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) sınıfının aşağıdaki özelliklerini ayarlayarak bunu geçersiz kılabilirsiniz.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): Unicode olmayan DXF ve DWG formatlarından metin verilerini okumak için kullanılan kodlamayı ayarlar. Varsayılan olarak otomatik algılanır.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): CJK kodlamalarının MIF kodlu sembollerini okumak için kullanılan kodlamayı ayarlar (M+nXXXX formatı). Varsayılan olarak otomatik algılanır.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): CIF (U+XXXX) ve MIF kodlu karakterlerin düzgün AutoCAD formatına sahip olmadıklarında çözümlenip çözümlenmeyeceğini tanımlar (AutoCAD bu sembolleri bir ters eğik çizgi ile önceden işaretler). Varsayılan olarak, çözümlenirler.

## Örnek Kod

Aşağıdaki kod örneği, Aspose.CAD'de otomatik kod sayfası algılamayı nasıl geçersiz kılacağınızı gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
