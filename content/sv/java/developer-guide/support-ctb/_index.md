---
title: Stöd för CTB-filer
type: docs
weight: 40
url: /sv/java/developer-guide/support-ctb/
---

## **Stöd för CTB-filer**

Ibland kan färg, linjetjocklekar och några andra alternativ för ritningar användas inte bara från ritningarna själva utan också från plottyper i separata CTB-filer. Det enklaste sättet att använda denna information är att sätta de motsvarande CTB-filerna nära filen med ritningen i DWG/DXF-format och informationen från dem kommer att tillämpas automatiskt under export.

Det är också möjligt att ladda alla CTB-filer i form av en ström med hjälp av 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) egenskapen av 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objektet.

Här är ett exempel på hur man gör detta:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
