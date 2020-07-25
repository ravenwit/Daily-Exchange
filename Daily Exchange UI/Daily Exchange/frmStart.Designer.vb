<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.MetroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
        Me.MetroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.MetroTabPanel2 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
        Me.MetroAppButton1 = New DevComponents.DotNetBar.Metro.MetroAppButton()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.MetroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.MetroTabItem2 = New DevComponents.DotNetBar.Metro.MetroTabItem()
        Me.btnColorScheme = New DevComponents.DotNetBar.ButtonItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.lblStatusTime = New DevComponents.DotNetBar.LabelItem()
        Me.tmrController = New System.Windows.Forms.Timer(Me.components)
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.lblTitle = New DevComponents.DotNetBar.LabelX()
        Me.btnUser = New DevComponents.DotNetBar.ButtonX()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.itmContainerAccount = New DevComponents.DotNetBar.ItemContainer()
        Me.btnAccount = New DevComponents.DotNetBar.ButtonItem()
        Me.itmContainerSignOut = New DevComponents.DotNetBar.ItemContainer()
        Me.btnSignOut = New DevComponents.DotNetBar.ButtonItem()
        Me.itmContainerQuit = New DevComponents.DotNetBar.ItemContainer()
        Me.btnQuit = New DevComponents.DotNetBar.ButtonItem()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.AddNewExchangeControl1 = New Daily_Exchange.AddNewExchangeControl()
        Me.MetroShell1.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroShell1
        '
        Me.MetroShell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.MetroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroShell1.BackgroundStyle.TextShadowColor = System.Drawing.SystemColors.ActiveBorder
        Me.MetroShell1.BackgroundStyle.TextShadowOffset = New System.Drawing.Point(2, 2)
        Me.MetroShell1.CaptionVisible = True
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel1)
        Me.MetroShell1.Controls.Add(Me.MetroTabPanel2)
        Me.MetroShell1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroShell1.ForeColor = System.Drawing.Color.Black
        Me.MetroShell1.HelpButtonText = Nothing
        Me.MetroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroAppButton1, Me.MetroTabItem1, Me.MetroTabItem2})
        Me.MetroShell1.KeyTipsFont = New System.Drawing.Font("Verdana", 7.0!)
        Me.MetroShell1.Location = New System.Drawing.Point(0, 0)
        Me.MetroShell1.Name = "MetroShell1"
        Me.MetroShell1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnColorScheme, Me.QatCustomizeItem1})
        Me.MetroShell1.Size = New System.Drawing.Size(932, 223)
        Me.MetroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.MetroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.MetroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.MetroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.MetroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.MetroShell1.SystemText.QatDialogAddButton = "&Add >>"
        Me.MetroShell1.SystemText.QatDialogCancelButton = "Cancel"
        Me.MetroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.MetroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.MetroShell1.SystemText.QatDialogOkButton = "OK"
        Me.MetroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.MetroShell1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.MetroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.MetroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.MetroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.MetroShell1.TabIndex = 0
        Me.MetroShell1.TabStripFont = New System.Drawing.Font("Tempus Sans ITC", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroShell1.Text = "Daily Exchange"
        Me.MetroShell1.TitleText = "Daily Exchange"
        Me.MetroShell1.UseExternalCustomization = True
        '
        'MetroTabPanel1
        '
        Me.MetroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel1.Location = New System.Drawing.Point(0, 50)
        Me.MetroTabPanel1.Name = "MetroTabPanel1"
        Me.MetroTabPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel1.Size = New System.Drawing.Size(932, 173)
        '
        '
        '
        Me.MetroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel1.TabIndex = 1
        '
        'MetroTabPanel2
        '
        Me.MetroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabPanel2.Location = New System.Drawing.Point(0, 50)
        Me.MetroTabPanel2.Name = "MetroTabPanel2"
        Me.MetroTabPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MetroTabPanel2.Size = New System.Drawing.Size(932, 173)
        '
        '
        '
        Me.MetroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MetroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTabPanel2.TabIndex = 2
        Me.MetroTabPanel2.Visible = False
        '
        'MetroAppButton1
        '
        Me.MetroAppButton1.AutoExpandOnClick = True
        Me.MetroAppButton1.BackstageTab = Me.SuperTabControl1
        Me.MetroAppButton1.CanCustomize = False
        Me.MetroAppButton1.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.MetroAppButton1.ImagePaddingHorizontal = 0
        Me.MetroAppButton1.ImagePaddingVertical = 0
        Me.MetroAppButton1.Name = "MetroAppButton1"
        Me.MetroAppButton1.ShowSubItems = False
        Me.MetroAppButton1.Text = "&File"
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuperTabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.ControlBox.Visible = False
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.ItemPadding.Left = 6
        Me.SuperTabControl1.ItemPadding.Right = 4
        Me.SuperTabControl1.ItemPadding.Top = 4
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 50)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = False
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SuperTabControl1.SelectedTabIndex = 6
        Me.SuperTabControl1.Size = New System.Drawing.Size(932, 450)
        Me.SuperTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabHorizontalSpacing = 16
        Me.SuperTabControl1.TabIndex = 11
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2, Me.ButtonItem3, Me.SuperTabItem2, Me.SuperTabItem1, Me.SuperTabItem3, Me.SuperTabItem4, Me.ButtonItem4, Me.ButtonItem5})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.TabVerticalSpacing = 8
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(95, 0)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(837, 450)
        Me.SuperTabControlPanel3.TabIndex = 3
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.KeyTips = "P"
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Print"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(95, 0)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(837, 450)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.KeyTips = "R"
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Recent"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(95, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(837, 450)
        Me.SuperTabControlPanel2.TabIndex = 2
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.KeyTips = "N"
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "New"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.BackgroundImage = CType(resources.GetObject("SuperTabControlPanel4.BackgroundImage"), System.Drawing.Image)
        Me.SuperTabControlPanel4.CanvasColor = System.Drawing.Color.Transparent
        Me.SuperTabControlPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(95, 0)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.ShowFocusRectangle = True
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(837, 450)
        Me.SuperTabControlPanel4.TabIndex = 4
        Me.SuperTabControlPanel4.TabItem = Me.SuperTabItem4
        Me.SuperTabControlPanel4.ThemeAware = True
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.SuperTabControlPanel4
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.KeyTips = "H"
        Me.SuperTabItem4.Name = "SuperTabItem4"
        Me.SuperTabItem4.Text = "Help"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.ImagePaddingHorizontal = 18
        Me.ButtonItem1.ImagePaddingVertical = 10
        Me.ButtonItem1.KeyTips = "S"
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Stretch = True
        Me.ButtonItem1.Text = "Save"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        Me.ButtonItem2.ImagePaddingHorizontal = 18
        Me.ButtonItem2.ImagePaddingVertical = 10
        Me.ButtonItem2.KeyTips = "O"
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Stretch = True
        Me.ButtonItem2.Text = "Open"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.ImagePaddingHorizontal = 18
        Me.ButtonItem3.ImagePaddingVertical = 10
        Me.ButtonItem3.KeyTips = "C"
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Stretch = True
        Me.ButtonItem3.Text = "Close"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem4.Image = CType(resources.GetObject("ButtonItem4.Image"), System.Drawing.Image)
        Me.ButtonItem4.ImagePaddingHorizontal = 18
        Me.ButtonItem4.ImagePaddingVertical = 10
        Me.ButtonItem4.KeyTips = "T"
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Stretch = True
        Me.ButtonItem4.Text = "Options"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem5.Image = CType(resources.GetObject("ButtonItem5.Image"), System.Drawing.Image)
        Me.ButtonItem5.ImagePaddingHorizontal = 18
        Me.ButtonItem5.ImagePaddingVertical = 10
        Me.ButtonItem5.KeyTips = "X"
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Stretch = True
        Me.ButtonItem5.Text = "Exit"
        '
        'MetroTabItem1
        '
        Me.MetroTabItem1.Checked = True
        Me.MetroTabItem1.Name = "MetroTabItem1"
        Me.MetroTabItem1.Panel = Me.MetroTabPanel1
        Me.MetroTabItem1.Text = "&HOME"
        '
        'MetroTabItem2
        '
        Me.MetroTabItem2.Name = "MetroTabItem2"
        Me.MetroTabItem2.Panel = Me.MetroTabPanel2
        Me.MetroTabItem2.Text = "&VIEW"
        '
        'btnColorScheme
        '
        Me.btnColorScheme.AutoExpandOnClick = True
        Me.btnColorScheme.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnColorScheme.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.btnColorScheme.Image = CType(resources.GetObject("btnColorScheme.Image"), System.Drawing.Image)
        Me.btnColorScheme.Name = "btnColorScheme"
        Me.btnColorScheme.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.BeginGroup = True
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(120, Byte), Integer)))
        '
        'MetroStatusBar1
        '
        Me.MetroStatusBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.MetroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar1.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar1.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lblStatusTime})
        Me.MetroStatusBar1.Location = New System.Drawing.Point(0, 478)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MetroStatusBar1.Size = New System.Drawing.Size(932, 22)
        Me.MetroStatusBar1.TabIndex = 10
        Me.MetroStatusBar1.Text = "MetroStatusBar1"
        '
        'lblStatusTime
        '
        Me.lblStatusTime.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.lblStatusTime.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblStatusTime.DividerStyle = True
        Me.lblStatusTime.Font = New System.Drawing.Font("DS-Digital", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusTime.Name = "lblStatusTime"
        Me.lblStatusTime.Text = "Time"
        Me.lblStatusTime.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.BackColor = System.Drawing.Color.Snow
        Me.ItemContainer2.BackgroundStyle.BackColor2 = System.Drawing.Color.GhostWhite
        Me.ItemContainer2.BackgroundStyle.BackColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Silver, 0.0!)})
        Me.ItemContainer2.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.ItemContainer2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer2.BackgroundStyle.BorderBottomColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ItemContainer2.BackgroundStyle.BorderBottomWidth = 2
        Me.ItemContainer2.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ItemContainer2.BackgroundStyle.BorderColor2 = System.Drawing.SystemColors.Control
        Me.ItemContainer2.BackgroundStyle.BorderColorLight = System.Drawing.SystemColors.ButtonFace
        Me.ItemContainer2.BackgroundStyle.BorderColorLight2 = System.Drawing.SystemColors.ControlLight
        Me.ItemContainer2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ItemContainer2.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center
        Me.ItemContainer2.ItemSpacing = 12
        Me.ItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.Text = "                    "
        '
        '
        '
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.BackColor = System.Drawing.Color.Snow
        Me.ItemContainer1.BackgroundStyle.BackColor2 = System.Drawing.Color.GhostWhite
        Me.ItemContainer1.BackgroundStyle.BackColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Silver, 0.0!)})
        Me.ItemContainer1.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.ItemContainer1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer1.BackgroundStyle.BorderBottomColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ItemContainer1.BackgroundStyle.BorderBottomWidth = 2
        Me.ItemContainer1.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ItemContainer1.BackgroundStyle.BorderColor2 = System.Drawing.SystemColors.Control
        Me.ItemContainer1.BackgroundStyle.BorderColorLight = System.Drawing.SystemColors.ButtonFace
        Me.ItemContainer1.BackgroundStyle.BorderColorLight2 = System.Drawing.SystemColors.ControlLight
        Me.ItemContainer1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ItemContainer1.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center
        Me.ItemContainer1.ItemSpacing = 12
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.Text = "                    "
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTitle.Font = New System.Drawing.Font("Tempus Sans ITC", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), System.Drawing.Image)
        Me.lblTitle.Location = New System.Drawing.Point(351, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.PaddingBottom = 2
        Me.lblTitle.PaddingLeft = 2
        Me.lblTitle.PaddingRight = 2
        Me.lblTitle.PaddingTop = 2
        Me.lblTitle.Size = New System.Drawing.Size(241, 54)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "Daily Exchange"
        Me.lblTitle.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnUser
        '
        Me.btnUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUser.AutoExpandOnClick = True
        Me.btnUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUser.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnUser.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Highlighter1.SetHighlightColor(Me.btnUser, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        Me.Highlighter1.SetHighlightOnFocus(Me.btnUser, True)
        Me.btnUser.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageFixedSize = New System.Drawing.Size(55, 55)
        Me.btnUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnUser.Location = New System.Drawing.Point(768, 3)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        Me.btnUser.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnUser.Size = New System.Drawing.Size(161, 64)
        Me.btnUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnUser.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3})
        Me.btnUser.SubItemsExpandWidth = 17
        Me.btnUser.TabIndex = 21
        Me.btnUser.Text = "<font size=""+7"">Shakir </font><br />&nbsp;&nbsp;&nbsp;&nbsp;<font size=""+1"">Ahmed" & _
    "</font>"
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.BackColor = System.Drawing.Color.Snow
        Me.ItemContainer3.BackgroundStyle.BackColor2 = System.Drawing.Color.GhostWhite
        Me.ItemContainer3.BackgroundStyle.BackColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.White, 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Silver, 0.0!)})
        Me.ItemContainer3.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.ItemContainer3.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer3.BackgroundStyle.BorderBottomColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ItemContainer3.BackgroundStyle.BorderBottomWidth = 2
        Me.ItemContainer3.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ItemContainer3.BackgroundStyle.BorderColor2 = System.Drawing.SystemColors.Control
        Me.ItemContainer3.BackgroundStyle.BorderColorLight = System.Drawing.SystemColors.ButtonFace
        Me.ItemContainer3.BackgroundStyle.BorderColorLight2 = System.Drawing.SystemColors.ControlLight
        Me.ItemContainer3.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer3.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer3.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ItemContainer3.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center
        Me.ItemContainer3.ItemSpacing = 12
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itmContainerAccount, Me.itmContainerSignOut, Me.itmContainerQuit})
        Me.ItemContainer3.Text = "                    "
        '
        '
        '
        Me.ItemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'itmContainerAccount
        '
        '
        '
        '
        Me.itmContainerAccount.BackgroundStyle.BackColor = System.Drawing.Color.Snow
        Me.itmContainerAccount.BackgroundStyle.BackColor2 = System.Drawing.Color.GhostWhite
        Me.itmContainerAccount.BackgroundStyle.BackColorGradientAngle = 90
        Me.itmContainerAccount.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.itmContainerAccount.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopRight
        Me.itmContainerAccount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itmContainerAccount.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.itmContainerAccount.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itmContainerAccount.Name = "itmContainerAccount"
        Me.itmContainerAccount.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAccount})
        '
        '
        '
        Me.itmContainerAccount.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnAccount
        '
        Me.btnAccount.BeginGroup = True
        Me.btnAccount.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnAccount.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccount.GlobalItem = False
        Me.btnAccount.HotFontBold = True
        Me.btnAccount.HotForeColor = System.Drawing.Color.Black
        Me.btnAccount.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.btnAccount.Image = CType(resources.GetObject("btnAccount.Image"), System.Drawing.Image)
        Me.btnAccount.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnAccount.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both
        Me.btnAccount.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.Fade
        Me.btnAccount.PopupFont = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        Me.btnAccount.PopupWidth = 500
        Me.btnAccount.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5, 5, 6, 5)
        Me.btnAccount.SplitButton = True
        Me.btnAccount.Stretch = True
        Me.btnAccount.Text = "         Account  "
        Me.btnAccount.Tooltip = "Show account settings"
        '
        'itmContainerSignOut
        '
        '
        '
        '
        Me.itmContainerSignOut.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itmContainerSignOut.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itmContainerSignOut.Name = "itmContainerSignOut"
        Me.itmContainerSignOut.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnSignOut})
        '
        '
        '
        Me.itmContainerSignOut.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnSignOut
        '
        Me.btnSignOut.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnSignOut.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.GlobalItem = False
        Me.btnSignOut.HotFontBold = True
        Me.btnSignOut.HotForeColor = System.Drawing.Color.Black
        Me.btnSignOut.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.btnSignOut.Image = CType(resources.GetObject("btnSignOut.Image"), System.Drawing.Image)
        Me.btnSignOut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnSignOut.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both
        Me.btnSignOut.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.Fade
        Me.btnSignOut.PopupFont = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        Me.btnSignOut.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5, 5, 6, 5)
        Me.btnSignOut.SplitButton = True
        Me.btnSignOut.Text = "        Sign Out  "
        Me.btnSignOut.Tooltip = "Sign Me Out"
        '
        'itmContainerQuit
        '
        '
        '
        '
        Me.itmContainerQuit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itmContainerQuit.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itmContainerQuit.Name = "itmContainerQuit"
        Me.itmContainerQuit.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnQuit})
        Me.itmContainerQuit.Text = "                              "
        '
        '
        '
        Me.itmContainerQuit.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnQuit
        '
        Me.btnQuit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnQuit.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuit.GlobalItem = False
        Me.btnQuit.HotFontBold = True
        Me.btnQuit.HotForeColor = System.Drawing.Color.Black
        Me.btnQuit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.btnQuit.Image = CType(resources.GetObject("btnQuit.Image"), System.Drawing.Image)
        Me.btnQuit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnQuit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both
        Me.btnQuit.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.Fade
        Me.btnQuit.PopupFont = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        Me.btnQuit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5, 5, 6, 5)
        Me.btnQuit.SplitButton = True
        Me.btnQuit.Text = "               Quit  "
        Me.btnQuit.Tooltip = "Quit application"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'AddNewExchangeControl1
        '
        Me.AddNewExchangeControl1.BackColor = System.Drawing.Color.Transparent
        Me.AddNewExchangeControl1.ForeColor = System.Drawing.Color.Black
        Me.AddNewExchangeControl1.IsOpen = False
        Me.AddNewExchangeControl1.Location = New System.Drawing.Point(0, 0)
        Me.AddNewExchangeControl1.Name = "AddNewExchangeControl1"
        Me.AddNewExchangeControl1.Size = New System.Drawing.Size(932, 430)
        Me.AddNewExchangeControl1.SlideOutButtonVisible = False
        Me.AddNewExchangeControl1.TabIndex = 23
        Me.AddNewExchangeControl1.Text = "AddNewExchangeControl1"
        Me.AddNewExchangeControl1.UsesBlockingAnimation = False
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.AddNewExchangeControl1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.MetroShell1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(938, 506)
        Me.MinimumSize = New System.Drawing.Size(938, 506)
        Me.Name = "frmStart"
        Me.MetroShell1.ResumeLayout(False)
        Me.MetroShell1.PerformLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroShell1 As DevComponents.DotNetBar.Metro.MetroShell
    Friend WithEvents MetroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents MetroTabPanel2 As DevComponents.DotNetBar.Metro.MetroTabPanel
    Friend WithEvents MetroAppButton1 As DevComponents.DotNetBar.Metro.MetroAppButton
    Friend WithEvents MetroTabItem1 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents MetroTabItem2 As DevComponents.DotNetBar.Metro.MetroTabItem
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btnColorScheme As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents lblStatusTime As DevComponents.DotNetBar.LabelItem
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tmrController As System.Windows.Forms.Timer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents lblTitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnUser As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents itmContainerAccount As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnAccount As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents itmContainerSignOut As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnSignOut As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents itmContainerQuit As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnQuit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents AddNewExchangeControl1 As Daily_Exchange.AddNewExchangeControl
End Class
