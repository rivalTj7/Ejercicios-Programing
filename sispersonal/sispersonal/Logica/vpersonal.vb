Public Class vpersonal
    Dim idpersonal As Integer
    Dim nombres, apellidos, puesto, salario As String
    Dim imagen() As Byte


    'seeter y getter

    Public Property gidpersonal
        Get
            Return idpersonal
        End Get
        Set(ByVal value)
            idpersonal = value
        End Set
    End Property

    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(ByVal value)
            nombres = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property


    Public Property gpuesto
        Get
            Return puesto
        End Get
        Set(ByVal value)
            puesto = value
        End Set
    End Property

    Public Property gsalario
        Get
            Return salario
        End Get
        Set(ByVal value)
            salario = value
        End Set
    End Property


    Public Property gimagen
        Get
            Return imagen
        End Get
        Set(ByVal value)
            imagen = value
        End Set
    End Property
    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idpersonal As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal puesto As String, ByVal salario As String, ByVal imagen As Byte)
        gidpersonal = idpersonal
        gnombres = nombres
        gapellidos = apellidos
        gpuesto = puesto
        gsalario = salario
        gimagen = imagen
    End Sub
End Class
