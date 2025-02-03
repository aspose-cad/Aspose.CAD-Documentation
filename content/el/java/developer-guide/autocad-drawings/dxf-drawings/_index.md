---
title: DXF Σχέδια
type: docs
weight: 60
url: /el/java/dxf-drawings/
---

## **Εξαγωγή DXF Σχεδίων σε PDF**

Aspose.CAD παρέχει τη δυνατότητα να φορτώνει οντότητες σχεδίων DXF του AutoCAD και να τις αποδίδει ως ένα ολόκληρο σχέδιο σε μορφή PDF. Η προσέγγιση μετατροπής DXF σε PDF λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίου DXF χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και ρυθμίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) και ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Καλέστε το Image.Save περνώντας ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ως δεύτερη παράμετρο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο χρησιμοποιώντας τις προεπιλεγμένες ρυθμίσεις.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Υποστηριζόμενες Μορφές**

Αυτή τη στιγμή υποστηρίζουμε πλήρως τις μορφές αρχείων DXF 2010 του AutoCAD. Οι προηγούμενες εκδόσεις DXF δεν εγγυώνται ότι είναι 100% έγκυρες. Σκοπεύουμε να συμπεριλάβουμε περισσότερες μορφές και δυνατότητες στις μελλοντικές εκδόσεις του Aspose.CAD.

### **Υποστηριζόμενες Οντότητες**

Αυτή τη στιγμή υποστηρίζουμε όλες τις ευρέως διαδεδομένες 2D οντότητες και τις βασικές προεπιλεγμένες παραμέτρους τους ως εξής:

1. Ευθυγραμμισμένη Διάσταση
1. Γωνιακή Διάσταση
1. Τόξο
1. Χαρακτηριστικό
1. Αναφορά Μπλοκ
1. Κύκλος
1. Διάσταση Διάμετρος
1. Ελλειψοειδής
1. Γέμισμα
1. Γραμμή
1. Πολυγραμμικό Κείμενο
1. Διάσταση Ορνιθών
1. Σημείο
1. Πολυγραμμή
1. Ακτινωτή Διάσταση
1. Ακτίνα
1. Περιστροφή Διάστασης
1. Πίνακας
1. Κείμενο
1. Χωρική Γραμμή

{{% alert color="primary" %}}

Εάν κατά την ανάλυση συναντήσουμε κάποια οντότητα ή ιδιότητα που δεν υποστηρίζουμε, η οντότητα ή η ιδιότητα θα αγνοηθεί σιωπηλά.

{{% /alert %}}

### **Διαχείριση Μνήμης**

Η ιδιότητα [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) μπορεί να χρησιμοποιηθεί για τον έλεγχο της ανακατανομής μνήμης. Η ανακατανομή είναι πιο πιθανό να συμβεί για προ-κατανεμημένα cache. Μπορεί να συμβεί όταν το σύστημα διαπιστώσει ότι ο κατανεμημένος χώρος δεν θα είναι επαρκής.

- Εάν η [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) έχει οριστεί στην προεπιλεγμένη τιμή, **False**, ο χώρος ανακατανεμηθεί στο ίδιο μέσο.
- Όταν οριστεί σε **True**, η ανακατανομή δεν μπορεί να υπερβεί τον μέγιστο καθορισμένο χώρο. Σε αυτήν την περίπτωση, το υπάρχον κατανεμημένο cache μνήμης (το οποίο απαιτεί ανακατανομή) απελευθερώνεται και ο επιπλέον χώρος κατανεμηθεί στον δίσκο.

## **Εξαγωγή Συγκεκριμένου Επίπεδου DXF Σχεδίων σε PDF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Ανοίξτε ένα αρχείο σχεδίου DXF χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και προσδιορίστε τις ιδιότητες [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Προσθέστε επίπεδα στο αντικείμενο της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Δημιουργήστε μια παρουσία της [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Εξάγετε το σχέδιο σε PDF χρησιμοποιώντας τη μέθοδο  [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα συγκεκριμένο επίπεδο DXF σε PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Εξαγωγή Συγκεκριμένου Επιπέδου DXF Σχεδίων σε Εικόνα**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Ανοίξτε ένα αρχείο σχεδίου DXF χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και προσδιορίστε τις ιδιότητες [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Προσθέστε επίπεδα στο αντικείμενο της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Δημιουργήστε μια παρουσία της [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) & ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Εξάγετε το σχέδιο σε PDF χρησιμοποιώντας τη μέθοδο [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα συγκεκριμένο επίπεδο DXF σε Εικόνα.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Απόδοση αρχείων PDF ως μέρος του DXF σχεδίου**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίου DXF χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και φορτώστε τα αρχεία PDF.
1. Ρυθμίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Καλέστε το [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) και αποθηκεύστε το αρχείο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να αποδώσετε αρχεία PDF ως μέρος του DXF σχεδίου.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Εξαγωγή DXF σε WMF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίου DXF χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και φορτώστε τα αρχεία PDF.
1. Ρυθμίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Καλέστε το [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) και αποθηκεύστε το αρχείο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εξαγάγετε το DXF σε WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Υποστήριξη για Αποθήκευση Αρχείων DXF**

