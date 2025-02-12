---
title: Detekce automatického kódování
type: docs
weight: 10
url: /cs/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Detekce automatického kódování**

Aspose.CAD podporuje detekci automatického kódování pro [DWG](https://docs.fileformat.com/cad/dwg/) a [DWF](https://docs.fileformat.com/cad/dwf/) soubory. Pokud si nepřejete využívat tuto funkci, můžete ji přepsat nastavením následujících vlastností třídy [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): nastaví kódování použité pro čtení textových dat z formátů DXF a DWG neobsahujících Unicode. Výchozí nastavení je automatická detekce.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): nastaví kódování použité pro čtení symbolů kódovaných ve formátu MIF kódování CJK (formát M+nXXXX). Výchozí nastavení je automatická detekce.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): určuje, zda budou dekódovány znaky kódované jako CIF (U+XXXX) a MIF, pokud nemají správné formátování AutoCADu (AutoCAD těmto symbolům předchází zpětným lomítkem). Výchozí nastavení je dekódování.

## Ukázkový kód

Následující ukázkový kód ukazuje, jak přepsat detekci automatického kódování v Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
