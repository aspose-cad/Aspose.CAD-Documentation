---
title: Stöd för CTB-filer
type: docs
weight: 40
url: /sv/net/developer-guide/support-ctb/
---

## **Stöd för CTB-filer**

Ibland kan färg, linjevikter och vissa andra alternativ för ritningar användas inte bara från ritningarna själva utan också från plotstilar i separata CTB-filer. 
Det enklaste sättet att använda denna information är att placera de motsvarande CTB-filerna bredvid filen med ritningen i DWG/DXF-format och informationen från dem kommer att tillämpas
automatisk under export.

Det är också möjligt att ladda alla CTB-filer i form av Stream med hjälp av 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) egenskapen av 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) objektet.

Här är ett exempel på hur man gör detta:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
