
Public Class vdetalle_salida
    Dim iddetalle_salida, idsalida, idproducto As Integer
    Dim cantidad As Double


    Public Property giddetalle_salida
        Get
            Return iddetalle_salida

        End Get
        Set(ByVal value)
            iddetalle_salida = value
        End Set
    End Property

    Public Property gidsalida
        Get
            Return idsalida

        End Get
        Set(ByVal value)
            idsalida = value
        End Set
    End Property

    Public Property gidproducto
        Get
            Return idproducto

        End Get
        Set(ByVal value)
            idproducto = value
        End Set
    End Property




    Public Property gcantidad
        Get
            Return cantidad

        End Get
        Set(ByVal value)
            cantidad = value
        End Set
    End Property



    Public Sub New()

    End Sub


    Public Sub New(ByVal iddetalle_salida As Integer, ByVal idsalida As Integer, ByVal idproducto As Integer, ByVal cantidad As Double)
        giddetalle_salida = iddetalle_salida
        gidsalida = idsalida
        gidproducto = idproducto
        gcantidad = cantidad

    End Sub


End Class
