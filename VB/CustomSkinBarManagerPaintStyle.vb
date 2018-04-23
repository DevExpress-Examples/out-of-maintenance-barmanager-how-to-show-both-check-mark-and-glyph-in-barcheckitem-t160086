Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Painters
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.Controls
Imports DevExpress.XtraBars.ViewInfo

Namespace WindowsFormsApplication242
    Public Class CustomSkinBarManagerPaintStyle
        Inherits SkinBarManagerPaintStyle

        Public Sub New(ByVal col As BarManagerPaintStyleCollection)
            MyBase.New(col)
        End Sub
        Protected Overrides Sub CreatePainters()
            MyBase.CreatePainters()
            Me.fPrimitivesPainter = New MySkinPrimitivesPainter(Me)
        End Sub
        Public Overrides ReadOnly Property Name() As String
            Get
                Return "Custom"
            End Get
        End Property
        Protected Overrides Sub RegisterItemInfo()
            MyBase.RegisterItemInfo()
            ItemInfoCollection.Add(New BarItemInfo("CustomBarCheckItem", "CustomCheck", 9, GetType(CustomBarCheckItem), GetType(CustomBarCheckItemLink), GetType(MyBarCheckButtonLinkViewInfo), New BarCheckButtonLinkPainter(Me), True, True))
        End Sub
        Protected Overrides Sub RegisterBarInfo()
            BarInfoCollection.Add(New BarControlInfo("BarDockControl", GetType(BarDockControl), GetType(DockControlOffice2003ViewInfo), New DockControlOffice2003Painter(Me)))
            BarInfoCollection.Add(New BarControlInfo("BarControl", GetType(CustomControl), GetType(BarControlViewInfo), New SkinBarPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("DockedBarControl", GetType(DockedBarControl), GetType(SkinDockedBarControlViewInfo), New SkinBarPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("SubMenuControl", GetType(SubMenuBarControl), GetType(MySubMenuBarControlViewInfo), New SkinBarSubMenuPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("PopupMenuControl", GetType(PopupMenuBarControl), GetType(PopupMenuBarControlViewInfo), New SkinBarSubMenuPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("PopupContainerControl", GetType(PopupContainerBarControl), GetType(PopupContainerControlViewInfo), New SkinPopupControlContainerBarPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("QuickCustomizationBarControl", GetType(QuickCustomizationBarControl), GetType(QuickCustomizationBarControlViewInfo), New SkinBarPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("FloatingBarControl", GetType(FloatingBarControl), GetType(SkinFloatingBarControlViewInfo), New SkinFloatingBarPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("TitleBarControl", GetType(DevExpress.XtraBars.Objects.TitleBarControl), GetType(DevExpress.XtraBars.Objects.TitleBarControlViewInfo), New SkinTitleBarPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("ControlForm", GetType(DevExpress.XtraBars.Forms.ControlForm), GetType(ControlFormViewInfo), New SkinControlFormPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("SubMenuControlForm", GetType(DevExpress.XtraBars.Forms.SubMenuControlForm), GetType(ControlFormViewInfo), New SkinControlFormPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("PopupContainerControlForm", GetType(DevExpress.XtraBars.Forms.PopupContainerForm), GetType(PopupContainerFormViewInfo), New SkinControlFormPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("FloatingBarControlForm", GetType(DevExpress.XtraBars.Forms.FloatingBarControlForm), GetType(SkinFloatingBarControlFormViewInfo), New SkinFloatingBarControlFormPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("GalleryDropDownBarControl", GetType(GalleryDropDownBarControl), GetType(GalleryDropDownControlViewInfo), New GalleyDropDownBarControlPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("AppMenuBarControl", GetType(AppMenuBarControl), GetType(AppMenuControlViewInfo), New BarSubMenuPainter(Me)))
            BarInfoCollection.Add(New BarControlInfo("AppMenuForm", GetType(DevExpress.XtraBars.Forms.AppMenuForm), GetType(AppMenuFormViewInfo), New SkinAppMenuFormPainter(Me)))
        End Sub
        Private Function FindBarInfo(ByVal itemType As Type) As Integer
            For i As Integer = 0 To BarInfoCollection.Count - 1
                If BarInfoCollection(i).ItemType Is itemType Then
                    Return i
                End If
            Next i
            Return -1
        End Function

    End Class
    Public Class CustomBarCheckItemLink
        Inherits BarCheckItemLink

        Public Sub New(ByVal ALinks As BarItemLinkReadOnlyCollection, ByVal AItem As BarItem, ByVal ALinkedObject As Object)
            MyBase.New(ALinks, AItem, ALinkedObject)
        End Sub
    End Class
    Public Class CustomBarCheckItem
        Inherits BarCheckItem

        Public Sub New()
            MyBase.New()

        End Sub
        Public Sub New(ByVal manager As BarManager)
            MyBase.New(manager)
        End Sub
        Public Sub New(ByVal manager As BarManager, ByVal check As Boolean)
            MyBase.New(manager, check)

        End Sub
    End Class

End Namespace
