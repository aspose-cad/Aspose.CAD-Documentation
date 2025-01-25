---
title: Abgerechnete Lizenzierung
type: docs
weight: 60
url: /de/net/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD ermöglicht es Entwicklern, einen abgerechneten Schlüssel anzuwenden. Es handelt sich um einen neuen Lizenzmechanismus. Der neue Lizenzmechanismus wird zusammen mit der bestehenden Lizenzmethode verwendet. Kunden, die basierend auf der Nutzung der API-Funktionen abgerechnet werden möchten, können die abgerechnete Lizenzierung nutzen. Für weitere Details verweisen wir auf den Abschnitt [Häufige Fragen zur abgerechneten Lizenzierung](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Abgerechnete Lizenzierung**
Hier sind die einfachen Schritte zur Verwendung der Metered-Klasse.

1. Erstellen Sie eine Instanz der Metered-Klasse.
1. Übergeben Sie die öffentlichen und privaten Schlüssel an die Methode SetMeteredKey.
1. Führen Sie die Verarbeitung durch (Aufgabe ausführen).
1. Rufen Sie die Methode GetConsumptionQuantity der Metered-Klasse auf.
1. Sie gibt die Anzahl der API-Anfragen zurück, die Sie bisher verbraucht haben.

Nachfolgend finden Sie den Beispielcode, der zeigt, wie man den abgerechneten öffentlichen und privaten Schlüssel festlegt.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
