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
        Me.btnNoteDone = New Premium_Note.uscImageButton
        Me.btnChangeMode = New Premium_Note.uscImageButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.panNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'panNote
        '
        Me.panNote.BackgroundImage = Global.Premium_Note.My.Resources.Resources.tabColor0
        Me.panNote.Controls.Add(Me.btnNoteDone)
        Me.panNote.Controls.Add(Me.btnChangeMode)
        Me.panNote.Location = New System.Drawing.Point(0, 0)
        Me.panNote.Margin = New System.Windows.Forms.Padding(0)
        Me.panNote.Name = "panNote"
        Me.panNote.Size = New System.Drawing.Size(23, 62)
        Me.panNote.TabIndex = 0
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
        Me.ToolTip1.SetToolTip(Me.btnNoteDone, "Done!")
        Me.btnNoteDone.ToolTip = ""
        '
        'btnChangeMode
        '
        Me.btnChangeMode.AutoSize = True
        Me.btnChangeMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChangeMode.BackColor = System.Drawing.Color.Transparent
        Me.btnChangeMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeMode.HoverImage = Global.Premium_Note.My.Resources.Resources.max_hover
        Me.btnChangeMode.Location = New System.Drawing.Point(11, 0)
        Me.btnChangeMode.Margin = New System.Windows.Forms.Padding(0)
        Me.btnChangeMode.Name = "btnChangeMode"
        Me.btnChangeMode.PressedImage = Global.Premium_Note.My.Resources.Resources.max
        Me.btnChangeMode.RegularImage = Global.Premium_Note.My.Resources.Resources.max
        Me.btnChangeMode.Size = New System.Drawing.Size(11, 11)
        Me.btnChangeMode.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnChangeMode, "Detail Mode")
        Me.btnChangeMode.ToolTip = ""
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 300
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 60
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panNote As System.Windows.Forms.Panel
    Friend WithEvents btnNoteDone As Premium_Note.uscImageButton
    Friend WithEvents btnChangeMode As Premium_Note.uscImageButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
