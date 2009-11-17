<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoteTemplate
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
        Me.components = New System.ComponentModel.Container
        Me.panNote = New System.Windows.Forms.Panel
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetailLookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoHideOnOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ThisNoteIsDONEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ArrangeTabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ArrangesTabsByColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnNoteDone = New Premium_Note.uscImageButton
        Me.btnAutoHide = New Premium_Note.uscImageButton
        Me.ArrangeTabsByAutoHideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.panNote.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panNote
        '
        Me.panNote.BackgroundImage = Global.Premium_Note.My.Resources.Resources.tabColor0
        Me.panNote.ContextMenuStrip = Me.ContextMenuStrip1
        Me.panNote.Controls.Add(Me.btnNoteDone)
        Me.panNote.Controls.Add(Me.btnAutoHide)
        Me.panNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panNote.Location = New System.Drawing.Point(0, 0)
        Me.panNote.Margin = New System.Windows.Forms.Padding(0)
        Me.panNote.Name = "panNote"
        Me.panNote.Size = New System.Drawing.Size(23, 62)
        Me.panNote.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailLookToolStripMenuItem, Me.AutoHideOnOffToolStripMenuItem, Me.ToolStripMenuItem1, Me.ThisNoteIsDONEToolStripMenuItem, Me.AddNotToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem2, Me.ArrangeTabsToolStripMenuItem, Me.ArrangesTabsByColorToolStripMenuItem, Me.ArrangeTabsByAutoHideToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(225, 236)
        '
        'DetailLookToolStripMenuItem
        '
        Me.DetailLookToolStripMenuItem.Name = "DetailLookToolStripMenuItem"
        Me.DetailLookToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.DetailLookToolStripMenuItem.Text = "Detail Look"
        '
        'AutoHideOnOffToolStripMenuItem
        '
        Me.AutoHideOnOffToolStripMenuItem.Checked = True
        Me.AutoHideOnOffToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoHideOnOffToolStripMenuItem.Name = "AutoHideOnOffToolStripMenuItem"
        Me.AutoHideOnOffToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.AutoHideOnOffToolStripMenuItem.Text = "Auto Hide"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        'ThisNoteIsDONEToolStripMenuItem
        '
        Me.ThisNoteIsDONEToolStripMenuItem.Name = "ThisNoteIsDONEToolStripMenuItem"
        Me.ThisNoteIsDONEToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ThisNoteIsDONEToolStripMenuItem.Text = "This Note Is DONE!"
        '
        'AddNotToolStripMenuItem
        '
        Me.AddNotToolStripMenuItem.Name = "AddNotToolStripMenuItem"
        Me.AddNotToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.AddNotToolStripMenuItem.Text = "Add New Note"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(221, 6)
        '
        'ArrangeTabsToolStripMenuItem
        '
        Me.ArrangeTabsToolStripMenuItem.Name = "ArrangeTabsToolStripMenuItem"
        Me.ArrangeTabsToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ArrangeTabsToolStripMenuItem.Text = "Arrange Tabs"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 300
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 60
        '
        'ArrangesTabsByColorToolStripMenuItem
        '
        Me.ArrangesTabsByColorToolStripMenuItem.Name = "ArrangesTabsByColorToolStripMenuItem"
        Me.ArrangesTabsByColorToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ArrangesTabsByColorToolStripMenuItem.Text = "Arranges Tabs By Color"
        '
        'btnNoteDone
        '
        Me.btnNoteDone.AutoSize = True
        Me.btnNoteDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNoteDone.BackColor = System.Drawing.Color.Transparent
        Me.btnNoteDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoteDone.HoverImage = Global.Premium_Note.My.Resources.Resources.done_hover
        Me.btnNoteDone.Location = New System.Drawing.Point(0, 0)
        Me.btnNoteDone.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNoteDone.Name = "btnNoteDone"
        Me.btnNoteDone.PressedImage = Global.Premium_Note.My.Resources.Resources.done
        Me.btnNoteDone.RegularImage = Global.Premium_Note.My.Resources.Resources.done
        Me.btnNoteDone.Size = New System.Drawing.Size(11, 11)
        Me.btnNoteDone.TabIndex = 0
        Me.btnNoteDone.ToolTipMe = "Done!"
        '
        'btnAutoHide
        '
        Me.btnAutoHide.AutoSize = True
        Me.btnAutoHide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAutoHide.BackColor = System.Drawing.Color.Transparent
        Me.btnAutoHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutoHide.HoverImage = Global.Premium_Note.My.Resources.Resources.AutoHide_hover
        Me.btnAutoHide.Location = New System.Drawing.Point(11, 0)
        Me.btnAutoHide.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAutoHide.Name = "btnAutoHide"
        Me.btnAutoHide.PressedImage = Global.Premium_Note.My.Resources.Resources.AutoHide
        Me.btnAutoHide.RegularImage = Global.Premium_Note.My.Resources.Resources.AutoHide
        Me.btnAutoHide.Size = New System.Drawing.Size(11, 11)
        Me.btnAutoHide.TabIndex = 1
        Me.btnAutoHide.ToolTipMe = "Auto Hide"
        '
        'ArrangeTabsByAutoHideToolStripMenuItem
        '
        Me.ArrangeTabsByAutoHideToolStripMenuItem.Name = "ArrangeTabsByAutoHideToolStripMenuItem"
        Me.ArrangeTabsByAutoHideToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ArrangeTabsByAutoHideToolStripMenuItem.Text = "Arrange Tabs By AutoHide"
        '
        'frmNoteTemplate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(23, 62)
        Me.Controls.Add(Me.panNote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNoteTemplate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmNoteTemplate"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.panNote.ResumeLayout(False)
        Me.panNote.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panNote As System.Windows.Forms.Panel
    Friend WithEvents btnNoteDone As Premium_Note.uscImageButton
    Friend WithEvents btnAutoHide As Premium_Note.uscImageButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DetailLookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoHideOnOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ThisNoteIsDONEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ArrangeTabsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangesTabsByColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeTabsByAutoHideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
