---
title: SHX-lettertypen exporteren
type: docs
weight: 40
url: /nl/python-net/developer-guide/export-shx-fonts/
---

## **SHX-lettertypen exporteren voor DXF/DWG-tekeningen**

Sommige tekeningen kunnen lettertypen in speciaal SHX-formaat bevatten, dat symbolen van het lettertype opslaat in de vorm van vormen. Dit formaat vereist een aanvullende
laadprocedure voor elk lettertype dat in de tekening wordt gebruikt. Apose.CAD kan tekeningen exporteren met tekst geschreven in SHX en heeft verschillende opties om dit te doen. De eenvoudigste manier om dit te doen is gewoon de 
**ShxFonts** eigenschap van 
**CadRasterizationOptions** object te gebruiken.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
