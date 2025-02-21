---  
title: COLLADA Tekeningen  
type: docs  
weight: 20  
url: /nl/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/  
---  
  
## **Exporteren van COLLADA-formaat naar PDF**  
  
Aspose.CAD voor Python stelt ontwikkelaars in staat om een [COLLADA](https://docs.fileformat.com/3d/dae/) bestand naar [PDF](https://docs.fileformat.com/pdf/) formaat te exporteren. De aanpak voor de conversie van [COLLADA](https://docs.fileformat.com/3d/dae/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:  
  
1. Laad het [COLLADA](https://docs.fileformat.com/3d/dae/) tekenbestand met behulp van de **Image.load** fabrieksmethode.  
1. Maak een object van de **CadRasterizationOptions** klasse en stel de eigenschappen **page_height** en **page_width** in.  
1. Maak een object van de **PdfOptions** klasse en stel de eigenschap **vector_rasterization_options** in.  
1. Roep **Image.save** aan en geef een object van **PdfOptions** door als de tweede parameter.  
  
## Voorbeeldcode  
  
{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
