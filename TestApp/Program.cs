
using FileProcessor;
using FileProcessor.Archiver;
using FileProcessor.Archiver.Exceptions;
using FileProcessor.Renamer;

string path = @"C:\Users\Master\Desktop\cleaner test\icons";

string[] dirPatterns =
{
                ".vs",
                ".DS_Store",
                "Debug",
                "bin",
                "debug",
                "obj"
            };

string[] filePatterns =
{
    "*.exe",
    "*.jpg",
    "*.png",
};

Finder finder = new Finder(false);
finder.DirMasks = dirPatterns;
finder.FileMasks = filePatterns;

finder.FindFiles(path);

//finder.Container.Dirs.ForEach(dir =>
//{
//    Console.WriteLine(dir.FullName);
//});
Console.WriteLine("Finded list\n");
finder.ResultContainer.Files.ForEach(f =>
{
   Console.WriteLine(f.FullName);
});




//ArchiveEngine engine = new ArchiveEngine();

//try
//{
//    engine.CompressDirectory(@"C:\Users\silver\Desktop\cleaner_test");
//}
//catch (ArchiverException ex)
//{

//    Console.WriteLine(ex.Message);
//}


//List<FileInfo> files = new List<FileInfo>(dir.GetFiles());

Renamer renamer = new Renamer(finder.ResultContainer.Files, RenamerMask.UUID);
RenamerReport report = renamer.RenameByMask("img_");



Console.WriteLine();


//Renamer renamer = new Renamer(finder.ResultContainer.Files);
//renamer.UUIDMode();

Console.WriteLine("Renamed List\n");
renamer.Files?.ForEach(r =>
{
    Console.WriteLine(r.FullName);
});




