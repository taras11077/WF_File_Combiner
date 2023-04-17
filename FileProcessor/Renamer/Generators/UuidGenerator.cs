
namespace FileProcessor.Renamer.Generators
{
    internal class UuidGenerator : IStringGenerator
    {
        public string GetNext()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
