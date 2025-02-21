---
title: Ondersteuning van CTB-bestanden
type: docs
weight: 40
url: /nl/java/developer-guide/support-ctb/
---

## **Ondersteuning van CTB-bestanden**

Soms kunnen kleuren, lijngewichten en andere opties voor tekeningen niet alleen vanuit de tekeningen zelf, maar ook vanuit plotstijlen in afzonderlijke CTB-bestanden worden gebruikt. 
De eenvoudigste manier om deze informatie te gebruiken, is door de overeenkomstige CTB-bestanden naast het bestand met de tekening in DWG/DXF-indeling te plaatsen, en de informatie vanuit die bestanden zal automatisch worden toegepast tijdens export.

Het is ook mogelijk om alle CTB-bestanden te laden in de vorm van een Stream met behulp van 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) eigenschap van 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) object.

Hier is een voorbeeld van hoe je dit doet:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
