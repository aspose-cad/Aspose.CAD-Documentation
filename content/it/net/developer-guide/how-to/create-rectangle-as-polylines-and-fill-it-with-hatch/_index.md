---
title: Creare un rettangolo come polilinee e riempirlo con trama
type: docs
weight: 24
url: /it/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Come creare un rettangolo come polilinee e riempirlo con trama**

**Problema:** Come creare un rettangolo come polilinee e riempirlo con trama (CADNET-1351).

**Suggerimenti:** Per fare questo, crea un CadLwPolyline e aggiungi le coordinate dei punti, usa CadHatch per lavorare con il colore e usa CadEdgeBoundaryPath per collegare, usa CadHatch per lavorare con gli angoli e CadHatchPatternData per il modello.

**Esempio:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
