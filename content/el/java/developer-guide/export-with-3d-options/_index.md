---
title: Εξαγωγή με 3D επιλογές
type: docs
weight: 40
url: /el/java/developer-guide/export-with-3d-options/
---

## **Εξαγωγή με 3D επιλογές**

Λίγες επιλογές εισήχθησαν για την εξαγωγή 3D μοντέλων σε PDF/raster από τις αντίστοιχες μορφές FBX, OBJ, STL.

Ακολουθούν παραδείγματα της 3D σκηνής από διαφορετικές οπτικές γωνίες:

![Σχέδια](/_assets/guide/3d/fig1.png)

![Σχέδια από άλλες οπτικές γωνίες](/_assets/guide/3d/fig2.png)

Η ιδιότητα ObserverPoint επιτρέπει την περιστροφή της 3D σκηνής σύμφωνα με τις καθορισμένες γωνίες γύρω από τον άξονα. Αυτό το παράδειγμα δείχνει τον κώδικα και το αποτέλεσμα εξαγωγής χρησιμοποιώντας κάποιες αυθαίρετες γωνίες περιστροφής.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Εξαγωγή με περιστροφή](/_assets/guide/3d/fig3.png)

Αλλάζοντας την ObserverAngle σε ObserverPoint = new ObserverPoint(5, 60, 0) επιτρέπει την περιστροφή της σκηνής.

![Εξαγωγή με αλλαγμένη περιστροφή](/_assets/guide/3d/fig4.png)

Η άλλη ιδιότητα RenderMode3D επιτρέπει να καθορίσουμε πώς θα πρέπει να παρουσιαστεί το αποτέλεσμα εξαγωγής. Υπάρχουν 3 τρόποι: Solid (η προεπιλογή), Wireframe, και SolidWithEdges.

Το παρακάτω παράδειγμα επιτρέπει τη δημιουργία μοντέλου wireframe για το σφαιρικό αντικείμενο.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Τρόπος Wireframe](/_assets/guide/3d/fig5.png)

Το παρακάτω παράδειγμα δείχνει τη διαφορά μεταξύ των τρόπων Solid και SolidWithEdges.

![Τρόπος Solid](/_assets/guide/3d/fig6.png)
![Τρόπος Solid με άκρη](/_assets/guide/3d/fig7.png)
