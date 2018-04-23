using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Styles;

namespace WindowsFormsApplication242 {
    [System.ComponentModel.DesignerCategory("")]
    public class CustomBarAndDockingController : BarAndDockingController {
        public CustomBarAndDockingController(IContainer container)
            : base(container) {
        }
        public CustomBarAndDockingController() {
        }
        protected override void RegisterPaintStyles() {
            base.RegisterPaintStyles();
            AddSkinPaintStyle();
        }
        void AddSkinPaintStyle() {
            PaintStyles.Add(new CustomSkinBarManagerPaintStyle(PaintStyles));
        }
    }
}
