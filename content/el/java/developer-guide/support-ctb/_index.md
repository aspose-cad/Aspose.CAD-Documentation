---
title: Υποστήριξη αρχείων CTB
type: docs
weight: 40
url: /el/java/developer-guide/support-ctb/
---

## **Υποστήριξη αρχείων CTB**

Μερικές φορές, τα χρώματα, τα βάρη γραμμών και ορισμένες άλλες επιλογές για σχέδια μπορεί να χρησιμοποιηθούν όχι μόνο από τα ίδια τα σχέδια αλλά και από στυλ εκτύπωσης σε ξεχωριστά αρχεία CTB.
Ο απλούστερος τρόπος για να χρησιμοποιήσετε αυτές τις πληροφορίες είναι να τοποθετήσετε τα αντίστοιχα αρχεία CTB κοντά στο αρχείο με το σχέδιο σε μορφή DWG/DXF και οι πληροφορίες από αυτά θα εφαρμοστούν
αυτόματα κατά την εξαγωγή.

Είναι επίσης δυνατή η φόρτωση όλων των αρχείων CTB με τη μορφή Stream χρησιμοποιώντας 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) ιδιότητα του 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) αντικειμένου.

Εδώ είναι το παράδειγμα για το πώς να το κάνετε αυτό:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
