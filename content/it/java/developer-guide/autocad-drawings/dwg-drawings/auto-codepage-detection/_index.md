---
title: Rilevamento Automatico della Codepage
type: docs
weight: 10
url: /it/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Rilevamento Automatico della Codepage**

Aspose.CAD supporta il rilevamento automatico della codepage per i file [DWG](https://docs.fileformat.com/cad/dwg/) e [DWF](https://docs.fileformat.com/cad/dwf/). Se non desideri utilizzare questa funzione, puoi sovrascriverla impostando le seguenti proprietà della classe [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): imposta la codifica utilizzata per leggere i dati di testo dai formati DXF e DWG non-Unicode. È autodetectata per impostazione predefinita.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): imposta la codifica utilizzata per leggere i simboli codificati MIF delle codifiche CJK (formato M+nXXXX). È autodetectata per impostazione predefinita.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): definisce se i caratteri CIF (U+XXXX) e MIF codificati saranno decodificati se non hanno il corretto formato di AutoCAD (AutoCAD precede questi simboli con una barra rovesciata). Per impostazione predefinita, vengono decodificati.

## Esempio di Codice

Il campione di codice qui sotto mostra come sovrascrivere il rilevamento automatico della codepage in Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
