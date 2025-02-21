---
title: Esportazione dei caratteri SHX
type: docs
weight: 40
url: /it/net/developer-guide/export-shx-fonts/
---

## **Esporta i caratteri SHX per disegni DXF/DWG**

Alcuni disegni possono contenere caratteri in formato SHX speciale, che memorizza i simboli del carattere in forma di forme. Questo formato richiede una procedura di caricamento aggiuntiva per ogni carattere utilizzato nel disegno. Apose.CAD può esportare disegni con testo scritto in SHX e ha diverse opzioni per farlo. Il modo più semplice per farlo è semplicemente utilizzare la proprietà 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) dell'oggetto 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Esempio di ShxFonts.cs">}}


È possibile evitare di impostare tutti i percorsi per più caratteri SHX con il seguente esempio:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Esempio di ShxFonts con cartella.cs">}}
	
Ogni carattere SHX è fornito con la corretta codepage associata ad esso. Queste associazioni sono conosciute e parzialmente incorporate in Aspose.CAD per i caratteri SHX noti. 
Nel caso venga utilizzato un carattere SHX personalizzato, è possibile applicare la proprietà ShxCodePages e impostare il percorso del file SHX e la corrispondente codepage. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Esempio di ShxCodePages.cs">}}
