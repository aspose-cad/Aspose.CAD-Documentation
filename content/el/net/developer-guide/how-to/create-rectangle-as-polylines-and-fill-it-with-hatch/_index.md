---
title: Δημιουργία παραλληλόγραμμου ως πολύγωνα και γέμισμα με διαγράμμιση
type: docs
weight: 24
url: /el/net/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Πώς να δημιουργήσετε παραλληλόγραμμο ως πολύγωνα και να το γεμίσετε με διαγράμμιση**

**Θέμα:** Πώς να δημιουργήσετε παραλληλόγραμμο ως πολύγωνα και να το γεμίσετε με διαγράμμιση (CADNET-1351).

**Συμβουλές:** Για να το κάνετε αυτό, δημιουργήστε μια CadLwPolyline και προσθέστε συντεταγμένες σημείων σε αυτήν, χρησιμοποιήστε το CadHatch για να εργαστείτε με χρώμα και χρησιμοποιήστε το CadEdgeBoundaryPath για να συνδέσετε, χρησιμοποιήστε το CadHatch για να εργαστείτε με γωνίες και CadHatchPatternData για το μοτίβο.

**Παράδειγμα:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
