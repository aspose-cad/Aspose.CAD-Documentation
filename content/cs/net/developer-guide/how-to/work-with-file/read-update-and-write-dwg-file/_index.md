---
title: Čtění, aktualizace a zápis souboru DWG
type: docs
weight: 11
url: /cs/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Jak číst, aktualizovat a zapisovat soubor DWG**

**Problém:** Jak číst, aktualizovat a zapisovat soubor DWG.

**Tipy:** K tomu můžete získat soubor pomocí metody načtení, získat potřebné entity a provést s nimi změny, jako je změna počátečních a koncových bodů nebo tloušťky čar.

**Poznámka:** Tento ukázkový kód ukazuje příklad čtení dwg souboru, změnu objektů: pozice čar, kruhů, textové hodnoty (můžete přidat změny i do dalších objektů a jejich hodnot, pro které je podporováno čtení/zápis) a následné uložení do nového souboru. Tak můžete otevřít nový soubor v AutoCADu a vidět objekty s změněnými hodnotami.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
