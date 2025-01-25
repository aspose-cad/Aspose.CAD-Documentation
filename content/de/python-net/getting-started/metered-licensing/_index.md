---
title: Abgerechnete Lizenzierung
type: docs
weight: 40
url: /de/python-net/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD ermöglicht Entwicklern die Verwendung eines abgerechneten Schlüssels. Es handelt sich um einen neuen Lizenzierungsmechanismus. Der neue Lizenzierungsmechanismus wird zusammen mit der bestehenden Lizenzmethode verwendet. Kunden, die basierend auf der Nutzung der API-Funktionen abgerechnet werden möchten, können die abgerechnete Lizenzierung nutzen. Für weitere Einzelheiten siehe den Abschnitt [Häufige Fragen zur abgerechneten Lizenzierung](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Abgerechnete Lizenzierung**
Hier sind die einfachen Schritte zur Verwendung der Metered-Klasse.

1. Erstellen Sie eine Instanz der Metered-Klasse.
1. Übergeben Sie die öffentlichen und privaten Schlüssel an die SetMeteredKey-Methode.
1. Führen Sie die Verarbeitung durch (führen Sie die Aufgabe aus).
1. Rufen Sie die Methode GetConsumptionQuantity der Metered-Klasse auf.
1. Es wird die Anzahl der API-Anfragen zurückgegeben, die Sie bisher verbraucht haben.

Im Folgenden finden Sie den Beispielcode, der zeigt, wie Sie den abgerechneten öffentlichen und privaten Schlüssel festlegen.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
