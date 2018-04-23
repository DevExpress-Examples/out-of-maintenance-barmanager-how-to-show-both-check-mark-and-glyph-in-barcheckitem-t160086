Namespace WindowsFormsApplication242
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.barSubItem2 = New DevExpress.XtraBars.BarSubItem()
            Me.customBarCheckItem5 = New WindowsFormsApplication242.CustomBarCheckItem()
            Me.customBarCheckItem4 = New WindowsFormsApplication242.CustomBarCheckItem()
            Me.barCheckItem24 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem25 = New DevExpress.XtraBars.BarCheckItem()
            Me.skinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
            Me.barSubItem4 = New DevExpress.XtraBars.BarSubItem()
            Me.customBarCheckItem6 = New WindowsFormsApplication242.CustomBarCheckItem()
            Me.customBarCheckItem7 = New WindowsFormsApplication242.CustomBarCheckItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.customBarAndDockingController1 = New WindowsFormsApplication242.CustomBarAndDockingController(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.barCheckItem4 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem3 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem5 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem6 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem7 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem8 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem9 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem10 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem11 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem12 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem13 = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barCheckItem14 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem15 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem16 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem17 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem18 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem19 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem20 = New DevExpress.XtraBars.BarCheckItem()
            Me.customBarCheckItem1 = New WindowsFormsApplication242.CustomBarCheckItem()
            Me.barCheckItem21 = New DevExpress.XtraBars.BarCheckItem()
            Me.barSubItem3 = New DevExpress.XtraBars.BarSubItem()
            Me.customBarCheckItem2 = New WindowsFormsApplication242.CustomBarCheckItem()
            Me.customBarCheckItem3 = New WindowsFormsApplication242.CustomBarCheckItem()
            Me.barCheckItem22 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem23 = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barSubItem5 = New DevExpress.XtraBars.BarSubItem()
            Me.customBarCheckItem8 = New WindowsFormsApplication242.CustomBarCheckItem()
            Me.customBarCheckItem9 = New WindowsFormsApplication242.CustomBarCheckItem()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.customBarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 489)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Nothing
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(787, 20)
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.Controller = Me.customBarAndDockingController1
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barSubItem1, Me.barCheckItem1, Me.barCheckItem2, Me.barCheckItem3, Me.barCheckItem4, Me.barCheckItem5, Me.barSubItem2, Me.barCheckItem6, Me.barCheckItem7, Me.barCheckItem8, Me.barCheckItem9, Me.barCheckItem10, Me.barCheckItem11, Me.barCheckItem12, Me.barCheckItem13, Me.barButtonItem1, Me.barCheckItem14, Me.barCheckItem15, Me.barCheckItem16, Me.barCheckItem17, Me.barCheckItem18, Me.barCheckItem19, Me.barCheckItem20, Me.customBarCheckItem1, Me.barCheckItem21, Me.barSubItem3, Me.barCheckItem22, Me.customBarCheckItem2, Me.customBarCheckItem3, Me.customBarCheckItem5, Me.barCheckItem23, Me.barButtonItem2, Me.barButtonItem3, Me.barCheckItem24, Me.barCheckItem25, Me.skinBarSubItem1, Me.customBarCheckItem4, Me.barSubItem4, Me.customBarCheckItem6, Me.customBarCheckItem7, Me.barButtonItem4, Me.barSubItem5, Me.customBarCheckItem8, Me.customBarCheckItem9})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 48
            Me.barManager1.StatusBar = Me.bar3
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem2)})
            Me.bar1.Offset = 1
            Me.bar1.Text = "Tools"
            ' 
            ' barSubItem2
            ' 
            Me.barSubItem2.Caption = "barSubItem2"
            Me.barSubItem2.Glyph = (DirectCast(resources.GetObject("barSubItem2.Glyph"), System.Drawing.Image))
            Me.barSubItem2.Id = 6
            Me.barSubItem2.LargeGlyph = (DirectCast(resources.GetObject("barSubItem2.LargeGlyph"), System.Drawing.Image))
            Me.barSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.customBarCheckItem5), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.customBarCheckItem4), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem24), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem25), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.skinBarSubItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem4) _
            })
            Me.barSubItem2.Name = "barSubItem2"
            ' 
            ' customBarCheckItem5
            ' 
            Me.customBarCheckItem5.Caption = "customBarCheckItem5"
            Me.customBarCheckItem5.Checked = True
            Me.customBarCheckItem5.Glyph = My.Resources.Untitled1
            Me.customBarCheckItem5.GroupIndex = 10
            Me.customBarCheckItem5.Id = 31
            Me.customBarCheckItem5.Name = "customBarCheckItem5"
            ' 
            ' customBarCheckItem4
            ' 
            Me.customBarCheckItem4.Caption = "custo"
            Me.customBarCheckItem4.Glyph = My.Resources.Untitled2
            Me.customBarCheckItem4.GroupIndex = 10
            Me.customBarCheckItem4.Id = 40
            Me.customBarCheckItem4.Name = "customBarCheckItem4"
            ' 
            ' barCheckItem24
            ' 
            Me.barCheckItem24.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.barCheckItem24.Caption = "barCheckItem24"
            Me.barCheckItem24.GroupIndex = 1
            Me.barCheckItem24.Id = 37
            Me.barCheckItem24.Name = "barCheckItem24"
            ' 
            ' barCheckItem25
            ' 
            Me.barCheckItem25.Caption = "barCheckItem25"
            Me.barCheckItem25.GroupIndex = 1
            Me.barCheckItem25.Id = 38
            Me.barCheckItem25.Name = "barCheckItem25"
            ' 
            ' skinBarSubItem1
            ' 
            Me.skinBarSubItem1.Caption = "skinBarSubItem1"
            Me.skinBarSubItem1.Id = 39
            Me.skinBarSubItem1.Name = "skinBarSubItem1"
            ' 
            ' barSubItem4
            ' 
            Me.barSubItem4.Caption = "barSubItem4"
            Me.barSubItem4.Id = 41
            Me.barSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.customBarCheckItem6), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.customBarCheckItem7) _
            })
            Me.barSubItem4.Name = "barSubItem4"
            ' 
            ' customBarCheckItem6
            ' 
            Me.customBarCheckItem6.Caption = "customBarCheckItem6"
            Me.customBarCheckItem6.Checked = True
            Me.customBarCheckItem6.Glyph = My.Resources.Untitled1
            Me.customBarCheckItem6.Id = 42
            Me.customBarCheckItem6.Name = "customBarCheckItem6"
            ' 
            ' customBarCheckItem7
            ' 
            Me.customBarCheckItem7.Caption = "customBarCheckItem7"
            Me.customBarCheckItem7.Id = 43
            Me.customBarCheckItem7.Name = "customBarCheckItem7"
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            ' 
            ' customBarAndDockingController1
            ' 
            Me.customBarAndDockingController1.PaintStyleName = "Custom"
            Me.customBarAndDockingController1.PropertiesBar.AllowLinkLighting = False
            Me.customBarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
            Me.customBarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(787, 49)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 486)
            Me.barDockControlBottom.Size = New System.Drawing.Size(787, 23)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 437)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(787, 49)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 437)
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "barSubItem1"
            Me.barSubItem1.Id = 0
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barCheckItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' barCheckItem4
            ' 
            Me.barCheckItem4.Caption = "barCheckItem4"
            Me.barCheckItem4.Glyph = (DirectCast(resources.GetObject("barCheckItem4.Glyph"), System.Drawing.Image))
            Me.barCheckItem4.Id = 4
            Me.barCheckItem4.Name = "barCheckItem4"
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.Caption = "barCheckItem1"
            Me.barCheckItem1.Glyph = (DirectCast(resources.GetObject("barCheckItem1.Glyph"), System.Drawing.Image))
            Me.barCheckItem1.Id = 1
            Me.barCheckItem1.LargeGlyph = (DirectCast(resources.GetObject("barCheckItem1.LargeGlyph"), System.Drawing.Image))
            Me.barCheckItem1.Name = "barCheckItem1"
            ' 
            ' barCheckItem2
            ' 
            Me.barCheckItem2.Caption = "barCheckItem2"
            Me.barCheckItem2.Id = 2
            Me.barCheckItem2.Name = "barCheckItem2"
            ' 
            ' barCheckItem3
            ' 
            Me.barCheckItem3.Caption = "barCheckItem3"
            Me.barCheckItem3.Id = 3
            Me.barCheckItem3.Name = "barCheckItem3"
            ' 
            ' barCheckItem5
            ' 
            Me.barCheckItem5.Caption = "barCheckItem5"
            Me.barCheckItem5.Glyph = (DirectCast(resources.GetObject("barCheckItem5.Glyph"), System.Drawing.Image))
            Me.barCheckItem5.Id = 5
            Me.barCheckItem5.LargeGlyph = (DirectCast(resources.GetObject("barCheckItem5.LargeGlyph"), System.Drawing.Image))
            Me.barCheckItem5.Name = "barCheckItem5"
            ' 
            ' barCheckItem6
            ' 
            Me.barCheckItem6.Caption = "barCheckItem6"
            Me.barCheckItem6.Checked = True
            Me.barCheckItem6.Glyph = (DirectCast(resources.GetObject("barCheckItem6.Glyph"), System.Drawing.Image))
            Me.barCheckItem6.Id = 7
            Me.barCheckItem6.LargeGlyph = (DirectCast(resources.GetObject("barCheckItem6.LargeGlyph"), System.Drawing.Image))
            Me.barCheckItem6.Name = "barCheckItem6"
            ' 
            ' barCheckItem7
            ' 
            Me.barCheckItem7.Caption = "barCheckItem7"
            Me.barCheckItem7.Checked = True
            Me.barCheckItem7.Glyph = My.Resources.Untitled1
            Me.barCheckItem7.Id = 8
            Me.barCheckItem7.Name = "barCheckItem7"
            ' 
            ' barCheckItem8
            ' 
            Me.barCheckItem8.Caption = "barCheckItem8"
            Me.barCheckItem8.Glyph = My.Resources.Untitled2
            Me.barCheckItem8.Id = 9
            Me.barCheckItem8.Name = "barCheckItem8"
            ' 
            ' barCheckItem9
            ' 
            Me.barCheckItem9.Caption = "barCheckItem9"
            Me.barCheckItem9.Glyph = (DirectCast(resources.GetObject("barCheckItem9.Glyph"), System.Drawing.Image))
            Me.barCheckItem9.Id = 10
            Me.barCheckItem9.LargeGlyph = (DirectCast(resources.GetObject("barCheckItem9.LargeGlyph"), System.Drawing.Image))
            Me.barCheckItem9.Name = "barCheckItem9"
            ' 
            ' barCheckItem10
            ' 
            Me.barCheckItem10.Caption = "barCheckItem10"
            Me.barCheckItem10.Glyph = (DirectCast(resources.GetObject("barCheckItem10.Glyph"), System.Drawing.Image))
            Me.barCheckItem10.Id = 11
            Me.barCheckItem10.LargeGlyph = (DirectCast(resources.GetObject("barCheckItem10.LargeGlyph"), System.Drawing.Image))
            Me.barCheckItem10.Name = "barCheckItem10"
            ' 
            ' barCheckItem11
            ' 
            Me.barCheckItem11.Caption = "barCheckItem11"
            Me.barCheckItem11.Id = 12
            Me.barCheckItem11.Name = "barCheckItem11"
            ' 
            ' barCheckItem12
            ' 
            Me.barCheckItem12.Caption = "barCheckItem12"
            Me.barCheckItem12.Id = 14
            Me.barCheckItem12.Name = "barCheckItem12"
            ' 
            ' barCheckItem13
            ' 
            Me.barCheckItem13.Caption = "barCheckItem13"
            Me.barCheckItem13.Id = 15
            Me.barCheckItem13.Name = "barCheckItem13"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "barButtonItem1"
            Me.barButtonItem1.Id = 16
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barCheckItem14
            ' 
            Me.barCheckItem14.Caption = "barCheckItem14"
            Me.barCheckItem14.Id = 17
            Me.barCheckItem14.Name = "barCheckItem14"
            ' 
            ' barCheckItem15
            ' 
            Me.barCheckItem15.Caption = "barCheckItem15"
            Me.barCheckItem15.Id = 18
            Me.barCheckItem15.Name = "barCheckItem15"
            ' 
            ' barCheckItem16
            ' 
            Me.barCheckItem16.Caption = "barCheckItem16"
            Me.barCheckItem16.Glyph = (DirectCast(resources.GetObject("barCheckItem16.Glyph"), System.Drawing.Image))
            Me.barCheckItem16.Id = 19
            Me.barCheckItem16.LargeGlyph = (DirectCast(resources.GetObject("barCheckItem16.LargeGlyph"), System.Drawing.Image))
            Me.barCheckItem16.Name = "barCheckItem16"
            ' 
            ' barCheckItem17
            ' 
            Me.barCheckItem17.Caption = "barCheckItem17"
            Me.barCheckItem17.Glyph = (DirectCast(resources.GetObject("barCheckItem17.Glyph"), System.Drawing.Image))
            Me.barCheckItem17.Id = 20
            Me.barCheckItem17.LargeGlyph = (DirectCast(resources.GetObject("barCheckItem17.LargeGlyph"), System.Drawing.Image))
            Me.barCheckItem17.Name = "barCheckItem17"
            ' 
            ' barCheckItem18
            ' 
            Me.barCheckItem18.Caption = "barCheckItem18"
            Me.barCheckItem18.Id = 21
            Me.barCheckItem18.Name = "barCheckItem18"
            ' 
            ' barCheckItem19
            ' 
            Me.barCheckItem19.Caption = "barCheckItem19"
            Me.barCheckItem19.Id = 22
            Me.barCheckItem19.Name = "barCheckItem19"
            ' 
            ' barCheckItem20
            ' 
            Me.barCheckItem20.Caption = "barCheckItem20"
            Me.barCheckItem20.Glyph = (DirectCast(resources.GetObject("barCheckItem20.Glyph"), System.Drawing.Image))
            Me.barCheckItem20.Id = 23
            Me.barCheckItem20.LargeGlyph = (DirectCast(resources.GetObject("barCheckItem20.LargeGlyph"), System.Drawing.Image))
            Me.barCheckItem20.Name = "barCheckItem20"
            ' 
            ' customBarCheckItem1
            ' 
            Me.customBarCheckItem1.Caption = "customBarCheckItem1"
            Me.customBarCheckItem1.Glyph = My.Resources.Untitled1
            Me.customBarCheckItem1.Id = 24
            Me.customBarCheckItem1.Name = "customBarCheckItem1"
            ' 
            ' barCheckItem21
            ' 
            Me.barCheckItem21.Caption = "barCheckItem21"
            Me.barCheckItem21.Id = 25
            Me.barCheckItem21.Name = "barCheckItem21"
            ' 
            ' barSubItem3
            ' 
            Me.barSubItem3.Caption = "barSubItem3"
            Me.barSubItem3.Id = 26
            Me.barSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.customBarCheckItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.customBarCheckItem3) _
            })
            Me.barSubItem3.Name = "barSubItem3"
            ' 
            ' customBarCheckItem2
            ' 
            Me.customBarCheckItem2.Caption = "customBarCheckItem2"
            Me.customBarCheckItem2.Checked = True
            Me.customBarCheckItem2.Glyph = My.Resources.Untitled2
            Me.customBarCheckItem2.Id = 28
            Me.customBarCheckItem2.Name = "customBarCheckItem2"
            ' 
            ' customBarCheckItem3
            ' 
            Me.customBarCheckItem3.Caption = "customBarCheckItem3"
            Me.customBarCheckItem3.Id = 29
            Me.customBarCheckItem3.Name = "customBarCheckItem3"
            ' 
            ' barCheckItem22
            ' 
            Me.barCheckItem22.Caption = "barCheckItem22"
            Me.barCheckItem22.Glyph = (DirectCast(resources.GetObject("barCheckItem22.Glyph"), System.Drawing.Image))
            Me.barCheckItem22.Id = 27
            Me.barCheckItem22.LargeGlyph = (DirectCast(resources.GetObject("barCheckItem22.LargeGlyph"), System.Drawing.Image))
            Me.barCheckItem22.Name = "barCheckItem22"
            ' 
            ' barCheckItem23
            ' 
            Me.barCheckItem23.Caption = "barCheckItem23"
            Me.barCheckItem23.Id = 32
            Me.barCheckItem23.Name = "barCheckItem23"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "barButtonItem2"
            Me.barButtonItem2.Id = 34
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "barButtonItem3"
            Me.barButtonItem3.Id = 35
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.InsertGalleryImage("add_16x16.png", "images/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_16x16.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "add_16x16.png")
            Me.imageCollection1.InsertGalleryImage("alignhorizontalbottom_16x16.png", "images/alignment/alignhorizontalbottom_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/alignhorizontalbottom_16x16.png"), 1)
            Me.imageCollection1.Images.SetKeyName(1, "alignhorizontalbottom_16x16.png")
            ' 
            ' popupMenu1
            ' 
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem5) _
            })
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.Name = "popupMenu1"
            ' 
            ' barButtonItem4
            ' 
            Me.barButtonItem4.Caption = "barButtonItem4"
            Me.barButtonItem4.Id = 44
            Me.barButtonItem4.Name = "barButtonItem4"
            ' 
            ' barSubItem5
            ' 
            Me.barSubItem5.Caption = "barSubItem5"
            Me.barSubItem5.Id = 45
            Me.barSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.customBarCheckItem8), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.customBarCheckItem9) _
            })
            Me.barSubItem5.Name = "barSubItem5"
            ' 
            ' customBarCheckItem8
            ' 
            Me.customBarCheckItem8.Caption = "customBarCheckItem8"
            Me.customBarCheckItem8.Glyph = My.Resources.Untitled1
            Me.customBarCheckItem8.Id = 46
            Me.customBarCheckItem8.Name = "customBarCheckItem8"
            ' 
            ' customBarCheckItem9
            ' 
            Me.customBarCheckItem9.Caption = "customBarCheckItem9"
            Me.customBarCheckItem9.Glyph = My.Resources.Untitled2
            Me.customBarCheckItem9.Id = 47
            Me.customBarCheckItem9.Name = "customBarCheckItem9"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(787, 509)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.customBarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private formAssistant1 As DevExpress.XtraBars.FormAssistant
        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private barSubItem1 As DevExpress.XtraBars.BarSubItem
        Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem
        Private bar2 As DevExpress.XtraBars.Bar
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barCheckItem2 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem3 As DevExpress.XtraBars.BarCheckItem
        Private customBarAndDockingController1 As CustomBarAndDockingController
        Private barCheckItem4 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem5 As DevExpress.XtraBars.BarCheckItem
        Private barSubItem2 As DevExpress.XtraBars.BarSubItem
        Private barCheckItem6 As DevExpress.XtraBars.BarCheckItem
        Private imageCollection1 As DevExpress.Utils.ImageCollection
        Private barCheckItem7 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem8 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem9 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem10 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem11 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem12 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem13 As DevExpress.XtraBars.BarCheckItem
        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private barCheckItem14 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem15 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem16 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem17 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem18 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem19 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem20 As DevExpress.XtraBars.BarCheckItem
        Private customBarCheckItem1 As CustomBarCheckItem
        Private barCheckItem21 As DevExpress.XtraBars.BarCheckItem
        Private barSubItem3 As DevExpress.XtraBars.BarSubItem
        Private barCheckItem22 As DevExpress.XtraBars.BarCheckItem
        Private customBarCheckItem2 As CustomBarCheckItem
        Private customBarCheckItem3 As CustomBarCheckItem
        Private customBarCheckItem5 As CustomBarCheckItem
        Private barCheckItem23 As DevExpress.XtraBars.BarCheckItem
        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
        Private barCheckItem24 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem25 As DevExpress.XtraBars.BarCheckItem
        Private skinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
        Private customBarCheckItem4 As CustomBarCheckItem
        Private barSubItem4 As DevExpress.XtraBars.BarSubItem
        Private customBarCheckItem6 As CustomBarCheckItem
        Private customBarCheckItem7 As CustomBarCheckItem
        Private popupMenu1 As DevExpress.XtraBars.PopupMenu
        Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
        Private barSubItem5 As DevExpress.XtraBars.BarSubItem
        Private customBarCheckItem8 As CustomBarCheckItem
        Private customBarCheckItem9 As CustomBarCheckItem
    End Class
End Namespace

