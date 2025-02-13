---  
title: Lire, mettre à jour et écrire un fichier DWG  
type: docs  
weight: 11  
url: /fr/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/  
---  
  
## **Comment lire, mettre à jour et écrire un fichier DWG**  
  
**Problème :** Comment lire, mettre à jour et écrire un fichier DWG.  
  
**Conseils :** Pour ce faire, vous pouvez obtenir le fichier en utilisant la méthode load, obtenir les entités nécessaires et y apporter des modifications, comme changer les points de départ et d'arrivée ou l'épaisseur des lignes.  
  
**Remarque :** Cet extrait de code montre un exemple de lecture d'un fichier dwg, de modification d'objets : les positions des lignes, des cercles, des valeurs de texte (vous pouvez ajouter des changements à d'autres objets et leurs valeurs pour lesquels la lecture/l'écriture est prise en charge) et ensuite les enregistrer dans un nouveau fichier. Ainsi, vous pouvez ouvrir un nouveau fichier dans AutoCAD et voir des objets avec des valeurs modifiées.  
  
**Exemple :**  
  
{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
