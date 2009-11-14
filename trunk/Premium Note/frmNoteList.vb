Option Strict On
Option Explicit On
Public Class frmNoteList


    Dim strLvwColname() As String = "no,title,content,add_time,piority,alerm,alem_time".Split(","c)


    Private Sub frmNoteList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadLvw()
    End Sub


    Public Sub loadLvw()
        lvw.Items.Clear()
        For Each obj As clsAllNotes.clsNoteData In aryALL_NOTES
            Dim lvwItem As New ListViewItem
            Dim item(strLvwColname.Length - 1) As String
            item(T.getLvwColnumByName(strLvwColname, "no")) = obj.note_no
            item(T.getLvwColnumByName(strLvwColname, "title")) = obj.note_title
            item(T.getLvwColnumByName(strLvwColname, "content")) = obj.note_content
            item(T.getLvwColnumByName(strLvwColname, "add_time")) = obj.note_create_time
            item(T.getLvwColnumByName(strLvwColname, "piority")) = obj.note_piority
            item(T.getLvwColnumByName(strLvwColname, "alerm")) = obj.note_alerm_enable
            item(T.getLvwColnumByName(strLvwColname, "alem_time")) = obj.note_alerm_time

            lvwItem.Text = item(0)

            For i As Integer = 1 To item.Length - 1
                lvwItem.SubItems.Add(item(i))
            Next
            lvwItem.BackColor = mdlVariable.NoteColor(T.getNoteColorNum(obj))
            lvw.Items.Add(lvwItem)
        Next
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lvw.SelectedItems.Count > 0 Then
            If MsgBox("This will delete the Note forever," & vbCrLf & "Continue ?", MsgBoxStyle.YesNo, "Please Confirm.") = MsgBoxResult.Yes Then
                For i As Integer = 0 To lvw.SelectedItems.Count - 1
                    T.deleteNote(lvw.SelectedItems(i).SubItems(T.getLvwColnumByName(strLvwColname, "no")).Text)
                Next

            End If
            T.noteDataChanged()
        End If
    End Sub

    Private Sub btnNoteDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoteDone.Click
        If lvw.SelectedItems.Count > 0 Then
            If MsgBox("Note Done ?", MsgBoxStyle.YesNo, "Please Confirm.") = MsgBoxResult.Yes Then
                For i As Integer = 0 To lvw.SelectedItems.Count - 1
                    T.doneNote(lvw.SelectedItems(i).SubItems(T.getLvwColnumByName(strLvwColname, "no")).Text)
                Next
            End If
            T.noteDataChanged()
        End If
    End Sub

    Private Sub lvw_ItemMouseHover(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemMouseHoverEventArgs) Handles lvw.ItemMouseHover
        Dim str As String
        str = e.Item.SubItems(T.getLvwColnumByName(strLvwColname, "title")).Text & vbCrLf _
            & e.Item.SubItems(T.getLvwColnumByName(strLvwColname, "content")).Text
        Me.ToolTip1.SetToolTip(Me.lvw, str)
    End Sub

    Private Sub lvw_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvw.MouseDoubleClick
        If lvw.GetItemAt(e.X, e.Y) IsNot Nothing Then
            showNote(lvw.GetItemAt(e.X, e.Y).SubItems(T.getLvwColnumByName(strLvwColname, "no")).Text)
        End If
    End Sub

   


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If lvw.SelectedItems.Count = 1 Then

        End If
    End Sub
End Class