---
title: स्थापना
type: docs
weight: 30
url: /hi/java/getting-started/installation/
---

## **Maven Repository से Aspose.CAD for Java स्थापित करना**

Aspose सभी Java APIs को [Maven repository](https://releases.aspose.com/java/repo/com/aspose/) पर होस्ट करता है। आप सरल कॉन्फ़िगरेशन के साथ अपने Maven प्रोजेक्ट्स में सीधे [Aspose.CAD for Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API का उपयोग कर सकते हैं।

### **Maven Repository कॉन्फ़िगरेशन निर्दिष्ट करें**

सबसे पहले, आपको अपने Maven pom.xml में Aspose Maven Repository कॉन्फ़िगरेशन/स्थान निर्दिष्ट करना होगा, जैसे:

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

### **Aspose.CAD for Java API निर्भरता परिभाषित करें**

फिर अपने pom.xml में Aspose.CAD for Java API निर्भरता को इस प्रकार परिभाषित करें:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

उपरोक्त चरणों को पूरा करने के बाद, Aspose.CAD for Java निर्भरता अंततः आपके Maven प्रोजेक्ट में परिभाषित होगी।

## **समर्थित प्लेटफ़ॉर्म**

Aspose.CAD for Java सबसे लोकप्रिय विकास और तैनाती प्लेटफ़ॉर्म का समर्थन करता है।

|**विशेषता**|**विवरण**|
| :- | :- |
|डेस्कटॉप एप्लिकेशन|Aspose.CAD for Java को MS Windows में डेस्कटॉप एप्लिकेशन विकसित करने के लिए उपयोग किया जा सकता है।|
|एंटरप्राइज वेब एप्लिकेशन|Aspose.CAD for Java पूरी तरह से वेब एप्लिकेशन का समर्थन करता है।|
|लिनक्स/यूनिक्स|Aspose.CAD for Java एक प्लेटफ़ॉर्म-स्वतंत्र API है और लिनक्स और यूनिक्स वातावरण में काम कर सकता है।|

## **समर्थित Java संस्करण**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
