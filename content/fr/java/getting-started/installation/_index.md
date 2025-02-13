---
title: Installation
type: docs
weight: 30
url: /fr/java/getting-started/installation/
---

## **Installation d'Aspose.CAD pour Java à partir du dépôt Maven**

Aspose héberge toutes les API Java sur le [dépôt Maven](https://releases.aspose.com/java/repo/com/aspose/). Vous pouvez utiliser facilement l'API [Aspose.CAD pour Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) directement dans vos projets Maven avec des configurations simples.

### **Spécifiez la configuration du dépôt Maven**

Tout d'abord, vous devez spécifier la configuration/emplacement du dépôt Maven d'Aspose dans votre fichier pom.xml Maven comme suit :

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>API Java Aspose</name>
        <url>https://releases.aspose.cloud/java/repo/</url>
        <snapshots>
            <enabled>false</enabled>
        </snapshots>
        <releases>
            <enabled>true</enabled>
        </releases>
    </repository>
</repositories>

{{< /highlight >}}

### **Définir la dépendance à l'API Aspose.CAD pour Java**

Ensuite, définissez la dépendance à l'API Aspose.CAD pour Java dans votre fichier pom.xml comme suit :

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Après avoir effectué les étapes ci-dessus, la dépendance d'Aspose.CAD pour Java sera enfin définie dans votre projet Maven.

## **Plateformes prises en charge**

Aspose.CAD pour Java prend en charge les plateformes de développement et de déploiement les plus populaires.

|**Fonctionnalité**|**Description**|
| :- | :- |
|Applications de bureau|Aspose.CAD pour Java peut être utilisé pour développer des applications de bureau sous MS Windows.|
|Applications Web d'entreprise|Aspose.CAD pour Java prend complètement en charge les applications Web.|
|Linux/Unix|Aspose.CAD pour Java est une API indépendante de la plateforme et peut fonctionner dans un environnement Linux et Unix.|

## **Versions Java prises en charge**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
