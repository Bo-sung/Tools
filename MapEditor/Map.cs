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
    public enum MapDef
    {
        block,
        bog_green0,
        bog_green1,
        bog_green2,
        bog_green3,
        cobble_blood1,
        cobble_blood10,
        cobble_blood11,
        cobble_blood12,
        cobble_blood2,
        cobble_blood3,
        cobble_blood4,
        cobble_blood5,
        cobble_blood6,
        cobble_blood7,
        cobble_blood8,
        cobble_blood9,
        crystal_floor0,
        crystal_floor1,
        crystal_floor2,
        crystal_floor3,
        crystal_floor4,
        crystal_floor5,
        dirt0,
        dirt1,
        dirt2,
        dirt_e,
        dirt_full,
        dirt_n,
        dirt_ne,
        dirt_nw,
        dirt_s,
        dirt_se,
        dirt_sw,
        dirt_w,
        floor_nerves0,
        floor_nerves1,
        floor_nerves2,
        floor_nerves3,
        floor_nerves4,
        floor_nerves5,
        floor_nerves6,
        floor_sand_stone0,
        floor_sand_stone1,
        floor_sand_stone2,
        floor_sand_stone3,
        floor_sand_stone4,
        floor_sand_stone5,
        floor_sand_stone6,
        floor_sand_stone7,
        floor_vines0,
        floor_vines1,
        floor_vines2,
        floor_vines3,
        floor_vines4,
        floor_vines5,
        floor_vines6,
        grey_dirt0,
        grey_dirt1,
        grey_dirt2,
        grey_dirt3,
        grey_dirt4,
        grey_dirt5,
        grey_dirt6,
        grey_dirt7,
        hive0,
        hive1,
        hive2,
        hive3,
        ice0,
        ice1,
        ice2,
        ice3,
        lair0,
        lair1,
        lair2,
        lair3,
        lava0,
        lava1,
        lava2,
        lava3,
        marble_floor1,
        marble_floor2,
        marble_floor3,
        marble_floor4,
        marble_floor5,
        marble_floor6,
        mesh0,
        mesh1,
        mesh2,
        mesh3,
        pebble_brown0,
        pebble_brown1,
        pebble_brown2,
        pebble_brown3,
        pebble_brown4,
        pebble_brown5,
        pebble_brown6,
        pebble_brown7,
        pebble_brown8,
        pedestal_e,
        pedestal_full,
        pedestal_n,
        pedestal_ne,
        pedestal_nw,
        pedestal_s,
        pedestal_se,
        pedestal_sw,
        pedestal_w,
        rect_gray0,
        rect_gray1,
        rect_gray2,
        rect_gray3,
        rough_red0,
        rough_red1,
        rough_red2,
        rough_red3,
        sandstone_floor0,
        sandstone_floor1,
        sandstone_floor2,
        sandstone_floor3,
        sandstone_floor4,
        sandstone_floor5,
        sandstone_floor6,
        sandstone_floor7,
        sandstone_floor8,
        sandstone_floor9,
        snake0,
        snake1,
        snake2,
        snake3,
        swamp0,
        swamp1,
        swamp2,
        swamp3,
        tomb0,
        tomb1,
        tomb2,
        tomb3,
        tutorial_pad,
        volcanic_floor0,
        volcanic_floor1,
        volcanic_floor2,
        volcanic_floor3,
        volcanic_floor4,
        volcanic_floor5,
        VolcanicFloor6,
    }
    /*
    맵은 txt파일 형태로.2차원 배열로 저장. 각 타일은 170가지의 숫자로 이루어짐.
    맵은 규격 정하기.
    type A : 16 X 16
    type B : 32 X 16
    type C : 32 X 32
    type D : 64 X 64
    */
    //enum Maptype {A,B,C,D }
    public struct MapSize
    {
        public int x;
        public int y;
    }
    

    public class MapInfo
    {        
        private int type;
        public int[,] data;
        public int Get_Type()
        {
            return type;
        }
        MapSize size;

        public MapSize Size { get => size;}

        //private List<List<int>> Mapp;
        public MapInfo(string dirPath,String @FileName)
        {
            data = FileIO.Load.Data(dirPath,@FileName);//int[,]배열로 리턴하는 함수 
            type = FileIO.Load.Type(dirPath, @FileName);
            size = sizeInit(type);
        }
        private MapSize sizeInit(int _type)
        {
            MapSize size = new MapSize();
            switch (type)
            {
                case 1:
                    {
                        size.x = 8;
                        size.y = 8;
                    }
                    break;
                case 2:
                    {
                        size.x = 16;
                        size.y = 8;
                    }
                    break;
                case 3:
                    {
                        size.x = 16;
                        size.y = 16;
                    }
                    break;
                case 4:
                    {
                        size.x = 32;
                        size.y = 32;
                    }
                    break;
                case 5:
                    {
                        size.x = 1;
                        size.y = statics.countOfImage;
                    }break;

            }
            return size;
        }
        public MapInfo(int _type)
        {
            type = _type;
            size = sizeInit(type);
            data = new int[size.y, size.x];
            Mapinitiallize(data, 1);
        }
        public MapInfo(int _type, string command)
        {
            type = _type;
            size = sizeInit(type);
            data = new int[size.y, size.x];
            Map(command);
        }
        private int[,] Map()
        {
            for (int y = 0; y < Size.y; ++y)
            {
                for (int x = 0; x < Size.x; ++x)
                {
                    data[y, x] = 1;
                }
            }
            return data;
        }
        private int[,] Map(int d)
        {
            for (int y = 0; y < Size.y; ++y)
            {
                for (int x = 0; x < Size.x; ++x)
                {
                    data[y, x] = d;
                }
            }
            return data;
        }
        private int[,] Map(string command)
        {
            int count = 0;
            for (int y = 0; y < Size.y; ++y)
            {
                for (int x = 0; x < Size.x; ++x)
                {
                    if (command == "seqence")
                    {
                        if(count >= statics.countOfImage-1)
                        {
                            break;
                        }
                        data[y, x] = count;
                        count++;
                    }
                    else if (command == "random")
                    {
                        data[y, x] = new Random().Next(statics.countOfImage - 1);
                    }                    
                }
            }
            return data;
        }
        public void Mapinitiallize(int[,] _data, int d)
        {
            for (int y = 0; y < Size.y; ++y)
            {
                for (int x = 0; x < Size.x; ++x)
                {
                    _data[y,x] = d;
                }
            }
        }
        
    }
    public class Map : MapInfo
    {
        public Map(int _type) : base(_type)
        {
            Mapinitiallize(data, 0);
        }
        public void LoadMap(int[,] _data)
        {

        }
    }
    public class dummyMap : Map
    {
        public dummyMap(int _type) : base(_type)
        {
            Mapinitiallize(data, 1);

        }
    }



    public class findMap
    {
        public findMap()
        {
            
        }
        public int findMapp(string str)
        {
            //Type_Changer를 찾아서 목록 블러옴
            int a = 0;
            return a;
        }
        
        
    }
    
}