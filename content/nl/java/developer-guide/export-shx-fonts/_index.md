---
title: SHX-lettertypen exporteren
type: docs
weight: 40
url: /nl/java/developer-guide/export-shx-fonts/
---

## **SHX-lettertypen exporteren voor DXF/DWG-tekeningen**

Sommige tekeningen kunnen lettertypen in een speciaal SHX-formaat bevatten, dat symbolen van het lettertype opslaat in de vorm van vormen. Dit formaat vereist een extra laadprocedure voor elk lettertype dat in de tekening wordt gebruikt. Apose.CAD kan tekeningen exporteren met tekst geschreven in SHX en heeft verschillende opties om dit te doen. De eenvoudigste manier om dit te doen is door gewoon de [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) property van het [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) object te gebruiken.	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Elk SHX-lettertype heeft de juiste codepagina die eraan is gekoppeld. Deze associaties zijn bekend en gedeeltelijk ingebed in de Aspose.CAD voor bekende SHX-lettertypen. In het geval dat een aangepast SHX-lettertype wordt gebruikt, is het mogelijk om de **setShxCodePages** property toe te passen en het pad naar het SHX-bestand en de bijbehorende codepagina in te stellen.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
