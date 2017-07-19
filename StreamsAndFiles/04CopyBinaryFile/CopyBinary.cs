
namespace _04CopyBinaryFile
{
    using System.IO;

    public class CopyBinary
    {
        public static void Main()
        {
            FileStream source = new FileStream("../../rabbit.gif", FileMode.Open);
            FileStream destination = new FileStream("../../result.gif", FileMode.Create);

            using (source)
            {
                using (destination)
                {
                    byte[] buffer = new byte[2048];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
