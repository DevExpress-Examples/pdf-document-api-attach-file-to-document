Imports DevExpress.Pdf
Imports System.IO

Namespace AttachFile

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Load a document.
                processor.LoadDocument("..\..\Document.pdf")
                ' Attach a file to the PDF document. 
                processor.AttachFile(New PdfFileAttachment() With {.CreationDate = Date.Now, .Description = "This is my attach file.", .FileName = "MyAttach.txt", .Data = File.ReadAllBytes("..\..\FileToAttach.txt")})
                ' The attached document.
                processor.SaveDocument("..\..\Result.pdf")
            End Using
        End Sub
    End Class
End Namespace
