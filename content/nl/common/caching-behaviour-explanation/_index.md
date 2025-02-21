---
title: Uitleg van het cachinggedrag van Aspose.CAD
type: docs
weight: 20
url: /nl/common/caching-behaviour-explanation/
---


## **Hoe Aspose.CAD gegevens cached** 

Alle caching die door Aspose.CAD wordt uitgevoerd, is volledig automatisch, zonder dat enige invoer van de gebruiker nodig of mogelijk is. Er zijn in wezen drie soorten caching, die allemaal verband houden met lettertypen.

### **Lettertype naam cache** 

De lettertype naam cache wordt gebruikt om een snellere opstart te vergemakkelijken door alle gevonden lettertypebestanden voor te verwerken en een lijst met lettertypenamen samen te stellen die in deze bestanden aanwezig zijn, omdat één lettertypebestand meer dan één lettertype kan bevatten. Het wordt opgeslagen als een tijdelijk bestand en is voor de meeste systemen maximaal tientallen kilobytes groot.

### **Lettertype glyph gegevens cache** 

Een in-memory cache van alle glyphs die tijdens de levensduur van de applicatie zijn gebruikt om het opnieuw lezen van de daadwerkelijke lettertypebestanden op schijf tijdens latere exports te verminderen. Als zodanig zou dit resulteren in een gestaag toenemende geheugenconsumptie als latere exports bestanden zouden hebben die naar nieuwe lettertypen verwijzen en/of tekens bevatten die eerder niet zijn tegengekomen. In de praktijk is de geheugenconsumptie, zelfs in de hele 
test suite van Aspose.CAD, met duizenden bestanden, waaronder bestanden in verschillende talen, ongeveer 200 megabyte, wat niet erg significant is voor een modern systeem.

### **Per-teken lettertype fallback cache** 

Een in-memory cache die lettertypen opslaat die een gegeven teken bevatten voor alle Unicode-tekens om het opzetten van een vervangend lettertype te vergemakkelijken in het geval dat een lettertype dat door een tekstentiteit in een tekening wordt geleverd, een teken in de tekstinhoud van die entiteit niet bevat. Het wordt opgebouwd tijdens de eerste exportoperatie tijdens de levensduur van de applicatie en blijft bestaan totdat de applicatie wordt beëindigd. Op onze relatief bescheiden testmachines met enorme lettertypecollecties die in de test suites worden gebruikt, duurt het bouwen van de cache ongeveer 30 seconden en neemt het 70 megabyte in beslag. Eenmaal gebouwd, kost het geen tijd meer en groeit het niet.
