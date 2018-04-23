Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Painters
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraBars.Controls
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing

Namespace WindowsFormsApplication242
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseClick
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                popupMenu1.ShowPopup(barManager1, Me.PointToScreen(e.Location))
            End If
        End Sub
    End Class
End Namespace
