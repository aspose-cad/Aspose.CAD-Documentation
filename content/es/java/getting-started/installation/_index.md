---
title: Instalación
type: docs
weight: 30
url: /es/java/installation/
---

## **Instalación de Aspose.CAD para Java desde el repositorio de Maven**

Aspose alberga todas las API de Java en el [repositorio de Maven](https://releases.aspose.com/java/repo/com/aspose/). Puedes usar fácilmente la API de [Aspose.CAD para Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) directamente en tus proyectos de Maven con configuraciones simples.

### **Especificar la configuración del repositorio de Maven**

Primero, necesitas especificar la configuración/ubicación del repositorio de Maven de Aspose en tu pom.xml de Maven de la siguiente manera:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>API Java de Aspose</name>
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

### **Definir la dependencia de la API Aspose.CAD para Java**

Luego define la dependencia de la API Aspose.CAD para Java en tu pom.xml de la siguiente manera:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Después de realizar los pasos anteriores, la dependencia de Aspose.CAD para Java finalmente se definirá en tu proyecto de Maven.

## **Plataformas soportadas**

Aspose.CAD para Java soporta las plataformas de desarrollo y despliegue más populares.

|**Característica**|**Descripción**|
| :- | :- |
|Aplicaciones de escritorio|Aspose.CAD para Java se puede utilizar para desarrollar aplicaciones de escritorio en MS Windows.|
|Aplicaciones web empresariales|Aspose.CAD para Java soporta completamente las aplicaciones web.|
|Linux/Unix|Aspose.CAD para Java es una API independiente de la plataforma y puede funcionar en un entorno Linux y Unix.|

## **Versiones de Java soportadas**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
