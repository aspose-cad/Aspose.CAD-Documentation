---
title: Integration mit JasperServer
type: docs
weight: 20
url: /de/python-net/integration-with-jasperserver/
---
{{% alert color="primary" %}}
Um Aspose.CAD für Python mit JasperServer zu integrieren, müssen mehrere zusätzliche Schritte unternommen und die JasperServer-Konfigurationsdateien aktualisiert werden. Dieser Artikel erklärt, wie.
{{% /alert %}}
1. Fügen Sie neue Exporter-Eigenschaften zur Konfigurationsdatei %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml hinzu.
{{< highlight xml >}}
    <!--JPG-->
    <bean id="reportASJpegExporter" class="com.aspose.cad.pythons.jpg.ASReportJpegExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="jpgASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="JPG - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="jpgExportParams"/>
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="currentExporter" ref="reportASJpegExporter"/>
    </bean>

    <!--BMP-->
    <bean id="reportASBmpExporter" class="com.aspose.cad.pythons.bmp.ASReportBmpExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="bmpExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="bmpASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="BMP - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="bmpExportParams"/>
        <property name="exportParameters" ref="bmpExportParameters"/>
        <property name="currentExporter" ref="reportASBmpExporter"/>
    </bean>

    <!--GIF-->
    <bean id="reportASGifExporter" class="com.aspose.cad.pythons.gif.ASReportGifExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="gifExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="gifASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="GIF - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="gifExportParams"/>
        <property name="exportParameters" ref="gifExportParameters"/>
        <property name="currentExporter" ref="reportASGifExporter"/>
    </bean>

    <!--JPG2000-->
    <bean id="reportASJpg2000Exporter" class="com.aspose.cad.pythons.jpg2000.ASReportJpeg2000Exporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpg2000ExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="jpg2000ASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="JPG2000 - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="jpg2000ExportParams"/>
        <property name="exportParameters" ref="jpg2000ExportParameters"/>
        <property name="currentExporter" ref="reportASJpg2000Exporter"/>
    </bean>

    <!--PDF-->
    <bean id="reportASPdfExporter" class="com.aspose.cad.pythons.pdf.ASReportPdfExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="pdfASExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">Multipage</value>
        </property>
    </bean>

    <bean id="pdfASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PDF - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="pdfExportParams"/>
        <property name="exportParameters" ref="pdfASExportParameters"/>
        <property name="currentExporter" ref="reportASPdfExporter"/>
    </bean>

    <!--PNG-->
    <bean id="reportASPngExporter" class="com.aspose.cad.pythons.png.ASReportPngExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="pngExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="pngASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PNG - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="pngExportParams"/>
        <property name="exportParameters" ref="pngExportParameters"/>
        <property name="currentExporter" ref="reportASPngExporter"/>
    </bean>

    <!--PSD-->
    <bean id="reportASPsdExporter" class="com.aspose.cad.pythons.psd.ASReportPsdExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="psdExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">Batch</value>
        </property>
    </bean>

    <bean id="psdASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="PSD - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="psdExportParams"/>
        <property name="exportParameters" ref="psdExportParameters"/>
        <property name="currentExporter" ref="reportASPsdExporter"/>
    </bean>

    <!--SVG-->
    <bean id="reportASSvgExporter" class="com.aspose.cad.pythons.svg.ASReportSvgExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="svgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">SinglePage</value>
        </property>
    </bean>

    <bean id="svgASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="SVG - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="svgExportParams"/>
        <property name="exportParameters" ref="svgExportParameters"/>
        <property name="currentExporter" ref="reportASSvgExporter"/>
    </bean>

    <!--TIFF-->
    <bean id="reportASTiffExporter" class="com.aspose.cad.pythons.tiff.ASReportTiffExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="tiffExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">Multipage</value>
        </property>
    </bean>

    <bean id="tiffASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="TIFF - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="tiffExportParams"/>
        <property name="exportParameters" ref="tiffExportParameters"/>
        <property name="currentExporter" ref="reportASTiffExporter"/>
    </bean>

    <!--WMF-->
    <bean id="reportASWmfExporter" class="com.aspose.cad.pythons.wmf.ASReportWmfExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">SinglePage</value>
        </property>
    </bean>

    <bean id="wmfASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="WMF - Bildexport von Aspose.CAD"/>
        <property name="parameterDialogName" value="wmfExportParams"/>
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="currentExporter" ref="reportASWmfExporter"/>
    </bean>
{{< /highlight >}}

    Um den Modus des Exports zu ändern, verwenden Sie die Eigenschaft mit dem Namen "exportMode" und setzen Sie den Wert entsprechend dem gewünschten Modus. 
Zum Beispiel:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.pythons.common.ExportMode">SinglePage</value>
    </property>
{{< /highlight >}}
    Sie können den Wert der Eigenschaft auf Batch, SinglePage oder Multipage unter Verwendung des Enum-Typs com.aspose.cad.pythons.common.ExportMode ändern.

2. Suchen Sie das <util:map id="exporterConfigMap">...</util:map>-Element in der Datei %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml und fügen Sie die folgenden Zeilen hinzu:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- Kommentieren Sie eine der folgenden Zeilen aus, wenn Sie die zugehörigen Exporter
        	 aus der Liste der Viewer-Exporter ausschließen/einschließen möchten.
        	 Hinweis: separate Konfiguration für iPad 'exportersSupportedByiPad'
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
		
			<!-- fügen Sie diese Einträge zum exporterConfigMap hinzu -->
			<!-- Aspose.CAD Pythons START -->
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
		<!-- Aspose.CAD für Python ENDE -->
    </util:map>
{{< /highlight >}}
3. Kopieren Sie aspose-cad-pythons-xx.xx.jar nach %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\lib.
4. Um die Exportfunktionen zu nutzen, aktualisieren Sie %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml wie folgt.
{{< highlight xml >}}
    <bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="bmpExportParameters" class="com.aspose.cad.pythons.bmp.ASBmpExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="gifExportParameters" class="com.aspose.cad.pythons.gif.ASGifExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="jpg2000ExportParameters" class="com.aspose.cad.pythons.jpg2000.ASJpeg2000ExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="pdfASExportParameters" class="com.aspose.cad.pythons.pdf.ASPdfExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="pngExportParameters" class="com.aspose.cad.pythons.png.ASPngExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="psdExportParameters" class="com.aspose.cad.pythons.psd.ASPsdExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="svgExportParameters" class="com.aspose.cad.pythons.svg.ASSvgExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
    </bean>

	<bean id="tiffExportParameters" class="com.aspose.cad.pythons.tiff.ASTiffExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="wmfExportParameters" class="com.aspose.cad.pythons.wmf.ASWmfExportParametersBean">
	<!--        Kommentieren Sie aus und ändern Sie, um eine Lizenz anzuwenden. Überprüfen Sie den Lizenzpfad.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
    </bean>
{{< /highlight >}}

5. Starten Sie den Pythons-Server neu und öffnen Sie einen beliebigen Bericht zur Ansicht. Wenn die vorherigen Schritte ordnungsgemäß ausgeführt wurden, sehen Sie zusätzliche Optionen in der Liste der Exportformate.
![todo:image_alt_text](ExportReportView.png)

Wenn Sie keine zusätzlichen Formate (Symbole oder Optionen) sehen, überprüfen Sie bitte die Protokolldateien im Verzeichnis \apache-tomcat\logs.
