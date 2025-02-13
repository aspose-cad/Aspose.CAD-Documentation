---
title: Licences
type: docs
weight: 50
url: /fr/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Vous pouvez télécharger une version d'évaluation de **Aspose.CAD** pour Java depuis [sa page de téléchargement](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). La version d'évaluation offre exactement les mêmes capacités que la version sous licence du produit. De plus, la version d'évaluation devient simplement sous licence lorsque vous achetez une licence et ajoutez quelques lignes de code pour appliquer la licence.

Une fois que vous êtes satisfait de votre évaluation de **Aspose.CAD**, vous pouvez [acheter une licence](https://purchase.aspose.com/buy) sur le site Web d'Aspose. Familiarisez-vous avec les différents types d'abonnement proposés. Si vous avez des questions, n'hésitez pas à contacter l'équipe de vente d'Aspose.

Chaque licence Aspose comprend un abonnement d'un an pour des mises à jour gratuites vers toutes les nouvelles versions ou corrections qui sortent pendant cette période. Le support technique est gratuit et illimité et est fourni à la fois aux utilisateurs licenciés et aux utilisateurs d'évaluation.

{{% /alert %}}

Si vous souhaitez tester **Aspose.CAD** sans les limitations de la version d'évaluation, demandez une licence temporaire de 30 jours. Veuillez consulter [Comment obtenir une licence temporaire ?](https://purchase.aspose.com/temporary-license) pour plus d'informations.

## **Configuration d'une licence**

La licence est un fichier XML en texte brut qui contient des détails tels que le nom du produit, le nombre de développeurs à qui elle est licenciée, la date d'expiration de l'abonnement, etc. Le fichier est signé numériquement, donc ne modifiez pas le fichier ; même l'ajout involontaire d'un saut de ligne supplémentaire dans le fichier l'invalidra.

Vous devez définir une licence avant d'effectuer des opérations avec des fichiers AutoCAD. Vous devez définir une licence une seule fois par application ou processus.

La licence peut être chargée depuis un flux ou un fichier dans les emplacements suivants :

1. Chemin explicite.
1. Le dossier qui contient le fichier Aspose.CAD.jar.

Utilisez la méthode License.setLicense() pour activer le composant. Souvent, le moyen le plus simple de définir une licence est de placer le fichier de licence dans le même dossier que Aspose.CAD.jar et de spécifier simplement le nom du fichier sans chemin, comme montré dans l'exemple suivant :

### **Exemple 1**

Dans cet exemple, **Aspose.CAD** tentera de trouver le fichier de licence dans le dossier contenant les JARs de votre application.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Exemple 2**

Initialise une licence à partir d'un flux.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Valider la licence**

Il est possible de valider si la licence a été correctement configurée ou non. La classe License dispose du champ isLicensed qui renverra true si la licence a été correctement configurée.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("La licence est configurée!");

}

{{< /highlight >}}
