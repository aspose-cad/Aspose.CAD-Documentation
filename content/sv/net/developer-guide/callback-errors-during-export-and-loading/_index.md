---
title: Återkopplingsfel under export och inläsning
type: docs
weight: 40
url: /sv/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Översikt över återkopplingsfel under export och inläsning**

Det är möjligt att vi under export eller inläsning av ritningen kan stöta på fel relaterade till filens struktur 
(t.ex. att sektioner i filen nu krävs men inte tidigare). 
Vissa av dem är kritiska och i sådana fall kastas ett undantag, men vi kan också ignorera vissa av dem internt och meddela om det med hjälp av återkopplingsmeddelanden.
Hur som helst kräver alla dessa meddelanden uppmärksamhet eftersom de kan förklara t.ex. saknade entiteter i exportresultaten eller andra effekter.

### **Fel under export**

Det finns ett RenderResult-fält i [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
som inkluderar IsRenderComplete för att se om det har förekommit fel under exporten och skriva ut information om dem:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Fel under inläsning**

Vissa problem med ritningar kan observeras tidigare än den tidpunkt då exportprocessen startar. 
[**Fel**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) egenskapen i
 [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) objekt används för att lagra meddelanden om dem.
[**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) egenskapen är användbar för att avgöra om 
det krävs att kasta undantag vid inläsningsfel eller inte. 

Här är ett exempel på användning av Errors-egenskapen:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
