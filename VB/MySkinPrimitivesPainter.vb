Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Painters
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.ViewInfo

Namespace WindowsFormsApplication242
    Public Class MySkinPrimitivesPainter
        Inherits SkinPrimitivesPainter

        Public Sub New(ByVal ps As SkinBarManagerPaintStyle)
            MyBase.New(ps)
        End Sub
        Public Overrides Sub DrawLinkCheckInMenu(ByVal e As BarLinkPaintArgs, ByVal state As BarLinkState, ByVal backBrush As Brush, ByVal painter As BarLinkPainter)
            If Not(TypeOf e.LinkInfo Is MyBarCheckButtonLinkViewInfo) Then
                MyBase.DrawLinkCheckInMenu(e, state, backBrush, painter)
                Return
            End If
            Dim r As Rectangle = e.LinkInfo.Rects(BarLinkParts.Checkbox)
            r.Inflate(1, 1)
            Dim element As New SkinElementInfo(PaintStyle.Skin(BarSkins.SkinPopupMenuCheck), r)
            ObjectPainter.DrawObject(e.Cache, SkinElementPainter.Default, element)
            painter.DrawLinkNormalGlyph(e, False)
        End Sub
    End Class
End Namespace
