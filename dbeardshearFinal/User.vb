Public Class User

    Private idVal As Integer
    Public Property ID() As Integer
        Get
            Return idVal
        End Get
        Set(ByVal value As Integer)
            idVal = value
        End Set
    End Property
    Private nameVal As String
    Public Property Name() As String
        Get
            Return nameVal
        End Get
        Set(ByVal value As String)
            nameVal = value
        End Set
    End Property

    Private maxHpVal As Integer = 300
    Public Property MaxHp() As Integer
        Get
            Return maxHpVal
        End Get
        Set(ByVal value As Integer)
            maxHpVal = value
        End Set
    End Property

    Private cHpVal As Integer
    Public Property CurrentHp() As Integer
        Get
            Return cHpVal
        End Get
        Set(ByVal value As Integer)
            cHpVal = value
        End Set
    End Property

    Private hIVal As Integer = 5
    Public Property Hi() As Integer
        Get
            Return hIVal
        End Get
        Set(ByVal value As Integer)
            hIVal = value
        End Set
    End Property

    Private killVal As Integer = 0
    Public Property Kills() As Integer
        Get
            Return killVal
        End Get
        Set(ByVal value As Integer)
            killVal = value
        End Set
    End Property

End Class
