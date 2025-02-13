---
title: Exporter des polices SHX
type: docs
weight: 40
url: /fr/net/developer-guide/export-shx-fonts/
---

## **Exporter des polices SHX pour les dessins DXF/DWG**

Certains dessins peuvent contenir des polices au format spécial SHX, qui stocke les symboles de la police sous forme de formes. Ce format nécessite une procédure de chargement supplémentaire pour chaque police utilisée dans le dessin. Apose.CAD peut exporter des dessins avec du texte écrit en SHX et propose différentes options pour ce faire. Le moyen le plus simple de le faire est d'utiliser la propriété 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) de l'objet 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/).
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Exemple de ShxFonts.cs">}}


Il est possible d'éviter de configurer tous les chemins vers plusieurs polices SHX avec l'exemple suivant :

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Exemple de ShxFonts avec dossier.cs">}}
	
Chaque police SHX est associée à la bonne page de code. Ces associations sont connues et en partie intégrées dans l'Aspose.CAD pour les polices SHX connues. 
Dans le cas où une police SHX personnalisée est utilisée, il est possible d'appliquer la propriété ShxCodePages et de configurer le chemin vers le fichier SHX et la page de code correspondante. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "Exemple de ShxCodePages.cs">}}
