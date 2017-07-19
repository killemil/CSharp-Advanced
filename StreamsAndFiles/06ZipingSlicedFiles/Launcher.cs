namespace _05SlicingFile
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class Launcher
    {
        private const string filePath = "../../File.txt";
        private const string destination = "../../Sliced/";

        public static void Main()
        {
            Console.Write("Enter Number of parts: ");
            int parts = int.Parse(Console.ReadLine());

            Slice(filePath, destination, parts);
            string[] files = Directory.GetFiles(destination, "*.gz");
            Assemble(files, destination);
        }

        private static void Assemble(string[] files, string destination)
        {
            foreach (var file in files)
            {
                using (FileStream reader = new FileStream(file, FileMode.Open))
                {
                    using (GZipStream decompress = new GZipStream(reader, CompressionMode.Decompress))
                    {
                        byte[] buffer = new byte[reader.Length];
                        using (FileStream writer = new FileStream(destination + "assembled.txt", FileMode.Append))
                        {
                            int readBytes = 0;
                            do
                            {
                                readBytes = decompress.Read(buffer, 0, buffer.Length);
                                writer.Write(buffer, 0, readBytes);

                            } while (readBytes > 0);
                        }
                    }
                }
            }
        }

        private static void Slice(string filePath, string destinationPath, int parts)
        {
            FileStream sourceFile = new FileStream(filePath, FileMode.Open);
            using (sourceFile)
            {
                var partSize = sourceFile.Length / (parts + (sourceFile.Length % parts));

                int part = 0;
                while (true)
                {
                    byte[] buffer = new byte[partSize];
                    int readBytes = sourceFile.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    using (FileStream writer = new FileStream(destination + $"Part-{part}.gz", FileMode.Create))
                    {
                        using (GZipStream compress = new GZipStream(writer, CompressionMode.Compress))
                        {
                            compress.Write(buffer, 0, buffer.Length);
                        }
                    }
                    part++;
                }
            }
        }
    }
}
