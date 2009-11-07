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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UscImageButton4 = New Premium_Note.uscImageButton
        Me.UscImageButton3 = New Premium_Note.uscImageButton
        Me.UscImageButton2 = New Premium_Note.uscImageButton
        Me.UscImageButton1 = New Premium_Note.uscImageButton
        Me.UscImageButton5 = New Premium_Note.uscImageButton
        Me.UscImageButton6 = New Premium_Note.uscImageButton
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Premium_Note.My.Resources.Resources.tabColor0
        Me.Panel1.Controls.Add(Me.UscImageButton5)
        Me.Panel1.Controls.Add(Me.UscImageButton6)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(62, 23)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Premium_Note.My.Resources.Resources.noteColor0
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.UscImageButton4)
        Me.Panel2.Controls.Add(Me.UscImageButton3)
        Me.Panel2.Controls.Add(Me.UscImageButton2)
        Me.Panel2.Controls.Add(Me.UscImageButton1)
        Me.Panel2.Location = New System.Drawing.Point(58, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(174, 179)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(7, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 1)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 134)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'UscImageButton4
        '
        Me.UscImageButton4.AutoSize = True
        Me.UscImageButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UscImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.UscImageButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UscImageButton4.HoverImage = Global.Premium_Note.My.Resources.Resources.done_hover
        Me.UscImageButton4.Location = New System.Drawing.Point(9, 164)
        Me.UscImageButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.UscImageButton4.Name = "UscImageButton4"
        Me.UscImageButton4.PressedImage = Global.Premium_Note.My.Resources.Resources.done
        Me.UscImageButton4.RegularImage = Global.Premium_Note.My.Resources.Resources.done
        Me.UscImageButton4.size = New System.Drawing.Size(11, 11)
        Me.UscImageButton4.TabIndex = 1
        '
        'UscImageButton3
        '
        Me.UscImageButton3.AutoSize = True
        Me.UscImageButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UscImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.UscImageButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UscImageButton3.HoverImage = Global.Premium_Note.My.Resources.Resources.delete_hover
        Me.UscImageButton3.Location = New System.Drawing.Point(26, 164)
        Me.UscImageButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.UscImageButton3.Name = "UscImageButton3"
        Me.UscImageButton3.PressedImage = Global.Premium_Note.My.Resources.Resources.delete
        Me.UscImageButton3.RegularImage = Global.Premium_Note.My.Resources.Resources.delete
        Me.UscImageButton3.size = New System.Drawing.Size(11, 11)
        Me.UscImageButton3.TabIndex = 1
        '
        'UscImageButton2
        '
        Me.UscImageButton2.AutoSize = True
        Me.UscImageButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UscImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.UscImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UscImageButton2.HoverImage = Global.Premium_Note.My.Resources.Resources.edit_hover
        Me.UscImageButton2.Location = New System.Drawing.Point(43, 164)
        Me.UscImageButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.UscImageButton2.Name = "UscImageButton2"
        Me.UscImageButton2.PressedImage = Global.Premium_Note.My.Resources.Resources.edit
        Me.UscImageButton2.RegularImage = Global.Premium_Note.My.Resources.Resources.edit
        Me.UscImageButton2.size = New System.Drawing.Size(11, 11)
        Me.UscImageButton2.TabIndex = 1
        '
        'UscImageButton1
        '
        Me.UscImageButton1.AutoSize = True
        Me.UscImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UscImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.UscImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UscImageButton1.HoverImage = Global.Premium_Note.My.Resources.Resources.min_hover
        Me.UscImageButton1.Location = New System.Drawing.Point(59, 164)
        Me.UscImageButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.UscImageButton1.Name = "UscImageButton1"
        Me.UscImageButton1.PressedImage = Global.Premium_Note.My.Resources.Resources.min
        Me.UscImageButton1.RegularImage = Global.Premium_Note.My.Resources.Resources.min
        Me.UscImageButton1.size = New System.Drawing.Size(11, 11)
        Me.UscImageButton1.TabIndex = 1
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
        Me.UscImageButton5.size = New System.Drawing.Size(11, 11)
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
        Me.UscImageButton6.size = New System.Drawing.Size(11, 11)
        Me.UscImageButton6.TabIndex = 1
        '
        'frmNoteTemplate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(244, 237)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNoteTemplate"
        Me.Text = "frmNoteTemplate"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UscImageButton1 As Premium_Note.uscImageButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UscImageButton4 As Premium_Note.uscImageButton
    Friend WithEvents UscImageButton3 As Premium_Note.uscImageButton
    Friend WithEvents UscImageButton2 As Premium_Note.uscImageButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UscImageButton5 As Premium_Note.uscImageButton
    Friend WithEvents UscImageButton6 As Premium_Note.uscImageButton
End Class
