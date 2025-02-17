---
title: JasperServer के साथ एकीकरण
type: docs
weight: 20
url: /hi/jasperreports/installation/integration-with-jasperserver/
---
{{% alert color="primary" %}}
JasperServer के साथ JasperReports के लिए Aspose.CAD को एकीकृत करने के लिए, कुछ अतिरिक्त कदम उठाना और JasperServer कॉन्फ़िगरेशन फ़ाइलों को अपडेट करना आवश्यक है। यह लेख बताता है कि कैसे।
{{% /alert %}}
1. %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml कॉन्फ़िगरेशन फ़ाइल में नए एक्स्पोर्टर गुण जोड़ें।
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
        <property name="descriptionKey" value="JPG - Aspose.CAD से छवि निर्यात"/>
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
        <property name="descriptionKey" value="BMP - Aspose.CAD से छवि निर्यात"/>
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
        <property name="descriptionKey" value="GIF - Aspose.CAD से छवि निर्यात"/>
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
        <property name="descriptionKey" value="JPG2000 - Aspose.CAD से छवि निर्यात"/>
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
        <property name="descriptionKey" value="PDF - Aspose.CAD से छवि निर्यात"/>
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
        <property name="descriptionKey" value="PNG - Aspose.CAD से छवि निर्यात"/>
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
        <property name="descriptionKey" value="PSD - Aspose.CAD से छवि निर्यात"/>
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
        <property name="descriptionKey" value="SVG - Aspose.CAD से छवि निर्यात"/>
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
        <property name="descriptionKey" value="TIFF - Aspose.CAD से छवि निर्यात"/>
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
        <property name="descriptionKey" value="WMF - Aspose.CAD से छवि निर्यात"/>
        <property name="parameterDialogName" value="wmfExportParams"/>
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="currentExporter" ref="reportASWmfExporter"/>
    </bean>
{{< /highlight >}}

    निर्यात के मोड को बदलने के लिए "exportMode" नाम के साथ गुण का उपयोग करें और इच्छित मोड के अनुसार मान डालें। 
उदाहरण के लिए:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.jasperreports.common.ExportMode">SinglePage</value>
    </property>
{{< /highlight >}}
    आप com.aspose.cad.jasperreports.common.ExportMode एनम प्रकार का उपयोग करके गुण का मान Batch, SinglePage या Multipage में बदल सकते हैं।

2. %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml फ़ाइल में <util:map id="exporterConfigMap">...</util:map> तत्व को ढूंढें और निम्नलिखित पंक्तियाँ जोड़ें:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- यदि आप संबंधित निर्यातकों को शामिल/बहिष्कृत करना चाहते हैं तो नीचे की किसी भी पंक्ति को टिप्पणी करें/अनटामेंट करें
        	 नोट: iPad के लिए अलग कॉन्फ़िगरेशन 'exportersSupportedByiPad' -->
        	 
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
		
			<!-- exporterConfigMap में ये प्रविष्टियाँ जोड़ें -->
			<!-- Aspose.CAD JasperReports प्रारंभ -->
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
		<!-- Aspose.CAD for JasperReports समाप्त -->
    </util:map>
{{< /highlight >}}
3. aspose-cad-jasperreports-xx.xx.jar को %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\lib में कॉपी करें।
4. निर्यात की विशेषताओं का उपयोग करने के लिए, %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml को नीचे की तरह अपडेट करें।
{{< highlight xml >}}
    <bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="bmpExportParameters" class="com.aspose.cad.jasperreports.bmp.ASBmpExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="gifExportParameters" class="com.aspose.cad.jasperreports.gif.ASGifExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="jpg2000ExportParameters" class="com.aspose.cad.jasperreports.jpg2000.ASJpeg2000ExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="pdfASExportParameters" class="com.aspose.cad.jasperreports.pdf.ASPdfExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="pngExportParameters" class="com.aspose.cad.jasperreports.png.ASPngExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="psdExportParameters" class="com.aspose.cad.jasperreports.psd.ASPsdExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="svgExportParameters" class="com.aspose.cad.jasperreports.svg.ASSvgExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
    </bean>

	<bean id="tiffExportParameters" class="com.aspose.cad.jasperreports.tiff.ASTiffExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
	</bean>

	<bean id="wmfExportParameters" class="com.aspose.cad.jasperreports.wmf.ASWmfExportParametersBean">
	<!--        लाइसेंस लागू करने के लिए अनकमेंट और संशोधित करें। लाइसेंस पथ की जांच करें।
	<property name="license" value="C:/Aspose.CAD.JasperReports.lic"/>
	-->
    </bean>
{{< /highlight >}}

5. JasperReports Server को पुनः चालू करें और कोई भी रिपोर्ट खोलें। यदि पिछले कदम सही ढंग से किए गए हैं, तो आप निर्यात प्रारूपों की सूची में अतिरिक्त विकल्प देखेंगे।
![todo:image_alt_text](/_assets/jasper/ExportReportView.png)

यदि आप अतिरिक्त प्रारूप (आइकन या विकल्प) नहीं देखते हैं, तो कृपया \apache-tomcat\logs निर्देशिका में लॉग फ़ाइलों की जांच करें।
