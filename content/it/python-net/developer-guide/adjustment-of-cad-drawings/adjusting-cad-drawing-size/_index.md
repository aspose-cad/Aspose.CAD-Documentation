---
title: Regolazione della dimensione del disegno CAD
type: docs
weight: 10
url: /it/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Utilizzando la libreria Aspose.CAD per Python, gli sviluppatori possono regolare la dimensione del disegno CAD durante la conversione in qualsiasi formato supportato. Questo argomento spiega l'approccio per regolare la dimensione in modo automatico o manuale utilizzando l'enumerazione **UnitType** della classe **ImageOptions**.

{{% /alert %}}

## **Regolazione della dimensione del disegno CAD**

Aspose.CAD per Python fornisce l'enumerazione **UnitType** per regolare la dimensione del disegno durante la conversione del formato CAD. Ci sono due modi per regolare la dimensione del disegno.

1. Regolazione automatica della dimensione.
2. Regolare la dimensione utilizzando l'enumerazione **UnitType** della classe **ImageOptions**.

Per regolare automaticamente la dimensione, gli sviluppatori non hanno bisogno di fornire le proprietà Width e Height della classe **CadRasterizationOptions**. Il codice di esempio fornito di seguito è un esempio di dimensionamento automatico.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

L'enumerazione **UnitType** offre la possibilità di regolare lo scaling quando le proprietà Width e Height non sono impostate. Il codice di esempio fornito di seguito dimostra come utilizzare **UnitType**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
