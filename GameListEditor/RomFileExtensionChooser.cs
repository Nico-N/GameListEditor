using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GameListEditor
{
    public partial class RomFileExtensionChooser : Form
    {

        public string SelectedExtensionList { get; set; }
        private bool ConfigFileSuccesfullyRead;

        private ListViewItem CreateListViewItem(string systemName, string romFileExtensions)
        {
            string[] tempListItem = new string[2];

            tempListItem[0] = systemName;
            tempListItem[1] = romFileExtensions;
            return new ListViewItem(tempListItem);
        }

        private ListViewItem CreateCheckedListViewItem(string systemName, string romFileExtensions)
        {
            ListViewItem tempItem = CreateListViewItem(systemName,romFileExtensions);
            tempItem.Checked = true;
            return tempItem;
        }

        private void FillExtensionListViewDefault()
        {

            warningLabel.Visible = true;
            extensionListView.Items.Clear();
            extensionListView.Items.Add(CreateCheckedListViewItem("Zip Files", "*.zip"));
            extensionListView.Items.Add(CreateListViewItem("3do", "*.iso"));
            extensionListView.Items.Add(CreateListViewItem("Adventure Game Studio", "*.exe"));
            extensionListView.Items.Add(CreateListViewItem("Amiga", "*.adf"));
            extensionListView.Items.Add(CreateListViewItem("Amstrad CPC", "*.dsk,*.cpc"));
            extensionListView.Items.Add(CreateListViewItem("Apple II", "*.dsk"));
            extensionListView.Items.Add(CreateListViewItem("Atari ST", "*.st,*.stx,*.img,*.rom,*.raw,*.ipf,*.ctr"));
            extensionListView.Items.Add(CreateListViewItem("Atari 2600", "*.bin,*.a26,*.rom"));
            extensionListView.Items.Add(CreateListViewItem("Atari 5200", "*.a52,*.bas,*.bin,*.xex,*.atr,*.xfd,*.dcm,*.gz"));
            extensionListView.Items.Add(CreateListViewItem("Atari 7800", "*.a78,*.bin"));
            extensionListView.Items.Add(CreateListViewItem("Atari Jaguar", "*.j64,*.jag"));
            extensionListView.Items.Add(CreateListViewItem("Atari Lynx", "*.lnx"));
            extensionListView.Items.Add(CreateListViewItem("Tandy Coco", "*.cas,*.wav,*.bas,*.asc,*.dmk,*.jvc,*.os9,*.dsk,*.vdk,*.rom,*.ccc,*.sna"));
            extensionListView.Items.Add(CreateListViewItem("Colecovision", "*.bin,*.col,*.rom"));
            extensionListView.Items.Add(CreateListViewItem("Commodore 64", "*.crt,*.d64,*.g64,*.t64,*.tap,*.x64"));
            extensionListView.Items.Add(CreateListViewItem("Daphne", "*.daphne"));
            extensionListView.Items.Add(CreateListViewItem("Dragon 32", "*.cas,*.wav,*.bas,*.asc,*.dmk,*.jvc,*.os9,*.dsk,*.vdk,*.rom,*.ccc,*.sna"));
            extensionListView.Items.Add(CreateListViewItem("Dreamcast", "*.cdi,*.gdi"));
            extensionListView.Items.Add(CreateListViewItem("FinalBurn Alpha", "*.zip"));
            extensionListView.Items.Add(CreateListViewItem("Game & Watch", "*.mgw"));
            extensionListView.Items.Add(CreateListViewItem("Game Gear", "*.gg"));
            extensionListView.Items.Add(CreateListViewItem("Game Boy", "*.gb"));
            extensionListView.Items.Add(CreateListViewItem("Game Boy Color", "*.gbc"));
            extensionListView.Items.Add(CreateListViewItem("Game Boy Advance", "*.gba"));
            extensionListView.Items.Add(CreateListViewItem("Intellivision", "*.int,*.bin"));
            extensionListView.Items.Add(CreateListViewItem("Macintosh", "*.img,*.rom"));
            extensionListView.Items.Add(CreateListViewItem("MAME", "*.zip"));
            extensionListView.Items.Add(CreateListViewItem("Master System", "*.sms"));
            extensionListView.Items.Add(CreateListViewItem("Genesis Megadrive", "*.smd,*.bin,*.md,*.iso"));
            extensionListView.Items.Add(CreateListViewItem("MESS", "*.zip"));
            extensionListView.Items.Add(CreateListViewItem("MSX", "*.rom,*.mx1,*.mx2,*.col,*.dsk"));
            extensionListView.Items.Add(CreateListViewItem("Nintendo 64", "z64,*.n64,*.v64"));
            extensionListView.Items.Add(CreateListViewItem("Nintendo DS", "*.nds,*.bin"));
            extensionListView.Items.Add(CreateListViewItem("Nintendo Entertainment System", "*.nes,*.smc,*.sfc,*.fig,*.swc,*.mgd"));
            extensionListView.Items.Add(CreateListViewItem("Neo Geo", "*.zip"));
            extensionListView.Items.Add(CreateListViewItem("Neo Geo Pocket", "*.ngp"));
            extensionListView.Items.Add(CreateListViewItem("Neo Geo Pocket Color", "*.ngpc"));
            extensionListView.Items.Add(CreateListViewItem("PC", "*.com,*.sh,*.bat,*.exe"));
            extensionListView.Items.Add(CreateListViewItem("PC Engine", "*.pce"));
            extensionListView.Items.Add(CreateListViewItem("PSP", "*.cso,*.iso,*.pbp"));
            extensionListView.Items.Add(CreateListViewItem("Playstation 1", "*.bin,*.cue,*.cbn,*.img,*.iso,*.m3u,*.mdf,*.pbp,*.toc,*.z,*.znx"));
            extensionListView.Items.Add(CreateListViewItem("Sam Coupe", "*.dsk,*.mgt,*.sbt,*.sad"));
            extensionListView.Items.Add(CreateListViewItem("Saturn", "*.bin,*.iso,*.mdf"));
            extensionListView.Items.Add(CreateListViewItem("ScummVM", "*.sh,*.svm"));
            extensionListView.Items.Add(CreateListViewItem("Sega 32X", "*.32x,*.smd,*.bin,*.md"));
            extensionListView.Items.Add(CreateListViewItem("Sega CD", "*.smd,*.bin,*.md,*.iso"));
            extensionListView.Items.Add(CreateListViewItem("Sega SG 1000", "*.sg"));
            extensionListView.Items.Add(CreateListViewItem("Super Nintendo Entertainment System", "*.smc,*.sfc,*.fig,*.swc"));
            extensionListView.Items.Add(CreateListViewItem("Vectrex", "*.vec,*.gam,*.bin"));
            extensionListView.Items.Add(CreateListViewItem("VideoPac Odyssey 2", "*.bin"));
            extensionListView.Items.Add(CreateListViewItem("Virtual Boy", "*.vb"));
            extensionListView.Items.Add(CreateListViewItem("WonderSwan", "*.ws"));
            extensionListView.Items.Add(CreateListViewItem("WonderSwan Color", "*.wsc"));
            extensionListView.Items.Add(CreateListViewItem("Zmachine", "*.dat,*.zip,*.z1,*.z2,*.z3,*.z4,*.z5,*.z6,*.z7,*.z8"));
            extensionListView.Items.Add(CreateListViewItem("ZX Spectrum", "*.sna,*.szx,*.z80,*.tap,*.tzx,*.gz,*.udi,*.mgt,*.img,*.trd,*.scl,*.dsk"));            

        }

        private static string GetNodeDataFromNode(XmlNode node, string nodePath)
        {
            string returnString = null;

            try
            {
                returnString = node.SelectSingleNode(nodePath).InnerText;
            }
            catch
            {
                returnString = null;
            }

            return returnString;
        }

        private static ListViewItem GetListViewItemFromNode(XmlNode node)
        {
            string[] tempListItem = new string[2];

            tempListItem[0] = GetNodeDataFromNode(node, "fullname");
            tempListItem[1] = Helper.GetExtensionList(GetNodeDataFromNode(node, "extension"));
            return new ListViewItem(tempListItem);
        }

        private void FillExtensionListViewByFile(string configFileName)
        {

            XmlDocument configFile = new XmlDocument();
            bool configFileLoaded;

            try
            {
                configFile.Load(configFileName);
                configFileLoaded = true;
            }
            catch
            {
                configFileLoaded = false;
            }

            if (configFileLoaded)
            {
                try
                {
                    extensionListView.Items.Add(CreateCheckedListViewItem("Zip Files", "*.zip"));
                    XmlNode resultListNode = configFile.SelectSingleNode("/systemList");                    
                    XmlNodeList resultNodeList = resultListNode.SelectNodes("system");
                    foreach (XmlNode node in resultNodeList)
                    {
                        ListViewItem temp = GetListViewItemFromNode(node);
                        extensionListView.Items.Add(temp);
                        Console.WriteLine(temp.ToString());                       
                    }
                    if (extensionListView.Items.Count > 1)
                    {
                        ConfigFileSuccesfullyRead = true;
                        warningLabel.Text = "Using system data from es_systems.cfg file.";
                        warningLabel.ForeColor = SystemColors.ControlText;
                    }
                    else
                        ConfigFileSuccesfullyRead = false;
                }
                catch (Exception exp)
                {
                    ConfigFileSuccesfullyRead = false;
                    MessageBox.Show(exp.ToString());
                } 
            }
        }

        public RomFileExtensionChooser()
        {
            InitializeComponent();            

            FillExtensionListViewByFile("es_systems.cfg");

            if(!ConfigFileSuccesfullyRead)
                FillExtensionListViewDefault();
                        

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection selectedExtensions = extensionListView.CheckedItems;

            string extensionList = "";

            foreach (ListViewItem item in selectedExtensions)
            {
                if (String.IsNullOrEmpty(extensionList))
                    extensionList = item.SubItems[1].Text;
                else
                    extensionList +=","+item.SubItems[1].Text;
            }

            SelectedExtensionList = Helper.GetExtensionList(extensionList);

            this.Hide();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in extensionListView.Items)
                itm.Checked = true;
        }

        private void selectNoneButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in extensionListView.Items)
                itm.Checked = false;
        }

        private void invertSelectionButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in extensionListView.Items)
                itm.Checked = !itm.Checked;
        }
    }
}
