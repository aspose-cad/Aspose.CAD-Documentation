---
title: Instalação
type: docs
weight: 30
url: /pt/java/getting-started/installation/
---

## **Instalando Aspose.CAD para Java a partir do Repositório Maven**

Aspose hospeda todas as APIs Java no [repositório Maven](https://releases.aspose.com/java/repo/com/aspose/). Você pode usar facilmente a API [Aspose.CAD para Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) diretamente em seus projetos Maven com configurações simples.

### **Especificar a Configuração do Repositório Maven**

Primeiro, você precisa especificar a configuração/localização do Repositório Maven do Aspose em seu pom.xml do Maven da seguinte forma:

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

### **Definir a Dependência da API Aspose.CAD para Java**

Em seguida, defina a dependência da API Aspose.CAD para Java em seu pom.xml da seguinte forma:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Após realizar os passos acima, a dependência do Aspose.CAD para Java será finalmente definida em seu projeto Maven.

## **Plataformas Suportadas**

Aspose.CAD para Java suporta as plataformas de desenvolvimento e implantação mais populares.

|**Recurso**|**Descrição**|
| :- | :- |
|Aplicações de Desktop|Aspose.CAD para Java pode ser usado para desenvolver aplicativos de Desktop em MS Windows.|
|Aplicações Web Empresariais|Aspose.CAD para Java suporta completamente aplicações Web.|
|Linux/Unix|Aspose.CAD para Java é uma API independente de plataforma e pode funcionar em um ambiente Linux e Unix.|

## **Versões Java Suportadas**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
