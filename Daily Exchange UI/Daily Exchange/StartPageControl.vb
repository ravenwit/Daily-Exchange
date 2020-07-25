Imports DevComponents
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar.Metro.ColorTables
Imports DevComponents.AdvTree
Imports DevExpress
Public Class StartPageControl
    Inherits DevComponents.DotNetBar.Controls.SlidePanel

    Const WM_NCLBUTTONDOWN As Integer = &HA1
    Const HTCAPTION As Integer = 2
    Private Declare Function ReleaseCapture Lib "user32.dll" () As Integer
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageW" (hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        Me.IsOpen = True
        Me.SlideOutButtonVisible = False
    End Sub

    Private Sub SlidePanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(frmStart.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
End Class
