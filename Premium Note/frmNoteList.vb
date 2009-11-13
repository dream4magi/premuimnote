Option Strict On
Option Explicit On
Public Class frmNoteList


    Dim strLvwColname() As String = "no,title,content,add_time,piority,alerm,alem_time".Split(","c)


    Private Sub frmNoteList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadLvw()
    End Sub


    Public Sub loadLvw()
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





    Public note_no As String = ""

    Public note_title As String = ""
    Public note_content As String = ""

    Public note_create_time As String = ""
    Public note_done_time As String = ""


    Public note_alerm_enable As String = ""
    Public note_alerm_time As String = ""

    Public note_piority As String = ""
    Public blnNoteDetailmode As String = ""

    Public note_color As String = ""

    Public X As String = ""
    Public Y As String = ""


End Class