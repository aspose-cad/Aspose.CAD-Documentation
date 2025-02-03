---
title: Δ Drawing DGN
type: docs
weight: 10
url: /el/java/dgn-drawing/
---

## **Σχεδίαση Μορφής DGN Ως Μέρος του DWG**

Το Aspose.CAD για Java επιτρέπει στους προγραμματιστές να εξάγουν ένα αρχείο DWG με ενσωματωμένο DGN υπόβαθρο. Ακολουθεί ο κώδικας που δείχνει πώς να αποκτήσετε πρόσβαση στο DGN υπόβαθρο μέσα σε ένα αρχείο DWG κατά την εξαγωγή του αρχείου DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Υποστήριξη 3D οντοτήτων για DGN v7**

Η API Aspose.CAD για Java έχει εισαγάγει τη λειτουργικότητα για φόρτωση ενός αρχείου DGN AutoCAD και υποστήριξη 3D οντοτήτων για DGN v7. Η κλάση [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) εξυπηρετεί αυτόν τον σκοπό. Κάθε εικόνα DGN υποστηρίζει 9 προεπιλεγμένες προβολές. Αριθμούνται από το 1 έως το 9. Εάν η προβολή δεν έχει καθοριστεί κατά την εξαγωγή, για πολλαπλά εξαγώγιμα μορφές (όπως PDF) όλες οι προβολές θα εξαχθούν, η κάθε μία σε διαφορετική σελίδα. Οι 3D οντότητες υποστηρίζονται στη μορφή αρχείου DGN, καθώς και οι 2D.
Το VectorRasterizationOptions.TypeOfEntities δεν χρησιμοποιείται πλέον για τη μορφή DGN (και οι 2D και 3D υποστηρίζονται ταυτόχρονα).

Δείγμα κώδικα για να δείτε τα υποστηριζόμενα στοιχεία DGN.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
