---
title: Σχέδια DRC
type: docs
weight: 15
url: /el/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Εξαγωγή Σχεδίων DRC σε PDF**

Η Aspose.CAD παρέχει τη δυνατότητα φόρτωσης των οντοτήτων σχεδίασης AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) και απόδοσής τους ως ολόκληρη σχεδίαση σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [DRC](https://docs.fileformat.com/3d/drc/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης [DRC](https://docs.fileformat.com/3d/drc/) χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ρυθμίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Καλέστε [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) περνώντας ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο.

### Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο χρησιμοποιώντας τις προεπιλεγμένες ρυθμίσεις.

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
