---
title: SHX-lettertypes exporteren
type: docs
weight: 40
url: /nl/net/developer-guide/export-shx-fonts/
---

## **SHX-lettertypes exporteren voor DXF/DWG-tekeningen**

Sommige tekeningen kunnen lettertypes in een speciaal SHX-formaat bevatten, dat de symbolen van het lettertype in de vorm van vormen opslaat. Dit formaat vereist een aanvullende
laadprocedure voor elk lettertype dat in de tekening wordt gebruikt. Apose.CAD kan tekeningen exporteren met tekst geschreven in SHX en heeft verschillende opties om dit te doen. De eenvoudigste manier om dit te doen is gewoon de 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) eigenschap van 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) object te gebruiken.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


Het is mogelijk om het instellen van alle paden naar meerdere SHX-lettertypes te vermijden met het volgende voorbeeld:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts met map voorbeeld.cs">}}
	
Elk SHX-lettertype komt met de juiste codepagina die eraan is gekoppeld. Deze associaties zijn bekend en gedeeltelijk ingebed in de Aspose.CAD voor bekende SHX-lettertypes.
In het geval dat een aangepast SHX-lettertype wordt gebruikt, is het mogelijk om de ShxCodePages-eigenschap toe te passen en het pad naar het SHX-bestand en de bijbehorende codepagina in te stellen. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages voorbeeld.cs">}}
