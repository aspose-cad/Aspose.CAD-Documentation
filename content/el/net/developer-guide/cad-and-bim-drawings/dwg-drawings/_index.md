---
title: Σχέδια DWG
type: docs
weight: 40
url: /el/net/dwg-drawings/
---

## **Εξαγωγή Σχεδίων DWG σε PDF**

Η βιβλιοθήκη Aspose.CAD για .NET API μπορεί να φορτώσει σχέδια AutoCAD σε μορφή [DWG](https://docs.fileformat.com/cad/dwg/) και να τα μετατρέψει σε [PDF](https://docs.fileformat.com/pdf/). Αυτό το θέμα εξηγεί τη χρήση της API Aspose.CAD για την επίτευξη της μετατροπής από DWG σε μορφή PDF μέσω απλών βημάτων όπως καθορίζονται παρακάτω.

{{% alert color="primary" %}}

Η API υποστηρίζει τις παρακάτω εκδόσεις DWG AutoCAD:

- DWG 2004 έκδοση 16.0 κυκλοφορία 18
- DWG 2005 έκδοση 16.1
- DWG 2010 έκδοση 18.0
- DWG 2013 έκδοση 19.0

{{% /alert %}}

### **Μορφή Αρχείου DWG**

Ένα [DWG](https://docs.fileformat.com/cad/dwg/) είναι ένα δυαδικό αρχείο που περιέχει δεδομένα εικόνας διανύσματος και μεταδεδομένα. Τα δεδομένα εικόνας διανύσματος παρέχουν οδηγίες στην εφαρμογή CAD σχετικά με το πώς να εμφανίσει το DWG. Τα μεταδεδομένα μπορεί να περιέχουν ποικιλία πληροφοριών σχετικά με το αρχείο, συμπεριλαμβανομένων δεδομένων που σχετίζονται με τη θέση και επίσης δεδομένων πελάτη. Ανοιχτές προδιαγραφές για τη μορφή αρχείου DWG μπορούν να βρεθούν [σε αυτό το PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Μετατροπή Αρχείων DWG σε PDF**

Ακολουθούν τα απλά βήματα που απαιτούνται για τη μετατροπή [DWG](https://docs.fileformat.com/cad/dwg/) σε [PDF](https://docs.fileformat.com/pdf/).

1. Φορτώστε το αρχείο DWG σε μια αναφορά του [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ρυθμίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) και [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Καλέστε [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) περνώντας ένα αντικείμενο [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εξάγετε σχέδια DWG σε PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Δημιουργία Μοναδικού PDF με Διαφορετικά Μεγέθη Διάταξης**

Η Aspose.CAD για .NET επιτρέπει να μετατρέψετε το αρχείο DWG σε ένα μοναδικό PDF με διαφορετικά μεγέθη διάταξης. Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας τη μέθοδο εργοστασίου [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Δημιουργήστε μια αναφορά της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ρυθμίστε το ύψος και το πλάτος της τελικής σελίδας.
1. Προσθέστε τις απαραίτητες [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) για το αντικείμενο [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Δημιουργήστε μια αναφορά της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Εξάγετε την εικόνα σε PDF χρησιμοποιώντας τη μέθοδο [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Το παρακάτω δείγμα κώδικα δείχνει πώς να δημιουργήσετε ένα μοναδικό [PDF](https://docs.fileformat.com/pdf/) με διαφορετικές διατάξεις.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Υποστηριζόμενα Πρώτες Υλικές AutoCAD**

Οι παρακάτω πρώτες ύλες AutoCAD υποστηρίζονται.

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

## **Εξαγωγή Συγκεκριμένης Διάταξης DWG σε PDF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας τη μέθοδο εργοστασίου [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Δημιουργήστε μια αναφορά της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ρυθμίστε το ύψος και το πλάτος της τελικής σελίδας.
1. Ρυθμίστε την ιδιότητα [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) για το αντικείμενο [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Δημιουργήστε μια αναφορά της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Εξάγετε την εικόνα σε PDF χρησιμοποιώντας τη μέθοδο [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε μια συγκεκριμένη διάταξη του DWG σε PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Απόδοση Εγγράφου DWG καθορίζοντας συντεταγμένες**

Η βιβλιοθήκη Aspose.CAD για .NET API παρέχει τώρα τη δυνατότητα απόδοσης εγγράφων DWG καθορίζοντας τις συντεταγμένες πλάτους και ύψους του εγγράφου.

Το παρακάτω δείγμα κώδικα δείχνει πώς να αποδώσετε ένα έγγραφο DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Εξαγωγή DWG σε Raster ή PDF χρησιμοποιώντας Σταθερό Μέγεθος**

Η Aspose.CAD για .NET API μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να τα μετατρέψει σε PDF ή Raster χρησιμοποιώντας σταθερό μέγεθος.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εφαρμόσετε αυτήν τη δυνατότητα.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Εξαγωγή DWG σε PDF/A και PDF/E**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας τη [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) μέθοδο εργοστασίου.
1. Δημιουργήστε μια αναφορά της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) κλάσης.
1. Δημιουργήστε μια αναφορά της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) κλάσης και ρυθμίστε την [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) ιδιότητα.
1. Ρυθμίστε την ιδιότητα συμμόρφωσης PDF και αποθηκεύστε το.
1. Εξάγετε την εικόνα σε PDF χρησιμοποιώντας τη [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) μέθοδο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο DWG σε PDF/A και PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Υποστήριξη για στρογγυλεμένες κρυφές γραμμές κατά την εξαγωγή DWG/DXF σε BMP και PDF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτώστε ένα DWG αρχείο χρησιμοποιώντας τη [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) μέθοδο εργοστασίου.
1. Δημιουργήστε μια αναφορά της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) κλάσης και ρυθμίστε το ύψος και το πλάτος της τελικής σελίδας.
1. Δημιουργήστε μια αναφορά της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) κλάσης και ρυθμίστε την [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) ιδιότητα.
1. Εξάγετε την εικόνα σε PDF χρησιμοποιώντας τη [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) μέθοδο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εφαρμόσετε αυτήν τη δυνατότητα.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Υποστήριξη για ρύθμιση περιοχής εκτύπωσης για εικόνα DWG στο εξαγόμενο PDF**

Η Aspose.CAD για .NET API μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να τα μετατρέψει σε PDF. Αυτό το θέμα εξηγεί τη χρήση της API Aspose.CAD για την επίτευξη υποστήριξης για τη ρύθμιση περιοχής εκτύπωσης για την εικόνα DWG στο εξαγόμενο PDF.

Το παρακάτω δείγμα κώδικα δείχνει πώς να εφαρμόσετε αυτήν τη δυνατότητα.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Υποστήριξη για ανάγνωση μεταδεδομένων XREF για αρχείο DWG**

1. Φορτώστε ένα αρχείο DWG χρησιμοποιώντας τη [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) μέθοδο εργοστασίου.
1. Διασχίστε κάθε οντότητα εικόνας.
1. Εάν μια οντότητα είναι CadUnderlay τότε XREF οντότητα με μεταδεδομένα.

Το παρακάτω δείγμα κώδικα δείχνει πώς να επιτύχετε αυτήν τη δυνατότητα.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Η ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) είναι τύπου πίνακα συμβολοσειρών, οπότε μπορείτε να καθορίζετε περισσότερες από μία διατάξεις ταυτόχρονα για πιθανή μετατροπή σε μορφή PDF. Κατά την καθορισμένη μετατροπή πολλών διατάξεων για την ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), το αρχείο PDF που προκύπτει θα έχει πολλές σελίδες, όπου κάθε σελίδα αντιπροσωπεύει μια ατομική διάταξη AutoCAD.

### **Λίστα Όλων των Διατάξεων**

Μπορείτε να απαριθμήσετε όλες τις διατάξεις που υπάρχουν σε ένα σχέδιο AutoCAD χρησιμοποιώντας το παρακάτω δείγμα κώδικα.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Πρόσβαση σε Σημαίες Υποστρώματος για τη Μορφή DWG**

Η Aspose.CAD για .NET έχει υλοποιήσει τις σημαίες υποστρώματος για τη μορφή DWG και επιτρέπει στους προγραμματιστές να έχουν πρόσβαση σε αυτές. Ακολουθεί η απλή επίδειξη κώδικα.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Υποστήριξη Οντοτήτων DWG**

Η Aspose.CAD για .NET API μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και υποστηρίζει διάφορες οντότητες για εργασία.

### **Υποστήριξη για Οντότητα MLeader**

Ένα DWG είναι ένα δυαδικό αρχείο που περιέχει δεδομένα εικόνας διανύσματος και μεταδεδομένα. Υπάρχουν πολλές οντότητες σε ένα αρχείο DWG. Η παρακάτω ενότητα περιγράφει ένα παράδειγμα εργασίας με την οντότητα MLeader μέσα στο αρχείο DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Υποστήριξη για Εξαγωγή Οντότητας DWG σε Εικόνα**

Ένα DWG είναι ένα δυαδικό αρχείο που περιέχει δεδομένα εικόνας διανύσματος και μεταδεδομένα. Υπάρχουν διάφορες οντότητες σε ένα αρχείο DWG. Η παρακάτω ενότητα περιγράφει ένα παράδειγμα εξαγωγής μιας συγκεκριμένης οντότητας DWG στην εικόνα.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Υποστήριξη για προσθήκη κειμένου σε DWG**

Η Aspose.CAD για .NET API μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και υποστηρίζει διάφορες οντότητες για εργασία. Ένα DWG είναι ένα δυαδικό αρχείο που περιέχει δεδομένα εικόνας διανύσματος και μεταδεδομένα. Υπάρχουν πολλές οντότητες σε ένα αρχείο DWG. Η παρακάτω ενότητα περιγράφει πώς μπορούμε να προσθέσουμε κείμενο μέσα στο αρχείο DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Υποστήριξη για Εισαγωγή Εικόνας σε Αρχείο DWG**

Η Aspose.CAD για .NET API μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και υποστηρίζει διάφορες οντότητες για εργασία. Ένα DWG είναι ένα δυαδικό αρχείο που περιέχει δεδομένα εικόνας διανύσματος και μεταδεδομένα. Υπάρχουν πολλές οντότητες σε ένα αρχείο DWG. Η παρακάτω ενότητα περιγράφει πώς μπορούμε να εισάγουμε εικόνες μέσα στο αρχείο DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Υποστήριξη για Πλέγμα σε DWG**

Η Aspose.CAD για .NET API μπορεί τώρα να έχει πρόσβαση στις οντότητες που υποστηρίζουν πλέγμα που περιλαμβάνουν τύπους [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) και [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). Το παρακάτω παράδειγμα περιγράφει πώς μπορούμε να αποκτήσουμε πρόσβαση στους τύπους πλέγματος.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Μετατροπή Σχεδίων DWG σε DXF**

Η Aspose.CAD παρέχει τη δυνατότητα να φορτώνει αρχείο DWG AutoCAD και να το εξάγει σε μορφή DXF. Η προσέγγιση μετατροπής από DWG σε DXF λειτουργεί ως εξής:

1. Φορτώστε το αρχείο σχεδίου DWG χρησιμοποιώντας τη [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) μέθοδο εργοστασίου.
1. Εξάγετε το σχέδιο DWG σε DXF χρησιμοποιώντας τη [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) μέθοδο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο DWG σε μορφή DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Μετατροπή Σχεδίων DWG σε SVG**

Η Aspose.CAD για .NET API μπορεί να φορτώσει σχέδια AutoCAD σε μορφή DWG και να τα μετατρέψει σε SVG. Αυτό το θέμα εξηγεί τη χρήση της API Aspose.CAD για την επίτευξη της μετατροπής από DWG σε μορφή SVG μέσω απλών βημάτων όπως καθορίζονται παρακάτω.

1. Φορτώστε το αρχείο DWG σε μια αναφορά του [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) και ρυθμίστε τις απαραίτητες ιδιότητες.
1. Εξάγετε το σχέδιο DWG σε SVG χρησιμοποιώντας τη [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) μέθοδο.

Το παρακάτω δείγμα κώδικα δείχνει πώς να μετατρέψετε ένα αρχείο DWG σε μορφή SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Φόρτωση Μεγάλου Αρχείου DWG**

Η Aspose.CAD για .NET παρέχει τη δυνατότητα να ανοίγει πολύ μεγάλα αρχεία DWG χρησιμοποιώντας την κλάση [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Τώρα μπορείτε να ανοίξετε εύκολα μεγάλα αρχεία με τη βοήθεια του δείγματος κώδικα που δίνεται παρακάτω.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
