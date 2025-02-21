---
title: Rilevamento Automatico della Codepage
type: docs
weight: 10
url: /it/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Rilevamento Automatico della Codepage**

Aspose.CAD supporta il rilevamento automatico della codepage per i file [DWG](https://docs.fileformat.com/cad/dwg/) e [DWF](https://docs.fileformat.com/cad/dwf/). Se non desideri utilizzare questa funzione, puoi sovrascriverla impostando le seguenti proprietà della classe [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): imposta la codifica utilizzata per leggere i dati testuali dai formati DXF e DWG non Unicode. Viene autodetected per impostazione predefinita.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): imposta la codifica utilizzata per leggere i simboli codificati MIF delle codifiche CJK (formato M+nXXXX). Viene autodetected per impostazione predefinita.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): definisce se i caratteri codificati CIF (U+XXXX) e MIF verranno decodificati se non hanno una formattazione AutoCAD corretta (AutoCAD precede questi simboli con una barra rovesciata). Per impostazione predefinita, vengono decodificati.

## Esempio di Codice

L'esempio di codice seguente mostra come sovrascrivere il rilevamento automatico della codepage in Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
