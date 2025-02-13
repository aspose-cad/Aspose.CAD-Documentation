---
title: Configuration des Démos
type: docs
weight: 40
url: /fr/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD pour Python comprend un certain nombre de projets de démonstration pour vous aider à démarrer.

Les démonstrations fournies avec Aspose.CAD pour Python sont des démonstrations standard de Python modifiées pour démontrer l'utilisation des nouveaux exportateurs.

{{% /alert %}}

Pour exécuter les démonstrations Aspose.CAD pour Python, effectuez les étapes suivantes :

1. Téléchargez Python (par exemple https://sourceforge.net/projects/python-net/files/archive/). Assurez-vous de télécharger l'ensemble du projet archivé avec le code source et les démonstrations, et pas seulement un seul JAR.
1. Décompressez le projet archivé à un emplacement sur votre disque dur, par exemple C:\.
1. Copiez tous les dossiers de démonstration du dossier \samples de **aspose-cad-xx.x.zip** vers **\InstallDir\demo\samples**, où "\InstallDir" est l'emplacement où vous avez décompressé Python. Cette étape est nécessaire car les scripts de construction de démo reposent sur la structure de dossier de Python, sinon vous devrez modifier les scripts de construction.
1. Copiez **aspose-cad-pythons-xx.x.jar** du dossier \lib de **aspose-cad-pythons-xx.x.zip** vers **\InstallDir\lib**.
1. Préparez l'outil de construction Ant et le gestionnaire de dépendances Ivy, voir **\InstallDir\readme.txt**.
1. Modifiez le **build.xml** à **\InstallDir\demo\samples**, ajoutez le aspose-cad-pythons-xx.x.jar dans le classpath :
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Changez le répertoire actuel vers **\InstallDir\demo\hsqldb** et exécutez la ligne de commande suivante :
   **ant runServer**
1. Changez le répertoire actuel vers l'une des démonstrations Aspose.CAD pour Python, par exemple **\InstallDir\demo\samples\charts.ai** et exécutez les commandes suivantes dans la ligne de commande :
   **ant test** - pour produire des fichiers de rapport.
1. Ouvrez l'un des documents résultants pour voir, par exemple **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
