---
title: Automatisk kodsidanavigering
type: docs
weight: 10
url: /sv/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Automatisk kodsidanavigering**

Aspose.CAD stöder automatisk kodsidanavigering för [DWG](https://docs.fileformat.com/cad/dwg/) och [DWF](https://docs.fileformat.com/cad/dwf/) filer. Om du inte vill använda denna funktion kan du åsidosätta detta genom att ställa in följande egenskaper för [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) klassen.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): sätter kodning som används för att läsa textdata från icke-Unicode DXF och DWG format. Den upptäckts automatiskt som standard.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): sätter kodning som används för att läsa MIF-kodade symboler av CJK-kodningar (M+nXXXX format). Den upptäckts automatiskt som standard.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): definierar huruvida CIF (U+XXXX) och MIF-kodade tecken kommer att avkodas om de inte har korrekt AutoCAD-formatering (AutoCAD föregår dessa symboler med en backslash). Som standard avkodas de.

## Exempelkod

Kodexemplet nedan visar hur man åsidosätter automatisk kodsidanavigering i Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
