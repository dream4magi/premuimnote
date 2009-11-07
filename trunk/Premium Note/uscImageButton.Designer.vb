<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscImageButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.picButton = New System.Windows.Forms.PictureBox
        CType(Me.picButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picButton
        '
        Me.picButton.BackColor = System.Drawing.Color.Transparent
        Me.picButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picButton.Location = New System.Drawing.Point(0, 0)
        Me.picButton.Margin = New System.Windows.Forms.Padding(0)
        Me.picButton.Name = "picButton"
        Me.picButton.Size = New System.Drawing.Size(100, 50)
        Me.picButton.TabIndex = 0
        Me.picButton.TabStop = False
        '
        'uscImageButton
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.picButton)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "uscImageButton"
        Me.size = New System.Drawing.Size(100, 50)
        CType(Me.picButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picButton As System.Windows.Forms.PictureBox

End Class
