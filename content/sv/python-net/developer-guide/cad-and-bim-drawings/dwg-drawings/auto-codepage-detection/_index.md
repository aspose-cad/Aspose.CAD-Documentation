---
title: Automatisk kodsiddetektering
type: docs
weight: 10
url: /sv/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatisk kodsiddetektering**

Aspose.CAD stödjer automatisk kodsiddetektering för [DWG](https://docs.fileformat.com/cad/dwg/) och [DWF](https://docs.fileformat.com/cad/dwf/) filer. Om du inte vill använda denna funktion, kan du åsidosätta detta genom att ställa in följande egenskaper i **LoadOptions** klassen.

- **specified_encoding**: ställer in kodningen som används för att läsa textdata från icke-Unicode DXF och DWG format. Det är autodetekterat som standard.
- **specified_mif_encoding**: ställer in kodningen som används för att läsa MIF-kodade symboler av CJK-kodningar (M+nXXXX format). Det är autodetekterat som standard.
- **recover_malformed_cif_mif**: definierar om CIF (U+XXXX) och MIF-kodade tecken kommer att avkodas om de inte har korrekt AutoCAD-formattering (AutoCAD föregår dessa symboler med en backslash). Som standard avkodas de.

## Exempelkod

Kodexemplet nedan visar hur man åsidosätter automatisk kodsiddetektering i Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
