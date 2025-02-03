---
title: Εργασία με κείμενο
type: docs
weight: 40
url: /el/net/work-with-text/
---

## **Εργασία με κείμενο**

Σχεδόν όλα τα σχέδια περιέχουν αντικείμενα κειμένου και αυτά τα παραδείγματα δείχνουν πώς να εκτελούνται λειτουργίες με αυτά. 
Υπάρχουν διαφορετικοί τύποι οντοτήτων για DWG/DXF που μπορούν να αποθηκεύσουν κείμενο, είναι τα [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Οι δύο τελευταίοι τύποι σχετίζονται συνήθως 
με [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
και αποθηκεύονται μέσα σε αυτό ή στο αντίστοιχο μπλοκ.

Ακολουθούν μερικά παραδείγματα που περιγράφουν λειτουργίες με κείμενο.

### **Αναζήτηση κειμένου**

Αυτό το παράδειγμα δείχνει πώς να βρείτε τιμές κειμένου στο αρχείο DWG/DXF και μπορεί επίσης να χρησιμοποιηθεί για την αντικατάσταση τιμών κειμένου.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Προσθήκη νέων αντικειμένων Κειμένου και MText**

Ακολουθεί το παράδειγμα για το πώς να προσθέσετε νέα αντικείμενα Κειμένου/Mtext στο σχέδιο. Η προσθήκη νέων οντοτήτων μπορεί να αλλάξει το μέγεθος του σχεδίου, επομένως συνιστάται
να καλέσετε την UpdateSize() μετά από αυτές τις λειτουργίες.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
