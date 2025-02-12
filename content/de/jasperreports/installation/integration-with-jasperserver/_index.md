---
title: Integration mit JasperServer
type: docs
weight: 20
url: /de/jasperreports/integration-with-jasperserver/
---
{{% alert color="primary" %}}
Um Aspose.CAD für JasperReports mit JasperServer zu integrieren, müssen mehrere zusätzliche Schritte unternommen und die Konfigurationsdateien von JasperServer aktualisiert werden. Dieser Artikel erklärt, wie das gemacht wird.
{{% /alert %}}
1. Fügen Sie neue Exporter-Eigenschaften zur Datei %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml hinzu.
{{< highlight xml >}}
    <!--JPG-->
    <bean id="reportASJpegExporter" class="com.aspose.cad.jasperreports.jpg.ASReportJpegExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="jpgASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="JPG - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="jpgExportParams"/>
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="currentExporter" ref="reportASJpegExporter"/>
    </bean>

    <!--BMP-->
    <bean id="reportASBmpExporter" class="com.aspose.cad.jasperreports.bmp.ASReportBmpExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="bmpExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="bmpASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="BMP - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="bmpExportParams"/>
        <property name="exportParameters" ref="bmpExportParameters"/>
        <property name="currentExporter" ref="reportASBmpExporter"/>
    </bean>

    <!--GIF-->
    <bean id="reportASGifExporter" class="com.aspose.cad.jasperreports.gif.ASReportGifExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="gifExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="gifASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="GIF - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="gifExportParams"/>
        <property name="exportParameters" ref="gifExportParameters"/>
        <property name="currentExporter" ref="reportASGifExporter"/>
    </bean>

    <!--JPG2000-->
    <bean id="reportASJpg2000Exporter" class="com.aspose.cad.jasperreports.jpg2000.ASReportJpeg2000Exporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpg2000ExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="jpg2000ASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="JPG2000 - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="jpg2000ExportParams"/>
        <property name="exportParameters" ref="jpg2000ExportParameters"/>
        <property name="currentExporter" ref="reportASJpg2000Exporter"/>
    </bean>

    <!--PDF-->
    <bean id="reportASPdfExporter" class="com.aspose.cad.jasperreports.pdf.ASReportPdfExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="pdfASExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Multipage</value>
        </property>
    </bean>

    <bean id="pdfASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PDF - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="pdfExportParams"/>
        <property name="exportParameters" ref="pdfASExportParameters"/>
        <property name="currentExporter" ref="reportASPdfExporter"/>
    </bean>

    <!--PNG-->
    <bean id="reportASPngExporter" class="com.aspose.cad.jasperreports.png.ASReportPngExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="pngExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="pngASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PNG - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="pngExportParams"/>
        <property name="exportParameters" ref="pngExportParameters"/>
        <property name="currentExporter" ref="reportASPngExporter"/>
    </bean>

    <!--PSD-->
    <bean id="reportASPsdExporter" class="com.aspose.cad.jasperreports.psd.ASReportPsdExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="psdExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="psdASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PSD - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="psdExportParams"/>
        <property name="exportParameters" ref="psdExportParameters"/>
        <property name="currentExporter" ref="reportASPsdExporter"/>
    </bean>

    <!--SVG-->
    <bean id="reportASSvgExporter" class="com.aspose.cad.jasperreports.svg.ASReportSvgExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="svgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">SinglePage</value>
        </property>
    </bean>

    <bean id="svgASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="SVG - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="svgExportParams"/>
        <property name="exportParameters" ref="svgExportParameters"/>
        <property name="currentExporter" ref="reportASSvgExporter"/>
    </bean>

    <!--TIFF-->
    <bean id="reportASTiffExporter" class="com.aspose.cad.jasperreports.tiff.ASReportTiffExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="tiffExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Multipage</value>
        </property>
    </bean>

    <bean id="tiffASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="TIFF - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="tiffExportParams"/>
        <property name="exportParameters" ref="tiffExportParameters"/>
        <property name="currentExporter" ref="reportASTiffExporter"/>
    </bean>

    <!--WMF-->
    <bean id="reportASWmfExporter" class="com.aspose.cad.jasperreports.wmf.ASReportWmfExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">SinglePage</value>
        </property>
    </bean>

    <bean id="wmfASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="WMF - Bildexport aus Aspose.CAD"/>
        <property name="parameterDialogName" value="wmfExportParams"/>
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="currentExporter" ref="reportASWmfExporter"/>
    </bean>
{{< /highlight >}}

    Um den Exportmodus zu ändern, verwenden Sie die Eigenschaft mit dem Namen "exportMode" und setzen Sie den Wert entsprechend dem gewünschten Modus. 
