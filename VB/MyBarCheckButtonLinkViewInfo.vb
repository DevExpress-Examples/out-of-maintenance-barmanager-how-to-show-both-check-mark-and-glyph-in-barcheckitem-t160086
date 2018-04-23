Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraBars.Controls

Namespace WindowsFormsApplication242
    Public Class MyBarCheckButtonLinkViewInfo
        Inherits BarCheckButtonLinkViewInfo

        Public Sub New(ByVal parameters As BarDrawParameters, ByVal link As BarItemLink)
            MyBase.New(parameters, link)
        End Sub

        Protected Overrides Sub CalcInMenuViewInfoCore(ByVal g As Graphics, ByVal sourceObject As Object, ByVal r As Rectangle)
            MyBase.CalcInMenuViewInfoCore(g, sourceObject, r)
            Dim glyph As Image = GetLinkImage(LinkState)

            Dim subMenu As SubMenuBarControl = (DirectCast(sourceObject, SubMenuBarControl))

            'calculating glyph location
            Dim rr As Rectangle = Rects(BarLinkParts.Glyph)
            If glyph IsNot Nothing Then
                rr.Width = glyph.Width
            End If
            rr.X = subMenu.Right - CType(subMenu.ViewInfo, MySubMenuBarControlViewInfo).CustomBarCheckGlyphMaxWidth - DrawParameters.Constants.SubMenuGlyphHorzIndent + 1
            'rr.X = r.Right - GlyphSize.Width - DrawParameters.Constants.SubMenuGlyphHorzIndent + 1;
            Rects(BarLinkParts.Glyph) = rr

            'calculating check mark bounds
            Rects(BarLinkParts.Checkbox) = New Rectangle(r.X + 1, r.Y + (r.Height - GlyphSize.Height) \ 2, GlyphSize.Height, GlyphSize.Height)

            'calculating caption location
            Dim captionRect As Rectangle = Rects(BarLinkParts.Glyph)
            Dim sz As Size = Rects(BarLinkParts.Caption).Size

            captionRect.X = Rects(BarLinkParts.Caption).X
            captionRect.Width = sz.Width
            Rects(BarLinkParts.Caption) = captionRect
        End Sub
    End Class

    Public Class MySubMenuBarControlViewInfo
        Inherits SubMenuBarControlViewInfo

        Public CustomBarCheckGlyphMaxWidth As Integer
        Public Sub New(ByVal manager As BarManager, ByVal parameters As BarDrawParameters, ByVal bar As CustomControl)
            MyBase.New(manager, parameters, bar)
        End Sub
        Protected Overrides Sub CalcMaxGlyphWidth()
            Dim maxWidth As Integer = 0

            Dim customBarCheckGlyphMaxWidth_Renamed As Integer = 0
            Dim startIndex As Integer = (If(IsAllowEmptyItemLink, -1, 0))
            For n As Integer = startIndex To BarControl.VisibleLinks.Count - 1
                Dim link As BarItemLink = (If(n = -1, BarControl.ControlLinks.EmptyLink, TryCast(BarControl.VisibleLinks(n), BarItemLink)))
                Dim linkViewInfo As BarLinkViewInfo = CreateLinkViewInfo(link)
                linkViewInfo.UpdateLinkInfo(Me)
                If Not(TypeOf link Is CustomBarCheckItemLink) OrElse sizeCalculation Then
                    maxWidth = Math.Max(maxWidth, linkViewInfo.GlyphSize.Width)
                End If
                customBarCheckGlyphMaxWidth_Renamed = Math.Max(customBarCheckGlyphMaxWidth_Renamed, linkViewInfo.GlyphSize.Width)
            Next n
            GlyphWidth = maxWidth
            CustomBarCheckGlyphMaxWidth = customBarCheckGlyphMaxWidth_Renamed
        End Sub
        Private sizeCalculation As Boolean = False
        Public Overrides Function CalcBarSize(ByVal g As Graphics, ByVal sourceObject As Object, ByVal width As Integer, ByVal maxHeight As Integer) As Size
            Me.sizeCalculation = True
            Try
                Return MyBase.CalcBarSize(g, sourceObject, width, maxHeight)
            Finally
                Me.sizeCalculation = False
            End Try
        End Function
        Public Overrides Function CalcGlyphWidth(ByVal glyphWidth As Integer) As Integer
            Return MyBase.CalcGlyphWidth(glyphWidth)
        End Function
    End Class
End Namespace
