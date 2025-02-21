---
title: Otomatik Kod Sayfası Algılama
type: docs
weight: 10
url: /tr/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Otomatik Kod Sayfası Algılama**

Aspose.CAD, [DWG](https://docs.fileformat.com/cad/dwg/) ve [DWF](https://docs.fileformat.com/cad/dwf/) dosyaları için otomatik kod sayfası algılamayı destekler. Bu özelliği kullanmak istemiyorsanız, [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) sınıfının aşağıdaki özelliklerini ayarlayarak bunu geçersiz kılabilirsiniz.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): Unicode olmayan DXF ve DWG formatlarından metin verilerini okumak için kullanılan kodlamayı ayarlar. Varsayılan olarak otomatik olarak algılanır.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): CJK kodlamalarının MIF kodlu sembollerini okumak için kullanılan kodlamayı ayarlar (M+nXXXX formatı). Varsayılan olarak otomatik olarak algılanır.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): CIF (U+XXXX) ve MIF kodlu karakterlerin AutoCAD formatlamasına sahip olup olmadıklarına bağlı olarak çözümlenip çözümlenmeyeceğini tanımlar (AutoCAD bu sembolleri ters eğik çizgi ile önler). Varsayılan olarak, bunlar çözümlenir.

## Örnek Kod

Aşağıdaki kod örneği, Aspose.CAD'de otomatik kod sayfası algılamayı nasıl geçersiz kılacağınızı göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
