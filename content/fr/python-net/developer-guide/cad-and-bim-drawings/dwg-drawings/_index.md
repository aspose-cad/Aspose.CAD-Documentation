---
title: Dessins DWG
type: docs
weight: 70
url: /fr/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Exportation des dessins DWG vers PDF**

Aspose.CAD pour l'API Python peut charger des dessins AutoCAD au format [DWG](https://docs.fileformat.com/cad/dwg/) et les convertir en [PDF](https://docs.fileformat.com/pdf/). Ce sujet explique l'utilisation de l'API Aspose.CAD pour réaliser la conversion de DWG en format PDF à travers des étapes simples comme défini ci-dessous.

{{% alert color="primary" %}}

L'API prend en charge les révisions DWG suivantes d'AutoCAD :

- Version 16.0, sortie 18 de DWG 2004
- Version 16.1 de DWG 2005
- Version 18.0 de DWG 2010
- Version 19.0 de DWG 2013

{{% /alert %}}

### **Format de fichier DWG**

Un [DWG](https://docs.fileformat.com/cad/dwg/) est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Les données d'image vectorielle fournissent des instructions à l'application CAD sur la manière d'afficher le DWG ; les métadonnées peuvent contenir une variété d'informations sur le fichier y compris des données spécifiques à l'emplacement et aussi des données client. Les spécifications ouvertes pour le format de fichier DWG peuvent être trouvées [dans ce PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convertir les fichiers DWG en PDF**

Les étapes simples suivantes sont requises pour convertir [DWG](https://docs.fileformat.com/cad/dwg/) en [PDF](https://docs.fileformat.com/pdf/).

1. Charger le fichier DWG dans une instance de **Image**.
1. Créer un objet de la classe **CadRasterizationOptions** et définir les propriétés **page_height** et **page_width**.
1. Créer un objet de la classe **PdfOptions** et définir la propriété **VectorRasterizationOptions**.
1. Appeler **Image.save** en passant un objet de **PdfOptions** comme le deuxième paramètre.

L'exemple de code ci-dessous montre comment exporter les dessins DWG vers PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **Primitifs AutoCAD pris en charge**

Les primitifs AutoCAD suivants sont pris en charge.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Exportation d'une mise en page DWG spécifique vers PDF**

Cette approche fonctionne comme suit :

1. Charger un fichier DWG en utilisant la méthode de fabrique **Aspose.CAD.Image.load**.
1. Créer une instance de la classe **CadRasterizationOptions** et définir la hauteur et la largeur de la page résultante.
1. Définir la propriété **Layouts** pour l'objet **CadRasterizationOptions**.
1. Créer une instance de la classe **PdfOptions** et définir sa propriété **VectorRasterizationOptions**.
1. Exporter l'image en PDF en utilisant la méthode **Image.save()**.

L'exemple de code ci-dessous montre comment convertir une mise en page spécifique de DWG en PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **Exportation de DWG vers PDF/A et PDF/E**

Cette approche fonctionne comme suit :

1. Charger un fichier DWG en utilisant la méthode de fabrique **Image.load**.
1. Créer une instance de la classe **CadRasterizationOptions**.
1. Créer une instance de la classe **PdfOptions** et définir sa propriété **VectorRasterizationOptions**.
1. Définir la propriété de conformité PDF et l'enregistrer.
1. Exporter l'image en PDF en utilisant la méthode **Image.save()**.

L'exemple de code ci-dessous montre comment convertir un fichier DWG en PDF/A et PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Convertir les dessins DWG en DXF**

Aspose.CAD offre la possibilité de charger un fichier DWG AutoCAD et de l'exporter au format DXF. L'approche de conversion de DWG en DXF fonctionne comme suit :

1. Charger le fichier de dessin DWG en utilisant la méthode de fabrique **Image.load**.
1. Exporter le dessin DWG en DXF en utilisant la méthode **Image.save()**.

L'exemple de code ci-dessous montre comment convertir un fichier DWG en format DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Convertir les dessins DWG en SVG**

Aspose.CAD pour l'API Python peut charger des dessins AutoCAD au format DWG et les convertir en SVG. Ce sujet explique l'utilisation de l'API Aspose.CAD pour réaliser la conversion de DWG en format SVG à travers des étapes simples comme défini ci-dessous.

1. Charger le fichier DWG dans une instance de **Image**.
1. Créer un objet de la classe **SvgOptions** et définir les propriétés requises.
1. Exporter le dessin DWG en SVG en utilisant la méthode **Image.save()**.

L'exemple de code ci-dessous montre comment convertir un fichier DWG en format SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
