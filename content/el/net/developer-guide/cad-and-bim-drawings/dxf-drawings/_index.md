---
title: DXF Σχέδια
type: docs
weight: 60
url: /el/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Εξαγωγή DXF Σχεδίων σε PDF**

Η Aspose.CAD παρέχει τη δυνατότητα φόρτωσης οντοτήτων σχεδίων DXF από το AutoCAD και την απόδοσή τους ως συνολικού σχεδίου σε μορφή PDF. Η προσέγγιση μετατροπής DXF σε PDF λειτουργεί ως εξής:

1. Φορτίστε το αρχείο DXF χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ορίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Καλέστε [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) περνώντας ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο.

Ο παρακάτω κωδικός δείχνει πώς να μετατρέψετε ένα αρχείο χρησιμοποιώντας τις προεπιλεγμένες ρυθμίσεις.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Υποστηριζόμενες Μορφές**

Αυτή τη στιγμή υποστηρίζουμε πλήρως τις μορφές αρχείων DXF 2010 του AutoCAD. Οι προηγούμενες εκδόσεις DXF δεν είναι εγγυημένες ότι είναι 100% έγκυρες. Σκοπεύουμε να περιλάβουμε περισσότερες μορφές και δυνατότητες σε μελλοντικές εκδόσεις της Aspose.CAD.

### **Υποστηριζόμενες Οντότητες**

Αυτή τη στιγμή υποστηρίζουμε όλες τις διαδεδομένες 2D οντότητες και τις βασικές προεπιλεγμένες παραμέτρους τους όπως παρακάτω:

1. Ευθυγραμμισμένη Διάσταση
1. Γωνιακή Διάσταση
1. Τόξο
1. Χαρακτηριστικό
1. Αναφορά Μπλοκ
1. Κύκλος
1. Διάσταση Διαμέτρου
1. Έλλειψη
1. Σκίαση
1. Γραμμή
1. Πολυγραμμένο Κείμενο
1. Διάσταση Ορνίθου
1. Σημείο
1. Πολυγραμμή
1. Ραδιοδιάσταση
1. Ακτίνα
1. Περιστραμμένη Διάσταση
1. Πίνακας
1. Κείμενο
1. Μη γραμμική γραμμή

{{% alert color="primary" %}}

Εάν κατά την ανάλυση συναντήσουμε κάποια οντότητα ή ιδιότητα που δεν υποστηρίζουμε, η οντότητα ή η ιδιότητα θα αγνοηθεί αθόρυβα.

{{% /alert %}}

### **Διαχείριση Μνήμης**

Η ιδιότητα [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) της κλάσης [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) μπορεί να χρησιμοποιηθεί για να ελέγξει την επανακατανομή μνήμης. Η επανακατανομή είναι πιο πιθανό να συμβεί για προκατανεμημένα κρυφεία. Μπορεί να συμβεί όταν το σύστημα διαπιστώσει ότι ο προγραμματισμένος χώρος δεν θα είναι επαρκής.

- Εάν η [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) ρυθμιστεί στην προεπιλεγμένη τιμή, **False**, ο χώρος επανακατανομής γίνεται προς το ίδιο μέσο.
- Όταν ρυθμιστεί σε **True**, η επανακατανομή δεν μπορεί να υπερβεί τον καθορισμένο μέγιστο χώρο. Σε αυτή την περίπτωση, το υπάρχον κατανεμημένο στην μνήμη κρύφο (το οποίο απαιτεί επανακατανομή) απελευθερώνεται και ο εκτεταμένος χώρος κατανεμηθεί στον δίσκο.

## **Εξαγωγή Συγκεκριμένου Επιπέδου DXF Σχεδίων σε PDF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Ανοίξτε ένα αρχείο σχεδίου DXF χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ορίστε τις ιδιότητες [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Προσθέστε επίπεδα στο αντικείμενο της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Δημιουργήστε μια παρουσία της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & ορίστε την ιδιότητά της [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Καλέστε τη μέθοδο [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) και περάστε το αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο.

Ο παρακάτω κωδικός δείχνει πώς να μετατρέψετε ένα συγκεκριμένο επίπεδο DXF σε PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Απόδοση PDF αρχείων ως μέρος αρχείων DXF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτίστε το αρχείο σχεδίου DXF χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και φορτώστε τα αρχεία PDF.
1. Ορίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Καλέστε [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) και αποθηκεύστε το αρχείο.

