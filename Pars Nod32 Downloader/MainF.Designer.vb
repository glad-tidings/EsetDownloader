<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainF
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainF))
        Me.URLList = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.URLListMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolbar = New System.Windows.Forms.ToolStrip()
        Me.StartDT = New System.Windows.Forms.ToolStripButton()
        Me.StopDT = New System.Windows.Forms.ToolStripButton()
        Me.DLTimer = New System.Windows.Forms.Timer(Me.components)
        Me.URLListMenu.SuspendLayout()
        Me.DownloadToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'URLList
        '
        Me.URLList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URLList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.URLList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9})
        Me.URLList.ContextMenuStrip = Me.URLListMenu
        Me.URLList.FullRowSelect = True
        Me.URLList.GridLines = True
        Me.URLList.Location = New System.Drawing.Point(0, 42)
        Me.URLList.Name = "URLList"
        Me.URLList.Size = New System.Drawing.Size(700, 360)
        Me.URLList.TabIndex = 0
        Me.URLList.UseCompatibleStateImageBehavior = False
        Me.URLList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.Width = 30
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Download Link"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Product Name"
        Me.ColumnHeader8.Width = 290
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Authorize"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Size"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Downloaded"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Transfer Rate"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Time Left"
        '
        'URLListMenu
        '
        Me.URLListMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddURLToolStripMenuItem, Me.EditURLToolStripMenuItem, Me.DeleteURLToolStripMenuItem})
        Me.URLListMenu.Name = "URLListMenu"
        Me.URLListMenu.Size = New System.Drawing.Size(132, 70)
        '
        'AddURLToolStripMenuItem
        '
        Me.AddURLToolStripMenuItem.Image = CType(resources.GetObject("AddURLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddURLToolStripMenuItem.Name = "AddURLToolStripMenuItem"
        Me.AddURLToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AddURLToolStripMenuItem.Text = "Add URL"
        '
        'EditURLToolStripMenuItem
        '
        Me.EditURLToolStripMenuItem.Image = CType(resources.GetObject("EditURLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditURLToolStripMenuItem.Name = "EditURLToolStripMenuItem"
        Me.EditURLToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EditURLToolStripMenuItem.Text = "Edit URL"
        '
        'DeleteURLToolStripMenuItem
        '
        Me.DeleteURLToolStripMenuItem.Image = CType(resources.GetObject("DeleteURLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteURLToolStripMenuItem.Name = "DeleteURLToolStripMenuItem"
        Me.DeleteURLToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DeleteURLToolStripMenuItem.Text = "Delete URL"
        '
        'DownloadToolbar
        '
        Me.DownloadToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DownloadToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartDT, Me.StopDT})
        Me.DownloadToolbar.Location = New System.Drawing.Point(0, 0)
        Me.DownloadToolbar.Name = "DownloadToolbar"
        Me.DownloadToolbar.Size = New System.Drawing.Size(700, 39)
        Me.DownloadToolbar.TabIndex = 1
        Me.DownloadToolbar.Text = "DownloadToolbar"
        '
        'StartDT
        '
        Me.StartDT.Image = CType(resources.GetObject("StartDT.Image"), System.Drawing.Image)
        Me.StartDT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StartDT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StartDT.Name = "StartDT"
        Me.StartDT.Size = New System.Drawing.Size(124, 36)
        Me.StartDT.Text = "Start Download"
        '
        'StopDT
        '
        Me.StopDT.Image = CType(resources.GetObject("StopDT.Image"), System.Drawing.Image)
        Me.StopDT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StopDT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StopDT.Name = "StopDT"
        Me.StopDT.Size = New System.Drawing.Size(124, 36)
        Me.StopDT.Text = "Stop Download"
        '
        'DLTimer
        '
        Me.DLTimer.Interval = 1000
        '
        'MainF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 403)
        Me.Controls.Add(Me.DownloadToolbar)
        Me.Controls.Add(Me.URLList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainF"
        Me.Text = "Pars Nod32 Downloader"
        Me.URLListMenu.ResumeLayout(False)
        Me.DownloadToolbar.ResumeLayout(False)
        Me.DownloadToolbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents URLList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DownloadToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents StartDT As System.Windows.Forms.ToolStripButton
    Friend WithEvents StopDT As System.Windows.Forms.ToolStripButton
    Friend WithEvents URLListMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DLTimer As System.Windows.Forms.Timer

End Class
