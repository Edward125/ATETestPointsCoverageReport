using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PlmBomToTxtBom;
using System.IO;

namespace ATETestPointsCoverageReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public enum NodeProperty
        {
            NO_STATUS,
            NO_PROBE,
            MANDATORY,
            NO_ACCESS,
            PREFERRED
           
        }

        public class Node
        {
            public string NodeName { set; get; }
            public List<string> ComponentPin { set; get; }
            public NodeProperty NodeProperty { set; get; }

            public bool  IsTestPoint()
            {
                if (NodeProperty == Form1.NodeProperty.MANDATORY || NodeProperty == Form1.NodeProperty.PREFERRED)
                    return true;
                else
                    return false;                    
            }
        }


        public List<Node> allNode = new List<Node>();

        private void btnOpenBoard_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.FileNames.Length >= 2)
                {
                    txtBoard.Text = open.FileNames[0];
                    txtBoardxy.Text = open.FileNames[1];
                }
                else
                    txtBoard.Text = open.FileName;
            }
        }






        public List<string> getNodelist(string boardfile)
        {

            bool _isstartnode = false;
            bool _isnode =false;
            List<Node> listnode = new List<Node>();

            List<string> nodelist = new List<string>();

            string line = string.Empty;
            StreamReader sr = new StreamReader(boardfile);
            while (!sr.EndOfStream )
            {
                line = sr.ReadLine();
                //MessageBox.Show(line);
                if (line.ToUpper().Trim() == "CONNECTIONS")
                    _isstartnode = true;
                if (line .ToUpper ().Trim ()=="DEVICES")
                    _isstartnode = false ;

                if (_isstartnode && !line.Contains (".") && !string.IsNullOrEmpty (line))
                {
                    if (line.EndsWith(";"))
                       line= line.Remove(line.Trim ().Length);
                    nodelist.Add(line);
                }



            }



            sr.Close();
            return nodelist;
        }


        public List<Node> getNodelist1(string boardfile)
        {

            bool _isstartnode = false;
            bool _isnode = false;
            List<Node> listnode = new List<Node>();

            List<string> nodelist = new List<string>();

            string line = string.Empty;
            StreamReader sr = new StreamReader(boardfile);
            Dictionary<int, Node> nee = new Dictionary<int, Node>();
            Node tempnode = new Node();
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                //MessageBox.Show(line);         

              

                if (_isstartnode )
                {
                    if (line.EndsWith(";"))
                        line = line.Remove(line.Trim().Length);

                    if (!string.IsNullOrEmpty(tempnode.NodeName) && !line.Contains("."))
                    {
                        listnode.Add(tempnode);
                        tempnode = new Node();
                    }

                    if (!string.IsNullOrEmpty(line))
                    {

                        if (!line.Contains("."))
                        {
                            tempnode = new Node();
                            tempnode.ComponentPin = new List<string>();
                            tempnode.NodeName = line;
                        }
                        else
                            tempnode.ComponentPin.Add(line.Trim());
                    }

                
                }

                if (line.ToUpper().Trim() == "CONNECTIONS")
                    _isstartnode = true;
                if ( line.ToUpper().Trim() == "DEVICES")
                    _isstartnode = false;
                if (line.ToUpper().Trim() == "NODES")
                    _isstartnode = false;
               


            }



            sr.Close();
            return listnode;
        }



        private void btnRun_Click(object sender, EventArgs e)
        {
          // List<string> nodelist = getNodelist(txtBoard.Text.Trim());
           // nodelist.Sort();

            allNode = getNodelist1(txtBoard.Text.Trim());

           // MessageBox.Show(allNode[1721].NodeName);


            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\11.txt", true);

            foreach (var item in allNode)
            {
                sw.WriteLine(item.NodeName);
            }

            sw.Close();

            MessageBox.Show("OK");
        }

    }
}
