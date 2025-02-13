---
title: Définir le délai d'attente lors de l'enregistrement
type: docs
weight: 70
url: /fr/net/developer-guide/set-timeout-on-save/
---

## **Définir le délai d'attente lors de l'enregistrement**

L'API Aspose.CAD pour .NET vous permet de définir un délai d'attente lors de l'enregistrement. Cela peut être utile dans les cas où le processus d'enregistrement prend beaucoup de temps ou consomme beaucoup de mémoire. Pour cela, l'API fournit la classe [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource). La classe [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) fournit un jeton qui est utilisé pour interrompre les opérations longues.

## Exemple de code

Le code suivant démontre l'utilisation de la classe [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
