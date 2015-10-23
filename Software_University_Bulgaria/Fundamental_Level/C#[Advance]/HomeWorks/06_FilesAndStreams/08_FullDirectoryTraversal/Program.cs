using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _08.FullDirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedDirectory = Console.ReadLine();
            SortedDictionary<string,Dictionary<string,double>> extension = new SortedDictionary<string,Dictionary<string,double>>
            DirectoryInfo directorySelected = new DirectoryInfo(searchedDirectory);
            DirectoriesTraversal(directorySelected,extension);
            StreamWriter writer = new StreamWriter("../../extensions.txt");


            using(writer)
	        {
		        WritungOnFile(writer,extension);
	        }
            
        }

        private static void WritungOnFile(StreamWriter writer, SortedDictionary<string, Dictionary<string, double>> extension)
        {
            var orderedExtensions = extension // ordering the main dictionarie by the count inner dictionaries.
                .OrderByDescending(extension => extension.Value.Count)
                .ThenBy(extension => extension.Key);

            foreach (var extension in orderedExtensions)
            {
                writer.WriteLine(extension.Key); // writing the type of extension.
                var orderedDic = extension.Value.OrderBy(dic => dic.Value); // ordering the innerDictionaries by their value 

                foreach (var dic in orderedDic)
                {
                    writer.WriteLine("{0}{1:F2}kb", dic.Key, dic.Value / 1024); // writing the files name with the kilobytes.
                }
            }
        }


        private static void DirectoriesTraversal(DirectoryInfo directorySelected, SortedDictionary<string, Dictionary<string, double>> extension)
        {
            DirectoryInfo[] subDirectories = directorySelected.GetDirectories();
            int subDirectoriesUsed = subDirectories.Length;


            foreach (var file in directorySelected.GetFiles())
            {
                FileExtensionSorting(file,extension);

                while (subDirectoriesUsed > 0 )
                {
                    foreach (var subDirectory in directorySelected.GetDirectories())
                    {
                        DirectoriesTraversal(subDirectory,extension);
                        subDirectoriesUsed--;
                    }
                }
            }


        }

        private static void FileExtensionSorting(FileInfo file, SortedDictionary<string, Dictionary<string, double>> extension)
        {
            if (!extension.ContainsKey(file.Extension))
            {
                extensions.Add(file.Extension,
                       new Directory<string,double>
                       {
                           {string.Format("--{0} - ",file.Name),file.Length}
                       }
                    );
            }

            else
	            {
                    extensions[file.Extension].Add(
                            string.Format("-- {0} - ", file.Name), file.Length
                        );
	            }
       }
    }
}
