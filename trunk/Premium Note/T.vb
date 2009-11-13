Module T



    Function getLvwColnumByName(ByVal LvwColname() As String, ByVal keyword As String) As Integer
        For i As Integer = 0 To LvwColname.Length - 1
            If LvwColname(i).ToLower.Equals(keyword.ToLower) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Function getNoteColorNum(ByVal noteClass As clsAllNotes.clsNoteData) As Integer
        Select Case noteClass.note_color
            Case "0"
                Return 0
            Case "1"
                Return 1
            Case "2"
                Return 2
            Case "3"
                Return 3
            Case "4"
                Return 4
            Case Else
                Return 0
        End Select
    End Function

    Sub setNoteColor(ByVal noteClass As clsAllNotes.clsNoteData, ByVal colorNo As Integer)
        noteClass.note_color = colorNo.ToString
    End Sub

End Module
