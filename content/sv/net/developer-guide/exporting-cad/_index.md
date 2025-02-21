---
title: Exportera CAD
type: docs
weight: 40
url: /sv/net/developer-guide/exporting-cad/
---

## **Exportera 3D AutoCAD-bilder till PDF**

Aspose.CAD gör det möjligt att exportera 3D AutoCAD-bilder till PDF. Vänligen använd [**Aspose.CAD.ImageOptions.CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) för att specificera att du vill exportera 3D-objekt.

Följande exempelkod laddar en AutoCAD 3D-fil och exporterar den till [PDF](https://docs.fileformat.com/pdf/). När filen har konverterats till PDF kan du öppna den med din favorit PDF-läsare.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-Export3DImagestoPDF-Export3DImagestoPDF.cs" >}}

## **Exportera CAD-layouts till PDF**

Aspose.CAD för .NET gör det möjligt att exportera CAD-layouts till PDF. [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metoden i [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klassen kan användas för att exportera layout(er) till [PDF](https://docs.fileformat.com/pdf/) format.

Följande exempelkod laddar en CAD-fil och exporterar dess "Model"-layout till PDF. När filen har konverterats till PDF kan du öppna den med din favorit PDF-läsare.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-CADLayoutsToPDF-CADLayoutsToPDF.cs" >}}

## **Support för inställning av pennan i exporten**

Aspose.CAD för .NET gör det möjligt att lägga till penalternativ i exportegenskaperna för CAD. Genom att använda [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) kan vi ställa in penegenskapsalternativ.

Nedan finns exempel kod för att uppnå angivna krav.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-PenSupportInExport-PenSupportInExport.cs" >}}

## **Dekomponera CAD-insertobjekt**

Aspose.CAD för .NET gör det möjligt att dekomponera CAD-objekt och bearbeta separata enheter inuti insert. Nedan finns exempel kod för att uppnå angivna krav.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-DecomposeCADInsertObject-DecomposeCADInsertObject.cs" >}}

## **Support för ACAD Proxy-enheter**

Aspose.CAD för .NET gör det möjligt att läsa och exportera ACAD_PROXY_ENTITY-enheter. Nedan finns exempel kod för att uppnå angivna krav.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ACADProxyEntities-ACADProxyEntities.cs" >}}

## **Integrera IGES-formatet**

Aspose.CAD för .NET gör det möjligt att läsa och exportera IGES-formatet. Nedan finns exempel kod för att uppnå angivna krav.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-IntegrateIGESFormat-IntegrateIGESFormat.cs" >}}

## **Support för meshmodeller**

Aspose.CAD för .NET gör det möjligt att implementera och räkna meshmodeller som kanter, hörn och ytor som använder polygonal representation. Nedan finns exempel kod för att uppnå angivna krav.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-MeshSupport-MeshSupport.cs" >}}

## **Ställ in anpassad synpunkt**

Aspose.CAD för .NET gör det möjligt att ställa in en anpassad synvinkel för modellayouten. Genom att använda [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) kan du ställa in en anpassad synvinkel. Koden nedan visar hur man ställer in en anpassad synvinkel.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-FreePointOfView-FreePointOfView.cs" >}}
