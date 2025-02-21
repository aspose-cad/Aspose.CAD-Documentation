---
title: Automatisk kodsidesdetektering
type: docs
weight: 10
url: /sv/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatisk kodsidesdetektering**

Aspose.CAD stödjer automatisk kodsidesdetektering för [DWG](https://docs.fileformat.com/cad/dwg/) och [DWF](https://docs.fileformat.com/cad/dwf/) filer. Om du inte vill använda denna funktion kan du åsidosätta den genom att ställa in följande egenskaper i klassen [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): ställer in kodning som används för att läsa textdata från icke-Unicode DXF och DWG format. Den detekteras automatiskt som standard.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): ställer in kodning som används för att läsa MIF-kodade symboler av CJK-kodningar (M+nXXXX format). Den detekteras automatiskt som standard.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): definierar om CIF (U+XXXX) och MIF-kodade tecken kommer att avkodas om de inte har korrekt AutoCAD-formatering (AutoCAD föregår dessa symboler med en backslash). Som standard avkodas de.

## Exempel på kod

Kodexemplet nedan visar hur man åsidosätter automatisk kodsidesdetektering i Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
