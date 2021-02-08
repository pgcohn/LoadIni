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

namespace LoadIni
{
    public partial class Form1 : Form
    {
        SortedDictionary<string, SortedDictionary<string, string>> confSections;
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.AliceBlue;
            label2.BackColor = Color.AliceBlue;
        }

        private void btnOpenIniFile_Click(object sender, EventArgs e)
        {
            if (openIniFileDialog.ShowDialog() == DialogResult.OK) 
            {
                bool btnOne = false;
                string strIniFileName = openIniFileDialog.FileName;
                if (sender == btnOpenIniFile1)
                {
                    btnOne = true;
                    txtIniFileName1.Text = strIniFileName;
                }
                else
                    txtIniFileName2.Text = strIniFileName;

                confSections = new SortedDictionary<string, SortedDictionary<string, string>>();
                SortedDictionary<string, string> section = new SortedDictionary<string,string>();

                using (StreamReader fileStream = new StreamReader(strIniFileName))
                {
                    string iniFileLine;
                    // Read and parse lines from the file until the end of
                    // the file is reached.
                    while ((iniFileLine = fileStream.ReadLine()) != null)
                    {
                        iniFileLine = iniFileLine.Trim();
                        // Ignore empty or comment lines
                        if (string.IsNullOrEmpty(iniFileLine) || iniFileLine.StartsWith(";") || iniFileLine.StartsWith("//"))
                            continue;

                        // SECTION Header
                        if(iniFileLine.StartsWith("["))
                        {
                            // Minimum syntax validation
                            if (iniFileLine.EndsWith("]"))
                            {
                                section = new SortedDictionary<string, string>();
                                confSections.Add(iniFileLine, section);
                            }
                            continue;
                        }

                        // Configuration entries - Key,Value pairs
                        string[] keyValue = iniFileLine.Split("=".ToCharArray());
                        // Minimum syntax validation
                        if (keyValue.Length >= 2)
                        {
                            string key = keyValue[0].Trim();
                            string val = "";
                            for (int j = 1; j < keyValue.Length; j++)
                                val += keyValue[j];
                            if (!section.Keys.Contains(key))
                                section.Add(key, val);
                            else
                            {
                                int dups = (from dupK in section.Keys where dupK.StartsWith(key)
                                            select dupK).Count();
                                string dupKey = string.Format("{0}({1})", key, dups);
                                section.Add(dupKey, val);
                            }
                            continue;
                        }

                        // Display unrecognized line
                        MessageBox.Show(string.Format("ERROR: {0}", iniFileLine));
                    }
                }

                // Build entries tree
                TreeView theTree = btnOne ? confTree1 : confTree2;

                theTree.Nodes.Clear();
                theTree.BeginUpdate();
                int i = 0;
                foreach(KeyValuePair<string,SortedDictionary<string,string>> sec in confSections)
                {
                    int j = 0;
                    theTree.Nodes.Add(sec.Key);
                    theTree.Nodes[i].BackColor = Color.Pink;
                    foreach (KeyValuePair<string,string> kvp in sec.Value)
                    {
                        theTree.Nodes[i].Nodes.Add(string.Format("{0} = {1}", kvp.Key, kvp.Value));
                        theTree.Nodes[i].Nodes[j].BackColor = Color.Pink;
                        theTree.Nodes[i].Nodes[j++].Tag = kvp;
                    }
                    i++;
                }

                Compare(confTree1.Nodes, confTree2.Nodes);

                theTree.EndUpdate();
            }
        }

        public bool Compare(TreeNodeCollection leftTree, TreeNodeCollection rightTree)
        {
            if (leftTree.Count == 0 || rightTree.Count == 0) return true;

            bool ret = true;

            TreeNode leftNode = leftTree[0];
            TreeNode rightNode = rightTree[0];

            while (leftNode != null && rightNode != null)
            {
                int txtCompare = string.Compare(leftNode.Text, rightNode.Text);

                switch (Math.Sign(txtCompare))
                {
                    case -1:
                        leftNode = leftNode.NextNode;
                        ret = false;
                        break;

                    case 1:
                        rightNode = rightNode.NextNode;
                        ret = false;
                        break;

                    case 0:
                        if(Compare(leftNode.Nodes, rightNode.Nodes))
                        {
                            leftNode.BackColor = Color.FromArgb(208, 255, 240);
                            rightNode.BackColor = Color.FromArgb(208, 255, 240);
                        }
                        leftNode = leftNode.NextNode;
                        rightNode = rightNode.NextNode;
                        break;
                }
            }

            return ret;
        }
    }
}
