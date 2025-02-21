---
title: Werk met tekst
type: docs
weight: 40
url: /nl/net/developer-guide/drawing-api/work-with-text/
---

## **Werk met tekst**

Bijna alle tekeningen bevatten tekstobjecten en deze voorbeelden tonen aan hoe je bewerkingen met hen kunt uitvoeren. 
Er zijn verschillende soorten entiteiten voor DWG/DXF die tekst kunnen opslaan, dit zijn [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. De laatste twee types zijn doorgaans gerelateerd 
aan [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
en worden binnenin of in het bijbehorende blok opgeslagen.

Hier zijn enkele voorbeelden die de bewerkingen met tekst beschrijven.

### **Zoeken naar de tekst**

Dit voorbeeld laat zien hoe je tekstwaarden in het DWG/DXF-bestand kunt vinden en kan ook worden gebruikt om tekstwaarden te vervangen.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Nieuwe Tekst en MText-items toevoegen**

Hier is het voorbeeld van hoe je nieuwe Tekst/MText-objecten aan de tekening kunt toevoegen. Het toevoegen van nieuwe entiteiten kan de grootte van de tekening veranderen, dus het wordt aanbevolen om 
UpdateSize() aan te roepen na deze bewerkingen.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
