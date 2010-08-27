using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LQFBUI.API;
using System.Collections;
using LQFBUI.Data;
using System.Text.RegularExpressions;

namespace LQFBUI
{
    public partial class LQFBUI : Form
    {

        private LQFBAPI api;

        public LQFBUI(string[] args)
        {
            InitializeComponent();
            string profilename = "default";
            foreach (string arg in args)
            {
                if (arg.StartsWith("--profile=") || arg.StartsWith("-p="))
                {
                    profilename = arg.Replace("--profile=", "").Replace("-p=", "");
                    if (!(new Regex("^[a-z0-9-]*$").IsMatch(profilename)))
                    {
                        MessageBox.Show("Invalid profile name. Allowed: [a-z0-9-]");
                        Application.Exit();
                    }
                }
            }

            Storage.init(profilename);
            textAPIURL.Text = Storage.apiurl;
            textAPIKEY.Text = Storage.apikey;
           
            refreshTree();
        }

        private void LQFBUI_Shown(object sender, EventArgs e)
        {


        }

        private void iniTree_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Tag.GetType() == typeof(ExtTopic))
            {
            }
            else
            {
                e.CancelEdit = true;
            }
        }

        private void iniTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Tag.GetType() == typeof(ExtTopic))
            {
                ((ExtTopic)e.Node.Tag).name = e.Label;
            }
        }

        private void iniTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
            {
                displayNone();
            }
            else if (e.Node.Tag.GetType() == typeof(ExtArea) )
            {
                 displayArea((ExtArea)e.Node.Tag);
            }
            else if (e.Node.Tag.GetType() == typeof(ExtTopic) )
            {
                displayTopic((ExtTopic)e.Node.Tag);
            }
            else if (e.Node.Tag.GetType() == typeof(ExtInitiative) )
            {
                displayInitiative((ExtInitiative)e.Node.Tag);
            }
            else textInitiative.Text = "Unknown entry type " + e.Node.Tag.GetType().ToString();
        }

        private ExtArea currentArea = null;
        private ExtTopic currentTopic = null;
        private ExtInitiative currentInitiative = null;

        private void displayNone()
        {
            textInitiative.Text = "";
            setButtons(0);
            currentArea = null;
            currentTopic = null;
            currentInitiative = null;
        }

        private void displayArea(ExtArea area) {
            currentArea = area;
            currentTopic = null;
            currentInitiative = null;
            setButtons(1);

            textInitiative.Text = "";
        }
       
        private void displayTopic(ExtTopic topic) {
            currentArea = topic.parent;
            currentTopic = topic;
            currentInitiative = null;
            setButtons(2);

            textInitiative.Text = "";
        }

        private void displayInitiative(ExtInitiative ini) {
            currentTopic = ini.parent;
            currentArea = currentTopic.parent;
            currentInitiative = ini;
            setButtons(3);

            textInitiative.Text = ini.initiative.current_draft_content.Replace("\r\n", "\n").Replace("\n", "\r\n");
        }

        // 0: no buttons, 1: area, 2: topic, 3: initiative
        private void setButtons(int level) {
            toolAreaAutoreject.Enabled = level > 0;
            toolAreaIgnore.Enabled = level > 0;
            toolAreaInterest.Enabled = level > 0;
            toolAreaLabel.Enabled = level > 0;

            toolTopicAutoreject.Enabled = level > 1;
            toolTopicIgnore.Enabled = level > 1;
            toolTopicInterest.Enabled = level > 1;
            toolTopicLabel.Enabled = level > 1;
            toolTopicVotelater.Enabled = level > 1;

            toolIniLabel.Enabled = level > 2;
            toolIniPotential.Enabled = level > 2;
            toolIniRead.Enabled = level > 2;
            toolIniSupport.Enabled = level > 2;
            toolIniWatchChange.Enabled = level > 2;
            toolIniWatchIdea.Enabled = level > 2;


            toolAreaAutoreject.Checked = currentArea != null ? currentArea.autoreject.local : false;
            toolAreaIgnore.Checked = currentArea != null ? currentArea.ignored : false;
            toolAreaInterest.Checked = currentArea != null ? currentArea.member.local : false;

            toolTopicAutoreject.Checked = currentTopic != null ? currentTopic.autoreject.local : false;
            toolTopicIgnore.Checked = currentTopic != null ? currentTopic.ignored : false;
            toolTopicInterest.Checked = currentTopic != null ? currentTopic.member.local : false;
            toolTopicVotelater.Checked = currentTopic != null ? currentTopic.votelater.local : false;

            // TODO initiativenbuttons
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            api = new LQFBAPI(textAPIURL.Text, textAPIKEY.Text);
            api.update();
            foreach (Area area in api.getAreas())
            {
                ExtArea.get(area);
            }
            foreach (Initiative ini in api.getInitiatives())
            {
                ExtInitiative.get(ini);
            }


            refreshTree();
        }

        private void refreshTree()
        {
            iniTree.Nodes.Clear();
            foreach (ExtArea area in Storage.areas)
            {
                TreeNode areanode = new TreeNode(area.name.local);
                areanode.Tag = area;
                // areanode.NodeFont = new Font(...); // in abhängigkeit von parametern/änderungen brigen
                foreach (ExtTopic topic in area.topics)
                {
                    TreeNode topicnode = new TreeNode(topic.name);
                    topicnode.Tag = topic;
                    foreach (ExtInitiative ini in topic.initiatives)
                    {
                        TreeNode ininode = new TreeNode(ini.initiative.name);
                        ininode.Tag = ini;
                        topicnode.Nodes.Add(ininode);
                    }
                    areanode.Nodes.Add(topicnode);
                }
                iniTree.Nodes.Add(areanode);
            }
        }

        private void toolButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LQFB UI by Jan Schejbal, GPLv2 or later.\nIcons: Silk by Mark James, CC-BY.\nSee README.txt for more information.", "About");
        }

        private void textAPIURL_Validated(object sender, EventArgs e)
        {
            Storage.apiurl = textAPIURL.Text;
        }

        private void textAPIKEY_Validated(object sender, EventArgs e)
        {
            Storage.apikey = textAPIKEY.Text;
        }

        private void toolAreaInterest_Click(object sender, EventArgs e)
        {
            currentArea.member.local = !currentArea.member.local;
            toolAreaInterest.Checked = currentArea.member.local;
        }

        private void toolAreaAutoreject_Click(object sender, EventArgs e)
        {
            currentArea.autoreject.local = !currentArea.autoreject.local;
            toolAreaAutoreject.Checked = currentArea.autoreject.local;
        }

        private void toolAreaIgnore_Click(object sender, EventArgs e)
        {
            currentArea.ignored = !currentArea.ignored;
            toolAreaIgnore.Checked = currentArea.ignored;
        }

        private void toolTopicInterest_Click(object sender, EventArgs e)
        {
            currentTopic.member.local = !currentTopic.member.local;
            toolTopicInterest.Checked = currentTopic.member.local;
        }

        private void toolTopicAutoreject_Click(object sender, EventArgs e)
        {
            currentTopic.autoreject.local = !currentTopic.autoreject.local;
            toolTopicAutoreject.Checked = currentTopic.autoreject.local;
        }

        private void toolTopicVotelater_Click(object sender, EventArgs e)
        {
            currentTopic.votelater.local = !currentTopic.votelater.local;
            toolTopicVotelater.Checked = currentTopic.votelater.local;
        }

        private void toolTopicIgnore_Click(object sender, EventArgs e)
        {
            currentTopic.ignored = !currentTopic.ignored;
            toolTopicIgnore.Checked = currentTopic.ignored;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Storage.saveContent();
        }

        



        

    }
}
