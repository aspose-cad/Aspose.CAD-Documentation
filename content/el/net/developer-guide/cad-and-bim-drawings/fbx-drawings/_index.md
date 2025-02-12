---
title: Σχέδια FBX
type: docs
weight: 70
url: /el/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Εξαγωγή μορφής FBX σε PDF**

Το Aspose.CAD για .NET επιτρέπει στους προγραμματιστές να εξάγουν ένα αρχείο [FBX](https://docs.fileformat.com/3d/fbx/) σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [FBX](https://docs.fileformat.com/3d/fbx/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης [FBX](https://docs.fileformat.com/3d/fbx/) χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ορίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Καλέστε [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) περνώντας ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο.

## Δείγμα Κώδικα

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
