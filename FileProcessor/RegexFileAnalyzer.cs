using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileProcessor
{
    internal class RegexFileAnalyzer
    {
        private Dictionary<string, string> map;
        public RegexFileAnalyzer()
        {
            map = new Dictionary<string, string>()
            {
                {".", "\\." },
                {"^", "\\^" },
                {"}", "\\}" },
                {"{", "\\{" },
                {"[", "\\[" },
                {"]", "\\]" },
                {"(", "\\(" },
                {")", "\\)" },
                {"+", "\\+" },

                {"*", ".*"},
                {"?", "." }
            };
        }
        public List<FileInfo> AnalyzeFiles(FileInfo[] files, string[] fileMasks)
        {
            List<FileInfo> result = new List<FileInfo>();

            string pattern = PrepareFilePatterns(fileMasks);

            Regex regex = new Regex(pattern);

            foreach (FileInfo file in files)
            {
                if (regex.IsMatch(file.Name))
                    result.Add(file);
            }

            return result;
        }

        private string PrepareFilePatterns(string[] fileMasks)
        {
            List<string> patterns = new List<string>();

            foreach (string mask in fileMasks)
            {
                patterns.Add(ConvertMaskToPattern(mask));
            }

            return $"({String.Join("|", patterns)})";
        }

        private string ConvertMaskToPattern(string mask)
        {
            foreach (KeyValuePair<string, string> item in map)
                mask = mask.Replace(item.Key, item.Value);

            mask = $"^{mask}$";

            return mask;
        }
    }
}
