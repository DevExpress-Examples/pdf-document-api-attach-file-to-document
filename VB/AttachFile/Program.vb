Imports DevExpress.Pdf
Imports System
Imports System.IO

Namespace AttachFile
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            Using processor As New PdfDocumentProcessor()
                ' Load a document.
                processor.LoadDocument("..\..\Document.pdf")

                ' Attach a file to the PDF document. 
                processor.AttachFile(New PdfFileAttachment() With { _
                    .CreationDate = Date.Now, _
                    .Description = "This is my attach file.", _
                    .FileName = "MyAttach.txt", _
                    .Data = File.ReadAllBytes("..\..\FileToAttach.txt") _
                })

                ' The attached document.
                processor.SaveDocument("..\..\Result.pdf")
            End Using
        End Sub
    End Class
End Namespace