Zum Beispiel:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.jasperreports.common.ExportMode">SinglePage</value>
    </property>
{{< /highlight >}}
    Sie können den Wert der Eigenschaft auf Batch, SinglePage oder Multipage ändern, indem Sie den Enumerationswert com.aspose.cad.jasperreports.common.ExportMode verwenden.

2. Suchen Sie das Element <util:map id="exporterConfigMap">... </util:map> in der Datei %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml und fügen Sie die folgenden Zeilen hinzu:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- Kommentieren Sie eine beliebige der unten stehenden Zeilen aus, wenn Sie möchten, dass die entsprechenden Exporter aus der Liste der Exporteure des Viewers ausgeschlossen/eingeschlossen werden
         Anmerkung: Separate Konfiguration für das iPad 'exportersSupportedByiPad'
         -->
             
        <entry key="pdf" value-ref="pdfExporterConfiguration"/>
        <entry key="xls" value-ref="xlsExporterConfiguration"/>
        <entry key="xlsNoPag" value-ref="xlsNoPaginationExporterConfiguration"/>
        <entry key="csv" value-ref="csvExporterConfiguration"/>
        <entry key="docx" value-ref="docxExporterConfiguration"/>
        <entry key="rtf" value-ref="rtfExporterConfiguration"/>
        <entry key="odt" value-ref="odtExporterConfiguration"/>
        <entry key="ods" value-ref="odsExporterConfiguration"/>
        <entry key="xlsx" value-ref="xlsxExporterConfiguration"/>
        <entry key="xlsxNoPag" value-ref="xlsxNoPaginationExporterConfiguration"/>
        <entry key="pptx" value-ref="pptxExporterConfiguration"/>
         <!--
         <entry key="txt" value-ref="txtExporterConfiguration"/>
         -->
         
         <!-- Fügen Sie diese Einträge zu exporterConfigMap hinzu -->
         <!-- Aspose.CAD JasperReports START -->
        <entry key="as_jpg" value-ref="jpgASExporterParameters"/>
        <entry key="as_bmp" value-ref="bmpASExporterParameters"/>
        <entry key="as_gif" value-ref="gifASExporterParameters"/>
        <entry key="as_jpg2000" value-ref="jpg2000ASExporterParameters"/>
        <entry key="as_pdf" value-ref="pdfASExporterParameters"/>
        <entry key="as_png" value-ref="pngASExporterParameters"/>
        <entry key="as_psd" value-ref="psdASExporterParameters"/>
        <entry key="as_svg" value-ref="svgASExporterParameters"/>
        <entry key="as_tiff" value-ref="tiffASExporterParameters"/>
        <entry key="as_wmf" value-ref="wmfASExporterParameters"/>
        <!-- Aspose.CAD für JasperReports END -->
    </util:map>
{{< /highlight >}}
3. Kopieren Sie aspose-cad-jasperreports-xx.xx.jar nach %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\lib.
4. Um Exportfunktionen zu nutzen, aktualisieren Sie %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml wie folgt.
{{< highlight xml >}}
    <bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>

    <bean id="bmpExportParameters" class="com.aspose.cad.jasperreports.bmp.ASBmpExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>

    <bean id="gifExportParameters" class="com.aspose.cad.jasperreports.gif.ASGifExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>

    <bean id="jpg2000ExportParameters" class="com.aspose.cad.jasperreports.jpg2000.ASJpeg2000ExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>

    <bean id="pdfASExportParameters" class="com.aspose.cad.jasperreports.pdf.ASPdfExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>

    <bean id="pngExportParameters" class="com.aspose.cad.jasperreports.png.ASPngExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>

    <bean id="psdExportParameters" class="com.aspose.cad.jasperreports.psd.ASPsdExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>

    <bean id="svgExportParameters" class="com.aspose.cad.jasperreports.svg.ASSvgExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>

    <bean id="tiffExportParameters" class="com.aspose.cad.jasperreports.tiff.ASTiffExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>

    <bean id="wmfExportParameters" class="com.aspose.cad.jasperreports.wmf.ASWmfExportParametersBean">
    <!--        Kommentieren Sie aus und passen Sie an, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
    <property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
    -->
    </bean>
{{< /highlight >}}

5. Starten Sie den JasperReports Server neu und öffnen Sie einen Bericht, um ihn anzuzeigen. Wenn die vorherigen Schritte ordnungsgemäß durchgeführt wurden, sehen Sie zusätzliche Auswahlmöglichkeiten in der Liste der Exportformate.
![todo:image_alt_text](/_assets/jasper/ExportReportView.png)

Wenn Sie keine zusätzlichen Formate (Symbole oder Auswahlmöglichkeiten) sehen, überprüfen Sie bitte die Protokolldateien im Verzeichnis \apache-tomcat\logs.