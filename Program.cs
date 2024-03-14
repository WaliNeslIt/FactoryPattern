// See https://aka.ms/new-console-template for more information

using FactoryPattern;

   IFileFormat _fileFormat = FileFormatFactory.getFileFormat("dfkgjdfj");
   Console.WriteLine("Factory Produced : {0}",_fileFormat.getExtenstion());


Console.ReadLine();