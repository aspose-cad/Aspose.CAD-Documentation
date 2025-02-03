---
title: FBX Σχεδιαγράμματα
type: docs
weight: 110
url: /el/python-net/fbx-drawings/
---

## **Εξαγωγή FBX Μορφής σε PDF**

Το Aspose.CAD για Python επιτρέπει στους προγραμματιστές να εξάγουν ένα [FBX](https://docs.fileformat.com/3d/fbx/) αρχείο σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [FBX](https://docs.fileformat.com/3d/fbx/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης [FBX](https://docs.fileformat.com/3d/fbx/) χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **CadRasterizationOptions** και ρυθμίστε τις ιδιότητες **PageHeight** & **PageWidth**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **PdfOptions** και ρυθμίστε την ιδιότητα **vector_rasterization_options**.
1. Καλέστε το **Image.save** περνώντας ένα αντικείμενο της **PdfOptions** ως δεύτερη παράμετρο.

## Δείγμα Κώδικα

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
