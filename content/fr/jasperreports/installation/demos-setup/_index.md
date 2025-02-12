---
title: Configuration des démos
type: docs
weight: 40
url: /fr/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD pour JasperReports comprend un certain nombre de projets de démonstration pour vous aider à commencer.

Les démos fournies avec Aspose.CAD pour JasperReports sont des démos standard de JasperReports modifiées pour démontrer l'utilisation des nouveaux exportateurs.

{{% /alert %}}

Pour exécuter les démos d'Aspose.CAD pour JasperReports, procédez comme suit :

1. Téléchargez JasperReports (par exemple https://sourceforge.net/projects/jasperreports/files/archive/). Assurez-vous de télécharger l'ensemble du projet archivé avec le code source et les démos, et pas seulement un seul JAR.
1. Décompressez le projet archivé à un emplacement sur votre disque dur, par exemple C:\.
1. Copiez tous les dossiers de démo du dossier \samples de **aspose-cad-xx.x.zip** vers **\InstallDir\demo\samples**, où "\InstallDir" est l'emplacement où vous avez décompressé JasperReports. Cette étape est nécessaire car les scripts de construction de démo dépendent de la structure des dossiers de JasperReports, sinon vous devrez modifier les scripts de construction.
1. Copiez **aspose-cad-jasperreports-xx.x.jar** du dossier \lib de **aspose-cad-jasperreports-xx.x.zip** vers **\InstallDir\lib**.
1. Préparez l'outil de construction Ant et le gestionnaire de dépendances Ivy, consultez **\InstallDir\readme.txt**.
1. Modifiez le **build.xml** à **\InstallDir\demo\samples**, ajoutez l'aspose-cad-jasperreports-xx.x.jar dans le classpath :
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Changez le répertoire courant en **\InstallDir\demo\hsqldb** et exécutez la ligne de commande suivante :
   **Ant runServer**
1. Changez le répertoire courant en l'une des démos d'Aspose.CAD pour JasperReports, par exemple **\InstallDir\demo\samples\charts.ai** et exécutez les commandes suivantes dans la ligne de commande :
   **ant test** - pour produire des fichiers de rapport.
1. Ouvrez l'un des documents résultants pour visionner, par exemple **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
