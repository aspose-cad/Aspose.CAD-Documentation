---
title: Αυτόματη ανίχνευση κωδικοσελίδας
type: docs
weight: 10
url: /el/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Αυτόματη ανίχνευση κωδικοσελίδας**

Η Aspose.CAD υποστηρίζει την αυτόματη ανίχνευση κωδικοσελίδας για αρχεία [DWG](https://docs.fileformat.com/cad/dwg/) και [DWF](https://docs.fileformat.com/cad/dwf/). Εάν δεν επιθυμείτε να χρησιμοποιήσετε αυτή τη δυνατότητα, μπορείτε να την παρακάμψετε ρυθμίζοντας τις παρακάτω ιδιότητες της [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions) κλάσης.

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): ρυθμίζει την κωδικοποίηση που χρησιμοποιείται για την ανάγνωση κειμένων από μη-Unicode DXF και DWG μορφές. Ανιχνεύεται αυτόματα από προεπιλογή.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): ρυθμίζει την κωδικοποίηση που χρησιμοποιείται για την ανάγνωση MIF-κωδικωμένων συμβόλων των κωδικοποιήσεων CJK (μορφή M+nXXXX). Ανιχνεύεται αυτόματα από προεπιλογή.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): ορίζει αν οι CIF (U+XXXX) και MIF-κωδικωμένοι χαρακτήρες θα αποκωδικοποιηθούν αν δεν έχουν τη σωστή μορφοποίηση AutoCAD (το AutoCAD προτάσσει αυτούς τους χαρακτήρες με μια απόστροφο). Από προεπιλογή, αποκωδικοποιούνται.

## Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να παρακάμψετε την αυτόματη ανίχνευση κωδικοσελίδας στην Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
