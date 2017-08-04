using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeNodeFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treenodeinsert();
        }

        private void treenodeinsert()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Arts & Photography");
            treeView1.Nodes[0].Nodes.Add("Architecture");
            treeView1.Nodes[0].Nodes.Add("Graphic Design");
            treeView1.Nodes[0].Nodes.Add("Music");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("Songbooks");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("Instruments & Performers");
            treeView1.Nodes[0].Nodes[2].Nodes[1].Nodes.Add("Brass");
            treeView1.Nodes[0].Nodes[2].Nodes[1].Nodes.Add("Woodwinds");


            treeView1.Nodes.Add("Comics & Graphic Novels");
            treeView1.Nodes[1].Nodes.Add("Comic Strips");
            treeView1.Nodes[1].Nodes.Add("Graphic Novels");
            treeView1.Nodes[1].Nodes.Add("Manga");
            

            treeView1.Nodes.Add("Mystery, Thriller and Suspense");
            treeView1.Nodes[2].Nodes.Add("Mystery");
            treeView1.Nodes[2].Nodes[0].Nodes.Add("Hard Boiled");
            treeView1.Nodes[2].Nodes[0].Nodes.Add("Police Procedurals");
            treeView1.Nodes[2].Nodes[0].Nodes[1].Nodes.Add("British Detectives");
            treeView1.Nodes[2].Nodes[0].Nodes[1].Nodes.Add("FBI Agents");
            treeView1.Nodes[2].Nodes[0].Nodes[1].Nodes.Add("Police Officers");

            treeView1.Nodes.Add("Nonfiction");
            treeView1.Nodes[3].Nodes.Add("Biographies and Memoirs");
            treeView1.Nodes[3].Nodes.Add("Business & Investing");
            treeView1.Nodes[3].Nodes.Add("Computers & Technology");
            treeView1.Nodes[3].Nodes[2].Nodes.Add("Databases");
            treeView1.Nodes[3].Nodes[2].Nodes.Add("Hardware");
            treeView1.Nodes[3].Nodes[2].Nodes.Add("Software");

        }
        

       
    }
}
