---
title: Σχέδια STP
type: docs
weight: 160
url: /el/python-net/stp-drawings/
---

## **Εξαγωγή μορφής STP σε PDF**

Το Aspose.CAD για Python επιτρέπει στους προγραμματιστές να εξάγουν ένα [STP](https://docs.fileformat.com/3d/stp/) αρχείο σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [STP](https://docs.fileformat.com/3d/stp/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης [STP](https://docs.fileformat.com/3d/stp/) χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **CadRasterizationOptions** και ρυθμίστε τις ιδιότητες **page_height** και **page_width**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **PdfOptions** και ρυθμίστε την ιδιότητα **vector_rasterization_options**.
1. Καλέστε **Image.save** περνώντας ως δεύτερη παράμετρο ένα αντικείμενο της **PdfOptions**.

## Δείγμα Κώδικα

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
