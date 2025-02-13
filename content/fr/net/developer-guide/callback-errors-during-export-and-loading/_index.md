---
title: Erreurs de rappel lors de l'exportation et du chargement
type: docs
weight: 40
url: /fr/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Examen des erreurs de rappel lors de l'exportation et du chargement**

Il est possible que lors de l'exportation ou du chargement du dessin, nous rencontrions des erreurs liées à la structure du fichier 
(par exemple, certaines sections dans le fichier sont désormais requises mais ne l'étaient pas auparavant). 
Certaines d'entre elles sont critiques et dans de tels cas, l'exception est levée, mais nous pouvons également ignorer certaines d'entre elles en interne et en informer via des messages de rappel.
Quoi qu'il en soit, tous ces messages nécessitent une attention car ils peuvent expliquer, par exemple, les entités manquantes dans les résultats d'exportation ou d'autres effets.


### **Erreurs lors de l'exportation**

Il y a un champ RenderResult dans [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
qui inclut IsRenderComplete pour savoir s'il y a eu des erreurs lors de l'exportation et imprimer des informations à leur sujet :

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Erreurs lors du chargement**

Des problèmes avec les dessins peuvent être observés avant que le processus d'exportation ne commence. 
La propriété [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) dans
 l'objet [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) est utilisée pour stocker des messages à leur sujet.
La propriété [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) est utile pour décider s'il est nécessaire 
de lever une exception sur les erreurs de chargement ou non.

Voici un exemple d'utilisation de la propriété Errors :

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
