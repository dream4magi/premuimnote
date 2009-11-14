<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoteList
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
        Me.lvw = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnNoteDone = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvw.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvw.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw.FullRowSelect = True
        Me.lvw.GridLines = True
        Me.lvw.HideSelection = False
        Me.lvw.Location = New System.Drawing.Point(0, 147)
        Me.lvw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvw.Name = "lvw"
        Me.lvw.ShowGroups = False
        Me.lvw.Size = New System.Drawing.Size(595, 399)
        Me.lvw.TabIndex = 1
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "No"
        Me.ColumnHeader5.Width = 40
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Title"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Content"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Added Time"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Piority"
        Me.ColumnHeader4.Width = 45
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Alerm"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Alerm Time"
        Me.ColumnHeader7.Width = 81
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(0, 79)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 28)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNoteDone
        '
        Me.btnNoteDone.Location = New System.Drawing.Point(0, 32)
        Me.btnNoteDone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNoteDone.Name = "btnNoteDone"
        Me.btnNoteDone.Size = New System.Drawing.Size(87, 28)
        Me.btnNoteDone.TabIndex = 2
        Me.btnNoteDone.Text = "Note Done"
        Me.btnNoteDone.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(267, 32)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 28)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'frmNoteList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Premium_Note.My.Resources.Resources.form_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(595, 546)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNoteDone)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lvw)
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmNoteList"
        Me.ShowInTaskbar = False
        Me.Text = "Note List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvw As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNoteDone As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
