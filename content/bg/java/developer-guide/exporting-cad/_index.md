---
title: Експортиране на CAD
type: docs
weight: 40
url: /bg/java/developer-guide/exporting-cad/
---

## **Експорт на 3D изображения от AutoCAD в PDF**
Aspose.CAD ви позволява да експортирате 3D изображения от AutoCAD в PDF. Моля, използвайте **TypeOfEntities.Entities3D** в **ImageOptions.CadRasterizationOptions**, за да посочите, че искате да експортирате 3D обекти. 
Следният примерен код зарежда 3D файл на AutoCAD и го експортира в PDF. След като файлът бъде конвертиран в PDF, можете да го отворите с любимия си PDF четец.

Примерният код по-долу показва как да експортирате 3D изображения от AutoCAD в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-Export3DAutoCADImagesToPDF-.java" >}}


## **Експортиране на CAD оформления в PDF**
Aspose.CAD за Java ви позволява да експортирате CAD оформления в PDF. Методът **save** на класа **CadImage** може да се използва за експортиране на оформление(я) в PDF формат. 
Следният примерен код зарежда CAD файл и експортира оформлението му "Model" в PDF. След като файлът бъде конвертиран в PDF, можете да го отворите с любимия си PDF четец.

Ето примерния код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportCADLayoutsToPDF-.java" >}}

## **Поддръжка за настройка на перо при експортиране**
Aspose.CAD за Java ви позволява да добавяте опции за перо в свойствата на експортиране на CAD. Чрез **rasterizationOptions** можем да зададем опции за свойства на перата.

Долу е примерен код, който постига зададените изисквания.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}

## **Декомпозиране на обект за вмъкване на CAD**
Aspose.CAD за Java ви позволява да декомпозиране на CAD обекти и да обработвате отделни единици вътре в вмъкването. Долу е примерен код, който постига зададените изисквания.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Поддръжка за ACAD Proxy Entities**
Aspose.CAD за Java ви позволява да четете и експортирате ACAD_PROXY_ENTITY единици. Долу е примерен код, който постига зададените изисквания.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}

## **Интегриране на IGES формат**
Aspose.CAD за Java ви позволява да четете и експортирате IGES формат. Долу е примерен код, който постига зададените изисквания.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-IGESDrawings-ExportIGEStoPDF-ExportIGEStoPDF.java" >}}

## **Поддръжка за мрежови модели**
Aspose.CAD за Java ви позволява да реализирате и броите мрежови модели, като ръбове, върхове и лица, които използват полигонално представяне. Долу е примерен код, който постига зададените изисквания.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-MeshSupportForDWG-MeshSupportForDWG.java" >}}

## **Задайте персонализирана точка на гледане**
Aspose.CAD за Java ви позволява да зададете персонализирана точка на гледане за оформлението на модела. Използвайки **vectorRasterizationOptions**, можете да зададете персонализирана точка на гледане. Примерният код по-долу показва как да зададете персонализирана точка на гледане.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-FreePointOfView-FreePointOfView.java" >}}
