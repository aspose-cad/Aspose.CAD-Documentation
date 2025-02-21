---
title: Экспорт CAD
type: docs
weight: 40
url: /ru/net/developer-guide/exporting-cad/
---

## **Экспорт 3D Изображений AutoCAD в PDF**

Aspose.CAD позволяет экспортировать 3D изображения AutoCAD в PDF. Пожалуйста, используйте [**Aspose.CAD.ImageOptions.CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions), чтобы указать, что вы хотите экспортировать 3D объекты.

Следующий пример кода загружает 3D файл AutoCAD и экспортирует его в [PDF](https://docs.fileformat.com/pdf/). После того как файл будет преобразован в PDF, вы сможете открыть его с помощью вашего любимого PDF-ридера.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-Export3DImagestoPDF-Export3DImagestoPDF.cs" >}}

## **Экспорт CAD Макетов в PDF**

Aspose.CAD для .NET позволяет вам экспортировать CAD макеты в PDF. Метод [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) класса [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) может использоваться для экспорта макета(ов) в формате [PDF](https://docs.fileformat.com/pdf/).

Следующий пример кода загружает CAD файл и экспортирует его макет "Model" в PDF. После того как файл будет преобразован в PDF, вы сможете открыть его с помощью вашего любимого PDF-ридера.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-CADLayoutsToPDF-CADLayoutsToPDF.cs" >}}

## **Поддержка настройки пера в экспорте**

Aspose.CAD для .NET позволяет вам добавлять параметры пера в свойства экспорта CAD. Используя [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions), мы можем установить параметры свойств пера.

Ниже приведен пример кода для достижения указанных требований.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-PenSupportInExport-PenSupportInExport.cs" >}}

## **Декомпозиция CAD Объекта Вставки**

Aspose.CAD для .NET позволяет вам декомпозировать CAD объекты и обрабатывать отдельные сущности внутри вставки. Ниже приведен пример кода, чтобы достичь указанных требований.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-DecomposeCADInsertObject-DecomposeCADInsertObject.cs" >}}

## **Поддержка ACAD Proxy Сущностей**

Aspose.CAD для .NET позволяет вам читать и экспортировать сущности ACAD_PROXY_ENTITY. Ниже приведен пример кода для достижения указанных требований.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ACADProxyEntities-ACADProxyEntities.cs" >}}

## **Интеграция формата IGES**

Aspose.CAD для .NET позволяет вам читать и экспортировать формат IGES. Ниже приведен пример кода для достижения указанных требований.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-IntegrateIGESFormat-IntegrateIGESFormat.cs" >}}

## **Поддержка Сетчатых Моделей**

Aspose.CAD для .NET позволяет вам реализовывать и подсчитывать сетчатые модели, такие как грани, вершины и поверхности, которые используют полигональное представление. Ниже приведен пример кода для достижения указанных требований.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-MeshSupport-MeshSupport.cs" >}}

## **Установить Пользовательскую Точку Зрения**

Aspose.CAD для .NET позволяет вам установить пользовательскую точку зрения для макета модели. Используя [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions), вы можете установить пользовательскую точку зрения. Пример кода ниже показывает, как установить пользовательскую точку зрения.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-FreePointOfView-FreePointOfView.cs" >}}
