---
title: Automatické odhalování kódování
type: docs
weight: 10
url: /cs/auto-codepage-detection/
---

## **Automatické odhalování kódování**

Aspose.CAD podporuje automatické odhalování kódování pro [DWG](https://docs.fileformat.com/cad/dwg/) a [DWF](https://docs.fileformat.com/cad/dwf/) soubory. Pokud si nepřejete používat tuto funkci, můžete ji přepsat nastavením následujících vlastností třídy [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): nastavuje kódování použité k načítání textových dat z formátů DXF a DWG není v Unicode. Výchozí je automatické odhalování.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): nastavuje kódování použité k načítání MIF-kódovaných symbolů kódování CJK (formát M+nXXXX). Výchozí je automatické odhalování.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): definuje, zda budou dekódována znaky kódovaná CIF (U+XXXX) a MIF, pokud nemají správné formátování programu AutoCAD (AutoCAD před těmito symboly umisťuje zpětné lomítko). Výchozí je dekódování.

## Ukázkový kód

Následující ukázkový kód ukazuje, jak přepsat automatické odhalování kódování ve službě Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
