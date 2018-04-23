Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Styles

Namespace WindowsFormsApplication242
    <System.ComponentModel.DesignerCategory("")> _
    Public Class CustomBarAndDockingController
        Inherits BarAndDockingController

        Public Sub New(ByVal container As IContainer)
            MyBase.New(container)
        End Sub
        Public Sub New()
        End Sub
        Protected Overrides Sub RegisterPaintStyles()
            MyBase.RegisterPaintStyles()
            AddSkinPaintStyle()
        End Sub
        Private Sub AddSkinPaintStyle()
            PaintStyles.Add(New CustomSkinBarManagerPaintStyle(PaintStyles))
        End Sub
    End Class
End Namespace
