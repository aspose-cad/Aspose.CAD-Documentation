---
title: Travailler avec du texte
type: docs
weight: 40
url: /fr/net/developer-guide/drawing-api/work-with-text/
---

## **Travailler avec du texte**

Presque tous les dessins contiennent des objets texte et ces exemples montrent comment effectuer des opérations avec eux. 
Il existe différents types d'entités pour DWG/DXF qui peuvent stocker du texte, ce sont [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Les deux derniers types sont généralement liés 
à [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
et sont stockés à l'intérieur de celui-ci ou dans le bloc correspondant.

Voici quelques exemples décrivant des opérations avec du texte.

### **Recherche de texte**

Cet exemple montre comment trouver des valeurs de texte dans le fichier DWG/DXF et peut également être utilisé pour remplacer des valeurs de texte.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Ajout de nouveaux éléments de texte et de MText**

Voici un exemple de la façon d'ajouter de nouveaux objets Texte/MText au dessin. L'ajout de nouvelles entités peut changer la taille du dessin, donc il est recommandé
d'appeler UpdateSize() après ces opérations.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
