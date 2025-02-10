---
title: الدمج مع JasperServer
type: docs
weight: 20
url: /ar/python-net/integration-with-jasperserver/
---
{{% alert color="primary" %}}
لدمج Aspose.CAD لـ Python مع JasperServer، من الضروري اتخاذ عدة خطوات إضافية وتحديث ملفات إعداد JasperServer. يوضح هذا المقال كيفية القيام بذلك.
{{% /alert %}}
1. أضف خصائص المصدر الجديدة إلى ملف الإعداد %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml.
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
        <property name="descriptionKey" value="JPG - تصدير الصورة من Aspose.CAD"/>
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
        <property name="descriptionKey" value="BMP - تصدير الصورة من Aspose.CAD"/>
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
        <property name="descriptionKey" value="GIF - تصدير الصورة من Aspose.CAD"/>
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
        <property name="descriptionKey" value="JPG2000 - تصدير الصورة من Aspose.CAD"/>
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
        <property name="descriptionKey" value="PDF - تصدير الصورة من Aspose.CAD"/>
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
        <property name="descriptionKey" value="PNG - تصدير الصورة من Aspose.CAD"/>
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
        <property name="descriptionKey" value="PSD - تصدير الصورة من Aspose.CAD"/>
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
        <property name="descriptionKey" value="SVG - تصدير الصورة من Aspose.CAD"/>
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
        <property name="descriptionKey" value="TIFF - تصدير الصورة من Aspose.CAD"/>
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
        <property name="descriptionKey" value="WMF - تصدير الصورة من Aspose.CAD"/>
        <property name="parameterDialogName" value="wmfExportParams"/>
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="currentExporter" ref="reportASWmfExporter"/>
    </bean>
{{< /highlight >}}

    لتغيير وضع التصدير، استخدم الخاصية المسماة "exportMode" وضع القيمة وفقًا للوضع المطلوب.
على سبيل المثال:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.pythons.common.ExportMode">SinglePage</value>
    </property>
{{< /highlight >}}
    يمكنك تغيير قيمة الخاصية إلى Batch أو SinglePage أو Multipage باستخدام نوع enum com.aspose.cad.pythons.common.ExportMode.

2. ابحث عن العنصر <util:map id="exporterConfigMap">...</util:map> في ملف %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml وأضف الأسطر التالية:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- قم بالتعليق/إلغاء التعليق على أي من الأسطر أدناه إذا كنت تريد استبعاد/إدراج المصدرين المعنيين في قائمة مصدرين المشاهد
        	 ملاحظة: إعداد منفصل لـ iPad 'exportersSupportedByiPad'
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
		
			<!-- أضف هذه الإدخالات إلى exporterConfigMap -->
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
		<!-- Aspose.CAD لـ Python END -->
    </util:map>
{{< /highlight >}}
3. انسخ aspose-cad-pythons-xx.xx.jar إلى %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\lib.
4. لاستخدام ميزات التصدير، قم بتحديث %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml كما يلي.
{{< highlight xml >}}
    <bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="bmpExportParameters" class="com.aspose.cad.pythons.bmp.ASBmpExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="gifExportParameters" class="com.aspose.cad.pythons.gif.ASGifExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="jpg2000ExportParameters" class="com.aspose.cad.pythons.jpg2000.ASJpeg2000ExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="pdfASExportParameters" class="com.aspose.cad.pythons.pdf.ASPdfExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="pngExportParameters" class="com.aspose.cad.pythons.png.ASPngExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="psdExportParameters" class="com.aspose.cad.pythons.psd.ASPsdExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="svgExportParameters" class="com.aspose.cad.pythons.svg.ASSvgExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
    </bean>

	<bean id="tiffExportParameters" class="com.aspose.cad.pythons.tiff.ASTiffExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
	</bean>

	<bean id="wmfExportParameters" class="com.aspose.cad.pythons.wmf.ASWmfExportParametersBean">
	<!--        قم بفك تعليق وتعديل لتطبيق ترخيص. تحقق من مسار الترخيص.
	<property name="license" value="C:/Aspose.CAD.Pythons.lic"/>
	-->
    </bean>
{{< /highlight >}}

5. أعد تشغيل خادم Pythons وافتح أي تقرير لعرضه. إذا تم تنفيذ الخطوات السابقة بشكل صحيح، سترى خيارات إضافية في قائمة تنسيقات التصدير.
![todo:image_alt_text](/_assets/ExportReportView.png)

إذا لم تر خيارات إضافية (رموز أو خيارات)، يرجى التحقق من ملفات السجل في مجلد \apache-tomcat\logs.