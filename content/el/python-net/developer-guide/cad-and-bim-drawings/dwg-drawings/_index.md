---
title: DWG Σχέδια
type: docs
weight: 70
url: /el/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Εξαγωγή DWG Σχεδίων σε PDF**

Το Aspose.CAD για το Python API μπορεί να φορτώσει σχέδια AutoCAD σε μορφή [DWG](https://docs.fileformat.com/cad/dwg/) και να τα μετατρέψει σε [PDF](https://docs.fileformat.com/pdf/). Αυτό το θέμα εξηγεί τη χρήση του Aspose.CAD API για να επιτευχθεί η μετατροπή του DWG σε PDF μορφή μέσω απλών βημάτων όπως ορίζονται παρακάτω.

{{% alert color="primary" %}}

Το API υποστηρίζει τις παρακάτω αναθεωρήσεις DWG του AutoCAD:

- DWG 2004 έκδοση 16.0 κυκλοφορία 18
- DWG 2005 έκδοση 16.1
- DWG 2010 έκδοση 18.0
- DWG 2013 έκδοση 19.0

{{% /alert %}}

### **Μορφή Αρχείου DWG**

Ένα [DWG](https://docs.fileformat.com/cad/dwg/) είναι ένα δυαδικό αρχείο που περιέχει δεδομένα εικόνας διανύσματος και μεταδεδομένα. Τα δεδομένα εικόνας διανύσματος παρέχουν οδηγίες στην εφαρμογή CAD σχετικά με το πώς να εμφανίσει το DWG; τα μεταδεδομένα μπορεί να περιέχουν ποικιλία πληροφοριών σχετικά με το αρχείο συμπεριλαμβανομένων δεδομένων που σχετίζονται με την τοποθεσία και επίσης δεδομένα πελάτη. Οι Ανοιχτές Προδιαγραφές για τη μορφή αρχείου DWG μπορούν να βρεθούν [σε αυτό το PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Μετατροπή DWG Αρχείων σε PDF**

Τα παρακάτω απλά βήματα απαιτούνται για να μετατραπεί το [DWG](https://docs.fileformat.com/cad/dwg/) σε [PDF](https://docs.fileformat.com/pdf/).

1. Φορτώστε το αρχείο DWG σε μια περίπτωση του **Image**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **CadRasterizationOptions** και ρυθμίστε τις ιδιότητες **page_height** & **page_width**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **PdfOptions** και ρυθμίστε την ιδιότητα **VectorRasterizationOptions**.
1. Καλέστε το **Image.save** περνώντας ένα αντικείμενο του **PdfOptions** ως δεύτερη παράμετρο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εξάγετε DWG σχέδια σε PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}


### **Υποστηριζόμενες AutoCAD Πρωτογενείς Οντότητες**

Οι παρακάτω πρωτογενείς οντότητες του AutoCAD υποστηρίζονται.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Εξαγωγή Ειδικού DWG Σχεδίου σε PDF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας τη μέθοδο εργοστασίου **Aspose.CAD.Image.load**.
1. Δημιουργήστε μια περίπτωση της κλάσης **CadRasterizationOptions** και ρυθμίστε το ύψος και το πλάτος της προκύπτουσας σελίδας.
1. Ρυθμίστε την ιδιότητα **Layouts** για το αντικείμενο **CadRasterizationOptions**.
1. Δημιουργήστε μια περίπτωση της κλάσης **PdfOptions** και ρυθμίστε την ιδιότητα **VectorRasterizationOptions**.
1. Εξάγετε την εικόνα σε PDF χρησιμοποιώντας τη μέθοδο **Image.save()**.

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα συγκεκριμένο σχέδιο DWG σε PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}


## **Εξαγωγή DWG σε PDF/A και PDF/E**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
1. Δημιουργήστε μια περίπτωση της κλάσης **CadRasterizationOptions**.
1. Δημιουργήστε μια περίπτωση της κλάσης **PdfOptions** και ρυθμίστε την ιδιότητα **VectorRasterizationOptions**.
1. Ρυθμίστε την ιδιότητα συμμόρφωσης PDF και αποθηκεύστε την.
1. Εξάγετε την εικόνα σε PDF χρησιμοποιώντας τη μέθοδο **Image.save()**.

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο DWG σε PDF/A και PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Μετατροπή DWG Σχεδίων σε DXF**

Το Aspose.CAD παρέχει τη δυνατότητα να φορτώσει ένα αρχείο DWG του AutoCAD και να το εξαγάγει σε μορφή DXF. Η προσέγγιση μετατροπής από DWG σε DXF λειτουργεί ως εξής:

1. Φορτώστε το αρχείο DWG χρησιμοποιώντας τη μέθοδο εργοστασίου **Image.load**.
1. Εξάγετε το σχέδιο DWG σε DXF χρησιμοποιώντας τη μέθοδο **Image.save()**.

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο DWG σε μορφή DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Μετατροπή DWG Σχεδίων σε SVG**

Το Aspose.CAD για το Python API μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να τα μετατρέψει σε SVG. Αυτό το θέμα εξηγεί τη χρήση του Aspose.CAD API για να επιτευχθεί η μετατροπή του DWG σε μορφή SVG μέσω απλών βημάτων όπως ορίζονται παρακάτω.

1. Φορτώστε το αρχείο DWG σε μια περίπτωση του **Image**.
1. Δημιουργήστε ένα αντικείμενο της κλάσης **SvgOptions** και ρυθμίστε τις απαιτούμενες ιδιότητες.
1. Εξάγετε το σχέδιο DWG σε SVG χρησιμοποιώντας τη μέθοδο **Image.save()**.

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο DWG σε μορφή SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
