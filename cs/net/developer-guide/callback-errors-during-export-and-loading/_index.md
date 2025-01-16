---
title: Callback chyby při exportu a načítání
type: docs
weight: 40
url: /cs/callback-chyby-pri-exportu-a-nacitani/
---

## **Přehled callback chyb při exportu a načítání**

Je možné, že během exportu nebo načítání výkresu se můžeme setkat s chybami souvisejícími se strukturou souboru (např. sekce ve souboru jsou nyní požadovány, ale dříve nebyly). Některé z nich jsou kritické a v takových případech je vyvolána výjimka, ale některé z nich můžeme také interně ignorovat a upozornit na ně pomocí callback zpráv. Každopádně tyto zprávy vyžadují pozornost, protože mohou vysvětlit například chybějící entity v exportních výsledcích nebo jiné účinky.

### **Chyby během exportu**

Existuje pole RenderResult v [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/), které zahrnuje IsRenderComplete k zjištění, zda během exportu došlo k chybám, a k zobrazení informací o nich:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Chyby během načítání**

Některé potíže s výkresy mohou být pozorovány dříve, než exportní proces začne. Vlastnost [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) v objektu [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) slouží k ukládání zpráv o nich. Vlastnost [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) je užitečná pro rozhodnutí, zda je zapotřebí vyvolat výjimku při chybách při načítání, nebo ne.

Zde je příklad použití vlastnosti Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
