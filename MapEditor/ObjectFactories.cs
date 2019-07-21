using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MapEditor
{
    public class Find
    {
        public class ENUM
        {
            public static String Tostring(int data)
            {
                for (MapDef m = MapDef.block; m < MapDef.volcanic_floor5; ++m)
                {
                    if (data == (int)m)
                    {
                        return m.ToString();
                    }
                }
                return null;
            }
        }
        public class Asset
        {
            int a;

            public static String DIR()
            {
                return Find.DIR() + @"\Asset";
            }
            public class Image
            {
                public static String DIR()
                {
                    return Asset.DIR() + @"\Image";
                }
            }
            public class Map
            {
                public static String DIR()
                {
                    return Asset.DIR() + @"\maps";
                }
                public static String DIR(String add)
                {
                    return Asset.Map.DIR() + @"\" + add;
                }
                public static String File(String name, String exten)
                {
                    return Asset.Map.DIR() + @"\" + name + exten;
                }
            }
        }
        public static String DIR()
        {
            String path = null;
            path = Application.StartupPath;
            path = System.IO.Directory.GetParent(path).ToString();
            path = System.IO.Directory.GetParent(path).ToString();
            return path;
        }
    }




    //타일 사이즈는 32 X 32
    public class dirInformation
    {
        DirectoryInfo info;
        public List<String> list;

        public dirInformation(string dir)
        {
            info = GetFolderInfo(dir);        
            list = new List<String>();
            Initialize_List();
        }

        public String List_str(int index)    //index위치의 파일의 이름을 문자열로 받아옴
        {
            return info.GetFileSystemInfos()[index].ToString();
        }

        private void Initialize_List()
        {
            for(int i = 0 ; i < info.GetFileSystemInfos().Length ;++i)
            {
                list.Add(List_str(i));
            }
        }
        

        public int List_size()        //리스트의 크기를 받아옴.
        {
            return info.GetFileSystemInfos().Length;
        }
        
        
        public DirectoryInfo GetFolderInfo(string dirpath)    //폴더위치를 받아와서 존재하면 DirectoryInfo를 리턴. 존재하지않으면 Null 리턴
        {
            if (System.IO.Directory.Exists(dirpath))
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(dirpath);
                return di;
            }

            return null;
        }

    }
    

    public class Tiles : Label
    {
        public Tiles()
        {
            
        }
        
        public Tiles(Image image)
        {
            this.Image = image;
        }
    }

    public class ObjectFactories
    {
        private string[] tile_types =
        {
            "bog", "dirt", "block", "cobble", "crystal", "floor_nerves", "floor_sand_stone", "floor_vines", "grey_dirt",
            "hive", "ice", "lair", "lava", "marble_floor", "mesh", "pebble_brown", "pedestal", "rect_gray", "rough_red",
            "sandstone_floor", "snake", "swamp", "tomb","volcanic_floor", "ETC"};

        private List<string> types;
        dirInformation dirinfo;
        ImageList imageList;
        Label selectPrint;
        public List<List<Image>> ListOfImage;

        public ObjectFactories(dirInformation _dirinfo,ImageList _imagelist ,Label monitor)
        {
            dirinfo = _dirinfo;
            imageList = _imagelist;
            selectPrint = monitor;
            initiallizeList();
        }

        private void initiallizeList()
        {
            types = new List<string>();
            for (int i = 0; i <tile_types.Length ; ++i)
            {
                types.Add(tile_types[i]);
            }
            
            ListOfImage = new List<List<Image>>();
            int x = 0, y = 0;
            for(;y < tile_types.Length;) 
            {
                ListOfImage.Add(new List<Image>());
                 for(;;)
                {
                    if (imageList.Images[x].ToString().Contains(tile_types[y]))
                    {
                        ListOfImage[y].Add(imageList.Images[x]);
                        x++;
                    }
                    else
                    {
                        y++;
                        break;
                    }
                }
                
            }
            
        }

        public Image Findimage(int type)
        {
            return null;
        }
        

        public Tiles TileFactory(int type)
        {
            Tiles tile = new Tiles();
            return tile;
        }

        public Label lableFactory(int index)
        {
            Label label = new Label();
            label.Text = dirinfo.List_str(index);
            label.BackColor = Color.White;
            label.AutoSize = true;
            label.Show();
            return label;
        }
        public void PrintButton(FlowLayoutPanel layout, MapInfo Map)
        {
            for(int y = 0; y < Map.Size.y; ++y)
            {
                for(int x = 0; x < Map.Size.x; ++x)
                {
                    layout.Controls.Add(BtnFactory(Map.data[y, x]));
                }
            }
        }
        public Button BtnFactory(int index)
        {
            Button btn = new Button();
            //btn.Text = dirinfo.List_str(index);
            //btn.Image = imageList.Images[index];
           
            btn.BackgroundImage = imageList.Images[index];
            btn.FlatStyle = FlatStyle.Flat;
            btn.TabStop = false;
            btn.AutoSize = false;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.FlatAppearance.BorderSize = 0;
            btn.Width = 64;
            btn.Height = 64;
            btn.Name = Find.ENUM.Tostring(index);
            btn.Margin = new Padding(0, 0, 0, 0);
            btn.Click += new EventHandler(btn_click);
            btn.Show();
            
            return btn;
        }
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Parent.Name == "Tile_Select_Pannel")//타일 선택창 내의 버튼이면
            {
                //Picked Type을 자신의 type으로 변경
                selectBtn(btn.Name);
            }
            else if(btn.Parent.Name == "Map_Edit_Pannel")//맵 출력창 내의 버튼이면
            {
                MessageBox.Show("selected");
                //자신의 type을 Picked Type으로 변경 
            }
        }
        void selectBtn(string name)
        {
            selectPrint.Text = name;
        }
        


        public Image GetImage(int type)
        {
            
            return null;

        }
    }


}