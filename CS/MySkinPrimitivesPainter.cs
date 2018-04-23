using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Painters;
using DevExpress.XtraBars.Styles;
using DevExpress.XtraBars.ViewInfo;

namespace WindowsFormsApplication242 {
    public class MySkinPrimitivesPainter : SkinPrimitivesPainter {
        public MySkinPrimitivesPainter(SkinBarManagerPaintStyle ps)
            : base(ps) {
        }
        public override void DrawLinkCheckInMenu(BarLinkPaintArgs e, BarLinkState state, Brush backBrush, BarLinkPainter painter) {
            if(!(e.LinkInfo is MyBarCheckButtonLinkViewInfo)) {
                base.DrawLinkCheckInMenu(e, state, backBrush, painter);
                return;
            }
            Rectangle r = e.LinkInfo.Rects[BarLinkParts.Checkbox];
            r.Inflate(1, 1);
            SkinElementInfo element = new SkinElementInfo(PaintStyle.Skin[BarSkins.SkinPopupMenuCheck], r);
            ObjectPainter.DrawObject(e.Cache, SkinElementPainter.Default, element);
            painter.DrawLinkNormalGlyph(e, false);
        }
    }
}
