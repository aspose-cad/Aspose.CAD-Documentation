---
title: Exportation des polices SHX
type: docs
weight: 40
url: /fr/python-net/developer-guide/export-shx-fonts/
---

## **Exporter des polices SHX pour des dessins DXF/DWG**

Certains dessins peuvent contenir des polices au format spécial SHX, qui stocke les symboles de la police sous forme de formes. Ce format nécessite une procédure de chargement supplémentaire pour chaque police utilisée dans le dessin. Apose.CAD peut exporter des dessins avec du texte écrit en SHX et propose différentes options pour cela. La manière la plus simple de procéder est simplement d'utiliser la propriété 
**ShxFonts** de l'objet 
**CadRasterizationOptions**.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
