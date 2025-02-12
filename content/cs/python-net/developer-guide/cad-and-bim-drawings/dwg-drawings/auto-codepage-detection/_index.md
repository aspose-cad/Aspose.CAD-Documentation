---
title: Detekce kódování automaticky
type: docs
weight: 10
url: /cs/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Detekce kódování automaticky**

Aspose.CAD podporuje automatickou detekci kódování pro soubory [DWG](https://docs.fileformat.com/cad/dwg/) a [DWF](https://docs.fileformat.com/cad/dwf/). Pokud si nepřejete použít tuto funkci, můžete ji přepsat nastavením následujících vlastností třídy **LoadOptions**.

- **specified_encoding**: nastaví kódování použité k čtení textových dat z formátů DXF a DWG, které nejsou v kódování Unicode. Výchozí hodnota je autodetekována.
- **specified_mif_encoding**: nastaví kódování použité k čtení symbolů kódovaných v MIF u kódování CJK (formát M+nXXXX). Výchozí hodnota je autodetekována.
- **recover_malformed_cif_mif**: určuje, zda budou dekódovány znaky kódované v CIF (U+XXXX) a MIF, pokud nemají správné formátování pro AutoCAD (AutoCAD před tyto symboly předchází zpětný lomítkem). Výchozí chování je jejich dekódování.

## Ukázkový kód

Níže uvedená ukázka kódu ukazuje, jak přepsat automatickou detekci kódování v Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
