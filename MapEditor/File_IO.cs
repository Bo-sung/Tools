using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MapEditor
{
    public class FileIO
    {
        public static string[] FILE(string dir, string Name)//dir에 존재하는 name이라는 파일을 불러와 string[]으로 반환.
        {
            if (System.IO.Directory.Exists(dir))
            {
                string[] str = System.IO.Directory.GetFiles(@"..\..\Asset\maps\");
                if (true)
                {
                    string[] file = File.ReadAllLines(str[0]);
                    return file;
                }
            }
            else
            {
                return null;
            }

        }
        public class Load
        {
            public static int[,] Data(String dir, String FileName)
            {
                return FileIO.Data(dir, FileName);
            }
            public static int Type(String dir, String FileName)
            {
                string[] file = FILE(dir, FileName);
                return FileIO.Type(dir,FileName);
            }
        }
        public class Save
        {
            public static void Data(int[,]data, String dir, String Filename)
            {
                using (StreamWriter outputFile = new StreamWriter(Find.Asset.Map.File("reference",".txt"), true))
                {
                    outputFile.WriteLine("Fourth Line");
                }
            }
        }

        public static int Type(String dir, String FileName)
        {
            string[] file = FILE(dir, FileName);
            switch (file[1])
            {
                case "A":
                    {
                        return 1;
                    }
                    break;
                case "B":
                    {
                        return 2;
                    }
                    break;
                case "C":
                    {
                        return 3;
                    }
                    break;
                case "D":
                    {
                        return 4;
                    }
                    break;
            }
            return 0;
        }
        public static int[,] Data(String dir, String FileName)//dir 위치의 파일을 불러와 맵Data를 파싱하여 추출하는 코드.
        {
            int _x = 0;
            int _y = 0;
            int[,] data = null;
            string[] file = FILE(dir, FileName);
            file[0].ToCharArray();
            if (file[0] == "/thisfileisformap/")
            {
                switch (file[1])
                {
                    case "A":
                        {
                            _x = 8;
                            _y = 8;
                        }
                        break;
                    case "B":
                        {
                            _x = 8;
                            _y = 16;
                        }
                        break;
                    case "C":
                        {
                            _x = 16;
                            _y = 16;
                        }
                        break;
                    case "D":
                        {
                            _x = 32;
                            _y = 32;
                        }
                        break;
                }
                data = new int[_x, _y];
                for (int y = 0; y < _y; ++y)
                {
                    string[] strfile = file[y + 2].Split(new char[] { '\t' });
                    data[y, 0] = int.Parse(strfile[0].ToString());
                    for (int x = 1; x < strfile.Count(); ++x)
                    {
                        data[y,x] = int.Parse(strfile[x].ToString());
                    }
                }
            }
            return data;
        }

    }

}
