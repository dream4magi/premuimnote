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
        Me.panNote = New System.Windows.Forms.Panel
        Me.UscImageButton5 = New Premium_Note.uscImageButton
        Me.UscImageButton6 = New Premium_Note.uscImageButton
        Me.panNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'panNote
        '
        Me.panNote.BackgroundImage = Global.Premium_Note.My.Resources.Resources.tabColor0
        Me.panNote.Controls.Add(Me.UscImageButton5)
        Me.panNote.Controls.Add(Me.UscImageButton6)
        Me.panNote.Location = New System.Drawing.Point(9, 9)
        Me.panNote.Margin = New System.Windows.Forms.Padding(0)
        Me.panNote.Name = "panNote"
        Me.panNote.Size = New System.Drawing.Size(62, 23)
        Me.panNote.TabIndex = 0
        '
        'UscImageButton5
        '
        Me.UscImageButton5.AutoSize = True
        Me.UscImageButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UscImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.UscImageButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UscImageButton5.HoverImage = Global.Premium_Note.My.Resources.Resources.done_hover
        Me.UscImageButton5.Location = New System.Drawing.Point(0, 0)
        Me.UscImageButton5.Margin = New System.Windows.Forms.Padding(0)
        Me.UscImageButton5.Name = "UscImageButton5"
        Me.UscImageButton5.PressedImage = Global.Premium_Note.My.Resources.Resources.done
        Me.UscImageButton5.RegularImage = Global.Premium_Note.My.Resources.Resources.done
        Me.UscImageButton5.Size = New System.Drawing.Size(11, 11)
        Me.UscImageButton5.TabIndex = 1
        '
        'UscImageButton6
        '
        Me.UscImageButton6.AutoSize = True
        Me.UscImageButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UscImageButton6.BackColor = System.Drawing.Color.Transparent
        Me.UscImageButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UscImageButton6.HoverImage = Global.Premium_Note.My.Resources.Resources.max_hover
        Me.UscImageButton6.Location = New System.Drawing.Point(0, 12)
        Me.UscImageButton6.Margin = New System.Windows.Forms.Padding(0)
        Me.UscImageButton6.Name = "UscImageButton6"
        Me.UscImageButton6.PressedImage = Global.Premium_Note.My.Resources.Resources.max
        Me.UscImageButton6.RegularImage = Global.Premium_Note.My.Resources.Resources.max
        Me.UscImageButton6.Size = New System.Drawing.Size(11, 11)
        Me.UscImageButton6.TabIndex = 1
        '
        'frmNoteTemplate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(244, 237)
        Me.Controls.Add(Me.panNote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNoteTemplate"
        Me.Text = "frmNoteTemplate"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.panNote.ResumeLayout(False)
        Me.panNote.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panNote As System.Windows.Forms.Panel
    Friend WithEvents UscImageButton5 As Premium_Note.uscImageButton
    Friend WithEvents UscImageButton6 As Premium_Note.uscImageButton
End Class
