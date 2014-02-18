using System.Windows.Forms;

namespace XivAuras {
    public class AuraTreeNode : TreeNode {
        public AuraTreeNode() {
            AuraName = "New aura";
            ActiveAlways = true;
            ShouldDisplayText = true;
            DisplayText = "Hello world";
            Font = new System.Drawing.Font("Sans", 12);
            Color = System.Drawing.Color.Black;
            Opacity = 1;
        }

        public string AuraName { get { return Text; } set { Text = value; } }

        public bool ActiveAlways { get; set; }

        // Text display.
        public bool ShouldDisplayText { get; set; }
        public string DisplayText { get; set; }
        public HorizontalAlignment DisplayTextAlignment { get; set; }
        public System.Drawing.Font Font { get; set; }
        public System.Drawing.Color Color { get; set; }
        public decimal Opacity { get; set; }
        
        // Visual positioning.
        public Anchor AuraAnchor { get; set; }
        public Anchor ScreenAnchor { get; set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }

    
        public void PopulateToForm(SetupForm form) {
        }

        public void CollectFromFrom(SetupForm form) {
        }
    }
}
