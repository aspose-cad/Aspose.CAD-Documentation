---
title: Supporto dei file CTB
type: docs
weight: 40
url: /it/net/developer-guide/support-ctb/
---

## **Supporto dei file CTB**

A volte i colori, i pesi delle linee e alcune altre opzioni per i disegni possono essere utilizzati non solo dai disegni stessi, ma anche dagli stili di traccia in file CTB separati. 
Il modo più semplice per utilizzare queste informazioni è inserire i file CTB corrispondenti vicino al file con il disegno in formato DWG/DXF e le informazioni da essi verranno applicate
automaticamente durante l'esportazione.

È anche possibile caricare tutti i file CTB sotto forma di Stream utilizzando 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) proprietà dell'oggetto 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).

Ecco un esempio di come farlo:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
