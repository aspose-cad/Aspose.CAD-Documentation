---
title: Supporto dei file CTB
type: docs
weight: 40
url: /it/java/developer-guide/support-ctb/
---

## **Supporto dei file CTB**

A volte il colore, i pesi delle linee e alcune altre opzioni per i disegni possono essere utilizzati non solo dai disegni stessi, ma anche dagli stili di plot in file CTB separati. 
Il modo più semplice per utilizzare queste informazioni è mettere i file CTB corrispondenti vicino al file con disegno in formato DWG/DXF e le informazioni provenienti da essi verranno applicate automaticamente durante l'esportazione.

È anche possibile caricare tutti i file CTB sotto forma di Stream utilizzando la proprietà 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) dell'oggetto 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

Ecco un esempio di come farlo:

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
