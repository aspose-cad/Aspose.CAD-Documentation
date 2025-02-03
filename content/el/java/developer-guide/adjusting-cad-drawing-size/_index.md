---
title: Ρυθμίζοντας το Μέγεθος Σχεδίου CAD
type: docs
weight: 10
url: /el/java/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Χρησιμοποιώντας το Aspose.CAD για Java, οι προγραμματιστές μπορούν να ρυθμίσουν το μέγεθος του σχεδίου κατά τη διάρκεια της μετατροπής της μορφής CAD. Αυτό το θέμα εξηγεί την προσέγγιση αυτόματης ρύθμισης ή ρύθμισης του μεγέθους χρησιμοποιώντας το [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enum της κλάσης [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame).

{{% /alert %}}

## **Ρυθμίζοντας το μέγεθος του σχεδίου CAD**

Το Aspose.CAD για Java παρέχει την αναπαράσταση [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) για να ρυθμίσει το μέγεθος του σχεδίου κατά τη διάρκεια της μετατροπής της μορφής CAD. Υπάρχουν δύο τρόποι για να ρυθμίσετε το μέγεθος του σχεδίου.

1. Αυτόματη ρύθμιση μεγέθους
1. Ρυθμίστε το μέγεθος χρησιμοποιώντας την αναπαράσταση [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) της κλάσης [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame)

Για την αυτόματη ρύθμιση του μεγέθους, οι προγραμματιστές δεν χρειάζεται να παρέχουν τις ιδιότητες Πλάτος και Ύψος της κλάσης [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Παρακάτω παρέχεται ένα παράδειγμα αυτόματης ρύθμισης μεγέθους.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

Η αναπαράσταση [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) παρέχει την ικανότητα να ρυθμίσετε την κλίμακα όταν οι ιδιότητες Πλάτος και Ύψος δεν έχουν οριστεί. Παρακάτω παρέχεται ένα παράδειγμα για το πώς να χρησιμοποιήσετε την [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
