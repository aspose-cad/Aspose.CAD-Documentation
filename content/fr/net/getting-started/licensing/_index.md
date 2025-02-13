---
title: Licences
type: docs
weight: 50
url: /fr/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Une fois que vous êtes satisfait de votre évaluation d'Aspose.CAD pour .NET, achetez une licence sur le site web d'Aspose : [Portail d'Achat](https://purchase.aspose.com/buy). Familiarisez-vous avec les différents types de licences disponibles. Si vous avez des questions, [contactez l'équipe de vente d'Aspose](https://about.aspose.com/contact) et ils se feront un plaisir de vous aider.

Chaque licence Aspose comprend un abonnement d'un an pour des mises à jour gratuites vers toutes les nouvelles versions ou corrections qui sortent pendant cette période. Nous fournissons un support technique gratuit et illimité aux utilisateurs licenciés et d'évaluation.

La licence est un fichier XML en texte brut qui contient des détails tels que le nom du produit, le nombre de développeurs licenciés, la date d'expiration de l'abonnement, etc. Le fichier est signé numériquement, donc ne modifiez pas le fichier : même l'ajout d'un retour à la ligne invalide le fichier.

{{% /alert %}}

## **Quand appliquer une licence**

Suivez ces simples règles :

- La licence doit être définie une seule fois par domaine d'application.
- Vous devez définir la licence avant d'utiliser d'autres classes Aspose.CAD.
- Appeler SetLicense plusieurs fois n'est pas nuisible, mais gaspille du temps processeur.
- Si vous développez une application Windows Forms ou console, appelez SetLicense dans le code de démarrage, avant d'utiliser les classes Aspose.CAD.
- Lorsque vous développez une application ASP.NET, appelez SetLicense depuis le fichier Global.asax.cs (Global.asax.vb), dans la méthode protégée Application_Start. Elle est appelée une fois lorsque l'application démarre.
- Ne pas appeler SetLicense depuis les méthodes Page_Load, car cela signifie que la licence sera chargée à chaque fois qu'une page web est chargée.
- Si vous développez une bibliothèque de classes, vous appelez SetLicense depuis un constructeur statique de la classe qui utilise Aspose.CAD. Le constructeur statique s'exécute avant la création d'une instance de votre classe, s'assurant que la licence Aspose.CAD est correctement définie.

## **Appliquer la licence en utilisant un fichier ou un objet Stream**

Utilisez la méthode **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** pour licencier le composant. Le moyen le plus simple de définir une licence est de placer le fichier de licence dans le même dossier que l'Aspose.CAD.dll et de spécifier le nom de fichier, sans chemin, comme indiqué ci-dessous.

### **Chargement d'une licence depuis un fichier**

Ce extrait de code initialise une licence stockée dans un fichier ou dans une ressource intégrée.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Chargement d'une licence depuis un objet Stream**

Ce extrait de code initialise la licence à partir d'un stream.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
