---
title: Σφάλματα Callback κατά τη διάρκεια εξαγωγής και φόρτωσης
type: docs
weight: 40
url: /el/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Αξιολόγηση σφαλμάτων callback κατά τη διάρκεια εξαγωγής και φόρτωσης**

Είναι πιθανό κατά τη διάρκεια της εξαγωγής ή φόρτωσης του σχεδίου να αντιμετωπίσουμε σφάλματα που σχετίζονται με τη δομή του αρχείου 
(π.χ. τμήματα στο αρχείο απαιτούνται τώρα αλλά όχι νωρίτερα). 
Ορισμένα από αυτά είναι κρίσιμα και σε αυτές τις περιπτώσεις ρίχνεται η εξαίρεση, αλλά μπορούμε επίσης να αγνοήσουμε ορισμένα από αυτά εσωτερικά και να ειδοποιήσουμε γι’ αυτό χρησιμοποιώντας μηνύματα callback.
Ούτως ή άλλως, όλα αυτά τα μηνύματα απαιτούν προσοχή επειδή μπορεί να εξηγήσουν π.χ. ελλείπουσες ο entites στα αποτελέσματα εξαγωγής ή άλλα αποτελέσματα.


### **Σφάλματα κατά την εξαγωγή**

Υπάρχει το πεδίο RenderResult στο [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
που περιλαμβάνει το IsRenderComplete για να διαπιστώσει αν υπήρξαν σφάλματα κατά την εξαγωγή και να εκτυπώσει πληροφορίες γι' αυτά:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Σφάλματα κατά την φόρτωσης**

Ορισμένα προβλήματα με σχέδια μπορεί να παρατηρηθούν νωρίτερα από την έναρξη της διαδικασίας εξαγωγής. 
Το [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) χαρακτηριστικό στο
 [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) αντικείμενο χρησιμοποιείται για να αποθηκεύει μηνύματα γι’ αυτά.
Το [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) χαρακτηριστικό είναι χρήσιμο για να αποφασίσει αν 
απαιτείται να ρίχνεται εξαίρεση για σφάλματα φόρτωσης ή όχι. 

Ακολουθεί ένα παράδειγμα χρήσης του χαρακτηριστικού Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
