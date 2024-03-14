using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class LargeFileFormat : IFileFormat
    {
        public string getExtenstion()
        {
            return "LargeExcel.xlsx";
        }
    }
}
