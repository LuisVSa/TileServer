Public Interface IServer

    ReadOnly Property ImageType() As String
    ReadOnly Property ServerName() As String
    ReadOnly Property MaximumZoom() As Integer
    Function DownloadTile(ByVal X As Integer, ByVal Y As Integer, ByVal Zoom As Integer, ByVal Filename As String) As Boolean

End Interface
