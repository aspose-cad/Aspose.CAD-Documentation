---
title: 설치
type: docs
weight: 30
url: /ko/java/getting-started/installation/
---

## **Maven 저장소에서 Aspose.CAD for Java 설치하기**

Aspose는 모든 Java API를 [Maven 저장소](https://releases.aspose.com/java/repo/com/aspose/)에 호스팅합니다. 간단한 구성으로 [Aspose.CAD for Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API를 Maven 프로젝트에서 쉽게 사용할 수 있습니다.

### **Maven 저장소 구성 지정하기**

먼저, Maven pom.xml에서 Aspose Maven 저장소 구성/위치를 다음과 같이 지정해야 합니다:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>Aspose Java API</name>
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

### **Aspose.CAD for Java API 의존성 정의하기**

그 다음, pom.xml에서 Aspose.CAD for Java API 의존성을 다음과 같이 정의합니다:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

위의 단계를 수행한 후, Aspose.CAD for Java 의존성이 Maven 프로젝트에서 최종적으로 정의됩니다.

## **지원되는 플랫폼**

Aspose.CAD for Java는 가장 인기 있는 개발 및 배포 플랫폼을 지원합니다.

|**기능**|**설명**|
| :- | :- |
|데스크탑 애플리케이션|Aspose.CAD for Java는 MS Windows에서 데스크탑 애플리케이션을 개발하는 데 사용할 수 있습니다.|
|기업 웹 애플리케이션|Aspose.CAD for Java는 웹 애플리케이션을 완전히 지원합니다.|
|Linux/Unix|Aspose.CAD for Java는 플랫폼 독립적인 API로 Linux 및 Unix 환경에서 작동할 수 있습니다.|

## **지원되는 Java 버전**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
