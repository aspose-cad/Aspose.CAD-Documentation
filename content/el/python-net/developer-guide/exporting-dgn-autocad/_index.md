---
title: Εξαγωγή ΔGN AutoCAD
type: docs
weight: 50
url: /el/python-net/developer-guide/exporting-dgn-autocad/
---

## **Εξαγωγή ΔGN AutoCAD σε μορφή PDF**

Η API Aspose.CAD για Python έχει εισαγάγει τη δυνατότητα φόρτωσης ενός αρχείου ΔGN AutoCAD και μετατροπής του σε μορφή PDF. Η κλάση **CadImage** εξυπηρετεί αυτόν τον σκοπό.

Πρέπει να φορτώσετε ένα υπάρχον αρχείο ΔGN ως **CadImage**. Δημιουργήστε μια κατάσταση της κλάσης **CadRasterizationOptions** και ρυθμίστε διαφορετικές ιδιότητες. Δημιουργήστε μια κατάσταση της κλάσης **PdfOptions** και περάστε την κατάσταση της **CadRasterizationOptions**. Τώρα καλέστε τη μέθοδο **save** της κατάστασης της κλάσης **CadImage**.

### Δείγμα Κώδικα

Ακολουθεί η επίδειξη κώδικα για τη μετατροπή/εξαγωγή [DGN](https://docs.fileformat.com/cad/dgn/) σε μορφή [PDF](https://docs.fileformat.com/pdf/).


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Εξαγωγή ΔGN AutoCAD σε μορφή ράστερ εικόνας**

Η API Aspose.CAD για Python έχει εισαγάγει τη δυνατότητα φόρτωσης ενός αρχείου ΔGN AutoCAD και μετατροπής του σε μια ράστερ εικόνα. Η κλάση **CadImage** εξυπηρετεί αυτόν τον σκοπό.

Πρέπει να φορτώσετε ένα υπάρχον αρχείο ΔGN ως **CadImage**. Δημιουργήστε μια κατάσταση της κλάσης **CadRasterizationOptions** και ρυθμίστε διαφορετικές ιδιότητες. Δημιουργήστε μια κατάσταση της κλάσης **JpegOptions** και περάστε την κατάσταση της **CadRasterizationOptions**. Τώρα καλέστε τη μέθοδο **save** της κατάστασης της κλάσης **CadImage**.

### Δείγμα Κώδικα

Ακολουθεί η επίδειξη κώδικα για τη μετατροπή/εξαγωγή [DGN](https://docs.fileformat.com/cad/dgn/) σε εικόνα [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Υποστήριξη 3D οντοτήτων για DGN v7**

Η API Aspose.CAD για Python έχει εισαγάγει τη δυνατότητα φόρτωσης ενός [DGN](https://docs.fileformat.com/cad/dgn/) αρχείου AutoCAD και υποστήριξης 3D οντοτήτων για DGN v7. Η κλάση **CadImage** εξυπηρετεί αυτόν τον σκοπό. Κάθε εικόνα [DGN](https://docs.fileformat.com/cad/dgn/) υποστηρίζει 9 προκαθορισμένες προβολές. Είναι αριθμημένες από 1 έως 9. Εάν η προβολή δεν καθορίζεται κατά την εξαγωγή, για μορφές εξόδου πολλαπλών σελίδων (όπως PDF) θα εξάγονται όλες οι προβολές, κάθε μία σε ξεχωριστή σελίδα. Οι 3D οντότητες υποστηρίζονται σε μορφή αρχείου DGN, καθώς και οι 2D. Γι' αυτό χρησιμοποιούνται οι **VectorRasterizationOptions**, και ο τύπος οντοτήτων δεν χρησιμοποιείται πια για τη μορφή DGN (και οι δύο 2D και 3D υποστηρίζονται ταυτόχρονα).

### Δείγμα Κώδικα

Ακολουθεί το δείγμα κώδικα για να δείτε τα υποστηριζόμενα στοιχεία DGN.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
