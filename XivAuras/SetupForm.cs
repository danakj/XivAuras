using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XivAuras {
    public partial class SetupForm : Form {
        private List<AuraTreeNode> auras = new List<AuraTreeNode>();
        private bool insidePopulate = false;

        public SetupForm() {
            InitializeComponent();

            LoadAll();

            setupTreeView.ExpandAll();
        }

        private AuraTreeNode CurrentAura() {
            TreeNode n = setupTreeView.SelectedNode;
            if (n == null || n.GetType() != typeof(AuraTreeNode))
                return null;
            return (AuraTreeNode)n;
        }

        private void PopulateFromAura() {
            insidePopulate = true;

            AuraTreeNode n = CurrentAura();

            aboutNameTextBox.Text = n.AuraName;
            aboutActiveAlwaysCheckbox.Checked = n.ActiveAlways;

            displayTextCheckBox.Checked = n.ShouldDisplayText;
            displayTextBox.Text = n.DisplayText;
            displayTextAlignment.SelectedIndex = (int)n.DisplayTextAlignment;
            displayTextFontButton.Text = n.Font.FontFamily.Name + " " + n.Font.Size + " ...";
            displayTextFontDialog.Font = n.Font;
            displayColorDialog.Color = n.Color;
            displayOpacitySpinner.Value = n.Opacity;

            displayAnchor.SelectedIndex = (int)n.AuraAnchor;
            displayScreenAnchor.SelectedIndex = (int)n.ScreenAnchor;
            displayXOffsetSpinner.Value = n.XOffset;
            displayYOffsetSpinner.Value = n.YOffset;

            SetUpDerivedValues(n);
            insidePopulate = false;
        }

        private void CollectToAura() {
            if (insidePopulate) return;

            AuraTreeNode n = CurrentAura();

            n.AuraName = aboutNameTextBox.Text;
            n.ActiveAlways = aboutActiveAlwaysCheckbox.Checked;

            n.ShouldDisplayText = displayTextCheckBox.Enabled;
            n.DisplayTextAlignment = (HorizontalAlignment)displayTextAlignment.SelectedIndex;
            n.DisplayText = displayTextBox.Text;
            n.Font = displayTextFontDialog.Font;
            n.Color = displayColorDialog.Color;
            n.Opacity = displayOpacitySpinner.Value;
            n.AuraAnchor = (Anchor)displayAnchor.SelectedIndex;
            n.AuraAnchor = (Anchor)displayScreenAnchor.SelectedIndex;
            n.XOffset = (int)displayXOffsetSpinner.Value;
            n.YOffset = (int)displayYOffsetSpinner.Value;

            SetUpDerivedValues(n);
        }

        private void SetUpDerivedValues(AuraTreeNode n) {
            displayOpacitySpinner.Enabled = displayTextCheckBox.Enabled;
            displayTextBox.Enabled = displayTextCheckBox.Checked;
            displayTextAlignment.Enabled = displayTextCheckBox.Checked;
            displayTextFontButton.Enabled = displayTextCheckBox.Checked;
            displayTextFontButton.Font = new Font(n.Font.FontFamily.Name, displayTextFontButton.Font.Size, n.Font.Style);
            displayTextFontColorButton.BackColor = displayColorDialog.Color;
        }

        private void LoadAll() {
            //Properties.Settings.Default.
        }

        private void SaveAll() {
            foreach (AuraTreeNode a in auras) {
            }
        }

        private void setupTreeView_AfterSelect(object sender, TreeViewEventArgs e) {
            AuraTreeNode n = CurrentAura();
            if (n == null) {
                auraTabs.Visible = false;
                return;
            }
            auraTabs.Visible = true;
            PopulateFromAura();
        }

        private void newAuraButton_Click(object sender, EventArgs e) {
            setupTreeView.BeginUpdate();
            TreeNodeCollection nodes = setupTreeView.Nodes;
            TreeNode root = nodes[0];

            AuraTreeNode newNode = new AuraTreeNode();
            root.Nodes.Add(newNode);

            setupTreeView.ExpandAll();
            setupTreeView.EndUpdate();
        }

        private void applyButton_Click(object sender, EventArgs e) {
            SaveAll();
        }

        private void resetButton_Click(object sender, EventArgs e) {
            LoadAll();
            if (CurrentAura() != null)
                PopulateFromAura();
        }

        private void displayTextCheckBox_CheckedChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void displayTextAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void displayTextBox_TextChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void displayTextFontButton_Click(object sender, EventArgs e) {
            if (displayTextFontDialog.ShowDialog(this) != DialogResult.OK)
                return;
            CollectToAura();
        }

        private void displayTextFontColorButton_Click(object sender, EventArgs e) {
            if (displayColorDialog.ShowDialog(this) != DialogResult.OK)
                return;
            CollectToAura();
        }

        private void displayOpacitySpinner_ValueChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void aboutNameTextBox_TextChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void aboutActiveAlwaysCheckbox_CheckedChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void displayAnchor_SelectedIndexChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void displayScreenAnchor_SelectedIndexChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void displayXOffsetSpinner_ValueChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void displayYOffsetSpinner_ValueChanged(object sender, EventArgs e) {
            CollectToAura();
        }

        private void displayTextDescription_LinkClicked(object sender, LinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
