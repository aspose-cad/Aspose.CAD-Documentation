---
title: Αυτόματη ανίχνευση κωδικοσελίδας
type: docs
weight: 10
url: /el/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **Αυτόματη ανίχνευση κωδικοσελίδας**

Η Aspose.CAD υποστηρίζει την αυτόματη ανίχνευση κωδικοσελίδας για [DWG](https://docs.fileformat.com/cad/dwg/) και [DWF](https://docs.fileformat.com/cad/dwf/) αρχεία. Αν δεν επιθυμείτε να χρησιμοποιήσετε αυτή τη δυνατότητα, μπορείτε να την παρακάμψετε ρυθμίζοντας τις ακόλουθες ιδιότητες της [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions) κλάσης.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): ορίζει την κωδικοποίηση που χρησιμοποιείται για την ανάγνωση κειμένων από μη-Unicode DXF και DWG μορφές. Είναι αυτόματα ανιχνεύσιμη από προεπιλογή.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): ορίζει την κωδικοποίηση που χρησιμοποιείται για την ανάγνωση των MIF-κωδικοποιημένων συμβόλων κωδικοποιήσεων CJK (M+nXXXX μορφή). Είναι αυτόματα ανιχνεύσιμη από προεπιλογή.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): καθορίζει αν οι χαρακτήρες CIF (U+XXXX) και MIF-κωδικοποιημένοι χαρακτήρες θα αποκωδικοποιηθούν αν δεν έχουν κατάλληλη μορφοποίηση AutoCAD (το AutoCAD προσαρτά αυτούς τους χαρακτήρες με μία αντίστροφη γραμμή). Από προεπιλογή, αποκωδικοποιούνται.

## Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να παρακάμψετε την αυτόματη ανίχνευση κωδικοσελίδας στην Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
