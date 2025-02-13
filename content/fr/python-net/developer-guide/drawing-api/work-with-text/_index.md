---
title: Travailler avec du texte
type: docs
weight: 40
url: /fr/python-net/developer-guide/drawing-api/work-with-text/
---

## **Travailler avec du texte**

Presque tous les dessins contiennent des objets texte et ces exemples montrent comment effectuer des opérations avec eux. 
Il existe différents types d'entités pour DWG/DXF qui peuvent stocker du texte, à savoir **CadText**,**CadMText**,CadAttDef, CadAttrib. Les deux derniers types sont généralement liés 
à **CadInsertObject** et sont stockés à l'intérieur ou dans le bloc correspondant.

Voici quelques exemples décrivant des opérations avec du texte.

### **Recherche du texte**

Cet exemple montre comment trouver des valeurs de texte dans le fichier DWG/DXF et peut également être utilisé pour le remplacement de valeurs de texte.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
