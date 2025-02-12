---
title: Σχέδια STP
type: docs
weight: 70
url: /el/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Εξαγωγή Μορφής STP σε PDF**

Το Aspose.CAD για .NET επιτρέπει στους προγραμματιστές να εξάγουν ένα [STP](https://docs.fileformat.com/3d/stp/) αρχείο σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [STP](https://docs.fileformat.com/3d/stp/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης [STP](https://docs.fileformat.com/3d/stp/) χρησιμοποιώντας την μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ρυθμίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) και [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Καλέστε τη [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) περνώντας ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο.

## Δείγμα Κώδικα

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
