Imports DevComponents
Imports DevExpress
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel

Public Class AddNewExchangeControl
    Inherits DevComponents.DotNetBar.Controls.SlidePanel

    Const WM_NCLBUTTONDOWN As Integer = &HA1
    Const HTCAPTION As Integer = 2
    Private Declare Function ReleaseCapture Lib "user32.dll" () As Integer
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageW" (hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer

    Private Sub AddNewExchangeControl_Load(sender As Object, e As EventArgs) Handles Me.Load

        PageSlider1.SelectedPageIndex = 0

        PageSlider1.BackColor = frmStart.StyleManager1.MetroColorParameters.CanvasColor

        fldExchangeName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        fldSource.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        fldRecipient.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        fldAmount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        fldDateTime.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default

    End Sub

    Private Sub AddNewExchangeControl_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, PageSlider1.MouseDown
        ReleaseCapture()
        SendMessage(frmStart.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub fldExchangeName_GotFocus(sender As Object, e As EventArgs) Handles fldExchangeName.GotFocus
        fldExchangeName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    End Sub

    Private Sub fldExchangeName_LostFocus(sender As Object, e As EventArgs) Handles fldExchangeName.LostFocus
        fldExchangeName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
    End Sub

    Private Sub lblSource_GotFocus(sender As Object, e As EventArgs) Handles fldSource.GotFocus
        fldSource.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    End Sub

    Private Sub lblSource_LostFocus(sender As Object, e As EventArgs) Handles fldSource.LostFocus
        fldSource.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
    End Sub

    Private Sub fldRecipient_GotFocus(sender As Object, e As EventArgs) Handles fldRecipient.GotFocus
        fldRecipient.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    End Sub

    Private Sub fldRecipient_LostFocus(sender As Object, e As EventArgs) Handles fldRecipient.LostFocus
        fldSource.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
    End Sub

    Private Sub fldAmount_GotFocus(sender As Object, e As EventArgs) Handles fldAmount.GotFocus
        fldAmount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    End Sub

    Private Sub fldAmount_LostFocus(sender As Object, e As EventArgs) Handles fldAmount.LostFocus
        fldAmount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
    End Sub

    Private Sub fldDateTime_GotFocus(sender As Object, e As EventArgs)
        fldDateTime.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    End Sub

    Private Sub fldDateTime_LostFocus(sender As Object, e As EventArgs)
        fldDateTime.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
    End Sub

    Private Sub PageNavigator1_NavigateNextPage(sender As Object, e As EventArgs) Handles PageNavigator1.NavigateNextPage
        If PageSlider1.SelectedPageIndex = PageSlider1.PageCount - 1 Then
            PageSlider1.SelectedPageIndex = 0
        Else
            PageSlider1.SelectedPageIndex += 1
        End If
    End Sub

    Private Sub PageNavigator1_NavigatePreviousPage(sender As Object, e As EventArgs) Handles PageNavigator1.NavigatePreviousPage
        If PageSlider1.SelectedPageIndex = 0 Then
            PageSlider1.SelectedPageIndex = PageSlider1.PageCount - 1
        Else
            PageSlider1.SelectedPageIndex -= 1
        End If
    End Sub

    Private Sub PageNavigator1_NavigateToday(sender As Object, e As EventArgs) Handles PageNavigator1.NavigateToday
        PageSlider1.SelectedPageIndex = 0
    End Sub

    
End Class
