---
title: Σχέδια COLLADA
type: docs
weight: 20
url: /el/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Εξαγωγή Δεδομένων COLLADA σε PDF**

Το Aspose.CAD για Python επιτρέπει στους προγραμματιστές να εξάγουν ένα αρχείο [COLLADA](https://docs.fileformat.com/3d/dae/) σε μορφή [PDF](https://docs.fileformat.com/pdf/). Η προσέγγιση μετατροπής από [COLLADA](https://docs.fileformat.com/3d/dae/) σε [PDF](https://docs.fileformat.com/pdf/) λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίασης [COLLADA](https://docs.fileformat.com/3d/dae/) χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
2. Δημιουργήστε ένα αντικείμενο της κλάσης **CadRasterizationOptions** και ορίστε τις ιδιότητες **page_height** & **page_width**.
3. Δημιουργήστε ένα αντικείμενο της κλάσης **PdfOptions** και ορίστε την ιδιότητα **vector_rasterization_options**.
4. Καλέστε **Image.save** περνώντας ένα αντικείμενο της **PdfOptions** ως δεύτερη παράμετρο.

## Δείγμα Κώδικα

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
