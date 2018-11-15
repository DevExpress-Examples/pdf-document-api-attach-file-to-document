<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/AttachFile/Program.cs) (VB: [Program.vb](./VB/AttachFile/Program.vb))
<!-- default file list end -->
# How to attach a file to the document


This example shows how to programmatically attach a file to the PDF document.<br><br>The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br>


<h3>Description</h3>

To do this:<br>- Create a<strong>&nbsp;</strong><a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressPdfPdfFileAttachmenttopic">PdfFileAttachment</a> object;<br>- Specify an attachment creation date, description,&nbsp;and file name using&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfFileAttachment_CreationDatetopic">CreationDate</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfFileAttachment_Descriptiontopic">Description</a>,<strong>&nbsp;</strong>and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfFileAttachment_FileNametopic">FileName</a>&nbsp;&nbsp;properties. You also need to specify the data&nbsp;for the attachment using the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfFileAttachment_Datatopic">Data</a> property;<br><br>If required, you can specify additional properties of an attached file, for example, the file's mime type and relationship using <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfFileAttachment_MimeTypetopic">PdfFileAttachment.MimeType</a>, and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfFileAttachment_Relationshiptopic">PdfFileAttachment.Relationship </a>properties, correspondingly.<br><br>-&nbsp;Call the<strong>&nbsp;</strong>&nbsp;<a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_AttachFiletopic">PdfDocumentProcessor.AttachFile</a> method with a file attachment object used as a parameter.

<br/>


