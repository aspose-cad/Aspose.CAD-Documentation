---
title: Прочетете, актуализирайте и запишете DWG файл
type: docs
weight: 11
url: /bg/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Как да прочетете, актуализирате и запишете DWG файл**

**Проблем:** Как да прочетете, актуализирате и запишете DWG файл.

**Съвети:** За да направите това, можете да вземете файла чрез метода за зареждане, да получите необходимите елементи и да направите промени в тях, като промените началните и крайни точки или дебелината на линиите.

**Забележка:** Този откъс от код показва пример за четене на dwg файл, промяна на обекти: позициите на линии, кръгове, текстови стойности (можете да добавите промени и към други обекти и техните стойности, за които се поддържа четене/писане) и после запазването в нов файл. Така можете да отворите нов файл в AutoCAD и да видите обекти с променени стойности

**Пример:** 

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
