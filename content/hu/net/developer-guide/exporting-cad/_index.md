---
title: CAD exportálása
type: docs
weight: 40
url: /hu/net/developer-guide/exporting-cad/
---

## **3D AutoCAD képek exportálása PDF-be**

Az Aspose.CAD lehetővé teszi a 3D AutoCAD képek exportálását PDF formátumba. Kérjük, használja a [**Aspose.CAD.ImageOptions.CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) osztályt, hogy megadja, hogy 3D entitásokat szeretne exportálni.

Az alábbi példa kód betölt egy AutoCAD 3D fájlt, és PDF-be exportálja. Miután a fájlt PDF formátumba alakította, megnyithatja kedvenc PDF-olvasójával.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-Export3DImagestoPDF-Export3DImagestoPDF.cs" >}}

## **CAD elrendezések exportálása PDF-be**

Az Aspose.CAD a .NET-hez lehetővé teszi a CAD elrendezések PDF-be exportálását. A [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) módszert a [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) osztályból lehet használni az elrendezés(ek) PDF formátumba való exportálásához.

Az alábbi példa kód betölt egy CAD fájlt, és az "Model" elrendezését exportálja PDF-be. Miután a fájlt PDF formátumba alakította, megnyithatja kedvenc PDF-olvasójával.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-CADLayoutsToPDF-CADLayoutsToPDF.cs" >}}

## **Támogatás a toll beállításához az exportálás során**

Az Aspose.CAD a .NET-hez lehetővé teszi toll opciók hozzáadását a CAD exportálási tulajdonságaihoz. A [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) használatával beállíthatjuk a toll tulajdonságait.

Az alábbi kód egy példa a megadott követelmények megvalósítására.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-PenSupportInExport-PenSupportInExport.cs" >}}

## **CAD beszúró objektum dekompozíciója**

Az Aspose.CAD a .NET-hez lehetővé teszi a CAD objektumok dekompozícióját és a különálló entitások feldolgozását a beszúrás során. Az alábbi kód egy példa a megadott követelmények megvalósítására.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-DecomposeCADInsertObject-DecomposeCADInsertObject.cs" >}}

## **Támogatás az ACAD Proxy entitásokhoz**

Az Aspose.CAD a .NET-hez lehetővé teszi az ACAD_PROXY_ENTITY entitások olvasását és exportálását. Az alábbi kód egy példa a megadott követelmények megvalósítására.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ACADProxyEntities-ACADProxyEntities.cs" >}}

## **IGES formátum integrálása**

Az Aspose.CAD a .NET-hez lehetővé teszi az IGES formátum olvasását és exportálását. Az alábbi kód egy példa a megadott követelmények megvalósítására.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-IntegrateIGESFormat-IntegrateIGESFormat.cs" >}}

## **Támogatás a hálómodellekhez**

Az Aspose.CAD a .NET-hez lehetővé teszi hálómodellek létrehozását és számítását, például élek, csúcsok és felületek polygonális reprezentációval. Az alábbi kód egy példa a megadott követelmények megvalósítására.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-MeshSupport-MeshSupport.cs" >}}

## **Saját nézőpont beállítása**

Az Aspose.CAD a .NET-hez lehetővé teszi a saját nézőpont beállítását a Model elrendezéshez. A [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) használatával megadhat egy egyedi nézőpontot. Az alábbi kód példát mutat arra, hogyan lehet beállítani egy egyedi nézőpontot.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-FreePointOfView-FreePointOfView.cs" >}}
