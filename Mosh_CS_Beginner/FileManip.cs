using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// File provides static methods. Security checking on static methods. Not good for big apps
// FileInfo provides instance methods. No security checks.

namespace Mosh_CS_Beginner
{
    class FileManip
    {
        static void Main(string[] args)
        {

            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true); // copies from c to d. "true" overload indicates if file exists, allow overwrite
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path); // Returns string

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            // fileInfo does not have readAllText method. 

        }
    }
}
