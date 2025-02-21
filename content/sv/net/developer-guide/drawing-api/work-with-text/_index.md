---
title: Arbeta med text
type: docs
weight: 40
url: /sv/net/developer-guide/drawing-api/work-with-text/
---

## **Arbeta med text**

Nästan alla ritningar innehåller textobjekt och dessa exempel visar hur man utför operationer med dem. 
Det finns olika typer av entiteter för DWG/DXF som kan lagra text, de är [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. De två sista typerna är typiskt relaterade 
till [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
och lagras inuti det eller i motsvarande block.

Här är några exempel som beskriver operationer med text.

### **Sök efter text**

Detta exempel visar hur man hittar textvärden i DWG/DXF-filen och kan även användas för att ersätta textvärden.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Lägga till nya Text- och MText-objekt**

Här är exemplet på hur man lägger till nya Text/Mtext-objekt till ritningen. Tillägg av nya entiteter kan ändra storleken på ritningen, så det rekommenderas
att anropa UpdateSize() efter dessa operationer.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
