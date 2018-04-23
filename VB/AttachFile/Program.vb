Imports DevExpress.Pdf
Imports System
Imports System.Text

Namespace AttachFile
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            Using processor As New PdfDocumentProcessor()
                ' Load a document.
                processor.LoadDocument("..\..\Document.pdf")

                ' Attach a file to the PDF document. 
                processor.AttachFile(New PdfFileAttachment() With {.CreationDate = Date.Now, .Description = "This is my attach file.", .FileName = "MyAttach.txt", .Data = GetData()})

                ' The attached document.
                processor.SaveDocument("..\..\Result.pdf")
            End Using
        End Sub

        Private Shared Function GetData() As Byte()
            Dim s As String = "this is my text"
            Dim data() As Byte = Encoding.ASCII.GetBytes(s)
            Return data
        End Function
    End Class
End Namespace
