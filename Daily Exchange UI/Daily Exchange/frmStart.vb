Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Text
Imports DevComponents
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar.Metro.ColorTables
Imports DevComponents.AdvTree
Imports DevExpress

Public Class frmStart
    Inherits MetroForm

    Const WM_NCLBUTTONDOWN As Integer = &HA1
    Const HTCAPTION As Integer = 2
    Private metroThemes() As MetroColorGeneratorParameters = MetroColorGeneratorParameters.GetAllPredefinedThemes()

    Private WithEvents StartPage As New StartPageControl
    Private WithEvents AddNewExchangeControl As New AddNewExchangeControl

    Private WithEvents tleCtrlStart As DevExpress.XtraEditors.TileControl = StartPage.TileControl1
    Private WithEvents itmAddNewExchange As DevExpress.XtraEditors.TileItem = StartPage.TileItemAddNewExchange

    Private WithEvents btnOk As DevComponents.DotNetBar.ButtonX = AddNewExchangeControl.btnOK
    Private WithEvents btnCancel As DevComponents.DotNetBar.ButtonX = AddNewExchangeControl.btnCancel

    Private Declare Function ReleaseCapture Lib "user32.dll" () As Integer
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageW" (hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer

    Private Sub ApplyGeneralStyle(ByVal Container As DevComponents.DotNetBar.ItemContainer)
        On Error Resume Next
        With Container.BackgroundStyle
            .BackColor = Color.Snow
            .BackColor2 = Color.GhostWhite
            .BackColorGradientAngle = 90
            .BackColorGradientType = DotNetBar.eGradientType.Radial
            .CornerType = DotNetBar.eCornerType.Square
        End With
    End Sub
    Private Sub ApplyHoverStyle(ByVal Container As DevComponents.DotNetBar.ItemContainer)
        On Error Resume Next
        With Container.BackgroundStyle
            .BackColor = Color.Silver
            .BackColor2 = Color.Gainsboro
            .BackColorGradientAngle = 90
            .BackColorGradientType = DotNetBar.eGradientType.Radial
            .CornerType = DotNetBar.eCornerType.Square
        End With
    End Sub

    Private Sub ChangeMetroTheme(sender As Object, e As EventArgs)
        Dim source As ICommandSource = CType(sender, ICommandSource)
        Dim theme As MetroColorGeneratorParameters = CType(source.CommandParameter, MetroColorGeneratorParameters)
        StyleManager.MetroColorGeneratorParameters = theme
    End Sub


    Private Sub InitializeFormComponents()

        'Adding the theme menu
        For Each mt As MetroColorGeneratorParameters In metroThemes
            Dim theme As New ButtonItem(mt.ThemeName, mt.ThemeName)
            theme.Command = New Command(components, New EventHandler(AddressOf ChangeMetroTheme))
            theme.CommandParameter = mt
            btnColorScheme.SubItems.Add(theme)
        Next mt


        'Form Setup
        Me.Size = New Size(938, 506)



        lblTitle.Visible = True
        btnUser.Visible = True

        MetroShell1.Visible = False
        MetroStatusBar1.Visible = False


        StartPage.Location = New Point(0, 70)
        StartPage.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
        StartPage.Size = New Size(932, 430)
        StartPage.Visible = True
        StartPage.IsOpen = True
        StartPage.SlideOutButtonVisible = True
        StartPage.SlideSide = DotNetBar.Controls.eSlideSide.Left

        AddNewExchangeControl.Location = New Point(0, 70)
        AddNewExchangeControl.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
        AddNewExchangeControl.Size = New Size(932, 430)
        AddNewExchangeControl.SlideOutButtonVisible = False
        AddNewExchangeControl.IsOpen = False
        AddNewExchangeControl.SlideSide = DotNetBar.Controls.eSlideSide.Right

        Me.Controls.Add(StartPage)
        Me.Controls.Add(AddNewExchangeControl)
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next
        Me.Activate()


        InitializeFormComponents()

    End Sub

    Private Sub frmStart_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        StartPage.Size = New Size(Me.Width, Me.Height - 77)
        AddNewExchangeControl.Size = New Size(Me.Width, Me.Height - 77)
    End Sub

    Private Sub frmStart_MouseDown(sender As Object, e As EventArgs) Handles Me.MouseDown, MetroShell1.MouseDown, MetroStatusBar1.MouseDown, lblTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btnAccount_MouseHover(sender As Object, e As EventArgs) Handles btnAccount.MouseMove
        ApplyHoverStyle(itmContainerAccount)
    End Sub

    Private Sub btnAccount_MouseLeave(sender As Object, e As EventArgs) Handles btnAccount.MouseLeave
        ApplyGeneralStyle(itmContainerAccount)
    End Sub

    Private Sub btnSignOut_MouseHover(sender As Object, e As EventArgs) Handles btnSignOut.MouseMove
        ApplyHoverStyle(itmContainerSignOut)
    End Sub

    Private Sub btnSignOut_MouseLeave(sender As Object, e As EventArgs) Handles btnSignOut.MouseLeave
        ApplyGeneralStyle(itmContainerSignOut)
    End Sub

    Private Sub btnQuit_MouseHover(sender As Object, e As EventArgs) Handles btnQuit.MouseMove
        ApplyHoverStyle(itmContainerQuit)
    End Sub

    Private Sub btnQuit_MouseLeave(sender As Object, e As EventArgs) Handles btnQuit.MouseLeave
        ApplyGeneralStyle(itmContainerQuit)
    End Sub

    Private Sub btnUser_MouseMove(sender As Object, e As MouseEventArgs) Handles btnUser.MouseMove
        btnUser.ForeColor = Color.Black
        btnUser.BackColor = Color.Transparent
    End Sub

    Private Sub itmAddNewExchange_ItemClick(sender As Object, e As XtraEditors.TileItemEventArgs) Handles itmAddNewExchange.ItemClick
        StartPage.IsOpen = False
        StartPage.SlideOutButtonVisible = False
        AddNewExchangeControl.IsOpen = True
    End Sub

    Private Sub MetroShell1_VisibleChanged(sender As Object, e As EventArgs) Handles MetroShell1.VisibleChanged
        lblTitle.Visible = Not MetroShell1.Visible
        btnUser.Visible = Not MetroShell1.Visible
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AddNewExchangeControl.IsOpen = False
        AddNewExchangeControl.SlideOutButtonVisible = False
        StartPage.IsOpen = True
    End Sub

   
End Class