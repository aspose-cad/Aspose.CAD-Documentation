---
title: Visszahívási hibák exportálás és betöltés során
type: docs
weight: 40
url: /hu/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Visszahívási hibák áttekintése exportálás és betöltés során**

Előfordulhat, hogy a rajz exportálása vagy betöltése során hibákkal találkozunk, amelyek kapcsolódnak a fájl szerkezetéhez 
(pl. a fájlban most szükséges szakaszok, amelyek korábban nem voltak). 
Ezek közül néhány kritikus, és ilyen esetekben kivétel keletkezik, de van olyan is, amelyeket belsőleg figyelmen kívül hagyhatunk, és értesíthetünk róluk visszahívási üzenetek segítségével.
Mindenesetre ezek a visszahívási üzenetek figyelmet igényelnek, mert például a hiányzó entitásokat az export eredményekben, vagy más hatásokat magyarázhatnak.

### **Hibák exportálás során**

Van egy RenderResult mező a [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) -ban,
amely tartalmazza az IsRenderComplete-t, hogy megtudjuk, voltak-e hibák az exportálás során, és azokról információt nyújt:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Hibák betöltés során**

A rajzokkal kapcsolatos problémák néha már az exportálási folyamat megkezdése előtt észlelhetők. 
A [**Hibák**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) tulajdonság a 
[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) objektumban tárolja azokról szóló üzeneteket.
A [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) tulajdonság hasznos annak eldöntésére, hogy 
szükséges-e kivételt dobni a betöltési hibák esetén, vagy sem.

Itt van egy példa a Hibák tulajdonság használatára:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
