Module Conexion
    ' la conexion
    Public laconexion As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Cuentas.mdf;Integrated Security=True")

    Public mycmdSql As New SqlClient.SqlCommand
    'comando ejcutor de ordenes de sql
    Public cmdSql As New SqlClient.SqlCommand
    'cursor o tabla
    Public tblDatos As SqlClient.SqlDataReader

    Public Sub conectarBasedeDatos()
        'aqui lo unico que se hace es abrir la conexion ya anteriormente enlazada a una variable local 
        Try
            laconexion.Open() 'abre la conexion 
            mycmdSql.Connection = laconexion 'se conecta el comando a la base de datos
            mycmdSql.CommandText = CommandType.Text 'se dice de que tipo ba a ser el comando para enviar las sentencias sql
            Inicio.lblEstado.Text = ("Conexion lista") ' se envia un mensaje de que todo funciona bien
        Catch ex As Exception
            Inicio.lblEstado.Text = ("Error en la conexion") 'ocurrio un error a la ora de intentar instanciar
        End Try
    End Sub

    Public Function buscarSql(ByVal Strsql As String) As Boolean
        'funcion de busqueda con parametro sql completo funcion generica sentencia completa
        Dim correcto As Boolean
        Dim mystrsql As String
        correcto = True
        mystrsql = Strsql
        mycmdSql.CommandText = mystrsql
        Try
            tblDatos = mycmdSql.ExecuteReader ' contenedor de datos que se obtuvo como resultado
        Catch ex As Exception
            MsgBox(Strsql)
            correcto = False
            MsgBox(ex.Message)
        End Try
        Return correcto
    End Function
    Public Function buscarTodo(ByVal qtabla As String) As Boolean
        Dim correcto As Boolean
        Dim strSql As String
        correcto = True
        strSql = "select * from " + qtabla 'sentencia sql 
        mycmdSql.CommandText = strSql ' sse envia la sentencia al comando 
        Try
            tblDatos = mycmdSql.ExecuteReader 'se ejecuta el comando 
        Catch ex As Exception
            correcto = False
        End Try
        Return correcto
    End Function

    Function mayor(tabla As String, campo As String) As Integer
        'busca inteligentemente cuantos datos ay en la tabla 
        Dim cual As Integer
        Dim strsql As String
        Dim correcto As Boolean
        strsql = "select max(" + campo + ")from " + tabla 'sentencia sql que busca cual es la maoyr cantidad de datos
        mycmdSql.CommandText = strsql 'se transfiere lasentencia al comando
        Try
            tblDatos = mycmdSql.ExecuteReader ' se ejecuta la sentencia
            correcto = True 'se dicta que ejecuto correctamente
        Catch ex As Exception
            MsgBox("ocurrio un error en sql " + Chr(13) + ex.Message)
            correcto = False 'ocurrio un error de ejecucion 
        End Try
        If correcto Then
            Try
                tblDatos.Read() ' se leen los datos en la tabla
                cual = tblDatos(0) ' si le da el valor a la variable cual dependiendo de la cantidad de datos
            Catch ex As Exception
                cual = 0 ' si no ay datos cual sera 0 devido a que no existen datos
            End Try
        End If
        tblDatos.Close() ' se sierra el contenedor de datos por fallos de interferencia
        Return cual ' se envia cual fuel la maxima cantidad de datos.

    End Function
    Function guardar(qtabla As String, columnas As String, valores As String) As Boolean
        ' Guardar tiene la funcion de agregar nuevos datos a la tabla 
        Dim strsql As String
        Dim correcto As Boolean

        strsql = "insert into " + qtabla + "(" + columnas + ") values(" + valores + ")"
        ' sentencia sql de inserccion de datos
        mycmdSql.CommandText = strsql 'se manda la sentencia al comando
        MsgBox(strsql) '------>esto solo verifica si se mandan correctamente los datos usar 
        'si es nesesario solo cuando ayga algun error y nose sepa donde esta
        Try
            mycmdSql.ExecuteNonQuery() ' se ejecuta el comando como un scrip
            correcto = True ' se ejecuta y guardo cambios
        Catch ex As Exception
            MsgBox("Error Al Guardar" + Chr(13) + ex.Message)
            correcto = False 'error revise todo el proyecto de nuevo :)
        End Try
        Return correcto 'se deveulve si guardo o si no ;)/// jajajaj

    End Function
End Module
