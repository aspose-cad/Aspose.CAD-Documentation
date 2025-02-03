---
title: DWG DXF σε PDF C# | Μετατροπή Αρχείων Auto CAD σε PDF JPEG PNG σε C# .NET
type: docs
weight: 30
url: /el/net/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG σε PDF C#, DXF σε PDF C#, DWF DWT σε PDF C#, μετατροπή AutoCAD, μετατροπή DWG, μετατροπή DWF, μετατροπή DWT, μετατροπή DXF, μετατροπή autocad σε pdf, μετατροπή DWG σε PDF, μετατροπή DWG σε PNG, μετατροπή DWG σε TIFF, μετατροπή DWG σε JPG"
description: Χρησιμοποιήστε το πρόγραμμα μετατροπής C# .NET AutoCAD σε PDF για να μετατρέψετε DWG ή DXF σε PDF σε C#. Μπορείτε να μετατρέψετε DWG, DWF, DWT και DXF σε PDF, JPEG, PNG, BMP, GIF και TIFF σε C# .NET επίσης.
---

## **Μετατροπή DWG ή DXF σε PNG JPEG BMP GIF ή TIFF σε C#**

Aspose.CAD για .NET μπορεί να μετατρέψει μορφές σχεδίου AutoCAD όπως [DXF](https://docs.fileformat.com/cad/dxf/) και [DWG](https://docs.fileformat.com/cad/dwg/) σε [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) και [GIF](https://docs.fileformat.com/image/gif/). Έχει εκθέσει μια αποδοτική και εύκολη στη χρήση API για να επιτύχει αυτό το στόχο.

Μπορείτε να μετατρέψετε οποιαδήποτε υποστηριζόμενη μορφή σχεδίου AutoCAD σε μορφές εικόνας ράστερ χρησιμοποιώντας τα απλά βήματα που αναλύονται παρακάτω.

1. Φορτώστε το αρχείο AutoCAD DWG ή DXF στην κλάση [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Δημιουργήστε μια παρουσία της [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Ορίστε/αλλάξτε το μέγεθος της εικόνας χρησιμοποιώντας [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) και [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. Δημιουργήστε μια παρουσία της [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. Ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) στην [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) που δημιουργήθηκε στο προηγούμενο βήμα.
1. Αποθηκεύστε το σχέδιο AutoCAD ως PDF με το [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) περνώντας το μονοπάτι του αρχείου (ή ένα αντικείμενο MemoryStream) καθώς και την παρουσία της [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) που δημιουργήθηκε στο προηγούμενο βήμα.

Ακολουθεί ο πλήρης πηγαίος κώδικας.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Από προεπιλογή, η API αποδίδει μόνο την "Μορφή" διάταξη. Ωστόσο, μπορείτε επίσης να προσδιορίσετε τις διατάξεις της επιλογής σας κατά τη μετατροπή σχεδίων CAD σε μορφές εικόνας.

## **Προσαρμογή Μετατροπής CAD**

Οι διαδικασίες μετατροπής CAD σε [PDF](https://docs.fileformat.com/pdf/) & CAD σε εικόνες ράστερ είναι υψηλά δια configurable γιατί η κλάση [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) έχει υλοποιηθεί με τέτοιο τρόπο ώστε να παρέχει πολλές προαιρετικές δυνατότητες που όταν οριστούν μπορούν να αντικαταστήσουν τη διαδικασία απόδοσης σύμφωνα με τις ανάγκες της εφαρμογής.

### **CadRasterizationOptions Class**

Η **CadRasterizationOptions** κλάση είναι κοινή για όλες τις υποστηριζόμενες μορφές CAD όπως DWG & DXF, επομένως οι πληροφορίες που μοιράζονται σε αυτό το άρθρο είναι έγκυρες και για τις δύο προαναφερθείσες μορφές CAD.

Οι πιο χρήσιμες ιδιότητες της **CadRasterizationOptions** είναι:

|**Ιδιότητα**|**Προεπιλεγμένη Τιμή**|**Απαιτείται**|**Περιγραφή**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ναι|Καθορίζει το πλάτος της σελίδας.|
|**PageHeight**|**0**|Ναι|Καθορίζει το ύψος της σελίδας|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Όχι|Καθορίζει αν η σχεδίαση πρέπει να κλιμακωθεί αυτόματα. Η προεπιλεγμένη τιμή μειώνει αυτόματα την εικόνα για να ταιριάζει στο μέγεθος του καμβά. Αλλάξτε σε **GrowToFit** λειτουργία, ή χρησιμοποιήστε την επιλογή **None** για να απενεργοποιήσετε την αυτόματη κλιμάκωση.|
|**BackgroundColor**|**Color.White**|Όχι|Καθορίζει το χρώμα φόντου της εξόδου εικόνας.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Όχι|Καθορίζει τη μέθοδο χρωματισμού του οντότητας. Καθορίστε την επιλογή **UseObjectColor** για την σχεδίαση οντοτήτων χρησιμοποιώντας το φυσικό τους χρώμα, ή την επιλογή **UseDrawColor** για να παρακάμψετε τα φυσικά χρώματα.|
|**DrawColor**|**Color.Black**|Όχι|Καθορίζει το χρώμα της υπερβαλλόμενης οντότητας (μόνο αν η **DrawType** έχει οριστεί στην τιμή του ιδιότητας **UseDrawColor**).|
|**AutomaticLayoutsScaling**|Ψευδής|Όχι|Καθορίζει αν θα εκτελείται αυτόματος κλιμακωτός σχεδιασμός για να ταιριάζει με τη διάταξη Μοντέλου.|

### **Ρύθμιση του Μεγέθους και της Λειτουργίας του Καμβά**

Η εξαγωγή από CAD σε PDF ή CAD σε μορφές εικόνας ράστερ δεν είναι μια τυχαία εργασία. Δεδομένου ότι το προϊόν PDF ή εικόνας απαιτεί να οριστεί το μέγεθος του καμβά, πρέπει να προσδιορίσουμε τις διαστάσεις εξόδου για την απόδοση του σχεδίου σωστά. Ορίστε τις ιδιότητες **CadRasterizationOptions.PageWidth** και **CadRasterizationOptions.PageHeight** ρητά, ή αλλιώς μπορείτε να λάβετε μια **ImageSaveException**.

Επιπλέον, μπορείτε να προσδιορίσετε επιλογές κλιμάκωσης διαστάσεων. Οι επιλογές κλιμάκωσης ορίζονται από την ιδιότητα **CadRasterizationOptions.ScaleMethod**. Χρησιμοποιήστε αυτή την επιλογή για να προσαρμόσετε αυτόματα τις διαστάσεις της εικόνας σύμφωνα με τις τιμές **CadRasterizationOptions.PageWidth** και **CadRasterizationOptions.PageHeight**. Από προεπιλογή, η **CadRasterizationOptions.ScaleMethod** είναι ρυθμισμένη σε λειτουργία **ScaleType.ShrinkToFit**. Αυτή η ιδιότητα καθορίζει την ακόλουθη συμπεριφορά:

- Εάν οι διαστάσεις του σχεδίου CAD είναι μεγαλύτερες από το μέγεθος του καμβά, τότε οι διαστάσεις του σχεδίου θα μειωθούν ώστε να χωρέσουν στο αποτέλεσμα καμβά, διατηρώντας την αναλογία διαστάσεων.
- Εάν οι διαστάσεις του σχεδίου CAD είναι μικρότερες από το μέγεθος του καμβά, ορίστε την ιδιότητα **CadRasterizationOptions.ScaleMethod** σε **ScaleType.GrowToFit** προκειμένου να αυξήσετε το μέγεθος του σχεδίου για να χωρέσει στο καμβά PDF, διατηρώντας την αναλογία διαστάσεων.
- Ή απενεργοποιήστε την αυτόματη κλιμάκωση με την επιλογή **ScaleType.None**.

Το παρακάτω δείγμα κώδικα δείχνει την επιλογή αυτόματης κλιμάκωσης σε χρήση.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Ρύθμιση Χρωμάτων Φόντου και Σχεδίασης**

Από προεπιλογή, η παλέτα χρωμάτων για τον προκύπτοντα καμβά είναι ρυθμισμένη στο κοινό σχέδιο εγγράφου. Αυτό σημαίνει ότι όλες οι οντότητες μέσα στη σχεδίαση CAD σχεδιάζονται με ένα μαύρο στυλό σε έναν ομοιόμορφο λευκό φόντο. Αυτές οι ρυθμίσεις μπορούν να αλλάξουν με τις ιδιότητες **CadRasterizationOptions.BackgroundColor** και **CadRasterizationOptions.DrawColor**. Η αλλαγή της ιδιότητας **CadRasterizationOptions.DrawColor** απαιτεί επίσης την ρύθμιση της ιδιότητας **CadRasterizationOptions.DrawType** για να χρησιμοποιηθεί το χρώμα σχεδίασης. Η ιδιότητα **CadRasterizationOptions.DrawType** ελέγχει εάν οι οντότητες CAD διατηρούν τα χρώματά τους ή μετατρέπονται σε προσαρμοσμένα χρώματα. Για να διατηρηθούν τα χρώματα οντοτήτων, προσδιορίστε την ιδιότητα **CadRasterizationOptions.DrawType** ως **CadDrawTypeMode.UseObjectColor**, διαφορετικά προσδιορίστε την τιμή **CadDrawTypeMode.UseDrawColor**.

Το παρακάτω δείγμα κώδικα δείχνει πώς να χρησιμοποιήσετε διαφορετικές χρωματικές ιδιότητες.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Ρύθμιση Αυτόματης Κλιμάκωσης Διάταξης**

Οι περισσότερες από τις σχεδιάσεις CAD διαθέτουν περισσότερες από μία διατάξεις αποθηκευμένες σε ένα αρχείο, και κάθε διάταξη μπορεί να διαφέρει σε διαστάσεις. Κατά την απόδοση τέτοιων σχεδίων CAD σε PDF, κάθε σελίδα του PDF μπορεί να έχει διαφορετική κλιμάκωση σύμφωνα με το μέγεθος της διάταξης. Για να γίνει η απόδοση ομοιογενής, οι API της Aspose.CAD έχουν εκθέσει την ιδιότητα **CadRasterizationOptions.AutomaticLayoutsScaling**. Η προεπιλεγμένη τιμή της είναι **false** αλλά όταν είναι true, η API θα προσπαθήσει να αναζητήσει μια αντίστοιχη κλίμακα για κάθε ξεχωριστή διάταξη και να τις σχεδιάσει ανάλογα εκτελώντας αυτόματη λειτουργία αλλαγής μεγέθους σύμφωνα με το μέγεθος της σελίδας.

Ακολουθεί πώς λειτουργεί η ιδιότητα **CadRasterizationOptions.AutomaticLayoutsScaling** σε συνεργασία με την ιδιότητα **CadRasterizationOptions.ScaleMethod**.

1. Εάν η **ScaleMethod** έχει ρυθμιστεί σε **ScaleType.ShrinkToFit** ή **ScaleType.GrowToFit** και η **AutomaticLayoutsScaling** είναι ρυθμισμένη σε false τότε όλες οι διατάξεις (συμπεριλαμβανομένου του Μοντέλου) θα υποβληθούν σε επεξεργασία σύμφωνα με την πρώτη επιλογή.
1. Εάν η **ScaleMethod** έχει ρυθμιστεί σε **ScaleType.ShrinkToFit** ή **ScaleType.GrowToFit** και η **AutomaticLayoutsScaling** είναι ρυθμισμένη σε true τότε όλες οι διατάξεις (εκτός του Μοντέλου) θα υποβληθούν σε επεξεργασία σύμφωνα με το μέγεθός τους ενώ το Μοντέλο θα υποβληθεί σε επεξεργασία σύμφωνα με την πρώτη επιλογή.
1. Εάν η **ScaleMethod** είναι ρυθμισμένη σε **ScaleType.None** με την **AutomaticLayoutsScaling** είτε true είτε false τότε δεν θα εκτελεστεί καμία κλιμάκωση.

Το παρακάτω δείγμα κώδικα δείχνει πώς να ρυθμίσετε την αυτόματη κλιμάκωση διάταξης για τη μετατροπή CAD σε PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Μετατροπή Διάταξης AutoCAD DXF ή DWG σε PNG ή Άλλες Μορφές Εικόνας σε C#**

Η API Aspose.CAD για .NET μπορεί να μετατρέψει διατάξεις CAD υποστηριζόμενων μορφών όπως DXF και DWG σε PNG BMP TIFF JPEG και GIF. Η API παρέχει επίσης υποστήριξη για την απόδοση συγκεκριμένων διατάξεων σχεδίου CAD σε διαφορετικά επίπεδα PSD.

Ακολουθούν τα βήματα για να επιτύχετε το ίδιο:

- Φορτώστε το αρχείο AutoCAD DWG ή DXF χρησιμοποιώντας την κλάση **Image**.
- Ορίστε/αλλάξτε το πλάτος και το ύψος της εικόνας.
- Ορίστε τα επιθυμητά ονόματα διάταξης χρησιμοποιώντας την ιδιότητα **CadRasterizationOptions.Layouts**.
- Δημιουργήστε μια παρουσία της **ImageOptionsBase** και ορίστε την ιδιότητα **VectorRasterizationOptions** στην παρουσία της **CadRasterizationOptions** που δημιουργήθηκε στο προηγούμενο βήμα.
- Αποθηκεύστε τη διάταξη CAD ως TIFF ή εικόνα.

Ακολουθεί ο πλήρης πηγαίος κώδικας.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

Η ιδιότητα **CadRasterizationOptions.Layouts** είναι τύπου πίνακα συμβολοσειρών, επομένως μπορείτε να προσδιορίσετε περισσότερες από μία διατάξεις ταυτόχρονα για πιθανή μετατροπή σε μορφές εικόνας. Ενώ προσδιορίζετε πολλές διατάξεις για την ιδιότητα **CadRasterizationOptions.Layouts**, η προκύπτουσα εικόνα TIFF θα έχει πολλές σελίδες, η εικόνα GIF θα έχει πολλές καρέ και η μορφή [PSD](https://docs.fileformat.com/image/psd/) θα έχει πολλά επίπεδα, όπου κάθε σελίδα/καρέ/επίπεδο αντιπροσωπεύει μια ατομική διάταξη AutoCAD. Σε περίπτωση που επιλεγεί οποιαδήποτε άλλη μορφή εικόνας όπως PNG, BMP, JPEG για την αποθήκευση του αποτελέσματος τότε η API θα αποδώσει μόνο την προεπιλεγμένη διάταξη· δηλαδή "Μοντέλο".

{{% /alert %}}

## **Ενεργοποίηση Παρακολούθησης για τη Διαδικασία Απόδοσης CAD**

Η Aspose.CAD έχει εισαγάγει μια σειρά κλάσεων και υποστηρικτικών πεδίων αρίθμησης για να διευκολύνει την παρακολούθηση της διαδικασίας απόδοσης CAD. Με αυτές τις αλλαγές, η μετατροπή CAD σε PDF μπορεί τώρα να επιτευχθεί όπως παρακάτω ενώ ενεργοποιείτε την παρακολούθηση.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Η παρακολούθηση της διαδικασίας απόδοσης CAD μπορεί να ανιχνεύσει τα εξής πιθανά προβλήματα.

1. Ελλιπής ή κατεστραμμένη πληροφορία κεφαλίδας.
1. Ελλιπής πληροφορία διάταξης.
1. Ελλιπείς οντότητες μπλοκ.
1. Ελλείποντα στυλ διαστάσεων.
1. Ελλιπή στυλ.

## **Αντικατάσταση Γραμματοσειρών κατά τη Μετατροπή Σχεδίων CAD**

Είναι πολύ πιθανόν μια συγκεκριμένη σχεδίαση CAD να χρησιμοποιεί μια συγκεκριμένη γραμματοσειρά που δεν είναι διαθέσιμη στη μηχανή όπου πραγματοποιείται η μετατροπή CAD σε PDF ή CAD σε εικόνα ράστερ. Σε τέτοιες καταστάσεις, η Aspose.CAD API θα ενεργοποιήσει μια κατάλληλη εξαίρεση για να τονίσει τις ελλιπείς γραμματοσειρές και να σταματήσει τη διαδικασία μετατροπής καθώς η API απαιτεί αυτές τις γραμματοσειρές για να αποδώσει σωστά τα περιεχόμενα στο αποτέλεσμα PDF ή στις εικόνες.

Η Aspose.CAD API παρέχει έναν εύκολο τρόπο να χρησιμοποιήσετε τη μηχανιστική αντικατάσταση των απαιτούμενων γραμματοσειρών με τις διαθέσιμες γραμματοσειρές. Η ιδιότητα **CadImage.Styles** επιστρέφει μια παρουσία της **CadStylesDictionary** η οποία με τη σειρά της περιέχει το **CadStyleTableObject** για κάθε στυλ στη σχεδίαση CAD, ενώ η **CadStyleTableObject.PrimaryFontName** μπορεί να χρησιμοποιηθεί για να προσδιορίσει το διαθέσιμο όνομα γραμματοσειράς.

Το παρακάτω δείγμα κώδικα δείχνει τη χρήση της Aspose.CAD για .NET API για να αλλάξει τη γραμματοσειρά όλων των στυλ σε ένα σχέδιο CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Είναι επίσης δυνατό να αλλάξετε τη γραμματοσειρά μόνο ενός συγκεκριμένου στυλ με την πρόσβαση σε αυτό μέσω του ονόματος του στυλ. Το παρακάτω δείγμα κώδικα δείχνει πώς να χρησιμοποιήσετε αυτήν την προσέγγιση.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Μετατροπή CAD Layers σε Μορφές Εικόνας Ράστερ**

Η API Aspose.CAD για .NET έχει εκθέσει έναν αποδοτικό και εύκολο στη χρήση τρόπο προσδιορισμού του ονόματος της απαραίτητης λεπίδας CAD και απόδοσής της σε μορφές εικόνας ράστερ. Ακολουθούν απλά 5 βήματα για να επιτύχετε το ίδιο όπως παρακάτω.

1. Φορτώστε το αρχείο CAD σε μια παρουσία της **Image** χρησιμοποιώντας τη μέθοδο εργοστασίου **Load**.
1. Δημιουργήστε μια παρουσία της **CadRasterizationOptions** και ορίστε τις υποχρεωτικές ιδιότητες της όπως **PageWidth** & **PageHeight**.
1. Προσθέστε το επιθυμητό όνομα λεπίδας χρησιμοποιώντας τη μέθοδο **CadRasterizationOptions.Layers.Add**.
1. Δημιουργήστε μια παρουσία της **ImageOptionsBase** και ορίστε την ιδιότητα **VectorRasterizationOptions** στην παρουσία της **CadRasterizationOptions** που δημιουργήθηκε στο προηγούμενο βήμα.
1. Καλέστε τη μέθοδο **Image.Save** περνώντας το αρχείο (ή ένα αντικείμενο MemoryStream) καθώς και την παρουσία της **ImageOptionsBase** που δημιουργήθηκε στο προηγούμενο βήμα.

Ακολουθεί ο πλήρης πηγαίος κώδικας.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Μετατροπή Όλων των CAD Layers σε Ξεχωριστές Εικόνες**

Μπορείτε να αποκτήσετε όλες τις λεπίδες από ένα σχέδιο CAD χρησιμοποιώντας το **CadImage.Layers** και να αποδώσετε κάθε λεπίδα σε ξεχωριστή εικόνα όπως φαίνεται παρακάτω.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Μετατροπή DWF CAD Layers σε Μορφές Εικόνας Ράστερ**

Η API Aspose.CAD για .NET έχει εκθέσει έναν αποδοτικό και εύκολο στη χρήση τρόπο προσδιορισμού του ονόματος της απαραίτητης λεπίδας CAD και απόδοσής της σε μορφές εικόνας ράστερ. Ακολουθούν τα βήματα που μπορείτε να ακολουθήσετε ως παρακάτω:

1. Φορτώστε το αρχείο DWF CAD σε μια παρουσία της **Image** χρησιμοποιώντας τη μέθοδο εργοστασίου **Load**.
1. Δημιουργήστε μια παρουσία της **CadRasterizationOptions** και ορίστε τις υποχρεωτικές ιδιότητες της όπως **PageWidth** & **PageHeight**.
1. Προσθέστε το επιθυμητό όνομα λεπίδας χρησιμοποιώντας τη μέθοδο **CadRasterizationOptions.Layers.Add**.
1. Δημιουργήστε μια παρουσία της **ImageOptionsBase** και ορίστε την ιδιότητα **VectorRasterizationOptions** στην παρουσία της **CadRasterizationOptions** που δημιουργήθηκε στο προηγούμενο βήμα.
1. Καλέστε τη μέθοδο **Image.Save** περνώντας το αρχείο (ή ένα αντικείμενο MemoryStream) καθώς και την παρουσία της **ImageOptionsBase** που δημιουργήθηκε στο προηγούμενο βήμα.

Ακολουθεί ο πλήρης πηγαίος κώδικας.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Η Aspose.CAD για .NET γράφει απευθείας τις πληροφορίες σχετικά με την API και τον αριθμό έκδοσης στα έγγραφα εξόδου. Για παράδειγμα, κατά την απόδοση του εγγράφου σε PDF, η Aspose.CAD για .NET συμπληρώνει το πεδίο Εφαρμογής με την τιμή 'Aspose.CAD' και το πεδίο Παραγωγού PDF με μία τιμή, π.χ. 'Aspose.CAD v 17.10'.

Παρακαλώ σημειώστε ότι δεν μπορείτε να ζητήσετε από την Aspose.CAD για .NET να αλλάξει ή να αφαιρέσει αυτές τις πληροφορίες από τα έγγραφα εξόδου.
