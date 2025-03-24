---
title: Εξαγωγή με επιλογές 3D
type: docs
weight: 40
url: /el/net/developer-guide/export-with-3d-options/
---

## **Εξαγωγή με επιλογές 3D**

Ορισμένες επιλογές εισήχθησαν για την εξαγωγή 3D μοντέλων σε PDF/raster από τα αντίστοιχα FBX, OBJ, STL φορμά.

Ακολουθούν παραδείγματα της 3D σκηνής από διαφορετικές γωνίες θέασης:

![Σχήματα](/cad/_assets/guide/3d/fig1.png)

![Σχήματα από άλλες γωνίες θέασης](/cad/_assets/guide/3d/fig2.png)

Η ιδιότητα ObserverPoint επιτρέπει την περιστροφή της 3D σκηνής σύμφωνα με τις καθορισμένες γωνίες γύρω από τον άξονα. Αυτό το παράδειγμα δείχνει τον κώδικα και το αποτέλεσμα εξαγωγής χρησιμοποιώντας ορισμένες αυθαίρετες γωνίες περιστροφής.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Εξαγωγή με περιστροφή](/cad/_assets/guide/3d/fig3.png)

Η αλλαγή του ObserverAngle σε ObserverPoint = new ObserverPoint(5, 60, 0) επιτρέπει την περιστροφή της σκηνής.

![Εξαγωγή με αλλαγμένη περιστροφή](/cad/_assets/guide/3d/fig4.png)

Η άλλη ιδιότητα RenderMode3D επιτρέπει να καθορίσετε πώς θα παρουσιαστεί το αποτέλεσμα εξαγωγής. Υπάρχουν 3 τρόποι: Στερεό (η προεπιλογή), Wireframe και SolidWithEdges.

Το παράδειγμα παρακάτω επιτρέπει τη δημιουργία μοντέλου wireframe για το σφαιρικό αντικείμενο.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Λειτουργία Wireframe](/cad/_assets/guide/3d/fig5.png)

Το παράδειγμα παρακάτω δείχνει τη διαφορά μεταξύ των τρόπων Solid και SolidWithEdges.

![Λειτουργία Solid](/cad/_assets/guide/3d/fig6.png)
![Λειτουργία Solid με άκρη](/cad/_assets/guide/3d/fig7.png)
