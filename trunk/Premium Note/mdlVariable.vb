Option Strict On
Option Explicit On
Public Class clsAllNotes
    Public Notes() As clsNoteData

    Public current_note_no As String
    Public Class clsNoteData
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

End Class

Module mdlVariable

    Public NoteColor(4) As Color
    Public aryALL_NOTES As New List(Of clsAllNotes.clsNoteData)

    Sub initialNoteColor()
        NoteColor(0) = System.Drawing.Color.FromArgb(255, 230, 62)
        NoteColor(1) = System.Drawing.Color.FromArgb(181, 228, 97)
        NoteColor(2) = System.Drawing.Color.FromArgb(251, 188, 188)
        NoteColor(3) = System.Drawing.Color.FromArgb(183, 234, 253)
        NoteColor(4) = System.Drawing.Color.FromArgb(233, 183, 253)
    End Sub
End Module
