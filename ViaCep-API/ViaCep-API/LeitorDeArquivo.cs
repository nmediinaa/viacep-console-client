using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace ViaCep_API;

public class LeitorDeArquivo
{
    public void ReadFile()
    {
        using (FileStream fs = new FileStream("SearchHistory.txt", FileMode.Open))
        {
            var buffer = new byte[1024];
            int readBytes = -1;

            while (readBytes != 0)
            {
                readBytes = fs.Read(buffer, 0, buffer.Length);
                GetString(buffer, readBytes);
            }
           
        }

        void GetString(Byte[] buffer, int bytesRead)
        {
            UTF8Encoding utf8 = new();
            string text = utf8.GetString(buffer,  0, bytesRead);
            Console.Write(text);
        }
    }
}