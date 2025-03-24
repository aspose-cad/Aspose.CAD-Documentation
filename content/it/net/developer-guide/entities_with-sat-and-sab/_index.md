---
title: Entità con struttura SAT/SAB
type: docs
weight: 40
url: /it/net/developer-guide/entities_with-sat-and-sab/
---

## **Entità con struttura SAT/SAB**

Alcune entità memorizzano i loro dati strutturali nel formato ACIS SAT/SAB. Queste entità possono essere esportate parzialmente in modalità wireframe 2D. Le entità supportate includono:

*	oggetti 3DSOLID: scatola, sfera, piramide, cuneo, cono, cilindro, toro, polisolido
*	SUPERFICIE: planare, estruso, rivolto, rastremato
*	REGIONE

Di seguito è riportato un esempio del risultato dell'esportazione (file DWG nella parte sinistra, risultato PDF nella parte destra).

![Esportazione di cono e sfere](/cad/_assets/guide/coneAndSpheres.png)

L'esportazione delle entità ACIS non richiede opzioni speciali. Per ottimizzare la dimensione del disegno, specialmente quando il disegno contiene esclusivamente entità ACIS, considera di utilizzare la funzione cadImage.UpdateSize() per regolare accuratamente le dimensioni iniziali del disegno.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
