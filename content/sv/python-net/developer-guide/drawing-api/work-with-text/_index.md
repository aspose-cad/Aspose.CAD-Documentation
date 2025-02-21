---
title: Arbeta med text
type: docs
weight: 40
url: /sv/python-net/developer-guide/drawing-api/work-with-text/
---

## **Arbeta med text**

Nästan alla ritningar innehåller textobjekt och dessa exempel visar hur man utför operationer med dem. 
Det finns olika typer av enheter för DWG/DXF som kan lagra text, de är **CadText**,**CadMText**,CadAttDef, CadAttrib. De två sista typerna är vanligtvis relaterade 
till **CadInsertObject** och lagras inne i det eller i den motsvarande blocket.

Här är några exempel som beskriver operationer med text.

### **Sök efter text**

Detta exempel visar hur man hittar textvärden i DWG/DXF-filen och kan även användas för att ersätta textvärden.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
