---
title: Εξαγωγή DGN AutoCAD
type: docs
weight: 50
url: /el/net/developer-guide/exporting-dgn-autocad/
---

## **Εξαγωγή Δεδομένων DGN AutoCAD σε PDF**

Η βιβλιοθήκη Aspose.CAD για .NET API έχει εισαγάγει τη λειτουργικότητα φόρτωσης ενός αρχείου DGN AutoCAD και μετατροπής του σε μορφή PDF. Η κλάση [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) εξυπηρετεί αυτόν τον σκοπό.

Πρέπει να φορτώσετε ένα υπάρχον αρχείο DGN ως [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Δημιουργήστε μια κλάση της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ορίστε διάφορες ιδιότητες. Δημιουργήστε μια κλάση της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και περάστε την κλάση [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Τώρα καλέστε τη μέθοδο [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) της κλάσης [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Δείγμα Κώδικα

Ακολουθεί η επίδειξη κώδικα για την μετατροπή/εξαγωγή [DGN](https://docs.fileformat.com/cad/dgn/) σε [PDF](https://docs.fileformat.com/pdf/) μορφή.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Εξαγωγή Δεδομένων DGN AutoCAD σε μορφή Ράστερ**

Η βιβλιοθήκη Aspose.CAD για .NET API έχει εισαγάγει τη λειτουργικότητα φόρτωσης ενός αρχείου DGN AutoCAD και μετατροπής του σε μια εικόνα ράστερ. Η κλάση [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) εξυπηρετεί αυτόν τον σκοπό.

Πρέπει να φορτώσετε ένα υπάρχον αρχείο DGN ως [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Δημιουργήστε μια κλάση της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ορίστε διάφορες ιδιότητες. Δημιουργήστε μια κλάση της [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) και περάστε την κλάση [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Τώρα καλέστε τη μέθοδο [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) της κλάσης [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Δείγμα Κώδικα

Ακολουθεί η επίδειξη κώδικα για την μετατροπή/εξαγωγή [DGN](https://docs.fileformat.com/cad/dgn/) σε εικόνα [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Υποστήριξη 3D οντοτήτων για DGN v7**

Η βιβλιοθήκη Aspose.CAD για .NET API έχει εισαγάγει τη λειτουργικότητα φόρτωσης ενός αρχείου [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD και υποστήριξης 3D οντοτήτων για DGN v7. Η κλάση [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) εξυπηρετεί αυτόν τον σκοπό. Κάθε εικόνα [DGN](https://docs.fileformat.com/cad/dgn/) υποστηρίζει 9 προκαθορισμένες προβολές. Είναι αριθμημένες από 1 έως 9. Αν δεν καθοριστεί προβολή κατά την εξαγωγή, για μορφές εξόδου με πολλές σελίδες (όπως PDF) θα εξάγονται όλες οι προβολές, καθεμία σε ξεχωριστή σελίδα. Οι 3D οντότητες υποστηρίζονται στη μορφή αρχείου DGN, καθώς και οι 2D. Για αυτό, χρησιμοποιείται η [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions), η οποία δεν χρησιμοποιεί πλέον το TypeOfEntities για τη μορφή DGN (υποστηρίζονται ταυτόχρονα και οι 2D και 3D).

### Δείγμα Κώδικα

Ακολουθεί το δείγμα κώδικα για να δείτε τα υποστηριζόμενα στοιχεία DGN.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
