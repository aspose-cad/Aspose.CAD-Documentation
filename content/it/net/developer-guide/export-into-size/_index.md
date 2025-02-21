---
title: Esportazione di disegni e layout DWG/DXF in dimensioni specifiche
type: docs
weight: 40
url: /it/net/developer-guide/export-into-size/
---

## **Esporta modello e tutti i layout in formato PDF A4**

L'API Aspose.CAD consente di esportare tutti i fogli del file DWG/DXF in un formato PDF fisico specificato.

Il seguente esempio di codice imposta la dimensione dell'oggetto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) per ottenere la dimensione PDF desiderata.  
La dimensione di un foglio di carta A4 è 210x297 millimetri o 8.27x11.69 pollici e questi valori vengono utilizzati nel codice.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Esporta layout CAD in PDF in dimensioni diverse**

A volte è necessario esportare il layout nelle sue dimensioni fisiche. L'esempio seguente dimostra l'esportazione del disegno in un PDF multipagina in cui ogni pagina con contenuto del layout ha la propria dimensione PDF fisica. Questo esempio utilizza la proprietà [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
