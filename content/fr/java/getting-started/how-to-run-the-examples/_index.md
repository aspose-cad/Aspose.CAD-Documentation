---
title: Comment exécuter les exemples
type: docs
weight: 70
url: /fr/java/getting-started/how-to-run-the-examples/
---

## **Télécharger depuis GitHub**

Tous les exemples d'Aspose.CAD pour Java sont hébergés sur [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Vous pouvez soit cloner le dépôt en utilisant votre client Github préféré, soit télécharger le fichier ZIP [ici](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Extrayez le contenu du fichier ZIP dans un dossier de votre ordinateur. Tous les exemples se trouvent dans le dossier **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figure : Répertoire des exemples Aspose.CAD**|

## **Importer les exemples dans l'IDE**

Le projet utilise le système de construction Maven. Tout IDE moderne peut facilement ouvrir ou importer le projet et ses dépendances. Ci-dessous, nous vous montrons comment utiliser des IDE populaires pour construire et exécuter les exemples.

### **IntelliJ IDEA**

 Cliquez sur le menu **Fichier** et choisissez **Ouvrir**. Parcourez le dossier du projet et sélectionnez le fichier **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Figure : Sélectionner un fichier ou un répertoire à importer**|
Il ouvrira le projet et téléchargera les dépendances automatiquement. Dans l'onglet Projet, parcourez les exemples dans le dossier **src/main/java**. Pour exécuter un exemple, il suffit de faire un clic droit sur le fichier et de choisir "Exécuter ..", l'exemple sera exécuté et la sortie sera affichée dans la fenêtre de console intégrée.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Figure : Exécuter l'exemple**|

### **Eclipse**

Cliquez sur le menu **Fichier** et choisissez **Importer**. Sélectionnez **Maven** - Projets Maven existants.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Figure : Importer**|
Parcourez le dossier que vous avez cloné ou téléchargé depuis GitHub et sélectionnez le fichier **pom.xml**. Cela ouvrira le projet et téléchargera les dépendances automatiquement. Dans l'onglet Package Explorer, parcourez les exemples dans le dossier **src/main/java**. Pour exécuter un exemple, il suffit de faire un clic droit sur le fichier et de choisir **Exécuter en tant que** - **Application Java**, l'exemple sera exécuté et la sortie sera affichée dans la fenêtre de console intégrée.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figure : Exécuter l'exemple**|

### **NetBeans**

Cliquez sur le menu **Fichier** et choisissez **Ouvrir le projet**. Parcourez le dossier que vous avez cloné ou téléchargé depuis GitHub. L'icône du dossier **Examples** indiquera qu'il s'agit d'un projet Maven. Sélectionnez Examples et ouvrez-le.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Figure : Ouvrir le projet**|
Cela ouvrira le projet et téléchargera les dépendances automatiquement. Dans l'onglet Projets, parcourez les exemples dans **paquets sources**. Pour exécuter un exemple, il suffit de faire un clic droit sur le fichier et de choisir **Exécuter le fichier**, l'exemple sera exécuté et la sortie sera affichée dans la fenêtre de console intégrée.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Figure : Exécuter l'exemple**|

## **Ajouter la bibliothèque Aspose.CAD dans le dépôt local Maven**

Lorsque vous importez le projet **Exemples Aspose.CAD** dans l'IDE, Maven télécharge automatiquement le fichier JAR aspose.cad depuis [Aspose Maven Repository](https://releases.aspose.com/java/repo/). Si vous n'avez pas accès à Internet, vous pouvez ajouter le JAR manuellement dans votre dépôt local.

### **mvn install**

Téléchargez le [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), extrayez-le et copiez le aspose.cad-version.jar ailleurs, par exemple, sur le disque C. Exécutez la commande suivante :

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Maintenant, le **aspose.cad** jar est copié dans votre dépôt local Maven.

### **pom.xml**

Après l'installation, déclarez simplement la coordonnée **aspose.cad** dans le pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Fait**

Construisez-le, maintenant le **aspose.cad** jar peut être récupéré depuis votre dépôt local Maven.

## **Contribuer**

Si vous souhaitez ajouter ou améliorer un exemple, nous vous encourageons à contribuer au projet. Tous les exemples et projets de démonstration dans ce dépôt sont open source et peuvent être utilisés librement dans vos propres applications.

Pour contribuer, vous pouvez forker le dépôt, modifier le code source et soumettre une Pull Request. Nous examinerons les modifications et les incluerons dans le dépôt si elles sont jugées utiles.
