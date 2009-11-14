<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TaskIconMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartWithSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitPremiumNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnAddNote = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tlblNoteNo = New System.Windows.Forms.ToolStripStatusLabel
        Me.tlblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnSetting = New System.Windows.Forms.Button
        Me.btnRecord = New System.Windows.Forms.Button
        Me.btnNoteList = New System.Windows.Forms.Button
        Me.btnAbout = New System.Windows.Forms.LinkLabel
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAlermCheck = New System.Windows.Forms.Timer(Me.components)
        Me.TaskIconMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.TaskIconMenu
        Me.NotifyIcon1.Icon = Global.Premium_Note.My.Resources.Resources.Blender
        Me.NotifyIcon1.Text = "Premium Not"
        Me.NotifyIcon1.Visible = True
        '
        'TaskIconMenu
        '
        Me.TaskIconMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.AddNewNoteToolStripMenuItem, Me.StartWithSystemToolStripMenuItem, Me.ToolStripMenuItem1, Me.HideToolStripMenuItem, Me.ExitPremiumNoteToolStripMenuItem})
        Me.TaskIconMenu.Name = "TaskIconMenu"
        Me.TaskIconMenu.Size = New System.Drawing.Size(182, 120)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'AddNewNoteToolStripMenuItem
        '
        Me.AddNewNoteToolStripMenuItem.Name = "AddNewNoteToolStripMenuItem"
        Me.AddNewNoteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AddNewNoteToolStripMenuItem.Text = "Add New Note"
        '
        'StartWithSystemToolStripMenuItem
        '
        Me.StartWithSystemToolStripMenuItem.CheckOnClick = True
        Me.StartWithSystemToolStripMenuItem.Name = "StartWithSystemToolStripMenuItem"
        Me.StartWithSystemToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.StartWithSystemToolStripMenuItem.Text = "Start With System"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ExitPremiumNoteToolStripMenuItem
        '
        Me.ExitPremiumNoteToolStripMenuItem.Name = "ExitPremiumNoteToolStripMenuItem"
        Me.ExitPremiumNoteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExitPremiumNoteToolStripMenuItem.Text = "Exit Premium Note"
        '
        'btnAddNote
        '
        Me.btnAddNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNote.Image = Global.Premium_Note.My.Resources.Resources.add
        Me.btnAddNote.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddNote.Location = New System.Drawing.Point(32, 30)
        Me.btnAddNote.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(187, 45)
        Me.btnAddNote.TabIndex = 1
        Me.btnAddNote.Text = "New &Note"
        Me.btnAddNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNote.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlblNoteNo, Me.tlblStatus})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 242)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(255, 18)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tlblNoteNo
        '
        Me.tlblNoteNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlblNoteNo.Name = "tlblNoteNo"
        Me.tlblNoteNo.Size = New System.Drawing.Size(46, 14)
        Me.tlblNoteNo.Text = "note_no"
        '
        'tlblStatus
        '
        Me.tlblStatus.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tlblStatus.Name = "tlblStatus"
        Me.tlblStatus.Size = New System.Drawing.Size(0, 0)
        Me.tlblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSetting
        '
        Me.btnSetting.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSetting.Location = New System.Drawing.Point(124, 181)
        Me.btnSetting.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(95, 28)
        Me.btnSetting.TabIndex = 3
        Me.btnSetting.Text = "Setting"
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecord.Location = New System.Drawing.Point(124, 149)
        Me.btnRecord.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(95, 28)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Note History"
        Me.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnNoteList
        '
        Me.btnNoteList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnNoteList.Location = New System.Drawing.Point(32, 79)
        Me.btnNoteList.Name = "btnNoteList"
        Me.btnNoteList.Size = New System.Drawing.Size(187, 45)
        Me.btnNoteList.TabIndex = 5
        Me.btnNoteList.Text = "Note List"
        Me.btnNoteList.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.AutoSize = True
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.ForeColor = System.Drawing.Color.DimGray
        Me.btnAbout.LinkColor = System.Drawing.Color.DimGray
        Me.btnAbout.Location = New System.Drawing.Point(1, 224)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(35, 13)
        Me.btnAbout.TabIndex = 6
        Me.btnAbout.TabStop = True
        Me.btnAbout.Text = "About"
        Me.btnAbout.VisitedLinkColor = System.Drawing.Color.DimGray
        '
        'tmr
        '
        Me.tmr.Enabled = True
        Me.tmr.Interval = 1800000
        '
        'tmrAlermCheck
        '
        Me.tmrAlermCheck.Enabled = True
        Me.tmrAlermCheck.Interval = 25000
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Premium_Note.My.Resources.Resources.form_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(255, 260)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnNoteList)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.btnSetting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Opacity = 0.9
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Premium Note"
        Me.TaskIconMenu.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TaskIconMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitPremiumNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddNote As System.Windows.Forms.Button
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartWithSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tlblNoteNo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnNoteList As System.Windows.Forms.Button
    Friend WithEvents AddNewNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAbout As System.Windows.Forms.LinkLabel
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents tmrAlermCheck As System.Windows.Forms.Timer


End Class
