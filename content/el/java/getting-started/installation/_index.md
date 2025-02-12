---
title: Εγκατάσταση
type: docs
weight: 30
url: /el/java/getting-started/installation/
---

## **Εγκαθιστώντας το Aspose.CAD για Java από το Maven Repository**

Το Aspose φιλοξενεί όλες τις Java APIs στο [Maven repository](https://releases.aspose.com/java/repo/com/aspose/). Μπορείτε εύκολα να χρησιμοποιήσετε την [Aspose.CAD για Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API απευθείας στα έργα Maven σας με απλές ρυθμίσεις.

### **Καθορίστε τη Ρύθμιση του Maven Repository**

Αρχικά, χρειάζεται να καθορίσετε τη ρύθμιση/τοποθεσία του Aspose Maven Repository στο αρχείο pom.xml σας ως εξής:

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

### **Ορίστε την Εξάρτηση της Aspose.CAD για Java API**

Στη συνέχεια, ορίστε την εξάρτηση της Aspose.CAD για Java API στο αρχείο pom.xml σας ως εξής:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Μετά την ολοκλήρωση των παραπάνω βημάτων, η εξάρτηση Aspose.CAD για Java θα καθοριστεί τελικά στο έργο Maven σας.

## **Υποστηριζόμενες Πλατφόρμες**

Η Aspose.CAD για Java υποστηρίζει τις πιο δημοφιλείς πλατφόρμες ανάπτυξης και ανάπτυξης.

|**Χαρακτηριστικό**|**Περιγραφή**|
| :- | :- |
|Εφαρμογές Επιτραπέζιων Υπολογιστών|Η Aspose.CAD για Java μπορεί να χρησιμοποιηθεί για την ανάπτυξη εφαρμογών Επιτραπέζιων υπολογιστών σε MS Windows.|
|Επιχειρησιακές Εφαρμογές Ιστού|Η Aspose.CAD για Java υποστηρίζει πλήρως τις εφαρμογές Ιστού.|
|Linux/Unix|Η Aspose.CAD για Java είναι μια ανεξάρτητη πλατφόρμα API και μπορεί να λειτουργήσει σε περιβάλλοντα Linux και Unix.|

## **Υποστηριζόμενες Εκδόσεις Java**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
