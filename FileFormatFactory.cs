using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class FileFormatFactory
    {
        public static IFileFormat getFileFormat(string requiredType)
        {
            IFileFormat fileFormat = null;

            switch (requiredType)
            {
                case "LargeFile":
                    fileFormat = new LargeFileFormat();
                break;
                case "SmallFile":
                    fileFormat = new SmallFileFormat();
                break;
                default:
                    fileFormat = new DefaultFileExtension();
                break;
            }
            return fileFormat;
        }
    }
}
