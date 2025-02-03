---
title: Σχέδια DWF
type: docs
weight: 20
url: /el/net/dwf-drawings/
---

## **Εξαγωγή Σχεδίων DWF σε PDF**

Το Aspose.CAD παρέχει τη δυνατότητα φόρτωσης οντοτήτων σχεδίου AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) και την απόδοση τους ως ένα ολόκληρο σχέδιο σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [DWF](https://docs.fileformat.com/cad/dwf/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίου [DWF](https://docs.fileformat.com/cad/dwf/) χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ορίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Καλέστε την [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) περνώντας ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο.

### Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο χρησιμοποιώντας τις προεπιλεγμένες ρυθμίσεις.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Εξαγωγή Στρωμάτων από Σχέδιο DWF**

Το Aspose.CAD παρέχει τη δυνατότητα φόρτωσης οντοτήτων σχεδίου AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) και την απόδοση τους ως ένα ολόκληρο σχέδιο σε μορφή [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Φορτώστε το αρχείο σχεδίου [DWF](https://docs.fileformat.com/cad/dwf/) χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Εξάγετε τα ονόματα στρωμάτων χρησιμοποιώντας το αντικείμενο [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Καλέστε την [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) περνώντας ένα αντικείμενο της [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) ως δεύτερη παράμετρο.

### Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο χρησιμοποιώντας τις προεπιλεγμένες ρυθμίσεις.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Υποστήριξη Στρωμάτων σε DWF**

Το Aspose.CAD παρέχει τη δυνατότητα φόρτωσης οντοτήτων σχεδίου AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) και την απόδοση τους ως ένα ολόκληρο σχέδιο σε μορφή [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Φορτώστε το αρχείο σχεδίου [DWF](https://docs.fileformat.com/cad/dwf/) χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Προσθέστε τα επιθυμητά στρώματα.
1. Καλέστε την [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ενώ περνάτε ένα αντικείμενο της [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) ως δεύτερη παράμετρο.

### Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο χρησιμοποιώντας τις προεπιλεγμένες ρυθμίσεις.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Εξαγωγή Σχεδίων DWF σε BMP**

Το Aspose.CAD παρέχει τη δυνατότητα φόρτωσης οντοτήτων σχεδίου AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) και την απόδοση τους ως ένα ολόκληρο σχέδιο σε μορφή [BMP](https://docs.fileformat.com/image/bmp/). Η προσέγγιση μετατροπής από [DWF](https://docs.fileformat.com/cad/dwf/) σε [BMP](https://docs.fileformat.com/image/bmp/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίου [DWF](https://docs.fileformat.com/cad/dwf/) χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ορίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Καλέστε την [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) περνώντας ένα αντικείμενο της [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) ως δεύτερη παράμετρο.

### Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο [DWF](https://docs.fileformat.com/cad/dwf/) σε [BMP](https://docs.fileformat.com/image/bmp/) χρησιμοποιώντας τις προεπιλεγμένες ρυθμίσεις.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
