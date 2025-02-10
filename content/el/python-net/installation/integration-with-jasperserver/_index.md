---
title: Ενοποίηση με το JasperServer
type: docs
weight: 20
url: /el/python-net/integration-with-jasperserver/
---
{{% alert color="primary" %}}
Για να ενοποιήσετε το Aspose.CAD για Python με το JasperServer, είναι απαραίτητο να ακολουθήσετε αρκετά επιπλέον βήματα και να ενημερώσετε τα αρχεία ρύθμισης παραμέτρων του JasperServer. Αυτό το άρθρο εξηγεί πώς.
{{% /alert %}}
1. Προσθέστε νέες ιδιότητες εξαγωγέα στο αρχείο ρύθμισης παραμέτρων %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml.
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
        <property name="descriptionKey" value="JPG - Εξαγωγή εικόνας από το Aspose.CAD"/>
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
        <property name="descriptionKey" value="BMP - Εξαγωγή εικόνας από το Aspose.CAD"/>
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
        <property name="descriptionKey" value="GIF - Εξαγωγή εικόνας από το Aspose.CAD"/>
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
        <property name="descriptionKey" value="JPG2000 - Εξαγωγή εικόνας από το Aspose.CAD"/>
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
        <property name="descriptionKey" value="PDF - Εξαγωγή εικόνας από το Aspose.CAD"/>
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
        <property name="descriptionKey" value="PNG - Εξαγωγή εικόνας από το Aspose.CAD"/>
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
        <property name="descriptionKey" value="PSD - Εξαγωγή εικόνας από το Aspose.CAD"/>
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
        <property name="descriptionKey" value="SVG - Εξαγωγή εικόνας από το Aspose.CAD"/>
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
        <property name="descriptionKey" value="TIFF - Εξαγωγή εικόνας από το Aspose.CAD"/>
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
        <property name="descriptionKey" value="WMF - Εξαγωγή εικόνας από το Aspose.CAD"/>
        <property name="parameterDialogName" value="wmfExportParams"/>
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="currentExporter" ref="reportASWmfExporter"/>
    </bean>
{{< /highlight >}}

    Για να αλλάξετε τη λειτουργία της εξαγωγής, χρησιμοποιήστε την ιδιότητα με το όνομα "exportMode" και βάλτε την τιμή σύμφωνα με τη επιθυμητή λειτουργία. 
Για παράδειγμα:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.pythons.common.ExportMode">SinglePage</value>
    </property>
{{< /highlight >}}
    Μπορείτε να αλλάξετε την τιμή της ιδιότητας σε Batch, SinglePage ή Multipage χρησιμοποιώντας τον τύπο enum com.aspose.cad.pythons.common.ExportMode.

2. Εντοπίστε το στοιχείο <util:map id="exporterConfigMap">...</util:map> στο αρχείο %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml και προσθέστε τις παρακάτω γραμμές:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- σχολιάστε/ξεσχολιάστε οποιαδήποτε από τις γραμμές παρακάτω αν θέλετε σχετικούς εξαγωγείς 
        	 να αποκλειστούν/συμπεριληφθούν στη λίστα εξαγωγέων του θεατή
        	 Σημείωση: ξεχωριστή ρύθμιση για iPad 'exportersSupportedByiPad'
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
		
			<!-- προσθέστε αυτές τις καταχωρήσεις στο exporterConfigMap -->
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
		<!-- Aspose.CAD for Python END -->
    </util:map>
{{< /highlight >}}
3. Αντιγράψτε το aspose-cad-pythons-xx.xx.jar στο %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\lib.
4. Για να χρησιμοποιήσετε τις δυνατότητες εξαγωγής, ενημερώστε το %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml όπως παρακάτω.
{{< highlight xml >}}
    <bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="bmpExportParameters" class="com.aspose.cad.pythons.bmp.ASBmpExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="gifExportParameters" class="com.aspose.cad.pythons.gif.ASGifExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="jpg2000ExportParameters" class="com.aspose.cad.pythons.jpg2000.ASJpeg2000ExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="pdfASExportParameters" class="com.aspose.cad.pythons.pdf.ASPdfExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="pngExportParameters" class="com.aspose.cad.pythons.png.ASPngExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="psdExportParameters" class="com.aspose.cad.pythons.psd.ASPsdExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="svgExportParameters" class="com.aspose.cad.pythons.svg.ASSvgExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
    </bean>

	<bean id="tiffExportParameters" class="com.aspose.cad.pythons.tiff.ASTiffExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="wmfExportParameters" class="com.aspose.cad.pythons.wmf.ASWmfExportParametersBean">
	<!--        Ξεσχολιάστε και τροποποιήστε για να εφαρμόσετε μια άδεια. Ελέγξτε τη διαδρομή άδειας.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
    </bean>
{{< /highlight >}}

5. Επανεκκινήστε τον Pythons Server και ανοίξτε οποιαδήποτε αναφορά για να δείτε. Εάν τα προηγούμενα βήματα πραγματοποιηθούν σωστά, θα δείτε επιπλέον επιλογές στη λίστα μορφών εξαγωγής.
![todo:image_alt_text](/_assets/ExportReportView.png)

Εάν δεν βλέπετε επιπλέον μορφές (εικόνες ή επιλογές), παρακαλώ ελέγξτε τα αρχεία καταγραφής στον κατάλογο \apache-tomcat\logs.
