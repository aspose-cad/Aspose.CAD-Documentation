---
title: Σχέδια DRC
type: docs
weight: 40
url: /el/python-net/drc-drawings/
---

## **Εξαγωγή Μορφής DRC σε PDF**

Το Aspose.CAD για Python επιτρέπει στους προγραμματιστές να εξάγουν ένα [DRC](https://docs.fileformat.com/3d/drc/) αρχείο σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [DRC](https://docs.fileformat.com/3d/drc/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης DRC χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **CadRasterizationOptions** και ρυθμίστε τις ιδιότητες **page_height** και **page_width**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **PdfOptions** και ρυθμίστε την ιδιότητα **VectorRasterizationOptions**.
1. Καλέστε το **Image.save** περνώντας ένα αντικείμενο **PdfOptions** ως δεύτερη παράμετρο.

## Δείγμα Κώδικα


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
