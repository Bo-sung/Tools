using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapEditor;

namespace MapEditor
{
    public partial class Form1 : Form
    {
        const int TILESIZE_X = 64;
        const int TILESIZE_Y = 64;

        dirInformation dirinfo;
        ObjectFactories objFactory;
        MapInfo NowMap;
        public Form1()
        {
           
            InitializeComponent();
            string dirPath = Find.Asset.Map.DIR();
            PathPrint.Text = null;
            if (System.IO.Directory.Exists(dirPath))
            {
                dirinfo = new dirInformation(dirPath);
                objFactory = new ObjectFactories(dirinfo,imageList1,Selected_Type_Print);
                PathPrint.Text = Find.Asset.Map.DIR();
            }
            NowMap = new MapInfo(dirPath,@"\reference.txt");
            //test_text_Print();
            Edit_Pannel_Print();
            Select_Pannel_Print();
            resize();
            Print();
            //Tile_Label_Print();
        }        

        private String Find_dirPath()
        {
            String path = null;
            path = Application.StartupPath;
            path = System.IO.Directory.GetParent(path).ToString();
            path = System.IO.Directory.GetParent(path).ToString();
            path += @"\Asset\Image";
            return path;
        }
        private void Print()
        {
            resize();
            //test_text_Print();
            Edit_Pannel_Print();
        }
        public void resize()
        {
            this.Map_Edit_Pannel.Width = NowMap.Size.x * TILESIZE_X;
            this.Map_Edit_Pannel.Height = NowMap.Size.y * TILESIZE_Y;
            this.Tile_Select_Pannel.Height = this.Tile_Select_Area.Height - 40;
            
        }

        List<List<Image>> GetListOfImage()
        {
            return objFactory.ListOfImage;
        }

        
        public void Select_Pannel_Print()
        {
            this.Tile_Select_Pannel.Controls.Clear();
            MapInfo map = new MapInfo(5,"seqence");
            objFactory.PrintButton(this.Tile_Select_Pannel, map);
            //for(int i = 0 ; i < dirinfo.List_size() ; ++i)
            //{
            //    Button btn = objFactory.BtnFactory(i);
            //    btn.Width = 48;
            //    btn.Height = 48;
            //    
            //    this.Tile_Select_Pannel.Controls.Add(btn);
            //    this.Tile_Select_Pannel.Controls.Add(objFactory.lableFactory(i));
            //}            
        }

        public void Tile_types_print(int index)
        {
            this.Tile_Select_Pannel.Controls.Clear();
            for(int i = 0 ; i <GetListOfImage()[index].Count ; ++i)
            {
                Button btn = objFactory.BtnFactory(i);
                btn.Width = 48;
                btn.Height = 48;
                
                this.Tile_Select_Pannel.Controls.Add(btn);
                this.Tile_Select_Pannel.Controls.Add(objFactory.lableFactory(i));
            }       
        }
        
        
        public void Tile_Label_Print()
        {
            for (int i = 0; i < dirinfo.List_size(); ++i)
            {
                
            }
        }
        public void Edit_Pannel_Print()
        {
            this.Map_Edit_Pannel.Controls.Clear();
            objFactory.PrintButton(this.Map_Edit_Pannel, NowMap);
        }


        private void Menu_Add_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Open_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Save_Click(object sender, EventArgs e)
        {

        }

        private void Menu_NewNameSave_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Type_Changer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbox = sender as ComboBox;
           // cbox.SelectedIndex;
        }

        private void Map_Edit_Pannel_SizeChanged(object sender, EventArgs e)
        {

        }

        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NowMap = new MapInfo(1);
            Print();
        }

        private void BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NowMap = new MapInfo(2);
            Print();
        }

        private void CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NowMap = new MapInfo(3);
            Print();
        }

        private void DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NowMap = new MapInfo(4);
            Print();
        }
    }
}
