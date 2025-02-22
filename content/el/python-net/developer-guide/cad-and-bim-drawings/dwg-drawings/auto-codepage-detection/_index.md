---
title: Αυτόματη Ανίχνευση Κωδικοσελίδας
type: docs
weight: 10
url: /el/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **Αυτόματη Ανίχνευση Κωδικοσελίδας**

Η Aspose.CAD υποστηρίζει αυτόματη ανίχνευση κωδικοσελίδας για αρχεία [DWG](https://docs.fileformat.com/cad/dwg/) και [DWF](https://docs.fileformat.com/cad/dwf/). Εάν δεν επιθυμείτε να χρησιμοποιήσετε αυτή τη δυνατότητα, μπορείτε να την παρακάμψετε ρυθμίζοντας τις παρακάτω ιδιότητες της κλάσης **LoadOptions**.

- **specified_encoding**: καθορίζει την κωδικοποίηση που χρησιμοποιείται για την ανάγνωση δεδομένων κειμένου από μη Unicode DXF και DWG μορφές. Ανιχνεύεται αυτόματα από προεπιλογή.
- **specified_mif_encoding**: καθορίζει την κωδικοποίηση που χρησιμοποιείται για την ανάγνωση συμβόλων κωδικοποίησης MIF-encoded για CJK κωδικοποιήσεις (μορφή M+nXXXX). Ανιχνεύεται αυτόματα από προεπιλογή.
- **recover_malformed_cif_mif**: ορίζει εάν οι χαρακτήρες CIF (U+XXXX) και MIF-encoded θα αποκωδικοποιηθούν εάν δεν έχουν σωστή μορφοποίηση AutoCAD (η AutoCAD προηγείται αυτών των συμβόλων με έναν ανάστροφο). Από προεπιλογή, αποκωδικοποιούνται.

## Δείγμα Κώδικα

Το παρακάτω δείγμα κώδικα δείχνει πώς να παρακάμψετε την αυτόματη ανίχνευση κωδικοσελίδας στην Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
