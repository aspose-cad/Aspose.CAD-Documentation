---
title: Installation
type: docs
weight: 30
url: /fr/net/getting-started/installation/
---

## **Installation d'Aspose.CAD pour .NET via NuGet**

NuGet est le moyen le plus simple de télécharger et d'installer les API Aspose pour .NET. Ouvrez Microsoft Visual Studio et le gestionnaire de packages NuGet. Recherchez "aspose" pour trouver l'API Aspose souhaitée. Cliquez sur "Installer", l'API sélectionnée sera téléchargée et référencée dans votre projet.

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **Référencer Aspose.CAD depuis un projet .NET**

Suivez ces étapes (en supposant que vous utilisez Microsoft Visual Studio) :

1. Dans **Explorateur de solutions**, développez le nœud du projet auquel vous souhaitez ajouter une référence.
1. Cliquez avec le bouton droit sur le nœud **Références** pour le projet et sélectionnez **Ajouter une référence** dans le menu contextuel.
1. Dans la boîte de dialogue **Ajouter une référence**, parcourez l'emplacement du fichier DLL.
1. Sélectionnez le fichier DLL *Aspose.CAD* et cliquez sur le bouton **OK**.
1. La référence *Aspose.CAD* apparaîtra sous le nœud **Références** de votre projet.

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **Installer ou mettre à jour Aspose.CAD en utilisant la console du gestionnaire de packages**

Vous pouvez suivre les étapes ci-dessous pour référencer l'[API Aspose.CAD](https://www.nuget.org/packages/Aspose.CAD/) en utilisant la console du gestionnaire de packages :

1. Ouvrez votre solution/projet dans Visual Studio.
1. Sélectionnez Outils -> Gestionnaire de packages de bibliothèque -> Console du gestionnaire de packages dans le menu pour ouvrir la console du gestionnaire de packages.

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

Tapez la commande “**Install-Package Aspose.CAD**” et appuyez sur entrer pour installer la dernière version complète dans votre application. Alternativement, vous pouvez ajouter le suffixe "**-prerelease**" à la commande pour spécifier que la dernière version avec des correctifs doit également être installée.

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

Vous verrez que le message "Téléchargement d'Aspose.CAD..." apparaît en bas à gauche de la fenêtre indiquant que le téléchargement est en cours. 

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

Une fois téléchargé, vous verrez les messages de confirmation suivants. Si vous n'êtes pas familier avec l'[EULA d'Aspose](https://about.aspose.com/legal/eula), il est donc conseillé de lire la licence référencée dans l'URL.

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

Vous devriez maintenant constater qu'Aspose.CAD a été ajouté et référencé avec succès dans votre application.

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

Dans la console du gestionnaire de packages, vous pouvez également utiliser la commande “**Update-Package Aspose.CAD**” et appuyer sur entrer pour vérifier s'il y a des mises à jour du package Aspose.CAD et les installer si elles sont présentes. Vous pouvez également ajouter le suffixe "-prerelease" pour mettre à jour la dernière version.

## **Considérations lors de l'exécution dans un environnement de serveur partagé**

Tous les composants Aspose .NET sont recommandés pour être exécutés avec un ensemble d'autorisations de confiance complète. Cela est dû au fait que le composant Aspose .NET doit parfois accéder aux paramètres du registre et aux fichiers situés dans des emplacements autres que le répertoire virtuel par exemple pour lire les polices, etc. De plus, les composants Aspose.NET sont basés sur des classes système .NET de base, dont certaines nécessitent également une autorisation de confiance complète pour fonctionner dans certains cas.

Les fournisseurs de services Internet hébergeant plusieurs applications de différentes entreprises appliquent généralement un niveau de sécurité de confiance moyenne. Dans le cas de .NET 2.0, un tel niveau de sécurité peut imposer les contraintes suivantes qui pourraient affecter la capacité d'Aspose.CAD à fonctionner correctement.

- **RegistryPermission** n'est pas disponible. Cela signifie que vous ne pouvez pas accéder au registre, ce qui est nécessaire pour énumérer les polices installées lors du rendu de documents.
- **FileIOPermission** est restreint. Cela signifie que vous ne pouvez accéder qu'aux fichiers dans la hiérarchie de répertoires virtuels de votre application. Cela peut signifier que les polices ne peuvent pas être lues lors de l'exportation.

Pour ces raisons spécifiées ci-dessus, il est recommandé qu'Aspose.CAD soit exécuté avec des autorisations de pleine confiance. Vous constaterez que certaines fonctionnalités de la bibliothèque fonctionneront lors de l'exécution de différentes tâches en confiance moyenne, alors que d'autres ne fonctionneront pas (le rendu par exemple), ce qui peut être dû à des appels à GDI+ pour le traitement d'images.

## **Exigences système**

### **Systèmes d'exploitation**

Aspose.CAD pour .NET prend en charge tout système d'exploitation 32 bits ou 64 bits où le framework .NET ou Mono est installé, y compris, mais sans s'y limiter :

- Microsoft Windows desktop (XP, Vista, 7, 8, 10) et systèmes d'exploitation serveur (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS et autres)
- Mac OS X

### **Frameworks**

Aspose.CAD pour .NET prend en charge :

- Versions du framework .NET de 2.0 à 4.5, y compris les versions Client Profile
- .NET Core
- Mono 2.6.7 ou version ultérieure

### **Environnements de développement**

Vous pouvez utiliser Aspose.CAD pour .NET pour développer des applications dans n'importe quel environnement de développement qui cible la plateforme .NET, mais les environnements suivants sont explicitement pris en charge :

- Microsoft Visual Studio 2010 ou version ultérieure
- MonoDevelop 2.4 et version ultérieure
