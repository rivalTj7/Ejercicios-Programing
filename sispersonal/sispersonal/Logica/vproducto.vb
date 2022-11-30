
Public Class vproducto
    Dim idproducto, idcategoria As Integer
    Dim nombre, descripcion As String
    Dim stock As Double

    Public Property gidproducto
        Get
            Return idproducto

        End Get
        Set(ByVal value)
            idproducto = value
        End Set
    End Property



    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(ByVal value)
            idcategoria = value
        End Set
    End Property


    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion

        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property

    Public Property gstock
        Get
            Return stock
        End Get
        Set(ByVal value)
            stock = value
        End Set
    End Property


    Public Sub New()

    End Sub


    Public Sub New(ByVal idproducto As Integer, ByVal idcategoria As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal stock As Double)
        gidproducto = idproducto
        gidcategoria = idcategoria
        gnombre = nombre
        gdescripcion = descripcion
        gstock = stock

    End Sub


End Class
