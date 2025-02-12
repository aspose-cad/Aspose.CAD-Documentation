---
title: Υποστήριξη αρχείων CTB
type: docs
weight: 40
url: /el/net/developer-guide/support-ctb/
---

## **Υποστήριξη αρχείων CTB**

Μερικές φορές, οι ρυθμίσεις χρώματος, οι γραμμές και κάποιες άλλες επιλογές για τα σχέδια μπορεί να χρησιμοποιούνται όχι μόνο από τα ίδια τα σχέδια αλλά και από στυλ εκτύπωσης σε ξεχωριστά αρχεία CTB. 
Ο απλούστερος τρόπος για να χρησιμοποιήσετε αυτές τις πληροφορίες είναι να τοποθετήσετε τα αντίστοιχα αρχεία CTB κοντά στο αρχείο με το σχέδιο σε μορφή DWG/DXF και οι πληροφορίες από αυτά θα εφαρμοστούν
αυτόματα κατά την εξαγωγή.

Είναι επίσης δυνατή η φόρτωση όλων των αρχείων CTB με τη μορφή Stream χρησιμοποιώντας 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) ιδιότητα του 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) αντικειμένου.

Ακολουθεί το παράδειγμα για το πώς να το κάνετε αυτό:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
