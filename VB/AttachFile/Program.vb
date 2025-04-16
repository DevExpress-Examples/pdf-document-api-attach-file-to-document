Imports System.IO
Imports DevExpress.Pdf

Namespace AttachFile

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Load a document.
                processor.LoadDocument("..\..\..\Document.pdf")
                ' Attach a file to the PDF document. 
                processor.AttachFile(New PdfFileAttachment() With {.CreationDate = Date.Now, .Description = "This is my attach file.", .FileName = "MyAttach.txt", .Data = File.ReadAllBytes("..\..\..\FileToAttach.txt"), .MimeType = "text/plain", .Relationship = PdfAssociatedFileRelationship.Supplement})
                ' The attached document.
                processor.SaveDocument("..\..\..\Result.pdf")
            End Using
            Process.Start(New ProcessStartInfo("..\..\..\Result.pdf") With {.UseShellExecute = True})
        End Sub
    End Class
End Namespace
