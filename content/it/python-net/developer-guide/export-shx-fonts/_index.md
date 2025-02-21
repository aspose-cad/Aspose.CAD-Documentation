---
title: Esportazione dei font SHX
type: docs
weight: 40
url: /it/python-net/developer-guide/export-shx-fonts/
---

## **Esportazione dei font SHX per disegni DXF/DWG**

Alcuni disegni possono contenere font in un formato speciale SHX, che memorizza i simboli del font sotto forma di forme. Questo formato richiede una procedura di caricamento aggiuntiva per ogni font utilizzato nel disegno. Apose.CAD può esportare disegni con testo scritto in SHX e dispone di diverse opzioni per farlo. Il modo più semplice per farlo è utilizzare la proprietà 
**ShxFonts** dell'oggetto 
**CadRasterizationOptions**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
