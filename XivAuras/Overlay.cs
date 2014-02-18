using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XivAuras {
    public partial class Overlay : Form {
        public Overlay() {
            InitializeComponent();

            Rectangle screen_bounds = Screen.PrimaryScreen.Bounds;
            this.Width = screen_bounds.Width;
            this.Height = screen_bounds.Height;
        }
    }

    
}
