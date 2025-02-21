---
title: Callback-fouten tijdens export en laadproces
type: docs
weight: 40
url: /nl/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Overzicht van callback-fouten tijdens export en laadproces**

Het is mogelijk dat we tijdens het exporteren of laden van de tekening fouten tegenkomen die verband houden met de structuur van het bestand 
(bijv. secties in het bestand zijn nu vereist maar waren dat voorheen niet). 
Een aantal hiervan zijn kritiek en in dergelijke gevallen wordt een uitzondering opgegooid, maar we kunnen ook enkele van hen intern negeren en hierover informeren met behulp van callbackberichten.
Hoe dan ook, al deze berichten vereisen aandacht omdat ze bijvoorbeeld ontbrekende entiteiten in exportresultaten of andere effecten kunnen uitleggen.


### **Fouten tijdens export**

Er is een RenderResult-veld in [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
dat IsRenderComplete bevat om te controleren of er fouten waren tijdens de export en informatie daarover af te drukken:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Fouten tijdens laden**

Sommige problemen met tekeningen kunnen eerder worden waargenomen dan het exportproces begint. 
De [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) eigenschap in
 [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) object wordt gebruikt om berichten hierover op te slaan.
De [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) eigenschap is nuttig om te beslissen of 
het nodig is om een uitzondering op te gooien bij laadfouten of niet. 

Hier is een voorbeeld van het gebruik van de Errors-eigenschap:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
