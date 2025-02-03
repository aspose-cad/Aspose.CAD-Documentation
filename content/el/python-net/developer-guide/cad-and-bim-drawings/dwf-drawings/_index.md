---
title: Σχέδια DWF
type: docs
weight: 50
url: /el/python-net/dwf-drawings/
---

## **Εξαγωγή Σχεδίων DWF σε PDF**

Η Aspose.CAD προσφέρει τη δυνατότητα φόρτωσης στοιχείων σχεδίασης AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) και την απόδοση τους ως ένα ολόκληρο σχέδιο σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [DWF](https://docs.fileformat.com/cad/dwf/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης [DWF](https://docs.fileformat.com/cad/dwf/) χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **CadRasterizationOptions** και ρυθμίστε τις ιδιότητες **page_height** & **page_width**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **PdfOptions** και ρυθμίστε την ιδιότητα **vector_rasterization_options**.
1. Καλέστε το **Image.save** περνώντας ένα αντικείμενο της **PdfOptions** ως δεύτερη παράμετρο.

### Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο χρησιμοποιώντας τις προεπιλεγμένες ρυθμίσεις.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Εξαγωγή Σχεδίων DWF σε BMP**

Η Aspose.CAD προσφέρει τη δυνατότητα φόρτωσης στοιχείων σχεδίασης AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) και την απόδοση τους ως ένα ολόκληρο σχέδιο σε μορφή [BMP](https://docs.fileformat.com/image/bmp/). Η προσέγγιση μετατροπής από [DWF](https://docs.fileformat.com/cad/dwf/) σε [BMP](https://docs.fileformat.com/image/bmp/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης [DWF](https://docs.fileformat.com/cad/dwf/) χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **CadRasterizationOptions** και ρυθμίστε τις ιδιότητες **page_height** & **page_width**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **BmpOptions** και ρυθμίστε την ιδιότητα **vector_rasterization_options**.
1. Καλέστε το **Image.save** περνώντας ένα αντικείμενο της **BmpOptions** ως δεύτερη παράμετρο.

### Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο [DWF](https://docs.fileformat.com/cad/dwf/) σε [BMP](https://docs.fileformat.com/image/bmp/) χρησιμοποιώντας τις προεπιλεγμένες ρυθμίσεις.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
