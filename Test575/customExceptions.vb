Public Class customExceptions
    Inherits ApplicationException

    Public Sub customExceptions()
        MessageBox.Show("An exception occured")
    End Sub

    Public Sub incorrectFilenameFormatException()
        MessageBox.Show("Please refrain from using '.', '_' and '*' in your company/file name and make sure all required feilds are filled in")
    End Sub
End Class
