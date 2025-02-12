---
title: Ρυθμίσεις Δοκιμών
type: docs
weight: 40
url: /el/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Η Aspose.CAD για Python περιλαμβάνει μια σειρά από έργα επίδειξης για να σας βοηθήσει να ξεκινήσετε.

Οι επίδειξεις που παρέχονται με την Aspose.CAD για Python είναι τυπικές επιδείξεις Python τροποποιημένες για να δείξουν τη χρήση των νέων εξαγωγέων.

{{% /alert %}}

Για να εκτελέσετε τις επιδείξεις της Aspose.CAD για Python, ακολουθήστε τα εξής βήματα:

1. Κατεβάστε τις Python (π.χ. https://sourceforge.net/projects/python-net/files/archive/). Βεβαιωθείτε ότι έχετε κατεβάσει ολόκληρο το αρχειοθετημένο έργο με τον πηγαίο κώδικα και τις επιδείξεις, όχι μόνο ένα μόνο JAR.
1. Αποσυμπιέστε το αρχειοθετημένο έργο σε κάποια τοποθεσία στον σκληρό σας δίσκο, για παράδειγμα C:\.
1. Αντιγράψτε όλους τους φακέλους επιδείξεων από το φάκελο \samples του **aspose-cad-xx.x.zip** στο **\InstallDir\demo\samples**, όπου το "\InstallDir" είναι η τοποθεσία στην οποία έχετε αποσυμπιέσει τις Python. Αυτό το βήμα είναι απαραίτητο επειδή τα σενάρια κατασκευής των επιδείξεων βασίζονται στην δομή των φακέλων της Python, διαφορετικά θα χρειαστεί να τροποποιήσετε τα σενάρια κατασκευής.
1. Αντιγράψτε το **aspose-cad-pythons-xx.x.jar** από το φάκελο \lib του **aspose-cad-pythons-xx.x.zip** στο **\InstallDir\lib**.
1. Ετοιμάστε το Ant Build Tool και τον Ivy Dependency Manager, δείτε το **\InstallDir\readme.txt**.
1. Τροποποιήστε το **build.xml** στο **\InstallDir\demo\samples**, προσθέστε το aspose-cad-pythons-xx.x.jar στο classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Αλλάξτε τον τρέχοντα κατάλογο σε **\InstallDir\demo\hsqldb** και εκτελέστε την παρακάτω εντολή γραμμής εντολών:
   **ant runServer**
1. Αλλάξτε τον τρέχοντα κατάλογο σε μία από τις επιδείξεις της Aspose.CAD για Python, για παράδειγμα **\InstallDir\demo\samples\charts.ai** και εκτελέστε τις παρακάτω εντολές στη γραμμή εντολών:
   **ant test** - για να παραγάγετε αρχεία αναφοράς.
1. Ανοίξτε κάποιο από τα παραγόμενα έγγραφα για προβολή, για παράδειγμα **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
