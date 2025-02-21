---
title: Esportazione dei font SHX
type: docs
weight: 40
url: /it/java/developer-guide/export-shx-fonts/
---

## **Esportazione dei font SHX per disegni DXF/DWG**

Alcuni disegni possono contenere font in formato SHX speciale, che memorizza i simboli del font sotto forma di forme.  
Questo formato richiede una procedura di caricamento aggiuntiva per ogni font utilizzato nel disegno.  
Apose.CAD può esportare disegni con testo scritto in SHX e ha diverse opzioni per farlo.  
Il modo più semplice per farlo è utilizzare la proprietà [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) dell'oggetto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Ogni font SHX è accompagnato dal codice pagina appropriato associato ad esso. Queste associazioni sono conosciute e parzialmente incorporate in Aspose.CAD per font SHX noti.  
Nel caso venga utilizzato un font SHX personalizzato, è possibile applicare la proprietà **setShxCodePages** e impostare il percorso del file SHX e il corrispondente codice pagina.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
