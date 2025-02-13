---
title: Définir un délai d'attente lors de l'enregistrement
type: docs
weight: 70
url: /fr/java/developer-guide/set-timeout-on-save/
---

## **Définir un délai d'attente lors de l'enregistrement**

Aspose.CAD pour Java API vous permet de définir un délai d'attente lors de l'enregistrement. Cela peut être utile dans les cas où le processus d'enregistrement prend beaucoup de temps ou consomme beaucoup de mémoire. Pour cela, l'API fournit la classe [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource). La classe [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) fournit un jeton qui est utilisé pour interrompre les longues opérations.

## Exemple de code

Le code suivant montre l'utilisation de la classe [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
