Public Class Enemy

    Private eIdVal As Integer
    Public Property eID() As Integer
        Get
            Return eIdVal
        End Get
        Set(ByVal value As Integer)
            eIdVal = value
        End Set
    End Property

    Private eNameVal As String
    Public Property EName() As String
        Get
            Return eNameVal
        End Get
        Set(ByVal value As String)
            eNameVal = value
        End Set
    End Property

    Private eHpVal As Integer
    Public Property EHp() As Integer
        Get
            Return eHpVal
        End Get
        Set(ByVal value As Integer)
            eHpVal = value
        End Set
    End Property

    Private eStrongVal As Integer
    Public Property eStrong() As Integer
        Get
            Return eStrongVal
        End Get
        Set(ByVal value As Integer)
            eStrongVal = value
        End Set
    End Property

    Private eFastVal As Integer
    Public Property eFast() As Integer
        Get
            Return eFastVal
        End Get
        Set(ByVal value As Integer)
            eFastVal = value
        End Set
    End Property

    Private healingval As Integer
    Public Property healing() As Integer
        Get
            Return healingval
        End Get
        Set(ByVal value As Integer)
            healingval = value
        End Set
    End Property

End Class
