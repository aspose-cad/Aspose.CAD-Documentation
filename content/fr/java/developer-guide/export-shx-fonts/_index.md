---
title: Exportation des polices SHX
type: docs
weight: 40
url: /fr/java/developer-guide/export-shx-fonts/
---

## **Exporter des polices SHX pour les dessins DXF/DWG**

Certains dessins peuvent contenir des polices au format spécial SHX, qui stocke des symboles de la police sous forme de formes.  
Ce format nécessite une procédure de chargement supplémentaire pour chaque police utilisée dans le dessin.  
Apose.CAD peut exporter des dessins avec du texte écrit en SHX et propose différentes options pour ce faire.  
Le moyen le plus simple de le faire consiste à utiliser la propriété [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) de l'objet [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Chaque police SHX est associée au codepage approprié. Ces associations sont connues et partiellement intégrées dans Aspose.CAD pour les polices SHX connues.  
Dans le cas où une police SHX personnalisée est utilisée, il est possible d'appliquer la propriété **setShxCodePages** et de définir le chemin du fichier SHX et du codepage correspondant.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
