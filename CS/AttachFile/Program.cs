using DevExpress.Pdf;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AttachFile {
    class Program {
        static void Main(string[] args) {

            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                // Load a document.
                processor.LoadDocument("..\\..\\..\\Document.pdf");

                // Attach a file to the PDF document. 
                processor.AttachFile(new PdfFileAttachment() {
                    CreationDate = DateTime.Now,
                    Description = "This is my attach file.",
                    FileName = "MyAttach.txt",
                    Data = File.ReadAllBytes("..\\..\\..\\FileToAttach.txt"),
                    MimeType = "text/plain",
                    Relationship = PdfAssociatedFileRelationship.Supplement,
                });


                // The attached document.
                processor.SaveDocument("..\\..\\..\\Result.pdf");
            }
            Process.Start(new ProcessStartInfo("..\\..\\..\\Result.pdf") { UseShellExecute = true });
        }
    }
}