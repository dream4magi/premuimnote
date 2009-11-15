<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoteDetailTemplate
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
        Me.chkTop = New System.Windows.Forms.CheckBox
        Me.lblContent = New System.Windows.Forms.Label
        Me.line = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnDone = New Premium_Note.uscImageButton
        Me.btnDelete = New Premium_Note.uscImageButton
        Me.btnEdit = New Premium_Note.uscImageButton
        Me.btnMin = New Premium_Note.uscImageButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.panNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'panNote
        '
        Me.panNote.BackgroundImage = Global.Premium_Note.My.Resources.Resources.noteColor0
        Me.panNote.Controls.Add(Me.chkTop)
        Me.panNote.Controls.Add(Me.lblContent)
        Me.panNote.Controls.Add(Me.line)
        Me.panNote.Controls.Add(Me.lblTitle)
        Me.panNote.Controls.Add(Me.btnDone)
        Me.panNote.Controls.Add(Me.btnDelete)
        Me.panNote.Controls.Add(Me.btnEdit)
        Me.panNote.Controls.Add(Me.btnMin)
        Me.panNote.Location = New System.Drawing.Point(0, 0)
        Me.panNote.Name = "panNote"
        Me.panNote.Size = New System.Drawing.Size(174, 179)
        Me.panNote.TabIndex = 0
        '
        'chkTop
        '
        Me.chkTop.AutoSize = True
        Me.chkTop.BackColor = System.Drawing.Color.Transparent
        Me.chkTop.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTop.Location = New System.Drawing.Point(77, 160)
        Me.chkTop.Name = "chkTop"
        Me.chkTop.Size = New System.Drawing.Size(77, 19)
        Me.chkTop.TabIndex = 6
        Me.chkTop.Text = "Stay on Top"
        Me.chkTop.UseVisualStyleBackColor = False
        '
        'lblContent
        '
        Me.lblContent.BackColor = System.Drawing.Color.Transparent
        Me.lblContent.Location = New System.Drawing.Point(7, 27)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(160, 134)
        Me.lblContent.TabIndex = 1
        Me.lblContent.Text = "Label1"
        '
        'line
        '
        Me.line.BackColor = System.Drawing.Color.Gray
        Me.line.Location = New System.Drawing.Point(7, 22)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(160, 1)
        Me.line.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Location = New System.Drawing.Point(4, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(166, 18)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Label2"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDone
        '
        Me.btnDone.AutoSize = True
        Me.btnDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDone.HoverImage = Global.Premium_Note.My.Resources.Resources.done_hover
        Me.btnDone.Location = New System.Drawing.Point(9, 164)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.PressedImage = Global.Premium_Note.My.Resources.Resources.done
        Me.btnDone.RegularImage = Global.Premium_Note.My.Resources.Resources.done
        Me.btnDone.Size = New System.Drawing.Size(11, 11)
        Me.btnDone.TabIndex = 2
        Me.btnDone.ToolTipMe = "Done!"
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.HoverImage = Global.Premium_Note.My.Resources.Resources.delete_hover
        Me.btnDelete.Location = New System.Drawing.Point(26, 164)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PressedImage = Global.Premium_Note.My.Resources.Resources.delete
        Me.btnDelete.RegularImage = Global.Premium_Note.My.Resources.Resources.delete
        Me.btnDelete.Size = New System.Drawing.Size(11, 11)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.ToolTipMe = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.HoverImage = Global.Premium_Note.My.Resources.Resources.edit_hover
        Me.btnEdit.Location = New System.Drawing.Point(43, 164)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PressedImage = Global.Premium_Note.My.Resources.Resources.edit
        Me.btnEdit.RegularImage = Global.Premium_Note.My.Resources.Resources.edit
        Me.btnEdit.Size = New System.Drawing.Size(11, 11)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.ToolTipMe = "Edit"
        '
        'btnMin
        '
        Me.btnMin.AutoSize = True
        Me.btnMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.HoverImage = Global.Premium_Note.My.Resources.Resources.min_hover
        Me.btnMin.Location = New System.Drawing.Point(59, 164)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.PressedImage = Global.Premium_Note.My.Resources.Resources.min
        Me.btnMin.RegularImage = Global.Premium_Note.My.Resources.Resources.min
        Me.btnMin.Size = New System.Drawing.Size(11, 11)
        Me.btnMin.TabIndex = 5
        Me.btnMin.ToolTipMe = "Edge Tab"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 400
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 400
        Me.ToolTip1.ReshowDelay = 80
        Me.ToolTip1.ShowAlways = True
        '
        'frmNoteDetailTemplate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(174, 179)
        Me.Controls.Add(Me.panNote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNoteDetailTemplate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmNoteTemplate"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.panNote.ResumeLayout(False)
        Me.panNote.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panNote As System.Windows.Forms.Panel
    Friend WithEvents btnMin As Premium_Note.uscImageButton
    Friend WithEvents line As System.Windows.Forms.Panel
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents btnDone As Premium_Note.uscImageButton
    Friend WithEvents btnDelete As Premium_Note.uscImageButton
    Friend WithEvents btnEdit As Premium_Note.uscImageButton
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents chkTop As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
