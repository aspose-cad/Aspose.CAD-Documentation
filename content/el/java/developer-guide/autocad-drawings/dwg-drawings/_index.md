---
title: Σχέδια DWG
type: docs
weight: 40
url: /el/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Εξαγωγή Σχεδίων DWG σε PDF**

Το Aspose.CAD για το API Java μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να τα μετατρέψει σε PDF. Αυτό το θέμα εξηγεί τη χρήση του API Aspose.CAD για να επιτευχθεί η μετατροπή του DWG σε μορφή PDF μέσω απλών βημάτων όπως ορίζονται παρακάτω.

{{% alert color="primary" %}}

Το API υποστηρίζει τις παρακάτω εκδόσεις DWG AutoCAD:

- DWG 2004 έκδοση 16.0 κυκλοφορία 18
- DWG 2005 έκδοση 16.1
- DWG 2010 έκδοση 18.0
- DWG 2013 έκδοση 19.0

{{% /alert %}}

### **Μορφή Αρχείου DWG**

Ένα DWG είναι ένα δυαδικό αρχείο που περιέχει δεδομένα διανυσματικής εικόνας και μεταδεδομένα. Τα δεδομένα διανυσματικής εικόνας παρέχουν οδηγίες στην εφαρμογή CAD σχετικά με το πώς να εμφανίσει το DWG. Τα μεταδεδομένα μπορεί να περιέχουν μια ποικιλία πληροφοριών σχετικά με το αρχείο, συμπεριλαμβανομένων των τοποθεσιών δεδομένων και επίσης δεδομένα πελατών. Ανοικτές προδιαγραφές για τη μορφή αρχείου DWG μπορείτε να βρείτε [σε αυτό το PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Μετατροπή Αρχείων DWG σε PDF**

Τα παρακάτω απλά βήματα απαιτούνται για να μετατρέψετε το DWG σε PDF.

1. Φορτώστε το αρχείο DWG σε μια παρουσία του [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
2. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και ορίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
3. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
4. Καλέστε τη μέθοδο [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) και περάστε το αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ως δεύτερη παράμετρο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εξάγετε σχέδια DWG σε PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Δημιουργία Ενιαίου PDF με Διαφορετικά Μεγέθη Διάταξης**

Το Aspose.CAD για το Java επιτρέπει τη μετατροπή του αρχείου DWG σε ένα ενιαίο PDF με διαφορετικά μεγέθη διάταξης. Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας τη μέθοδο δημιουργίας [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Δημιουργήστε μια παρουσία της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και ορίστε το ύψος και το πλάτος της επιτυχημένης σελίδας.
3. Προσθέστε τις απαιτούμενες [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) για το αντικείμενο [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
4. Δημιουργήστε μια παρουσία της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
5. Εξάγετε την εικόνα σε PDF χρησιμοποιώντας τη μέθοδο [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Το παρακάτω δείγμα κώδικα δείχνει πώς να δημιουργήσετε ένα ενιαίο PDF με διαφορετικές διατάξεις.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Εξαγωγή DWG σε PDF/A και PDF/E**

Τα παρακάτω απλά βήματα απαιτούνται για να μετατρέψετε το DWG σε PDF.

1. Φορτώστε το αρχείο DWG σε μια παρουσία του [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
2. Δημιουργήστε ένα αντικείμενο της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) κλάσης και ορίστε τις [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) ιδιότητες.
3. Δημιουργήστε ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) κλάσης και ορίστε την [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) ιδιότητα.
4. Καλέστε τη [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) μέθοδο και περάστε το αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ως τη δεύτερη παράμετρο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εξάγετε σχέδια DWG σε PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Υποστηριζόμενα Στοιχεία AutoCAD**

Οι παρακάτω αρχές AutoCAD υποστηρίζονται.

- ΚΕΙΜΕΝΟ
- MTEXT
- ATTDEF
- ATTRIB
- ΤΟΞΟ
- ΕΛΛΕΙΨΗ
- ΣΚΙΑΣΗ
- ΗΓΕΤΗΣ
- ΣΗΜΕΙΟ
- ΚΟΡΥΦΗ 2D
- ΚΟΡΥΦΗ 3D
- ΠΟΛΥΓΡΑΜΜΟ 2D
- LWPOLYLINE
- ΑΚΤΙΝΑ
- ΚΟΙΛΟ
- ΔΙΑΣΤΑΣΗ
- ΔΙΑΣΤΑΣΗ ΓΡΑΜΜΙΚΗ
- ΔΙΑΣΤΑΣΗ ΕΥΘΕΙΑ
- ΔΙΑΣΤΑΣΗ ΓΩΝΙΑ 3Pt
- ΔΙΑΣΤΑΣΗ ΓΩΝΙΑ 2Ln
- ΔΙΑΣΤΑΣΗ ΡΑΔΙΟΥΣ
- ΔΙΑΣΤΑΣΗ ΔΙΑΜΕΤΡΟΥ
- ΣΧΗΜΑ
- ΣΤΕΓΑΝΟΔΙΑΦΟΡΑ
- SPLINE
- MLINE
- ΓΡΑΜΜΗ
- XLINE
- ΣΤΥΛ
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Εξαγωγή Σpecific DWG Layout σε PDF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας τη μέθοδο [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) κλάσης και ορίστε το ύψος και το πλάτος της επιτυχούς σελίδας.
3. Ορίστε την ιδιότητα [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) για το αντικείμενο [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
4. Δημιουργήστε μια παρουσία της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
5. Εξάγετε την εικόνα σε PDF χρησιμοποιώντας τη μέθοδο [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε μια συγκεκριμένη διάταξη του DWG σε PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Εξαγωγή DWG σε Raster ή PDF χρησιμοποιώντας Σταθερό Μέγεθος**

Το Aspose.CAD για το API Java μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να τα μετατρέψει σε PDF ή Raster χρησιμοποιώντας σταθερό μέγεθος.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εφαρμόσετε αυτή τη δυνατότητα.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Υποστήριξη στρογγυλών κρυμμένων γραμμών κατά την εξαγωγή DWG/DXF σε BMP και PDF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας την [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) μέθοδο δημιουργίας.
2. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) κλάσης.
3. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) κλάσης και ορίστε το ύψος και το πλάτος της επιτυχούς σελίδας.
4. Δημιουργήστε μια παρουσία της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
5. Εξάγετε την εικόνα σε PDF χρησιμοποιώντας τη [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) μέθοδο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εφαρμόσετε αυτή τη δυνατότητα.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Υποστήριξη για την ρύθμιση περιοχής εκτύπωσης για την εικόνα DWG στο εξαγόμενο PDF**

Το Aspose.CAD για το API Java μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να τα μετατρέψει σε PDF. Αυτό το θέμα εξηγεί τη χρήση του API Aspose.CAD για να επιτευχθεί η υποστήριξη για την ρύθμιση μιας περιοχής εκτύπωσης για την εικόνα DWG στο εξαγόμενο PDF.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εφαρμόσετε αυτή τη δυνατότητα.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Υποστήριξη για την ανάγνωση των μεταδεδομένων XREF για αρχείο DWG**

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας την [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) μέθοδο δημιουργίας.
2. Επιθεωρήστε κάθε οντότητα εικόνας.
3. Εάν η οντότητα είναι [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay), τότε οντότητα XREF με μεταδεδομένα.

Το παρακάτω δείγμα κώδικα δείχνει πώς να επιτύχετε αυτή τη δυνατότητα.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Έγγραφο DWG καθορίζοντας συντεταγμένες**

Το Aspose.CAD για το API Java τώρα παρέχει μια δυνατότητα για την απόδοση εγγράφων DWG παρέχοντας τις συντεταγμένες του πλάτους και του ύψους του εγγράφου.

Το παρακάτω δείγμα κώδικα δείχνει πώς να αποδώσετε ένα έγγραφο DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

Η ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) είναι τύπου πίνακα συμβολοσειρών, οπότε μπορείτε να ορίσετε περισσότερα από μία διάταξη ταυτόχρονα για πιθανή μετατροπή σε μορφή PDF. Κατά την καθορισμένη πολλαπλών σχεδίων για την ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), το παραγόμενο PDF θα έχει πολλές σελίδες, όπου κάθε σελίδα αντιπροσωπεύει μία ατομική διάταξη AutoCAD.

### **Λίστα Όλων των Διάταξεων**

Μπορείτε να καταγράψετε όλες τις διατάξεις που υπάρχουν σε ένα σχέδιο AutoCAD χρησιμοποιώντας το παρακάτω δείγμα κώδικα.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Αξιοποίηση τιμής χαρακτηριστικού της εξωτερικής αναφοράς**

Το Aspose.CAD για το API Java σας επιτρέπει να λάβετε μια εξωτερική αναφορά από μια οντότητα χαρακτηριστικού. Το API Aspose.CAD εκθέτει την ιδιότητα [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) για να αποκτήσετε την εξωτερική αναφορά ενός χαρακτηριστικού μπλοκ σε μια συλλογή [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

Το παρακάτω δείγμα κώδικα δείχνει πώς να λάβετε μια εξωτερική αναφορά ενός χαρακτηριστικού μπλοκ.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Αναζήτηση κειμένου σε αρχείο DWG AutoCAD**

Το Aspose.CAD για το API Java σας επιτρέπει να αναζητάτε κείμενο σε ένα αρχείο DWG AutoCAD. Το API Aspose.CAD εκθέτει την κλάση [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) που αντιπροσωπεύει οντότητες κειμένου στο αρχείο DWG AutoCAD. Η κλάση [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) συμπεριλαμβάνεται επίσης στο API Aspose.CAD επειδή ορισμένες άλλες οντότητες μπορεί επίσης να περιέχουν κείμενο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να αναζητήσετε κείμενο στο αρχείο DWG AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Αναζήτηση κειμένου σε συγκεκριμένη διάταξη**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Πρόσβαση στις σημαίες υποστρώματος για τη μορφή DWG**

Η Aspose.CAD για το Java έχει εφαρμόσει τις σημαίες υποστρώματος για τη μορφή DWG και επιτρέπει στους προγραμματιστές να έχουν πρόσβαση σε αυτές. Ακολουθεί μια απλή εμφάνιση κώδικα.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Υποστήριξη για Οντότητες DWG**

Το Aspose.CAD για το API Java μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να υποστηρίξει διάφορες οντότητες για εργασία με.

### **Υποστήριξη για την οντότητα MLeader**

Ένα DWG είναι ένα δυαδικό αρχείο που περιέχει δεδομένα διανυσματικής εικόνας και μεταδεδομένα. Υπάρχουν διάφορες οντότητες σε ένα αρχείο DWG. Η παρακάτω ενότητα περιγράφει ένα παράδειγμα εργασίας με την οντότητα MLeader μέσα στο αρχείο DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Υποστήριξη για την εξαγωγή οντότητας DWG σε εικόνα**

Ένα DWG είναι ένα δυαδικό αρχείο που περιέχει δεδομένα διανυσματικής εικόνας και μεταδεδομένα. Υπάρχουν διάφορες οντότητες σε ένα αρχείο DWG. Η παρακάτω ενότητα περιγράφει ένα παράδειγμα εξαγωγής μιας συγκεκριμένης οντότητας DWG στην εικόνα.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Υποστήριξη για την εισαγωγή εικόνας σε αρχείο DWG**

Το Aspose.CAD για το API Java μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να υποστηρίξει διάφορες οντότητες για εργασία με. Ένα DWG είναι ένα δυαδικό αρχείο που περιέχει δεδομένα διανυσματικής εικόνας και μεταδεδομένα. Υπάρχουν διάφορες οντότητες σε ένα αρχείο DWG. Η παρακάτω ενότητα περιγράφει πώς μπορούμε να εισάγουμε εικόνες μέσα στο αρχείο DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Υποστήριξη για την προσθήκη κειμένου στο DWG**

Το Aspose.CAD για το API Java μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να υποστηρίξει διάφορες οντότητες για εργασία με. Ένα DWG είναι ένα δυαδικό αρχείο που περιέχει δεδομένα διανυσματικής εικόνας και μεταδεδομένα. Υπάρχουν διάφορες οντότητες σε ένα αρχείο DWG. Η παρακάτω ενότητα περιγράφει πώς μπορούμε να προσθέσουμε κείμενο μέσα στο αρχείο DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Υποστήριξη για Mesh στο DWG**

Το Aspose.CAD για το API Java μπορεί τώρα να έχει πρόσβαση στις οντότητες που υποστηρίζουν το mesh, που περιλαμβάνουν τους τύπους [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) και [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). Το παρακάτω παράδειγμα περιγράφει πώς μπορούμε να αποκτήσουμε τους τύπους mesh.

## **Μετατροπή Σχεδίων DWG σε DXF**

Το Aspose.CAD παρέχει τη δυνατότητα να φορτώσετε ένα αρχείο DWG AutoCAD και να το εξάγετε σε μορφή DXF. Η προσέγγιση μετατροπής DWG σε DXF λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίου DWG χρησιμοποιώντας τη μέθοδο [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) δημιουργίας.
2. Εξάγετε το σχέδιο DWG σε DXF χρησιμοποιώντας τη μέθοδο [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο DWG σε μορφή DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Μετατροπή Σχεδίων DWG σε SVG**

Το API Aspose.CAD μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να τα μετατρέψει σε SVG. Αυτό το θέμα εξηγεί τη χρήση του API Aspose.CAD για να επιτευχθεί η μετατροπή του DWG σε μορφή SVG μέσω απλών βημάτων όπως ορίζονται παρακάτω.

1. Φορτώστε το αρχείο DWG σε μια παρουσία του [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
2. Δημιουργήστε ένα αντικείμενο της κλάσης [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) και ορίστε τις απαιτούμενες ιδιότητες.
3. Εξάγετε το σχέδιο DWG σε SVG χρησιμοποιώντας τη μέθοδο [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο DWG σε μορφή SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
