Option Strict On
Option Explicit On
Public Class frmAddNote

    Private Sub frmAddNote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chk_time_pic()

        cboPiority.Text = "Normal"
    End Sub

    Private Sub chkAlerm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlerm.CheckedChanged
        chk_time_pic()

    End Sub




    Sub chk_time_pic()
        Me.DateTimePicker1.Enabled = Me.chkAlerm.Checked
        Me.picAlerm.Visible = Me.chkAlerm.Checked
    End Sub




#Region "Color Selection"
    Sub resetPanColorBackcolor()
        panColor0.BackColor = System.Drawing.SystemColors.Control
        panColor1.BackColor = System.Drawing.SystemColors.Control
        panColor2.BackColor = System.Drawing.SystemColors.Control
        panColor3.BackColor = System.Drawing.SystemColors.Control
        panColor4.BackColor = System.Drawing.SystemColors.Control
    End Sub
    Private Sub picColor0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picColor0.Click
        resetPanColorBackcolor()
        panColor0.BackColor = System.Drawing.SystemColors.ControlDarkDark
    End Sub
    Private Sub picColor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picColor1.Click
        resetPanColorBackcolor()
        panColor1.BackColor = System.Drawing.SystemColors.ControlDarkDark
    End Sub
    Private Sub picColor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picColor2.Click
        resetPanColorBackcolor()
        panColor2.BackColor = System.Drawing.SystemColors.ControlDarkDark
    End Sub
    Private Sub picColor3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picColor3.Click
        resetPanColorBackcolor()
        panColor3.BackColor = System.Drawing.SystemColors.ControlDarkDark
    End Sub
    Private Sub picColor4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picColor4.Click
        resetPanColorBackcolor()
        panColor4.BackColor = System.Drawing.SystemColors.ControlDarkDark
    End Sub
    Function getSelectedColorNum() As Integer
        If panColor0.BackColor = System.Drawing.SystemColors.ControlDarkDark Then
            Return 0
        ElseIf panColor1.BackColor = System.Drawing.SystemColors.ControlDarkDark Then
            Return 1
        ElseIf panColor2.BackColor = System.Drawing.SystemColors.ControlDarkDark Then
            Return 2
        ElseIf panColor3.BackColor = System.Drawing.SystemColors.ControlDarkDark Then
            Return 3
        ElseIf panColor4.BackColor = System.Drawing.SystemColors.ControlDarkDark Then
            Return 4
        Else
            Return -1
        End If

    End Function
#End Region

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        T.createNewNoteDetailPaper( _
            T.addNote(txtTitle.Text, txtContent.Text, IIf(chkAlerm.Checked, "Y", "N").ToString, IIf(chkAlerm.Checked, DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm"), "").ToString, cboPiority.Text, getSelectedColorNum.ToString) _
        )

        T.saveDataFile()

        Me.Close()
    End Sub

End Class