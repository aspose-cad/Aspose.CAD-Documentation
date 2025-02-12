---
title: Μετατροπή Σχεδίων CAD σε PDF και Μορφές Ραστερικής Εικόνας
type: docs
weight: 30
url: /el/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Το Aspose.CAD for Java γράφει απευθείας τις πληροφορίες σχετικά με το API και τον αριθμό έκδοσης στα έγγραφα εξόδου. Για παράδειγμα, κατά την απόδοση του Εγγράφου σε PDF, το Aspose.CAD for Java συμπληρώνει το πεδίο Εφαρμογής με την τιμή 'Aspose.CAD' και το πεδίο PDF Producer με μια τιμή, π.χ. 'Aspose.CAD v 17.9'.

Σημειώστε ότι δεν μπορείτε να ζητήσετε από το Aspose.CAD for Java να αλλάξει ή να αφαιρέσει αυτές τις πληροφορίες από τα έγγραφα εξόδου.

{{% /alert %}} 
## **Μετατροπή Σχεδίων CAD σε Μορφές Ραστερικής Εικόνας**
Το Aspose.CAD for Java είναι ικανό να μετατρέπει τις μορφές σχεδίων CAD όπως [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) στις υποστηριζόμενες μορφές ραστερικής εικόνας όπως [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). Το API Aspose.CAD for Java έχει προσφέρει αποτελεσματικούς και εύκολους στη χρήση τρόπους για να επιτευχθεί αυτός ο στόχος.
Μπορείτε να μετατρέψετε οποιαδήποτε υποστηριζόμενη μορφή σχεδίου CAD σε μορφές ραστερικών εικόνων χρησιμοποιώντας τα απλά βήματα που περιγράφονται παρακάτω.

