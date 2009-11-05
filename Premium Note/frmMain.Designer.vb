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
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitPremiumNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.StartWithSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TaskIconMenu.SuspendLayout()
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
        Me.TaskIconMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.HideToolStripMenuItem, Me.StartWithSystemToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitPremiumNoteToolStripMenuItem})
        Me.TaskIconMenu.Name = "TaskIconMenu"
        Me.TaskIconMenu.Size = New System.Drawing.Size(182, 120)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'ExitPremiumNoteToolStripMenuItem
        '
        Me.ExitPremiumNoteToolStripMenuItem.Name = "ExitPremiumNoteToolStripMenuItem"
        Me.ExitPremiumNoteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExitPremiumNoteToolStripMenuItem.Text = "Exit Premium Note"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Premium_Note.My.Resources.Resources.add
        Me.Button1.Location = New System.Drawing.Point(142, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "New &Note"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StartWithSystemToolStripMenuItem
        '
        Me.StartWithSystemToolStripMenuItem.CheckOnClick = True
        Me.StartWithSystemToolStripMenuItem.Name = "StartWithSystemToolStripMenuItem"
        Me.StartWithSystemToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.StartWithSystemToolStripMenuItem.Text = "Start With System"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Opacity = 0.9
        Me.ShowIcon = False
        Me.Text = "Premium Note 1.0 by Spike"
        Me.TaskIconMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TaskIconMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitPremiumNoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartWithSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem


End Class
