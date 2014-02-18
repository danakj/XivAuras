using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XivAuras {
    public enum Anchor {
        TopLeft,
        TopMiddle,
        TopRight,
        LeftMiddle,
        Center,
        RightMiddle,
        BottomLeft,
        BottomMiddle,
        BottomRight,
    }

    public class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Program program = new Program();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Overlay());
            Application.Run(new SetupForm());
        }
    }
}
