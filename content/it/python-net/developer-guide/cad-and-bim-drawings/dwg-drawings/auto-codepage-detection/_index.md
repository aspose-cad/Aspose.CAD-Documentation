---
title: Rilevamento automatico della codepage
type: docs
weight: 10
url: /it/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Rilevamento automatico della codepage**

Aspose.CAD supporta il rilevamento automatico della codepage per i file [DWG](https://docs.fileformat.com/cad/dwg/) e [DWF](https://docs.fileformat.com/cad/dwf/). Se non desideri utilizzare questa funzionalità, puoi sovrascriverla impostando le seguenti proprietà della classe **LoadOptions**.

- **specified_encoding**: imposta l'encoding utilizzato per leggere i dati di testo dai formati DXF e DWG non Unicode. Di default è autodetectato.
- **specified_mif_encoding**: imposta l'encoding utilizzato per leggere simboli codificati MIF degli encoding CJK (formato M+nXXXX). Di default è autodetectato.
- **recover_malformed_cif_mif**: definisce se i caratteri CIF (U+XXXX) e codificati MIF saranno decodificati se non hanno un formattazione AutoCAD corretta (AutoCAD precede questi simboli con una barra rovesciata). Di default, vengono decodificati.

## Codice di esempio

Il campione di codice qui sotto mostra come sovrascrivere il rilevamento automatico della codepage in Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