Ο παρακάτω κωδικός δείχνει πώς να αναπαράγετε τα PDF αρχεία ως μέρος των DXF σχεδίων.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Εξαγωγή ενσωματωμένου υποβάθρου DGN για τη μορφή DXF**

Η Aspose.CAD παρέχει τη δυνατότητα φόρτωσης αρχείων DXF από το AutoCAD και εξαγωγής ενσωματωμένου υποβάθρου DGN για τη μορφή DXF.

Ο παρακάτω κωδικός δείχνει πώς να επιτευχθούν οι καθορισμένες απαιτήσεις.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Υποστήριξη για Αποθήκευση Αρχείων DXF**

Η Aspose.CAD παρέχει τη δυνατότητα φόρτωσης αρχείων DXF από το AutoCAD, να κάνει αλλαγές σε αυτά και να τα αποθηκεύσει ξανά ως αρχείο DXF.

Ο παρακάτω κωδικός δείχνει πώς να επιτευχθούν οι καθορισμένες απαιτήσεις.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Εξαγωγή DXF σε WMF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Φορτίστε το αρχείο σχεδίου DXF χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και φορτώστε τα αρχεία PDF.
1. Ορίστε τις ιδιότητες [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Καλέστε [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) και αποθηκεύστε το αρχείο.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Εξαγωγή Συγκεκριμένου Σχεδίου DXF σε PDF**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Ανοίξτε ένα αρχείο σχεδίου DXF χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ορίστε τις ιδιότητες [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Ορίστε τα επιθυμητά ονόματα σχεδίου χρησιμοποιώντας την ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Δημιουργήστε μια παρουσία της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & ορίστε την ιδιότητά της [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Εξάγετε το σχέδιο σε PDF καλώντας τη μέθοδο [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) και περνώντας το αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο.

Ο παρακάτω κωδικός δείχνει πώς να μετατρέψετε ένα συγκεκριμένο σχέδιο DXF σε PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

Η ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) είναι τύπου πίνακα συμβολοσειρών, επομένως μπορείτε να ορίσετε περισσότερα από ένα σχέδια ταυτόχρονα για πιθανή μετατροπή σε μορφή PDF. Όταν καθορίζετε πολλαπλά σχέδια για την ιδιότητα [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), το αποτέλεσμα PDF θα έχει πολλές σελίδες, όπου κάθε σελίδα αντιπροσωπεύει ένα ξεχωριστό σχέδιο AutoCAD.

{{% /alert %}}

## **Υποστήριξη Κοπής Μπλοκ**

Η Aspose.CAD παρέχει τη δυνατότητα Κοπής Μπλοκ. Η προσέγγιση Κοπής Μπλοκ λειτουργεί ως εξής:

1. Φορτίστε το αρχείο σχεδίου DXF χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Δημιουργήστε ένα αντικείμενο της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και φορτώστε τα αρχεία PDF.
1. Ορίστε τις επιθυμητές ιδιότητες της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Καλέστε [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) περνώντας ένα αντικείμενο της [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ως δεύτερη παράμετρο και αποθηκεύστε το αρχείο.

Ο παρακάτω κωδικός δείχνει πώς λειτουργεί η Κοπής Μπλοκ.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Εξαγωγή Εικόνων σε DXF**

Χρησιμοποιώντας την Aspose.CAD, μπορείτε να εξάγετε εικόνες στη μορφή DXF. Χρησιμοποιώντας αυτή την προσέγγιση, μπορείτε να εκτελέσετε τις παρακάτω ενέργειες:

1. Ορίστε νέα γραμματοσειρά
1. Κρύψτε τις οντότητες
1. Ενημερώστε το κείμενο

Ο παρακάτω κωδικός δείχνει πώς να εκτελέσετε τις παραπάνω ενέργειες.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Εξαγωγή Συγκεκριμένου Επιπέδου DXF Σχεδίων σε Εικόνα**

Αυτή η προσέγγιση λειτουργεί ως εξής:

1. Ανοίξτε ένα αρχείο σχεδίου DXF χρησιμοποιώντας τη μέθοδο εργοστασίου [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) και ορίστε τις ιδιότητες [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) και [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Προσθέστε επίπεδα στο αντικείμενο της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Δημιουργήστε μια παρουσία της [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) και ορίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Εξάγετε το σχέδιο σε PDF χρησιμοποιώντας τη μέθοδο [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Ο παρακάτω κωδικός δείχνει πώς να μετατρέψετε ένα συγκεκριμένο επίπεδο DXF σε Εικόνα.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