Η Aspose.CAD παρέχει τη δυνατότητα να φορτώνει αρχεία DXF του AutoCAD, να κάνουν αλλαγές σε αυτά και να τα αποθηκεύει ξανά ως αρχείο DXF. Το παρακάτω δείγμα κώδικα δείχνει πώς να επιτευχθούν οι καθορισμένες απαιτήσεις.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Εξαγωγή ενσωματωμένου DGN υποστρώματος για μορφή DXF**

Η Aspose.CAD παρέχει τη δυνατότητα να φορτώνει αρχεία DXF του AutoCAD και να εξάγει το ενσωματωμένο DGN υπόστρωμα για μορφή DXF.

Το παρακάτω δείγμα κώδικα δείχνει πώς να επιτευχθούν οι καθορισμένες απαιτήσεις.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Εξαγωγή Συγκεκριμένου Επίπεδου DXF σε PDF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Ανοίξτε ένα αρχείο σχεδίου DXF χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και προσδιορίστε τις ιδιότητες [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Προσδιορίστε τα επιθυμητά ονόματα διάταξης χρησιμοποιώντας την ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Δημιουργήστε μια παρουσία της [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Εξάγετε το σχέδιο σε PDF χρησιμοποιώντας τη μέθοδο [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε μια συγκεκριμένη διάταξη DXF σε PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Η ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) είναι τύπου πίνακα συμβολοσειρών, οπότε μπορείτε να προσδιορίσετε περισσότερες από μία διατάξεις ταυτόχρονα για δυνατή μετατροπή σε μορφή PDF. Όταν ορίζετε πολλές διατάξεις για την ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) , το προκύπτον PDF θα έχει πολλές σελίδες, όπου κάθε σελίδα αντιπροσωπεύει μια ατομική διάταξη AutoCAD.

{{% /alert %}}

## **Πρόσβαση σε Αντικείμενα ATTRIB και MTEXT**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Ανοίξτε ένα αρχείο σχεδίου DXF χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Προσπελάστε τις οντότητες μέσα στο αρχείο CAD.
1. Ελέγξτε για τις οντότητες [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) και [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Προσθέστε σε προσωρινή λίστα για περαιτέρω επεξεργασία.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Αποσύνθεση Αντικειμένων CAD Insert**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Ανοίξτε ένα αρχείο σχεδίου **DXF** χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Προσπελάστε τις οντότητες μέσα στο αρχείο CAD.
1. Ελέγξτε για τις οντότητες [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Ελέγξτε για τη λίστα τύπου [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Επεξεργαστείτε τις οντότητες.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Υποστήριξη Κοπής Μπλοκ**

Η Aspose.CAD παρέχει τη δυνατότητα κοπής μπλοκ. Η προσέγγιση κοπής μπλοκ λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίου DXF χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και φορτώστε τα αρχεία PDF.
1. Ρυθμίστε τις επιθυμητές ιδιότητες της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Καλέστε το [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ενώ περνάτε ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ως δεύτερη παράμετρο και αποθηκεύστε το αρχείο.

Το παρακάτω δείγμα κώδικα δείχνει πώς λειτουργεί η Κοπή Μπλοκ.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Εξαγωγή Εικόνων σε DXF**

Χρησιμοποιώντας το Aspose.CAD, μπορείτε να εξάγετε εικόνες στη μορφή DXF. Χρησιμοποιώντας αυτήν την προσέγγιση, μπορείτε να εκτελέσετε τις εξής ενέργειες:

1. Ρυθμίστε νέα γραμματοσειρά
1. Κρύψτε οντότητες
1. Ενημερώστε το κείμενο

Το παρακάτω δείγμα κώδικα σας δείχνει πώς να εκτελέσετε τις παραπάνω ενέργειες.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
