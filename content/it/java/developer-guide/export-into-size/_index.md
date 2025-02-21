---
title: Esportazione di disegni e layout DWG/DXF in dimensioni specificate
type: docs
weight: 40
url: /it/java/developer-guide/export-into-size/
---

## **Esporta modello e tutti i layout in formato PDF A4**

L'API Aspose.CAD consente di esportare tutti i fogli del file DWG/DXF in formato PDF fisico specificato. Il seguente codice di esempio imposta la dimensione dell'oggetto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) per ottenere la dimensione PDF desiderata. La dimensione della pagina A4 è di 210x297 millimetri o 8,27x11,69 pollici e questi valori sono utilizzati nel codice.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Esporta layout CAD in PDF in dimensioni diverse**

A volte è necessario esportare il layout nella sua dimensione fisica. L'esempio seguente dimostra l'esportazione del disegno in un PDF multipagina dove ogni pagina con contenuto del layout ha la propria dimensione PDF fisica. Questo esempio utilizza la proprietà [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
