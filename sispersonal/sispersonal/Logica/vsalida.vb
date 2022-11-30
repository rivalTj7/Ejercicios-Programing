Public Class vsalida
    Dim idsalida, idpersonal As Integer
    Dim fecha_salida As Date
    Dim tipo_documento, num_documento As String


    Public Property gidsalida
        Get
            Return idsalida
        End Get
        Set(ByVal value)
            idsalida = value
        End Set
    End Property

    Public Property gidpersonal
        Get
            Return idpersonal
        End Get
        Set(ByVal value)
            idpersonal = value
        End Set
    End Property

    Public Property gfecha_salida
        Get
            Return fecha_salida
        End Get
        Set(ByVal value)
            fecha_salida = value
        End Set
    End Property

    Public Property gtipo_documento
        Get
            Return tipo_documento

        End Get
        Set(ByVal value)
            tipo_documento = value
        End Set
    End Property

    Public Property gnum_documento
        Get
            Return num_documento

        End Get
        Set(ByVal value)
            num_documento = value
        End Set
    End Property


    Public Sub New()

    End Sub


    Public Sub New(ByVal idsalida As Integer, ByVal idpersonal As Integer, ByVal fecha_salida As Date, ByVal tipo_documento As String, ByVal num_documento As String)
        gidsalida = idsalida
        gidpersonal = idpersonal
        gfecha_salida = fecha_salida
        gtipo_documento = tipo_documento
        gnum_documento = num_documento
    End Sub
End Class
