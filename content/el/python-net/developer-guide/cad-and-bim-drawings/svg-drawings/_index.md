---
title: SVG Δεδομένα
type: docs
weight: 170
url: /el/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Εξαγωγή SVG Μορφής σε PDF**

Το Aspose.CAD για Python επιτρέπει στους προγραμματιστές να εξάγουν ένα αρχείο [SVG](https://docs.fileformat.com/page-description-language/svg/) σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [SVG](https://docs.fileformat.com/page-description-language/svg/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίου SVG χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **CadRasterizationOptions** και ορίστε τις ιδιότητες **page_height** και **page_width**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **PdfOptions** και ορίστε την ιδιότητα **VectorRasterizationOptions**.
1. Καλέστε το **Image.save** περνώντας ένα αντικείμενο της **PdfOptions** ως δεύτερη παράμετρο.

## Δείγμα Κώδικα

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
