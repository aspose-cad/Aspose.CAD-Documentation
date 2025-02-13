---
title: Comment exécuter les exemples
type: docs
weight: 70
url: /fr/net/showcases/comment-executer-les-exemples/
---

## **Exigences logicielles**

Veuillez vous assurer que vous remplissez les conditions suivantes avant de télécharger et d'exécuter les exemples.

1. Visual Studio 2010 ou version ultérieure
1. Gestionnaire de packages NuGet installé dans Visual Studio. Assurez-vous que la dernière version de l'API NuGet est installée dans Visual Studio. Pour des détails sur la façon d'installer le gestionnaire de packages NuGet, veuillez consulter https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. Allez dans Outils->Options->Gestionnaire de Packages NuGet->Sources de Packages et assurez-vous que l'option **nuget.org** est cochée
1. Le projet d'exemple utilise la fonctionnalité de restauration automatique des packages NuGet, donc vous devez avoir une connexion Internet active. Si vous n'avez pas de connexion Internet active sur la machine où les exemples doivent être exécutés, veuillez consulter [Installation](/fr/cad/net/installation/) pour ajouter une référence à Aspose.CAD.dll dans le projet d'exemple.

## **Télécharger depuis GitHub**

Tous les exemples d'Aspose.CAD pour .NET sont hébergés sur [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Vous pouvez soit cloner le dépôt à l'aide de votre client GitHub préféré, soit télécharger le fichier ZIP [ici](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Extrayez le contenu du fichier ZIP dans un dossier de votre ordinateur. Tous les exemples se trouvent dans le dossier **Examples**.
- Il y a un fichier de solution Visual Studio pour C#.
- Les projets sont créés dans Visual Studio 2013, mais les fichiers de solution sont compatibles avec Visual Studio 2010 SP1 et supérieur.
- Ouvrez le fichier de solution dans Visual Studio et construisez le projet.
- Lors de la première exécution, les dépendances seront automatiquement téléchargées via NuGet.
- Le dossier **Data** à la racine du dossier **Examples** contient les fichiers d'entrée utilisés par les exemples CSharp. Il est obligatoire que vous téléchargiez le dossier **Data** avec le projet d'exemples.
- Ouvrez le fichier RunExamples.cs, tous les exemples sont appelés depuis ici.
- Décommentez les exemples que vous souhaitez exécuter dans le projet.

N'hésitez pas à nous contacter via nos forums si vous avez des problèmes de configuration ou d'exécution des exemples.

## **Contribuer**

Si vous souhaitez ajouter ou améliorer un exemple, nous vous encourageons à contribuer au projet. Tous les exemples et projets de démonstration dans ce dépôt sont open source et peuvent être librement utilisés dans vos propres applications.

Pour contribuer, vous pouvez forker le dépôt, modifier le code source et créer une demande de tirage. Nous examinerons les modifications et les inclurons dans le dépôt si elles sont jugées utiles.
