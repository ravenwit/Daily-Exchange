<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewExchangeControl
    Inherits DevComponents.DotNetBar.Controls.SlidePanel

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnOK = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PageSlider1 = New DevComponents.DotNetBar.Controls.PageSlider()
        Me.PageSliderPage1 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.fldRecipient = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.fldSource = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.fldExchangeName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.lblSource = New DevComponents.DotNetBar.LabelX()
        Me.lblExchangeName = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.PageSliderPage2 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.lblAmount = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.fldAmount = New DevExpress.XtraEditors.TextEdit()
        Me.PageSliderPage3 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.lblDate = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.fldDateTime = New DevExpress.XtraEditors.DateEdit()
        Me.PageNavigator1 = New DevComponents.DotNetBar.Controls.PageNavigator()
        Me.PageSlider1.SuspendLayout()
        Me.PageSliderPage1.SuspendLayout()
        CType(Me.fldRecipient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldExchangeName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageSliderPage2.SuspendLayout()
        CType(Me.fldAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageSliderPage3.SuspendLayout()
        CType(Me.fldDateTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDateTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(485, 393)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.Symbol = ""
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOK.Location = New System.Drawing.Point(368, 393)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btnOK.Size = New System.Drawing.Size(72, 23)
        Me.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOK.Symbol = ""
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.LabelX1.BackgroundStyle.TextShadowColor = System.Drawing.Color.AntiqueWhite
        Me.LabelX1.BackgroundStyle.TextShadowOffset = New System.Drawing.Point(4, 4)
        Me.LabelX1.Font = New System.Drawing.Font("Tempus Sans ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX1.Location = New System.Drawing.Point(383, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(174, 30)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Add New Exchange"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PageSlider1
        '
        Me.PageSlider1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PageSlider1.AnimationTime = 350
        Me.PageSlider1.Controls.Add(Me.PageSliderPage1)
        Me.PageSlider1.Controls.Add(Me.PageSliderPage2)
        Me.PageSlider1.Controls.Add(Me.PageSliderPage3)
        Me.PageSlider1.Location = New System.Drawing.Point(0, 36)
        Me.PageSlider1.Name = "PageSlider1"
        Me.PageSlider1.SelectedPage = Me.PageSliderPage3
        Me.PageSlider1.Size = New System.Drawing.Size(932, 321)
        Me.PageSlider1.TabIndex = 5
        Me.PageSlider1.Text = "PageSlider1"
        '
        'PageSliderPage1
        '
        Me.PageSliderPage1.Controls.Add(Me.fldRecipient)
        Me.PageSliderPage1.Controls.Add(Me.fldSource)
        Me.PageSliderPage1.Controls.Add(Me.fldExchangeName)
        Me.PageSliderPage1.Controls.Add(Me.LabelX4)
        Me.PageSliderPage1.Controls.Add(Me.lblSource)
        Me.PageSliderPage1.Controls.Add(Me.lblExchangeName)
        Me.PageSliderPage1.Controls.Add(Me.LabelX2)
        Me.PageSliderPage1.Location = New System.Drawing.Point(-1744, 8)
        Me.PageSliderPage1.Name = "PageSliderPage1"
        Me.PageSliderPage1.Size = New System.Drawing.Size(826, 309)
        Me.PageSliderPage1.TabIndex = 3
        '
        'fldRecipient
        '
        Me.fldRecipient.AllowDrop = True
        Me.fldRecipient.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldRecipient.EditValue = ""
        Me.fldRecipient.EnterMoveNextControl = True
        Me.fldRecipient.Location = New System.Drawing.Point(380, 217)
        Me.fldRecipient.Name = "fldRecipient"
        Me.fldRecipient.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldRecipient.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.fldRecipient.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.fldRecipient.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.fldRecipient.Properties.Appearance.Options.UseBackColor = True
        Me.fldRecipient.Properties.Appearance.Options.UseFont = True
        Me.fldRecipient.Properties.Appearance.Options.UseTextOptions = True
        Me.fldRecipient.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fldRecipient.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.fldRecipient.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.fldRecipient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fldRecipient.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.fldRecipient.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.fldRecipient.Properties.LookAndFeel.SkinName = "Office 2013"
        Me.fldRecipient.Properties.NullText = "Recipient"
        Me.fldRecipient.Properties.NullValuePrompt = "Recipient Name"
        Me.fldRecipient.Properties.NullValuePromptShowForEmptyValue = True
        Me.fldRecipient.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.fldRecipient.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.fldRecipient.Properties.UseCtrlScroll = True
        Me.fldRecipient.Properties.ValidateOnEnterKey = True
        Me.fldRecipient.Size = New System.Drawing.Size(240, 24)
        Me.fldRecipient.TabIndex = 3
        '
        'fldSource
        '
        Me.fldSource.AllowDrop = True
        Me.fldSource.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldSource.EditValue = ""
        Me.fldSource.EnterMoveNextControl = True
        Me.fldSource.Location = New System.Drawing.Point(380, 143)
        Me.fldSource.Name = "fldSource"
        Me.fldSource.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldSource.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.fldSource.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.fldSource.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.fldSource.Properties.Appearance.Options.UseBackColor = True
        Me.fldSource.Properties.Appearance.Options.UseFont = True
        Me.fldSource.Properties.Appearance.Options.UseTextOptions = True
        Me.fldSource.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fldSource.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.fldSource.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.fldSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fldSource.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.fldSource.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.fldSource.Properties.LookAndFeel.SkinName = "Office 2013"
        Me.fldSource.Properties.NullText = "Source Name "
        Me.fldSource.Properties.NullValuePrompt = "Source Name"
        Me.fldSource.Properties.NullValuePromptShowForEmptyValue = True
        Me.fldSource.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.fldSource.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.fldSource.Properties.UseCtrlScroll = True
        Me.fldSource.Properties.ValidateOnEnterKey = True
        Me.fldSource.Size = New System.Drawing.Size(240, 24)
        Me.fldSource.TabIndex = 2
        '
        'fldExchangeName
        '
        Me.fldExchangeName.AllowDrop = True
        Me.fldExchangeName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldExchangeName.EditValue = ""
        Me.fldExchangeName.EnterMoveNextControl = True
        Me.fldExchangeName.Location = New System.Drawing.Point(380, 68)
        Me.fldExchangeName.Name = "fldExchangeName"
        Me.fldExchangeName.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldExchangeName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.fldExchangeName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.fldExchangeName.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.fldExchangeName.Properties.Appearance.Options.UseBackColor = True
        Me.fldExchangeName.Properties.Appearance.Options.UseFont = True
        Me.fldExchangeName.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.fldExchangeName.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.fldExchangeName.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.fldExchangeName.Properties.LookAndFeel.SkinName = "Office 2013"
        Me.fldExchangeName.Properties.NullText = "Exchange Name"
        Me.fldExchangeName.Properties.NullValuePrompt = "Exchange Name"
        Me.fldExchangeName.Properties.NullValuePromptShowForEmptyValue = True
        Me.fldExchangeName.Properties.Tag = ""
        Me.fldExchangeName.Properties.ValidateOnEnterKey = True
        Me.fldExchangeName.Size = New System.Drawing.Size(240, 24)
        Me.fldExchangeName.TabIndex = 1
        Me.fldExchangeName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.LabelX4.BackgroundStyle.TextShadowColor = System.Drawing.Color.AntiqueWhite
        Me.LabelX4.BackgroundStyle.TextShadowOffset = New System.Drawing.Point(4, 4)
        Me.LabelX4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(207, 217)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(167, 23)
        Me.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX4.TabIndex = 4
        Me.LabelX4.Text = "Recipient            :"
        '
        'lblSource
        '
        Me.lblSource.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblSource.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblSource.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.Location = New System.Drawing.Point(207, 140)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(167, 23)
        Me.lblSource.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.lblSource.TabIndex = 3
        Me.lblSource.Text = "Source                :"
        '
        'lblExchangeName
        '
        Me.lblExchangeName.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblExchangeName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblExchangeName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExchangeName.Location = New System.Drawing.Point(207, 69)
        Me.lblExchangeName.Name = "lblExchangeName"
        Me.lblExchangeName.Size = New System.Drawing.Size(167, 23)
        Me.lblExchangeName.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.lblExchangeName.TabIndex = 2
        Me.lblExchangeName.Text = "Exchange Name   :"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelX2.Font = New System.Drawing.Font("Tempus Sans ITC", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(0, 0)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(826, 45)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Names"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PageSliderPage2
        '
        Me.PageSliderPage2.Controls.Add(Me.lblAmount)
        Me.PageSliderPage2.Controls.Add(Me.LabelX3)
        Me.PageSliderPage2.Controls.Add(Me.fldAmount)
        Me.PageSliderPage2.Location = New System.Drawing.Point(-870, 8)
        Me.PageSliderPage2.Name = "PageSliderPage2"
        Me.PageSliderPage2.Size = New System.Drawing.Size(826, 309)
        Me.PageSliderPage2.TabIndex = 4
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblAmount.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(207, 142)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(167, 23)
        Me.lblAmount.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.lblAmount.TabIndex = 6
        Me.lblAmount.Text = "Amount                :"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.LabelX3.BackgroundStyle.TextShadowColor = System.Drawing.Color.AntiqueWhite
        Me.LabelX3.BackgroundStyle.TextShadowOffset = New System.Drawing.Point(4, 4)
        Me.LabelX3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelX3.Font = New System.Drawing.Font("Tempus Sans ITC", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(0, 0)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(826, 45)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Amount"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'fldAmount
        '
        Me.fldAmount.EditValue = ""
        Me.fldAmount.Location = New System.Drawing.Point(380, 142)
        Me.fldAmount.Name = "fldAmount"
        Me.fldAmount.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.fldAmount.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.fldAmount.Properties.Appearance.Options.UseBackColor = True
        Me.fldAmount.Properties.Appearance.Options.UseFont = True
        Me.fldAmount.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.fldAmount.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.fldAmount.Properties.LookAndFeel.SkinName = "Office 2013"
        Me.fldAmount.Properties.Mask.BeepOnError = True
        Me.fldAmount.Properties.Mask.IgnoreMaskBlank = False
        Me.fldAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.fldAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.fldAmount.Properties.NullText = "0.00"
        Me.fldAmount.Properties.Tag = ""
        Me.fldAmount.Size = New System.Drawing.Size(240, 24)
        Me.fldAmount.TabIndex = 4
        Me.fldAmount.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application
        '
        'PageSliderPage3
        '
        Me.PageSliderPage3.Controls.Add(Me.lblDate)
        Me.PageSliderPage3.Controls.Add(Me.LabelX5)
        Me.PageSliderPage3.Controls.Add(Me.fldDateTime)
        Me.PageSliderPage3.Location = New System.Drawing.Point(4, 8)
        Me.PageSliderPage3.Name = "PageSliderPage3"
        Me.PageSliderPage3.Size = New System.Drawing.Size(826, 309)
        Me.PageSliderPage3.TabIndex = 5
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(212, 142)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(179, 23)
        Me.lblDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date and Time        :"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelX5.Font = New System.Drawing.Font("Tempus Sans ITC", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(0, 0)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(826, 45)
        Me.LabelX5.TabIndex = 3
        Me.LabelX5.Text = "Date and Time"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'fldDateTime
        '
        Me.fldDateTime.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldDateTime.EditValue = New Date(2013, 7, 15, 18, 9, 2, 0)
        Me.fldDateTime.EnterMoveNextControl = True
        Me.fldDateTime.Location = New System.Drawing.Point(397, 143)
        Me.fldDateTime.Name = "fldDateTime"
        Me.fldDateTime.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldDateTime.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.fldDateTime.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.fldDateTime.Properties.Appearance.Options.UseBackColor = True
        Me.fldDateTime.Properties.Appearance.Options.UseFont = True
        Me.fldDateTime.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.fldDateTime.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.fldDateTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fldDateTime.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic
        Me.fldDateTime.Properties.Mask.BeepOnError = True
        Me.fldDateTime.Properties.Mask.EditMask = ""
        Me.fldDateTime.Properties.NullDate = New Date(2012, 12, 21, 18, 15, 22, 0)
        Me.fldDateTime.Properties.NullValuePrompt = "Exchange Date and Time"
        Me.fldDateTime.Properties.NullValuePromptShowForEmptyValue = True
        Me.fldDateTime.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.fldDateTime.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.fldDateTime.Properties.ShowWeekNumbers = True
        Me.fldDateTime.Properties.ValidateOnEnterKey = True
        Me.fldDateTime.Properties.VistaCalendarViewStyle = CType(((((DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView Or DevExpress.XtraEditors.VistaCalendarViewStyle.YearView) _
            Or DevExpress.XtraEditors.VistaCalendarViewStyle.QuarterView) _
            Or DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView) _
            Or DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView), DevExpress.XtraEditors.VistaCalendarViewStyle)
        Me.fldDateTime.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldDateTime.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[True]
        Me.fldDateTime.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fldDateTime.Size = New System.Drawing.Size(217, 24)
        Me.fldDateTime.TabIndex = 8
        '
        'PageNavigator1
        '
        Me.PageNavigator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.PageNavigator1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PageNavigator1.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PageNavigator1.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.PageNavigator1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PageNavigator1.Location = New System.Drawing.Point(0, 357)
        Me.PageNavigator1.Name = "PageNavigator1"
        Me.PageNavigator1.NextPageTooltip = "Go to next page"
        Me.PageNavigator1.PreviousPageTooltip = "Go to previous page"
        Me.PageNavigator1.Size = New System.Drawing.Size(932, 17)
        Me.PageNavigator1.TabIndex = 8
        Me.PageNavigator1.Text = "PageNavigator1"
        Me.PageNavigator1.TodayTooltip = "Go to first page"
        '
        'AddNewExchangeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PageNavigator1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.PageSlider1)
        Me.Name = "AddNewExchangeControl"
        Me.Size = New System.Drawing.Size(932, 430)
        Me.PageSlider1.ResumeLayout(False)
        Me.PageSliderPage1.ResumeLayout(False)
        CType(Me.fldRecipient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldExchangeName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageSliderPage2.ResumeLayout(False)
        CType(Me.fldAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageSliderPage3.ResumeLayout(False)
        CType(Me.fldDateTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDateTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOK As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PageSlider1 As DevComponents.DotNetBar.Controls.PageSlider
    Friend WithEvents PageSliderPage1 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents fldRecipient As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents fldSource As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents fldExchangeName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblSource As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblExchangeName As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PageSliderPage2 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents lblAmount As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents fldAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PageSliderPage3 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents lblDate As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents fldDateTime As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PageNavigator1 As DevComponents.DotNetBar.Controls.PageNavigator

End Class
