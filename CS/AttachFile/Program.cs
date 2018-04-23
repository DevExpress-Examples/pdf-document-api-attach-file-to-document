using DevExpress.Pdf;
using System;
using System.Text;

namespace AttachFile {
    class Program {
        static void Main(string[] args) {

            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                // Load a document.
                processor.LoadDocument("..\\..\\Document.pdf");               

                // Attach a txt. file to the PDF document. 
                processor.AttachFile(new PdfFileAttachment() {
                    CreationDate = DateTime.Now,
                    Description = "This is my attach file.",
                    MimeType = "text/plain",
                    FileName = "MyAttach.txt",
                    Data = GetData(),
                });

                // The attached document.
                processor.SaveDocument("..\\..\\Result.pdf");
            }
        }

        static byte[] GetData() {
            string s = "this is my text";
            byte[] data = Encoding.ASCII.GetBytes(s);
            return data;
        }
    }
}
