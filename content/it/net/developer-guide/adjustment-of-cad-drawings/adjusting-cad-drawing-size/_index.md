---
title: Regolare le dimensioni del disegno CAD
type: docs
weight: 10
url: /it/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Utilizzando la libreria Aspose.CAD per .NET, gli sviluppatori possono regolare le dimensioni del disegno CAD durante la conversione in qualsiasi formato supportato. Questo argomento spiega l'approccio per regolare le dimensioni automaticamente o manualmente utilizzando l'enumerazione [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) della classe [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

{{% /alert %}}

## **Regolare le dimensioni del disegno CAD**

Aspose.CAD per .NET fornisce l'enumerazione [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) per regolare le dimensioni del disegno durante la conversione del formato CAD. Ci sono due modi per regolare le dimensioni del disegno.

1. Regolazione automatica delle dimensioni.
1. Regolare le dimensioni utilizzando l'enumerazione [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) della classe [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions).

Per regolare automaticamente le dimensioni, gli sviluppatori non devono fornire le proprietà Width e Height della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index). Di seguito è fornito un frammento di codice che è un esempio di dimensionamento automatico.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

L'enumerazione [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) offre la possibilità di regolare la scala quando le proprietà Width e Height non sono impostate. Di seguito è fornito un frammento di codice che dimostra come utilizzare [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
