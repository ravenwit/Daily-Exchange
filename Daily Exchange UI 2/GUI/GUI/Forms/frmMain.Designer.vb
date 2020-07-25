Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits XtraForm

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
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GalleryControlGallery1 = New DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.WindowsUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
        Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.Document2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.Document3 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.document1Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.document2Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.document3Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.TileContainer1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(Me.components)
        Me.PageGroup1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WindowsUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.document1Tile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.document2Tile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.document3Tile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis Dark"
        '
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.View = Me.WindowsUIView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.WindowsUIView1})
        '
        'WindowsUIView1
        '
        Me.WindowsUIView1.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() {Me.TileContainer1, Me.PageGroup1})
        Me.WindowsUIView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document1, Me.Document2, Me.Document3})
        Me.WindowsUIView1.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.document1Tile, Me.document2Tile, Me.document3Tile})
        '
        'Document1
        '
        Me.Document1.Caption = "document1"
        Me.Document1.ControlName = "document1"
        '
        'Document2
        '
        Me.Document2.Caption = "document2"
        Me.Document2.ControlName = "document2"
        '
        'Document3
        '
        Me.Document3.Caption = "document3"
        Me.Document3.ControlName = "document3"
        '
        'document1Tile
        '
        Me.document1Tile.Document = Me.Document1
        Me.document1Tile.Group = ""
        Me.document1Tile.Name = "document1Tile"
        '
        'document2Tile
        '
        Me.document2Tile.Document = Me.Document2
        Me.document2Tile.Group = ""
        Me.TileContainer1.SetID(Me.document2Tile, 1)
        Me.document2Tile.Name = "document2Tile"
        '
        'document3Tile
        '
        Me.document3Tile.Document = Me.Document3
        Me.document3Tile.Group = ""
        Me.TileContainer1.SetID(Me.document3Tile, 2)
        Me.document3Tile.Name = "document3Tile"
        '
        'TileContainer1
        '
        Me.TileContainer1.ActivationTarget = Me.PageGroup1
        Me.TileContainer1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.document2Tile, Me.document3Tile, Me.document1Tile})
        Me.TileContainer1.Name = "TileContainer1"
        '
        'PageGroup1
        '
        Me.PageGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document() {Me.Document1, Me.Document2, Me.Document3})
        Me.PageGroup1.Name = "PageGroup1"
        Me.PageGroup1.Parent = Me.TileContainer1
        '
        'frmMain
        '
        Me.Appearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.Appearance.Options.UseBorderColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 453)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.Text = "Daily Exchange"
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WindowsUIView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.document1Tile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.document2Tile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.document3Tile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GalleryControlGallery1 As DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents WindowsUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
    Friend WithEvents TileContainer1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer
    Friend WithEvents PageGroup1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
    Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents Document2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents Document3 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents document2Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents document3Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents document1Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

End Class
