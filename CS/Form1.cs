using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Painters;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Styles;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;

namespace WindowsFormsApplication242 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(barManager1, this.PointToScreen(e.Location));
            }
        }
    }
}
