---
title: Werk met tekst
type: docs
weight: 40
url: /nl/python-net/developer-guide/drawing-api/work-with-text/
---

## **Werk met tekst**

Bijna alle tekeningen bevatten tekstopjecten en deze voorbeelden laten zien hoe je operaties met hen kunt uitvoeren. 
Er zijn verschillende soorten entiteiten voor DWG/DXF die tekst kunnen opslaan, zij zijn **CadText**, **CadMText**, CadAttDef, CadAttrib. De laatste twee types zijn typisch gerelateerd 
aan **CadInsertObject** en worden daarbinnen of in het bijbehorende blok opgeslagen.

Hier zijn enkele voorbeelden die operaties met tekst beschrijven.

### **Zoeken naar de tekst**

Dit voorbeeld laat zien hoe je tekstwaarden in het DWG/DXF-bestand kunt vinden en kan ook worden gebruikt voor het vervangen van tekstwaarden.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
