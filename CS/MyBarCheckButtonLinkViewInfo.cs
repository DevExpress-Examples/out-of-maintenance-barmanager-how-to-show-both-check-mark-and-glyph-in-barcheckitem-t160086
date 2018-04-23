using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraBars;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraBars.Controls;

namespace WindowsFormsApplication242 {
    public class MyBarCheckButtonLinkViewInfo : BarCheckButtonLinkViewInfo {
        public MyBarCheckButtonLinkViewInfo(BarDrawParameters parameters, BarItemLink link)
            : base(parameters, link) {
        }

        protected override void CalcInMenuViewInfoCore(Graphics g, object sourceObject, Rectangle r) {
            base.CalcInMenuViewInfoCore(g, sourceObject, r);
            Image glyph = GetLinkImage(LinkState);

            SubMenuBarControl subMenu = ((SubMenuBarControl)sourceObject);

            //calculating glyph location
            Rectangle rr = Rects[BarLinkParts.Glyph];
            if(glyph != null) rr.Width = glyph.Width;
            rr.X = subMenu.Right - ((MySubMenuBarControlViewInfo)subMenu.ViewInfo).CustomBarCheckGlyphMaxWidth - DrawParameters.Constants.SubMenuGlyphHorzIndent + 1;
            //rr.X = r.Right - GlyphSize.Width - DrawParameters.Constants.SubMenuGlyphHorzIndent + 1;
            Rects[BarLinkParts.Glyph] = rr;
            
            //calculating check mark bounds
            Rects[BarLinkParts.Checkbox] = new Rectangle(r.X + 1, r.Y + (r.Height - GlyphSize.Height) / 2, GlyphSize.Height, GlyphSize.Height);

            //calculating caption location
            Rectangle captionRect = Rects[BarLinkParts.Glyph];
            Size sz = Rects[BarLinkParts.Caption].Size;

            captionRect.X = Rects[BarLinkParts.Caption].X;            
            captionRect.Width = sz.Width;
            Rects[BarLinkParts.Caption] = captionRect;
        }
    }

    public class MySubMenuBarControlViewInfo : SubMenuBarControlViewInfo {
        public int CustomBarCheckGlyphMaxWidth;
        public MySubMenuBarControlViewInfo(BarManager manager, BarDrawParameters parameters, CustomControl bar)
            : base(manager, parameters, bar) {
        }
        protected override void CalcMaxGlyphWidth() {
            int maxWidth = 0;
            int customBarCheckGlyphMaxWidth = 0;
            int startIndex = (IsAllowEmptyItemLink ? -1 : 0);
            for(int n = startIndex; n < BarControl.VisibleLinks.Count; n++) {
                BarItemLink link = (n == -1 ? BarControl.ControlLinks.EmptyLink : BarControl.VisibleLinks[n] as BarItemLink);
                BarLinkViewInfo linkViewInfo = CreateLinkViewInfo(link);
                linkViewInfo.UpdateLinkInfo(this);
                if (!(link is CustomBarCheckItemLink) || sizeCalculation)
                    maxWidth = Math.Max(maxWidth, linkViewInfo.GlyphSize.Width);
                customBarCheckGlyphMaxWidth = Math.Max(customBarCheckGlyphMaxWidth, linkViewInfo.GlyphSize.Width);
            }
            GlyphWidth = maxWidth;
            CustomBarCheckGlyphMaxWidth = customBarCheckGlyphMaxWidth;
        }
        bool sizeCalculation = false;
        public override Size CalcBarSize(Graphics g, object sourceObject, int width, int maxHeight) {
            this.sizeCalculation = true;
            try {
                return base.CalcBarSize(g, sourceObject, width, maxHeight);
            }
            finally {
                this.sizeCalculation = false;
            }
        }
        public override int CalcGlyphWidth(int glyphWidth) {
            return base.CalcGlyphWidth(glyphWidth);
        }
    }
}
