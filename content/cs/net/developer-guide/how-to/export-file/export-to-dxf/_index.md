---
title: Exportovat do DXF
type: docs
weight: 20
url: /cs/net/developer-guide/how-to/export-file/export-to-dxf/
---

## **Jak exportovat do DXF**

**Problém:** Jak exportovat do DXF.

**Tipy:** Pro provedení tohoto úkonu můžete použít možnosti ukládání souboru: DxfOption, jak binární, tak normální.

**Poznámka:** Jednou z zajímavých funkcí je schopnost ukládat libovolný podporovaný formát souboru do formátu DXF. Jedná se o skutečně užitečnou funkci, ale má několik nuancí:
Ukládání z formátů souborů DXF/DWG - provede export s přesnými prvky, které má zdrojový formát
Export z jiných formátů - provede export pouze s použitím linií a textových prvků.
Podporujeme také ASCII a binární formáty souborů DXF.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-dxf.cs" >}}
