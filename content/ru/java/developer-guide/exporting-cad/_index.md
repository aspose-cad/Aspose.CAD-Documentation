---
title: Экспорт CAD
type: docs
weight: 40
url: /ru/java/developer-guide/exporting-cad/
---

## **Экспорт 3D изображений AutoCAD в PDF**
Aspose.CAD позволяет экспортировать 3D изображения AutoCAD в PDF. Пожалуйста, используйте **TypeOfEntities.Entities3D** в **ImageOptions.CadRasterizationOptions**, чтобы указать, что вы хотите экспортировать 3D сущности.
Следующий пример кода загружает 3D файл AutoCAD и экспортирует его в PDF. После преобразования файла в PDF, вы можете открыть его с помощью вашего любимого PDF-Viewera.

Пример кода ниже показывает, как экспортировать 3D изображения AutoCAD в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-Export3DAutoCADImagesToPDF-.java" >}}

## **Экспорт макетов CAD в PDF**
Aspose.CAD для Java позволяет экспортировать макеты CAD в PDF. Метод **save** класса **CadImage** можно использовать для экспорта макетов в формат PDF.
Следующий пример кода загружает файл CAD и экспортирует его "Model" макет в PDF. После преобразования файла в PDF, вы можете открыть его с помощью вашего любимого PDF-Viewera.

Вот пример кода.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportCADLayoutsToPDF-.java" >}}
## **Поддержка настройки пера в экспорте**
Aspose.CAD для Java позволяет добавлять параметры пера в свойства экспорта CAD. С помощью rasterizationOptions мы можем задать параметры свойств пера.

Ниже приведен пример кода для достижения указанных требований.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}
## **Декомпозиция объекта вставки CAD**
Aspose.CAD для Java позволяет декомпозировать объекты CAD и обрабатывать отдельные сущности внутри вставки. Ниже приведен пример кода для достижения указанных требований.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}
## **Поддержка прокси-сущностей ACAD**
Aspose.CAD для Java позволяет читать и экспортировать сущности ACAD_PROXY_ENTITY. Ниже приведен пример кода для достижения указанных требований.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}
## **Интеграция формата IGES**
Aspose.CAD для Java позволяет читать и экспортировать формат IGES. Ниже приведен пример кода для достижения указанных требований.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-IGESDrawings-ExportIGEStoPDF-ExportIGEStoPDF.java" >}}
## **Поддержка моделей сеток**
Aspose.CAD для Java позволяет реализовывать и подсчитывать модели сеток, такие как ребра, вершины и грани, которые используют полигональное представление. Ниже приведен пример кода для достижения указанных требований.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-MeshSupportForDWG-MeshSupportForDWG.java" >}}
## **Установка пользовательской точки зрения**
Aspose.CAD для Java позволяет установить пользовательскую точку зрения для макета модели. Используя **vectorRasterizationOptions**, вы можете установить пользовательскую точку зрения. Пример кода ниже показывает, как установить пользовательскую точку зрения.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-FreePointOfView-FreePointOfView.java" >}}
