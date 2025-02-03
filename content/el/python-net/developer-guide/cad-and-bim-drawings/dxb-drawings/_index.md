---
title: Σχέδια DXB
type: docs
weight: 90
url: /el/python-net/dxb-drawings/
---

## **Εξαγωγή μορφής DXB σε PDF**

Το Aspose.CAD για Python επιτρέπει στους προγραμματιστές να εξάγουν ένα αρχείο DXB σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής DXB σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης DXB χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **CadRasterizationOptions** και ορίστε τις ιδιότητες **page_height** και **page_width**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **PdfOptions** και ορίστε την ιδιότητα **vector_rasterization_options**.
1. Καλέστε το **Image.save** περνώντας ένα αντικείμενο της **PdfOptions** ως δεύτερη παράμετρο.

## Δείγμα Κώδικα

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
