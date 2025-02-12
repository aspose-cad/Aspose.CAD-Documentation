---
title: Εξαγωγή ΔGN AutoCAD
type: docs
weight: 50
url: /el/java/developer-guide/exporting-dgn-autocad/
---

## **Εξαγωγή μορφής ΔGN AutoCAD σε PDF**

Το Aspose.CAD για το API Java έχει εισαγάγει τη δυνατότητα φόρτωσης ενός [ΔGN](https://docs.fileformat.com/cad/dgn/) αρχείου AutoCAD και μετατροπής του σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η κλάση [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) εξυπηρετεί το σκοπό αυτό.

Πρέπει να φορτώσετε ένα υπάρχον αρχείο ΔGN ως [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Δημιουργήστε μια περίπτωση της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και ρυθμίστε διαφορετικές ιδιότητες. Δημιουργήστε μια περίπτωση της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) και περάστε την περίπτωση της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Τώρα καλέστε τη μέθοδο [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) της κλάσης [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Δείγμα Κώδικα

Ακολουθεί η επίδειξη του κώδικα για την εξαγωγή/μετατροπή ΔGN σε μορφή PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Εξαγωγή μορφής ΔGN AutoCAD σε μορφή Ράστερ Εικόνας**

Το Aspose.CAD για το API Java έχει εισαγάγει τη δυνατότητα φόρτωσης ενός [ΔGN](https://docs.fileformat.com/cad/dgn/) αρχείου AutoCAD και μετατροπής του σε μια εικόνα ράστερ. Η κλάση [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) εξυπηρετεί το σκοπό αυτό.

Πρέπει να φορτώσετε ένα υπάρχον αρχείο ΔGN ως [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Δημιουργήστε μια περίπτωση της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και ρυθμίστε διαφορετικές ιδιότητες. Δημιουργήστε μια περίπτωση της κλάσης [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) και περάστε την περίπτωση της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Τώρα καλέστε τη μέθοδο [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) της κλάσης [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Δείγμα Κώδικα

Ακολουθεί η επίδειξη του κώδικα για την εξαγωγή/μετατροπή [ΔGN](https://docs.fileformat.com/cad/dgn/) σε εικόνα [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
