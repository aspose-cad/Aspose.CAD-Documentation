---
title: 3DS Σχέδια
type: docs
weight: 70
url: /el/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Εξαγωγή μορφής 3DS σε PDF**

Το Aspose.CAD για .NET επιτρέπει στους προγραμματιστές να εξάγουν ένα [3DS](https://docs.fileformat.com/3d/3ds/) αρχείο σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [3DS](https://docs.fileformat.com/3d/3ds/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης [3DS](https://docs.fileformat.com/3d/3ds/) χρησιμοποιώντας τη μέθοδο κατασκευής [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ρυθμίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Καλέστε την [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) περνώντας ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο.

## Δείγμα Κώδικα

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