1. Φορτώστε το αρχείο CAD σε μια παρουσία του [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Δημιουργήστε μια παρουσία του [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) και ρυθμίστε τις υποχρεωτικές ιδιότητές της όπως το [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & το [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Δημιουργήστε μια παρουσία του **ImageOptionsBase** και ρυθμίστε την ιδιότητα [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) στην παρουσία του **CadRasterizationOptions** που δημιουργήθηκε στο προηγούμενο βήμα.
1. Καλέστε το **Image.save** περνώντας τη διαδρομή του αρχείου (ή ένα αντικείμενο MemoryStream) καθώς και την παρουσία του [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) που δημιουργήθηκε στο προηγούμενο βήμα.

Εδώ είναι ο πλήρης πηγαίος κώδικας.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Από προεπιλογή, το API αποδίδει μόνο την διάταξη "Model". Ωστόσο, μπορείτε επίσης να καθορίσετε τις διάταξές της επιλογής σας κατά τη μετατροπή των σχεδίων CAD σε μορφές εικόνας.
## **Προσαρμογή της Μετατροπής CAD**
Οι διαδικασίες μετατροπής CAD σε [PDF](https://docs.fileformat.com/pdf/) και CAD σε ραστερικές εικόνες είναι εξαιρετικά παραμετροποιήσιμες, καθώς η κλάση [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) έχει υλοποιηθεί με τέτοιο τρόπο ώστε να παρέχει πολλές προαιρετικές δυνατότητες που, αφού ρυθμιστούν, μπορούν να αντικαταστήσουν τη διαδικασία απόδοσης σύμφωνα με τις ανάγκες της εφαρμογής.
### **Κλάση CadRasterizationOptions**
Η κλάση [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) είναι κοινή για όλες τις υποστηριζόμενες μορφές CAD όπως [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/), επομένως, οι πληροφορίες που κοινοποιούνται σε αυτό το άρθρο είναι έγκυρες και για τις δύο ανωτέρω μορφές CAD.

Οι πιο χρήσιμες ιδιότητες της κλάσης **CadRasterizationOptions** είναι:

|**Ιδιότητα**|**Αρχική Τιμή**|**Απαιτείται**|**Περιγραφή**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ναι|Καθορίζει το πλάτος της σελίδας.|
|**PageHeight**|**0**|Ναι|Καθορίζει το ύψος της σελίδας|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Όχι|Καθορίζει εάν το σχέδιο πρέπει να κλιμακωθεί αυτόματα. Η προεπιλεγμένη τιμή μειώνει αυτόματα την εικόνα για να χωρέσει στο μέγεθος του καμβά. Εναλλάσσεστε σε **GrowToFit** ή χρησιμοποιήστε την ρύθμιση **None** για να απενεργοποιήσετε την αυτόματη κλιμάκωση.|
|**BackgroundColor**|**Color.White**|Όχι|Καθορίζει το χρώμα φόντου της εξόδου εικόνας.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Όχι|Καθορίζει τη μέθοδο χρωματισμού της οντότητας. Καθορίστε την επιλογή **UseObjectColor** για να σχεδιάσετε τις οντότητες χρησιμοποιώντας το εγγενές χρώμα τους ή την επιλογή **UseDrawColor** για να αντικαταστήσετε τα εγγενή χρώματα.|
|**DrawColor**|**Color.Black**|Όχι|Καθορίζει το χρώμα της αντικατασταθείσας οντότητας (μόνο αν η **DrawType** είναι ρυθμισμένη στην τιμή ιδιότητας **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Όχι|Καθορίζει εάν πρέπει να εκτελείται αυτόματη κλιμάκωση διάταξης για να ταιριάζει με τη διάταξη Model.|
### **Ρύθμιση του Μεγέθους & Τύπου Καμβά**
Η εξαγωγή από CAD σε PDF ή CAD σε μορφές ραστερικής εικόνας δεν είναι μια απλή εργασία. Δεδομένου ότι η προκύπτουσα PDF ή εικόνα απαιτεί να καθοριστεί το μέγεθος του καμβά, πρέπει να καθορίσουμε τις διαστάσεις εξόδου για την σελίδα PDF ώστε να αποδοθεί σωστά το σχέδιο. Ρυθμίστε τις ιδιότητες **CadRasterizationOptions.PageWidth** και **CadRasterizationOptions.PageHeight** ρητά ή μπορεί να προκύψει μια **ImageSaveException**.

Επιπλέον, μπορείτε να καθορίσετε επιλογές κλιμάκωσης διαστάσεων. Οι επιλογές κλιμάκωσης ρυθμίζονται από την ιδιότητα **CadRasterizationOptions.ScaleMethod**. Χρησιμοποιήστε αυτήν την επιλογή για να προσαρμόσετε αυτόματα τις διαστάσεις της εικόνας σύμφωνα με τις τιμές **CadRasterizationOptions.PageWidth** και **CadRasterizationOptions.PageHeight**. Από προεπιλογή, η **CadRasterizationOptions.ScaleMethod** είναι ρυθμισμένη σε **ScaleType.ShrinkToFit**. Αυτή η ιδιότητα καθορίζει την ακόλουθη συμπεριφορά:

- Εάν οι διαστάσεις του σχεδίου CAD είναι μεγαλύτερες από το μέγεθος καμβά, τότε οι διαστάσεις του σχεδίου μειώνονται για να χωρέσουν στο μέγεθος του προκύπτοντος καμβά διατηρώντας τη αναλογία διαστάσεων.
- Εάν οι διαστάσεις του σχεδίου CAD είναι μικρότερες από το μέγεθος του προκύπτοντος καμβά, ρυθμίστε την ιδιότητα **CadRasterizationOptions.ScaleMethod** στην **ScaleType.GrowToFit** για να αυξήσετε το μέγεθος του σχεδίου ώστε να ταιριάζει στο καμβά PDF διατηρώντας τη αναλογία διαστάσεων.
- Ή απενεργοποιήστε την αυτόματη κλιμάκωση με την επιλογή **ScaleType.None**.

Ο παρακάτω κώδικας δείχνει την επιλογή αυτόματης κλιμάκωσης σε χρήση.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Ρύθμιση Χρωμάτων Φόντου & Σχεδίασης**
Από προεπιλογή, η παλέτα χρωμάτων για τον προκύπτοντα καμβά είναι ρυθμισμένη στο κοινό σχέδιο εγγράφου. Αυτό σημαίνει ότι όλες οι οντότητες μέσα στο σχέδιο CAD σχεδιάζονται με ένα μαύρο χρώμα πάνω σε ένα απλό λευκό φόντο. Αυτές οι ρυθμίσεις μπορούν να αλλάξουν με τις ιδιότητες **CadRasterizationOptions.BackgroundColor** και **CadRasterizationOptions.DrawColor**. Η αλλαγή της ιδιότητας **CadRasterizationOptions.DrawColor** απαιτεί επίσης να ρυθμίσετε την ιδιότητα **CadRasterizationOptions.DrawType** για να χρησιμοποιήσετε το χρώμα σχεδίασης που θα χρησιμοποιηθεί. Η ιδιότητα **CadRasterizationOptions.DrawType** ελέγχει εάν οι οντότητες CAD διατηρούν τα χρώματά τους ή αν μετατρέπονται σε προσαρμοσμένα χρώματα. Για να διατηρήσετε τα χρώματα των οντοτήτων, καθορίστε την **CadRasterizationOptions.DrawType** ως **CadDrawTypeMode.UseObjectColor**, αλλιώς καθορίστε την τιμή **CadDrawTypeMode.UseDrawColor**.

Ο παρακάτω κώδικας δείχνει πώς να χρησιμοποιήσετε τις διάφορες χρωματικές ιδιότητες.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Ρύθμιση Αυτόματης Κλιμάκωσης Διάταξης**
Οι περισσότερες σχεδιάσεις CAD έχουν περισσότερες από μία διάταξες που είναι αποθηκευμένες σε ένα μόνο αρχείο, και κάθε διάταξη μπορεί να έχει διαφορετικές διαστάσεις. Κατά την απόδοση τέτοιων σχεδίων CAD σε PDF, κάθε σελίδα του PDF μπορεί να έχει διαφορετική κλιμάκωση σύμφωνα με το μέγεθος της διάταξης. Για να γίνει η απόδοση ομογενής, τα APIs Aspose.CAD έχουν αποκαλύψει την ιδιότητα **CadRasterizationOptions.AutomaticLayoutsScaling**. Η προεπιλεγμένη τιμή της είναι **false**, αλλά όταν είναι true, το API θα προσπαθήσει να αναζητήσει την αντίστοιχη κλίμακα για κάθε ξεχωριστή διάταξη και να τις αποδώσει με αντίστοιχο τρόπο εκτελώντας αυτόματη λειτουργία αλλαγής μεγέθους σύμφωνα με το μέγεθος της σελίδας.

Δείτε πώς λειτουργεί η ιδιότητα **CadRasterizationOptions.AutomaticLayoutsScaling** σε συνεργασία με την ιδιότητα **CadRasterizationOptions.ScaleMethod**.

1. Εάν η **ScaleMethod** ρυθμιστεί σε **ScaleType.ShrinkToFit** ή **ScaleType.GrowToFit** με την **AutomaticLayoutsScaling** ρυθμισμένη σε false, τότε όλες οι διάταξεις (συμπεριλαμβανομένης της Model) θα υποβληθούν σε επεξεργασία σύμφωνα με την πρώτη επιλογή.
1. Εάν η **ScaleMethod** ρυθμιστεί σε **ScaleType.ShrinkToFit** ή **ScaleType.GrowToFit** με την **AutomaticLayoutsScaling** ρυθμισμένη σε true, τότε όλες οι διάταξεις (εκτός από την Model) θα υποβληθούν σε επεξεργασία σύμφωνα με το μέγεθός τους, ενώ η Model θα υποβληθεί σε επεξεργασία σύμφωνα με την πρώτη επιλογή.
1. Εάν η **ScaleMethod** ρυθμιστεί σε **ScaleType.None** με την **AutomaticLayoutsScaling** ρυθμισμένη σε true ή false τότε δεν θα εκτελεστεί καμία κλιμάκωση.

Ο παρακάτω κώδικας δείχνει πώς να ρυθμίσετε την αυτόματη κλιμάκωση διάταξης για τη μετατροπή CAD σε PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Μετατροπή Διάταξεων CAD σε Μορφές Ραστερικής Εικόνας**
Το API Aspose.CAD for Java είναι ικανό να μετατρέπει τις διάταξεις CAD υποστηριζόμενων μορφών όπως DXF & DWG σε ραστερικές εικόνες όπως PNG, BMP, TIFF, JPEG & GIF. Το API παρέχει επίσης υποστήριξη για την απόδοση συγκεκριμένων διάταξεων ενός σχεδίου CAD σε διαφορετικά επίπεδα PSD. 
Το API Aspose.CAD for Java έχει προσφέρει αποτελεσματικούς και εύκολους στη χρήση τρόπους για να καθορίσετε τη λίστα των απαιτούμενων διάταξεων CAD και να τις αποδώσετε σε μορφές ραστερικής εικόνας. Δείτε πώς μπορείτε να το επιτύχετε σε 5 απλά βήματα που παρατίθενται παρακάτω.

1. Φορτώστε το αρχείο CAD σε μια παρουσία του **Image** χρησιμοποιώντας τη μέθοδο δημιουργίας **load**.
1. Δημιουργήστε μια παρουσία του **CadRasterizationOptions** και ρυθμίστε τις υποχρεωτικές ιδιότητές της όπως **PageWidth** & **PageHeight**.
1. Καθορίστε το όνομα(τα) διάταξης που επιθυμείτε χρησιμοποιώντας την ιδιότητα CadRasterizationOptions.Layouts.
1. Δημιουργήστε μια παρουσία του **ImageOptionsBase** και ρυθμίστε την ιδιότητα **VectorRasterizationOptions** στην παρουσία του **CadRasterizationOptions** που δημιουργήθηκε στο προηγούμενο βήμα.
1. Καλέστε τη μέθοδο **Image.Save** περνώντας τη διαδρομή του αρχείου (ή ένα αντικείμενο MemoryStream) καθώς και την παρουσία της **ImageOptionsBase** που δημιουργήθηκε στο προηγούμενο βήμα.

Εδώ είναι ο πλήρης πηγαίος κώδικας.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

Η ιδιότητα **CadRasterizationOptions.Layouts** είναι τύπου πίνακα συμβολοσειρών, επομένως μπορείτε να καθορίσετε περισσότερες από μία διάταξεις ταυτόχρονα για πιθανή μετατροπή σε μορφές εικόνας. Κατά την καθορισμένη επιλογή πολλαπλών διάταξεων για την ιδιότητα **CadRasterizationOptions.Layouts**, η προκύπτουσα εικόνα TIFF θα έχει πολλαπλές σελίδες, η εικόνα GIF θα έχει πολλαπλά καρέ και η μορφή PSD θα έχει πολλαπλά επίπεδα, όπου κάθε σελίδα/καρέ/επίπεδο αντιπροσωπεύει μια μεμονωμένη διάταξη AutoCAD. Σε περίπτωση που επιλεγεί οποιαδήποτε άλλη μορφή εικόνας όπως PNG, BMP, JPEG για να αποθηκευτεί το αποτέλεσμα, τότε το API θα αποδώσει μόνο τη βασική διάταξη, δηλαδή την "Model".

{{% /alert %}} 
## **Ενεργοποίηση Παρακολούθησης της Διαδικασίας Απόδοσης CAD**
Το Aspose.CAD έχει εισαγάγει μια σειρά κλάσεων και υποστηρικτικών πεδίων καταμέτρησης για να βοηθήσει στην παρακολούθηση της διαδικασίας απόδοσης CAD. Με αυτές τις αλλαγές στη θέση τους, η μετατροπή CAD σε PDF μπορεί να επιτευχθεί τώρα ως εξής, ενεργοποιώντας την παρακολούθηση.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Η παρακολούθηση της διαδικασίας απόδοσης CAD μπορεί να ανιχνεύσει τα εξής πιθανά προβλήματα.

1. Απώλεια ή κατεστραμμένες πληροφορίες κεφαλίδας.
1. Απώλεια πληροφοριών διάταξης.
1. Απώλεια οντοτήτων μπλοκ.
1. Απώλεια στυλ διαστάσεων.
1. Απώλεια στυλ.
## **Αντικατάσταση Γραμματοσειρών κατά τη Μετατροπή Σχεδίων CAD**
Είναι πολύ πιθανό ότι ένα συγκεκριμένο σχέδιο CAD χρησιμοποιεί κάποια συγκεκριμένη γραμματοσειρά που δεν είναι διαθέσιμη στη μηχανή όπου πραγματοποιείται η μετατροπή CAD σε PDF ή CAD σε μορφές ραστερικής εικόνας. Σε τέτοιες περιπτώσεις, το API Aspose.CAD θα ενεργοποιήσει μια κατάλληλη εξαίρεση για να επισημάνει τις ελλείπουσες γραμματοσειρές και να σταματήσει τη διαδικασία μετατροπής γιατί το API απαιτεί αυτές τις γραμματοσειρές για να αποδώσει σωστά τα περιεχόμενα στα προκύπτοντα PDF και/ή εικόνες.
Το API Aspose.CAD παρέχει έναν εύκολο τρόπο για να χρησιμοποιήσετε μηχανισμό αντικατάστασης των απαιτούμενων γραμματοσειρών με τις διαθέσιμες γραμματοσειρές. Η ιδιότητα **CadImage.Styles** επιστρέφει μια παρουσία του **CadStylesDictionary** που περιέχει τη **CadStyleTableObject** για κάθε στυλ στο σχέδιο CAD, ενώ η **CadStyleTableObject.PrimaryFontName** μπορεί να χρησιμοποιηθεί για να καθορίσει το όνομα της διαθέσιμης γραμματοσειράς.

Ο παρακάτω κώδικας δείχνει την χρήση του Aspose.CAD for Java API για να αλλάξει τη γραμματοσειρά όλων των στυλών σε ένα σχέδιο CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Είναι επίσης δυνατό να αλλάξετε τη γραμματοσειρά μόνο ενός συγκεκριμένου στυλ επιλέγοντας το μέσω του ονόματος στυλ. Ο παρακάτω κώδικας δείχνει την χρήση αυτής της προσέγγισης.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Μετατροπή Επίπεδων CAD σε Μορφές Ραστερικής Εικόνας**
Το API Aspose.CAD for Java έχει προσφέρει ένα αποτελεσματικό και εύκολο στη χρήση τρόπο για να προσδιορίσετε το όνομα του επιθυμητού επιπέδου CAD και να το αποδώσετε σε μορφές ραστερικής εικόνας. Δείτε πώς μπορείτε να το επιτύχετε σε 5 απλά βήματα όπως παρατίθεται παρακάτω.

1. Φορτώστε το αρχείο CAD σε μια παρουσία του **Image** χρησιμοποιώντας τη μέθοδο δημιουργίας **load**.
1. Δημιουργήστε μια παρουσία του **CadRasterizationOptions** και ρυθμίστε τις υποχρεωτικές ιδιότητές της όπως **PageWidth** & **PageHeight**.
1. Προσθέστε το επιθυμητό όνομα επιπέδου χρησιμοποιώντας τη μέθοδο **CadRasterizationOptions.Layers.add**.
1. Δημιουργήστε μια παρουσία του **ImageOptionsBase** και ρυθμίστε την ιδιότητα **VectorRasterizationOptions** στην παρουσία του **CadRasterizationOptions** που δημιουργήθηκε στο προηγούμενο βήμα.
1. Καλέστε τη μέθοδο **Image.save** με την περνώντας τη διαδρομή του αρχείου (ή ένα αντικείμενο του MemoryStream) καθώς και την παρουσία του **ImageOptionsBase** που δημιουργήθηκε στο προηγούμενο βήμα.

Εδώ είναι ο πλήρης πηγαίος κώδικας.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Μετατροπή Όλων των Επιπέδων CAD σε Ξεχωριστές Εικόνες**
Μπορείτε να αποκτήσετε όλα τα επίπεδα από ένα σχέδιο CAD χρησιμοποιώντας την **CadImage.Layers** και να αποδώσετε κάθε επίπεδο σε ξεχωριστή εικόνα όπως απεικονίζεται παρακάτω.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Μετατροπή Επιπέδων DWF CAD σε Μορφές Ραστερικής Εικόνας**
Το API Aspose.CAD for Java έχει προσφέρει έναν αποτελεσματικό και εύκολο στη χρήση τρόπο για να προσδιορίσετε το όνομα του επιθυμητού επιπέδου CAD και να το αποδώσετε σε μορφές ραστερικής εικόνας. Δείτε πώς μπορείτε να το επιτύχετε σε 5 απλά βήματα όπως παρατίθενται παρακάτω.

1. Φορτώστε το αρχείο DWF CAD σε μια παρουσία του **Image** χρησιμοποιώντας τη μέθοδο δημιουργίας **Load**.
1. Δημιουργήστε μια παρουσία του **CadRasterizationOptions** και ρυθμίστε τις υποχρεωτικές ιδιότητές της όπως **PageWidth** & **PageHeight**.
1. Προσθέστε το επιθυμητό όνομα επιπέδου χρησιμοποιώντας τη μέθοδο **CadRasterizationOptions.Layers.Add**.
1. Δημιουργήστε μια παρουσία του **ImageOptionsBase** και ρυθμίστε την ιδιότητα **VectorRasterizationOptions** στην παρουσία του **CadRasterizationOptions** που δημιουργήθηκε στο προηγούμενο βήμα.
1. Καλέστε τη μέθοδο **Image.Save** περνώντας τη διαδρομή του αρχείου (ή ένα αντικείμενο MemoryStream) καθώς και την παρουσία του **ImageOptionsBase** που δημιουργήθηκε στο προηγούμενο βήμα.

Εδώ είναι ο πλήρης πηγαίος κώδικας.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
