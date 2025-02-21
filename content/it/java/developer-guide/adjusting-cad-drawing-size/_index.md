---
title: Regolazione della dimensione del disegno CAD
type: docs
weight: 10
url: /it/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Utilizzando Aspose.CAD per Java, gli sviluppatori possono regolare la dimensione del disegno durante la conversione del formato CAD. Questo argomento spiega l'approccio per l'auto-regolazione o la regolazione della dimensione utilizzando l'enumerazione [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) della classe [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Regolazione della dimensione del disegno CAD**

Aspose.CAD per Java fornisce l'enumerazione [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) per regolare la dimensione del disegno durante la conversione del formato CAD. Ci sono due modi per regolare la dimensione del disegno.

1. Regolazione automatica della dimensione
1. Regolazione della dimensione utilizzando l'enumerazione [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) della classe [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Per la regolazione automatica della dimensione, gli sviluppatori non devono fornire le proprietà Larghezza e Altezza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Di seguito è fornito un esempio di codice per la dimensione automatica.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

L'enumerazione [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) offre la possibilità di regolare la scala quando le proprietà Larghezza e Altezza non sono impostate. Di seguito è fornito un esempio di codice che dimostra come utilizzare [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
