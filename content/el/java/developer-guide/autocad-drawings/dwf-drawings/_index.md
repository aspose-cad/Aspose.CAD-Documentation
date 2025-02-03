---
title: DWF Σχέδια
type: docs
weight: 20
url: /el/java/dwf-drawings/
---

## **Εξαγωγή Σχεδίων DWF σε PDF**

Το Aspose.CAD για την API Java μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWF και να τα μετατρέψει σε PDF. Αυτό το θέμα εξηγεί τη χρήση του API Aspose.CAD για την επίτευξη της μετατροπής από DWF σε PDF μέσω απλών βημάτων όπως ορίζεται παρακάτω.

### **Μετατροπή Αρχείων DWF σε PDF**

Τα παρακάτω απλά βήματα απαιτούνται για να μετατραπεί το DWF σε PDF.

1. Φορτώστε το αρχείο DWF σε μια παρουσία του [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και ορίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Καλέστε [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) περνώντας ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ως δεύτερη παράμετρο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εξάγετε σχέδια DWF σε PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Υποστήριξη Στρωμάτων σε DWF**

Το Aspose.CAD παρέχει τη δυνατότητα να φορτώνει οντότητες σχεδίων DWF AutoCAD και να τις αποδίδει ως ολόκληρο σχέδιο σε μορφή JPG.

1. Φορτώστε το αρχείο σχεδίου DWF χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Προσθέστε τα επιθυμητά στρώματα.
1. Καλέστε [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) περνώντας ένα αντικείμενο της [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) ως δεύτερη παράμετρο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο χρησιμοποιώντας προεπιλεγμένες ρυθμίσεις.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
