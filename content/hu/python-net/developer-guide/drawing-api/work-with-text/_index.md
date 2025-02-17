---
title: Munka szöveggel
type: docs
weight: 40
url: /hu/python-net/developer-guide/drawing-api/work-with-text/
---

## **Munka szöveggel**

Szinte minden rajz tartalmaz szövegobjektumokat, és ezek a példák bemutatják, hogyan végezhetünk műveleteket velük. 
Különböző típusú entitások léteznek a DWG/DXF formátumban, amelyek képesek szöveget tárolni, ezek a következők: **CadText**, **CadMText**, CadAttDef, CadAttrib. Az utolsó két típus jellemzően a **CadInsertObject**-hez kapcsolódik, és benne vagy a megfelelő blokkban tárolódik.

Íme néhány példa, amely a szöveggel végzett műveleteket írja le.

### **Szöveg keresése**

Ez a példa bemutatja, hogyan találhatók meg a szövegértékek a DWG/DXF fájlban, és ez a szövegek értékeinek helyettesítésére is alkalmazható.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
