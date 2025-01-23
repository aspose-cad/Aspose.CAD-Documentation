---
title: Erläuterung des Zwischenspeicherverhaltens von Aspose.CAD
type: docs
weight: 20
url: /de/common/caching-behaviour-explanation
---

## **Wie Aspose.CAD Daten zwischenspeichert**

Der gesamte Zwischenspeichervorgang von Aspose.CAD erfolgt vollautomatisch, ohne dass eine Benutzereingabe erforderlich oder möglich ist. Es gibt im Wesentlichen drei Arten von Zwischenspeicherungen, die alle mit Schriften zusammenhängen.

### **Zwischenspeicherung von Schriftartnamen**

Die Zwischenspeicherung von Schriftartnamen wird verwendet, um einen schnelleren Start zu ermöglichen, indem alle gefundenen Schriftdateien vorverarbeitet und eine Liste der in diesen Dateien vorhandenen Schriftartnamen kompiliert wird. Da eine Schriftdatei mehr als eine Schrift enthalten kann, wird sie als temporäre Datei gespeichert und ist für die meisten Systeme höchstens einige zehn Kilobyte groß.

### **Zwischenspeicherung von Schriftzeichendaten**

Ein im Arbeitsspeicher befindlicher Zwischenspeicher aller Zeichen, die während der Anwendungslebensdauer verwendet wurden, um das erneute Lesen der eigentlichen Dateien auf dem Datenträger während nachfolgender Exportvorgänge zu reduzieren. Dies führt zu einer stetigen Zunahme des Speicherverbrauchs, wenn nachfolgende Exportvorgänge Dateien enthalten, die auf neue Schriften verweisen und/oder Zeichen enthalten, die zuvor nicht aufgetreten sind. In der Praxis beträgt der Speicherverbrauch selbst bei Aspose.CAD-Testreihe mit Tausenden von Dateien, einschließlich Dateien in verschiedenen Sprachen, etwa 200 Megabyte, was für ein modernes System nicht sehr signifikant ist.

### **Zwischenspeicherung von Schriftfallrückgriff pro Zeichen**

Ein im Arbeitsspeicher befindlicher Zwischenspeicher, der Schriften speichert, die ein bestimmtes Zeichen enthalten, für alle Unicode-Zeichen, um das Auswählen einer Ersatzschrift zu erleichtern, falls eine von einem Textobjekt in einer Zeichnung bereitgestellte Schrift das Zeichen im Textinhalt dieses Objekts nicht enthält. Er wird beim ersten Exportvorgang während der Lebensdauer der Anwendung aufgebaut und bleibt bis zur Beendigung der Anwendung bestehen. Auf unseren relativ bescheidenen Testmaschinen mit umfangreichen Schriftsammlungen, die in den Testreihen verwendet werden, dauert der Aufbau des Zwischenspeichers etwa 30 Sekunden und belegt 70 Megabyte. Sobald er erstellt ist, benötigt er keine Zeit mehr und wächst nicht weiter.
